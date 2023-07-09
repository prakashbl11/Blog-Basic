using BlogDBContext;
using BlogPostModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogRepository
{
    public class MessageRepository : IMessageRepository
    {
        private readonly BlogDbContext dbContext;
        public MessageRepository(BlogDbContext db)
        {
            this.dbContext = db;
        }

        public async Task<Message> AddMessageAsync(Message message)
        {
            await dbContext.Messages.AddAsync(message);
            await dbContext.SaveChangesAsync();
            return message;
        }

        public async Task<bool> DeleteMessageAsync(Message message)
        {
            dbContext.Remove(message);
            await dbContext.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<Message>> GetAllMessagesAsync()
        {
            return await dbContext.Messages.ToListAsync();

        }

        public async Task<Message> GetMessageAsync(Guid id)
        {
            return await dbContext.Messages.FindAsync(id);

        }

    }
}
