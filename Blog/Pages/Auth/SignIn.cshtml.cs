using BlogPostModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
//Author:Prakash Bl Dhakal Date:2023/20/03
namespace Blog.Pages.Auth
{
    
    public class SignInModel : PageModel
    {
        private readonly SignInManager<IdentityUser> _signInManager; 
        public SignInModel(SignInManager<IdentityUser> signInManager)
        {
            this._signInManager = signInManager;
        }     

        [BindProperty]
        public SignInDTO SignInDTO { get; set; }
        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            else
            {
                //if login succeeded user navigate to the Index page where all blogs are placed.
                //if user enters the wrong password,User redirect to login page again
                var result = await _signInManager.PasswordSignInAsync(SignInDTO.UserEmail, SignInDTO.UserPassword, false, false);

                if (result.Succeeded)
                {
                    return RedirectToPage("/View/Index");
                }
                ModelState.AddModelError("", "UserEmail or Password is not matched!");
                return RedirectToPage("SignIn");
            }  
        }
    }
}
