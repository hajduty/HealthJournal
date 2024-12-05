using HealthJournal.Data;
using HealthJournal.Dto.Encounter;
using HealthJournal.Dto.Patient;
using HealthJournal.Interfaces;
using HealthJournal.Mappers;
using HealthJournal.Models;
using Microsoft.EntityFrameworkCore;

namespace HealthJournal.Repository
{
    public class EncounterRepository : Repository<Encounter>, IEncounterRepository
    {
        public EncounterRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public EncounterSearchDto GetEncounters(int patientId, int page = 1, int pageSize = 10)
        {
            var encounters = _dbContext.Encounters.Where(e => e.Patient.Id == patientId).Include(e => e.Observations);

            var filteredData = encounters.Skip((page - 1) * pageSize)
                                         .Take(pageSize)
                                         .OrderBy(e => e.Date)
                                         .ToList();

            var data = EncounterMapper.ToEncounterDtos(filteredData);

            var result = new EncounterSearchDto()
            {
                Encounters = data,
                TotalCount = encounters.Count()
            };

            return result;
        }

        public Encounter GetEncounterWithObservations(int encounterId)
        {
            return _dbContext.Encounters.Include(e => e.Observations).FirstOrDefault(e => e.Id == encounterId)!;
        }
    }
}
