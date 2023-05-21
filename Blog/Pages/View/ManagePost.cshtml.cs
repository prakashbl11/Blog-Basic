
using BlogPostModel;
using BlogPostServices;
using BlogRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
//Author:Prakash Bl Dhakal Date:2023/21/03
namespace Blog.Pages.View
{
    [Authorize]
    public class ManagePostModel : PageModel
    {
        [BindProperty]
        public PostContent Blogposts { get; set; }
        private readonly IBlogServices blogServices;
        public ManagePostModel(IBlogServices blogServices)
        {
            this.blogServices = blogServices;
        }
        public async Task OnGet(Guid id)
        {
            Blogposts = await blogServices.GetPostsAsync(id);

        }
        public async Task<IActionResult> OnPost()
        {
            var value = await blogServices.GetPostsAsync(Blogposts.Id);
            if (value != null)
            {
                value.Title = Blogposts.Title;
                value.Content = Blogposts.Content;
                value.Author = Blogposts.Author;
                value.UpdatedDate = DateTime.UtcNow;
            }
            blogServices.UpdatePostAsync(value);
            return RedirectToPage("/View/Index");
        }
        public async Task<IActionResult> OnPostDelete()
        {
            var value = await blogServices.GetPostsAsync(Blogposts.Id);
            if (value != null)
            {
                blogServices.DeletePostAsync(value);
                return RedirectToPage("/View/Index");
            }
            else
            {
                return Page();
            }
        }
    }
}



