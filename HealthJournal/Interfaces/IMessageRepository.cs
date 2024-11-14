using HealthJournal.Models;

namespace HealthJournal.Interfaces
{
    public interface IMessageRepository : IRepository<Message>
    {
        ICollection<Message> GetReceivedMessages(string userId);
        ICollection<Message> GetSentMessages(string userId);
    }
}
