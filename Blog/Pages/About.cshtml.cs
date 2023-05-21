using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Blog.Pages
{
    [Authorize]
    public class AboutModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
