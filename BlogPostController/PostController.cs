using BlogPostModel;
using BlogPostServices;
using BlogRepository;
using Microsoft.AspNetCore.Mvc;

namespace BlogPostController
{
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly IBlogServices _blogServices;

        public BlogController(IBlogServices blogServices)
        {
            _blogServices = blogServices;
        }

        [HttpPost]
        public async Task<ActionResult<PostContent>> AddPostsAsync(PostContent blogPost)
        {
            
            await _blogServices.AddPostsAsync(blogPost);
            return blogPost;
        }

        [HttpDelete]
        public async Task<ActionResult<bool>> DeletePostAsync(PostContent blogPost)
        {
            var deleted = await _blogServices.DeletePostAsync(blogPost);
            return deleted;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PostContent>>> GetAllPostsAsync()
        {
            var posts = await _blogServices.GetAllPostsAsync();
            return Ok(posts);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PostContent>> GetPostsAsync(Guid id)
        {
            var post = await _blogServices.GetPostsAsync(id);
            if (post == null)
                return NotFound();

            return post;
        }

        [HttpPut]
        public async Task<ActionResult<PostContent>> UpdatePostAsync(PostContent blogPost)
        {
            
            var updatedPost = await _blogServices.UpdatePostAsync(blogPost);
            if (updatedPost == null)
                return NotFound();

            return updatedPost;
        }
    }


}
