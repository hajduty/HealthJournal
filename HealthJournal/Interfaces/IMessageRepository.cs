using HealthJournal.Models;

namespace HealthJournal.Interfaces
{
    public interface IMessageRepository
    {
        Message GetMessage(int id);
        Message CreateMessage(Message message);
        Message UpdateMessage(int id, Message message);
        ICollection<Message> GetReceivedMessages(int userId);
        ICollection<Message> GetSentMessages(int userId);
    }
}
