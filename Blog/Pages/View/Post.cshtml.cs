
using BlogPostModel;
using BlogPostServices;
using BlogRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;
//Author:Prakash Bl Dhakal Date:2023 / 21 / 03
namespace Blog.Pages.View
{
    [Authorize]
    public class PostModel : PageModel
    {
        private readonly IBlogServices blogServices;
        public PostModel(IBlogServices blogServices)
        {
            this.blogServices = blogServices;
        }
        [BindProperty]
        public PostContentDTO BlogPostDTO { get; set; }
        public async Task<IActionResult> OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();  
            }
            else
            {
                var blogpost = new PostContent
                {
                    Title = BlogPostDTO.Title,
                    Content = BlogPostDTO.Content,
                    Author = BlogPostDTO.Author

                };
                await blogServices.AddPostsAsync(blogpost);
                return RedirectToPage("/View/Index");
            }
        }
    }
}
