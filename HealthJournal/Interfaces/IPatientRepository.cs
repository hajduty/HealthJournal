using HealthJournal.Models;

namespace HealthJournal.Interfaces
{
    public interface IPatientRepository
    {
        Patient GetPatient(int id);
        Patient UpdatePatient(int id, Patient patient);
        Patient CreatePatient(Patient patient);
        ICollection<Patient> GetAllPatients();
    }
}
