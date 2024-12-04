using HealthJournal.Dto.Observation;
using HealthJournal.Models;

namespace HealthJournal.Interfaces
{
    public interface IObservationRepository : IRepository<Observation>
    {
        ICollection<ObservationDto> GetObservationsFromId(int id);
    }
}
