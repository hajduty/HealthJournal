using HealthJournal.Data;
using HealthJournal.Dto.Observation;
using HealthJournal.Interfaces;
using HealthJournal.Mappers;
using HealthJournal.Models;

namespace HealthJournal.Repository
{
    public class ObservationRepository : Repository<Observation>, IObservationRepository
    {
        public ObservationRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public ICollection<ObservationDto> GetObservationsFromId(int encounterId)
        {
            var obs = _dbContext.Observations.Where(o => o.EncounterId == encounterId).ToList();
            return ObservationMapper.ToObservationDtos(obs);
        }
    }
}
