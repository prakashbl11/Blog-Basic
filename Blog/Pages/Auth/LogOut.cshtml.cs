using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
//Author:Prakash Bl Dhakal,Date:2023/05/20
namespace Blog.Pages.Auth
{
    [Authorize]
    public class LogOutModel : PageModel
    {
        private SignInManager<IdentityUser> _signInManager;
        public LogOutModel(SignInManager<IdentityUser> signInManager)
        {
            _signInManager = signInManager;
        }
        public async Task<IActionResult> OnPostLogout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToPage("SignIn");
        }
        public  IActionResult OnPostCancel()
        {    
            return RedirectToPage("/View/Index");
        }
    }
}
