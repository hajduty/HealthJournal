using HealthJournal.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HealthJournal.Interfaces
{
    public interface IConditionRepository : IRepository<Condition>
    {
        ICollection<Condition> GetConditions(int patientId);
    }
}
