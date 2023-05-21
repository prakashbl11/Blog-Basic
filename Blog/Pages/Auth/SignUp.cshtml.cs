using BlogPostModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Http.Headers;

namespace Blog.Pages.Auth
{
    public class SignUpModel : PageModel
    {
        public UserManager<IdentityUser> UserManager { get; }
        public SignInManager<IdentityUser> SignInManager { get; }
        public SignUpModel(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            UserManager = userManager;
            SignInManager = signInManager;
        }

        [BindProperty]
        public SignUpDTO SignUpDTO { get; set; }
        //This method create a identical user using UserManager and signinmanager features.
        //if action succeeded user navigated to the index page.
        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser()
                {

                    Email = SignUpDTO.UserEmail,
                    UserName = SignUpDTO.UserEmail,
                    PasswordHash = SignUpDTO.UserPassword
                };
                var result = await UserManager.CreateAsync(user, SignUpDTO.UserPassword);
                if (result.Succeeded)
                {
                    await SignInManager.SignInAsync(user, false);
                    return RedirectToPage("/View/Index");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            return Page();

        }
    }
}


