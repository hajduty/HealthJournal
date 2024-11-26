using HealthJournal.Dto.Patient;
using HealthJournal.Models;

namespace HealthJournal.Interfaces
{
    public interface IPatientRepository : IRepository<Patient>
    {
        ICollection<Patient> GetAllPatients();
        SearchResultDto SearchPatient(string query, int page, int pageSize);
    }
}
