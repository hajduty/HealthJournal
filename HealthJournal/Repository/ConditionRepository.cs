using HealthJournal.Data;
using HealthJournal.Interfaces;
using HealthJournal.Models;

namespace HealthJournal.Repository
{
    public class ConditionRepository : Repository<Condition>, IConditionRepository
    {
        public ConditionRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public ICollection<Condition> GetConditions(int patientId)
        {
            return _dbContext.Conditions.Where(p => p.PatientId == patientId).ToList();
        }
    }
}
