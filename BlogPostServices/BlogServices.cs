
using BlogPostModel;
using BlogRepository;
//Author: Prakash Bl Dhakal Date:2023 / 18 / 03
namespace BlogPostServices
{
    public class BlogServices : IBlogServices
    {

        private readonly IBlogPostRepository blogPostRepository;

        public BlogServices(IBlogPostRepository blogPostRepository)
        {
            this.blogPostRepository = blogPostRepository;
        }
        async Task<PostContent> IBlogServices.AddPostsAsync(PostContent blogPost)
        {
            blogPost.PublishedDate = DateTime.UtcNow;
            await blogPostRepository.AddPostsAsync(blogPost);
            return blogPost;
        }
        async Task<bool> IBlogServices.DeletePostAsync(PostContent blogPost)
        {
            var deleted =await blogPostRepository.DeletePostAsync(blogPost);
            return deleted;
        }
        async Task<IEnumerable<PostContent>> IBlogServices.GetAllPostsAsync()
        {
            return await blogPostRepository.GetAllPostsAsync();
        }

        async Task<PostContent> IBlogServices.GetPostsAsync(Guid id)
        {
            return await blogPostRepository.GetPostsAsync(id);
        }
          async Task<PostContent> IBlogServices.UpdatePostAsync(PostContent blogPost)
        {
           blogPost.UpdatedDate = DateTime.UtcNow;
           return await blogPostRepository.UpdatePostAsync(blogPost);
        }
    }
}