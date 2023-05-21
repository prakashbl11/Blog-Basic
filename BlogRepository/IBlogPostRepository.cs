using BlogPostModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Author: Prakash Bl Dhakal Date:2023 / 18 / 03
namespace BlogRepository
{
    public interface IBlogPostRepository
    {
        Task<PostContent> AddPostsAsync(PostContent blogPost);
        Task<IEnumerable<PostContent>> GetAllPostsAsync();
        Task<PostContent> GetPostsAsync(Guid id);
        Task<PostContent> UpdatePostAsync(PostContent post);
        Task<bool> DeletePostAsync(PostContent post);


    }
}
