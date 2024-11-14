using HealthJournal.Models;

namespace HealthJournal.Interfaces
{
    public interface IPatientRepository : IRepository<Patient>
    {
        ICollection<Patient> GetAllPatients();
    }
}
