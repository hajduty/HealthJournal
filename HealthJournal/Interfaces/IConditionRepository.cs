using HealthJournal.Models;

namespace HealthJournal.Interfaces
{
    public interface IConditionRepository
    {
        Condition GetCondition(int id);
        Condition CreateCondition(Condition condition);
        Condition UpdateCondition(int id, Condition condition);
        bool DeleteCondition(int id);
    }
}
