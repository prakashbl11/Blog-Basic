

using BlogPostModel;
using BlogRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Blog.Pages.View
{
    [Authorize]
    public class IndexModel : PageModel
    {
        public IEnumerable<PostContent> AllPosts { get; set; }


        private readonly IBlogPostRepository blogPostRepository;
        public IndexModel(IBlogPostRepository blogPostRepository)
        {
            this.blogPostRepository = blogPostRepository;
        }
        
        public async Task OnGet()
        {
            AllPosts = await blogPostRepository.GetAllPostsAsync();
        }
    }
}