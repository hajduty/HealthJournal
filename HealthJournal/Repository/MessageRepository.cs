using HealthJournal.Data;
using HealthJournal.Interfaces;
using HealthJournal.Models;

namespace HealthJournal.Repository
{
    public class MessageRepository : Repository<Message>, IMessageRepository
    {
        public MessageRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public ICollection<Message> GetReceivedMessages(string userId)
        {
            return _dbContext.Messages.Where(p => p.ReceiverId == userId).ToList();
        }

        public ICollection<Message> GetSentMessages(string userId)
        {
            return _dbContext.Messages.Where(p => p.SenderId == userId).ToList();
        }
    }
}
