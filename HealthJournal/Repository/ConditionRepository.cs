using HealthJournal.Data;
using HealthJournal.Interfaces;
using HealthJournal.Models;

namespace HealthJournal.Repository
{
    public class ConditionRepository : IConditionRepository
    {
        public readonly AppDbContext _dbContext;
        public ConditionRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Condition CreateCondition(Condition condition)
        {
            return _dbContext.Conditions.Add(condition).Entity;
        }

        public Condition GetCondition(int id)
        {
            return _dbContext.Conditions.Find(id)!;
        }

        public Condition UpdateCondition(int id, Condition condition)
        {
            Condition oldCondition = _dbContext.Conditions.Find(id)!;

            if (oldCondition != null)
            {
                _dbContext.Entry(oldCondition).CurrentValues.SetValues(condition);
                _dbContext.SaveChanges();
            }
            return oldCondition!;
        }

        public bool DeleteCondition(int id)
        {
            var condition = GetCondition(id);

            if (condition != null)
            {
                _dbContext.Conditions.Remove(condition);
                _dbContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
