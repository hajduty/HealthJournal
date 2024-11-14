using HealthJournal.Data;
using HealthJournal.Interfaces;
using HealthJournal.Models;
using Microsoft.EntityFrameworkCore;

namespace HealthJournal.Repository
{
    public class EncounterRepository : Repository<Encounter>, IEncounterRepository
    {
        public EncounterRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public ICollection<Encounter> GetEncounters(string userId)
        {
            return _dbContext.Encounters.Where(e => e.Patient.UserId == userId).ToList();
        }

        public Encounter GetEncountersWithObservations(int encounterId)
        {
            return _dbContext.Encounters.Include(e => e.Observations).FirstOrDefault(e => e.Id == encounterId);
        }

    }
}
