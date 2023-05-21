
using BlogDBContext;
using BlogPostModel;
using Microsoft.EntityFrameworkCore;
//Author: Prakash Bl Dhakal Date:2023 / 18 / 03
namespace BlogRepository
{
    public class BlogPostRepository : IBlogPostRepository
    {
        private readonly BlogDbContext dbContext;

        public BlogPostRepository(BlogDbContext db)
        {
            this.dbContext = db;
        }
        public async Task<PostContent> AddPostsAsync(PostContent blogPost)
        {
            await dbContext.PostContents.AddAsync(blogPost);
            await dbContext.SaveChangesAsync();
            return blogPost;
        }

        public async Task<bool> DeletePostAsync(PostContent post)
        {
            dbContext.Remove(post);
            await dbContext.SaveChangesAsync();
            return true;
        }
        public async Task<IEnumerable<PostContent>> GetAllPostsAsync()
        {
            return await dbContext.PostContents.ToListAsync();
        }
        public async Task<PostContent> GetPostsAsync(Guid id)
        {
            return await dbContext.PostContents.FindAsync(id);
        }
        public async Task<PostContent> UpdatePostAsync(PostContent blogPost)
        {
            var value = await dbContext.PostContents.FindAsync(blogPost.Id);
            if (value != null)
            {
                value.Title = blogPost.Title;
                value.Content = blogPost.Content;
                value.Author = blogPost.Author;
            }

            await dbContext.SaveChangesAsync();
            return value;

        }
    }
}
