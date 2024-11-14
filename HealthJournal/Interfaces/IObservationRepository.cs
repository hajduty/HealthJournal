using HealthJournal.Models;

namespace HealthJournal.Interfaces
{
    public interface IObservationRepository : IRepository<Observation>
    {
        ICollection<Observation> GetObservationsForUser(string userId);
    }
}
