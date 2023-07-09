using BlogPostModel;
using BlogPostServices;
using BlogRepository;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Pages.View
{
    public class MessageModel : PageModel
    {
        private readonly IMessageRepository _messageServices;
        private readonly UserManager<IdentityUser> _userManager;

        public IEnumerable<Message> AllMessages { get; set; }
        public IEnumerable<Message> Raw { get; set; }
        [BindProperty]
        public Message messages { get; set; }

        public MessageModel(IMessageRepository message, UserManager<IdentityUser> userManager)
        {
            _messageServices = message;
            _userManager = userManager;
        }

        public async Task OnGet()
        {
            Raw = await _messageServices.GetAllMessagesAsync();

            // Filter messages based on audience role
            var user = await _userManager.GetUserAsync(User);
            var role = await _userManager.GetRolesAsync(user);
            if (role.Contains("Admin"))
            {
                // Admin can see all messages
                AllMessages = Raw;
            }
            else
            {
                // Filter messages for other roles based on audience
                AllMessages = Raw.Where(m => m.Audience == role.FirstOrDefault() || m.Audience=="All").ToList();
            }
        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            else
            {
                var message = new Message
                {
                    Subject = messages.Subject,
                    Body = messages.Body,
                    Audience = messages.Audience,
                    Author = messages.Author
                };

                await _messageServices.AddMessageAsync(message);
                return RedirectToPage("/View/Index");
            }
        }
    }
}
