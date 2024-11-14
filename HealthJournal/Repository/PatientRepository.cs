using HealthJournal.Data;
using HealthJournal.Interfaces;
using HealthJournal.Models;

namespace HealthJournal.Repository
{
    public class PatientRepository : Repository<Patient>, IPatientRepository
    {
        public PatientRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public ICollection<Patient> GetAllPatients()
        {
            return _dbContext.Patients.ToList();
        }
    }
}
