

using BlogPostModel;
using BlogPostServices;
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


        private readonly IBlogServices blogPostRepository;
        public IndexModel(IBlogServices blogPostRepository)
        {
            this.blogPostRepository = blogPostRepository;
        }
        
        public async Task OnGet()
        {
            AllPosts = await blogPostRepository.GetAllPostsAsync();
        }
    }
}