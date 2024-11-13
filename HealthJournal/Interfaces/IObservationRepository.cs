using HealthJournal.Models;

namespace HealthJournal.Interfaces
{
    public interface IObservationRepository
    {
        Observation GetObservation(int id);
        Observation UpdateObservation(int id, Observation observation);
        Observation CreateObservation(Observation observation);
        ICollection<Observation> GetObservationsForUser(int userId);
    }
}
