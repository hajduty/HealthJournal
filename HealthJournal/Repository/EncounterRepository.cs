using HealthJournal.Data;
using HealthJournal.Interfaces;
using HealthJournal.Models;

namespace HealthJournal.Repository
{
    public class EncounterRepository : IEncounterRepository
    {
        private readonly AppDbContext _dbContext;
        public EncounterRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Encounter CreateEncounter(Encounter encounter)
        {
            return _dbContext.Encounters.Add(encounter).Entity;
        }

        public bool DeleteEncounter(int id)
        {
            var encounter = _dbContext.Encounters.SingleOrDefault(p => p.Id == id);

            if (encounter != null)
            {
                _dbContext.Remove(encounter);
                _dbContext.SaveChanges();
                return true;
            }

            return false;
        }

        public Encounter GetEncounter(int id)
        {
            return _dbContext.Encounters.Find(id)!;
        }

        public Encounter UpdateEncounter(int id, Encounter encounter)
        {
            var oldEncounter = GetEncounter(id);

            if (encounter != null)
            {
                _dbContext.Entry(oldEncounter).CurrentValues.SetValues(encounter);
                _dbContext.SaveChanges();
            }

            return oldEncounter;
        }
    }
}
