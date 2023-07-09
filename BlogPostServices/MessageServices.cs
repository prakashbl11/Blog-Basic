using BlogPostModel;
using BlogRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BlogPostServices
{
    public class MessageServices : IMessageServices
    {
        private readonly IMessageRepository _messageRepository;
        public MessageServices(IMessageRepository repo)
        {
            _messageRepository = repo;
        }
        public async Task<Message> AddMessageAsync(Message message)
        {
            message.Created = DateTime.UtcNow;
             await _messageRepository.AddMessageAsync(message);
            return message;
        }
        public async Task<bool> DeleteMessageAsync(Message message)
        {
            var deleted = await _messageRepository.DeleteMessageAsync(message);
            return deleted;
        }
        public async Task<IEnumerable<Message>> GetAllMessagesAsync()
        {
            return await _messageRepository.GetAllMessagesAsync();
        }
        public async Task<Message> GetMessageAsync(Guid id)
        {
            return await _messageRepository.GetMessageAsync(id);
        }
    }
}
