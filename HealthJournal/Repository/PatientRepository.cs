using HealthJournal.Data;
using HealthJournal.Interfaces;
using HealthJournal.Models;

namespace HealthJournal.Repository
{
    public class PatientRepository : IPatientRepository
    {
        public readonly AppDbContext _dbContext;
        public PatientRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Patient CreatePatient(Patient patient)
        {
            return _dbContext.Patients.Add(patient).Entity;
        }

        public ICollection<Patient> GetAllPatients()
        {
            return _dbContext.Patients.ToList();
        }

        public Patient GetPatient(int id)
        {
            return _dbContext.Patients.Where(p => p.Id == id).FirstOrDefault();
        }

        public Patient UpdatePatient(int id, Patient patient)
        {
            var oldPatient = _dbContext.Patients.Where(p => p.Id == id).FirstOrDefault();

            if (oldPatient != null)
            {
                _dbContext.Entry(oldPatient).CurrentValues.SetValues(patient);
                _dbContext.SaveChanges();
            }

            return oldPatient!;
        }
    }
}
