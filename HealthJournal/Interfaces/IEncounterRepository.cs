using HealthJournal.Dto.Encounter;
using HealthJournal.Models;

namespace HealthJournal.Interfaces
{
    public interface IEncounterRepository : IRepository<Encounter>
    {
        EncounterSearchDto GetEncounters(int patientId, int page, int pageSize);
        Encounter GetEncounterWithObservations(int encounterId);
    }
}
