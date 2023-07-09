using BlogPostModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogRepository
{
    public interface IMessageRepository
    {
        Task<Message> AddMessageAsync(Message message);
        Task<IEnumerable<Message>> GetAllMessagesAsync();
        Task<Message> GetMessageAsync(Guid id);
        Task<bool> DeleteMessageAsync(Message message);

    }
}
