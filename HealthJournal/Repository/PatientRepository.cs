using HealthJournal.Data;
using HealthJournal.Dto;
using HealthJournal.Dto.Patient;
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

        public SearchResultDto SearchPatient(string query, int page, int pageSize)
        {
            if (page == 0)
                page = 1;

            var filteredPatients = _dbContext.Patients
                .Where(p => (p.FirstName + " " + p.LastName).Contains(query.Trim()));

            var totalCount = filteredPatients.Count();

            var data = filteredPatients
                            .Skip((page - 1) * pageSize)
                            .Take(pageSize)
                            .Select(p => new PatientDto
                            {
                                UserId = p.UserId,
                                FirstName = p.FirstName,
                                LastName = p.LastName,
                                Id = p.Id,
                                Age = p.Age
                            }).ToList();

            return new SearchResultDto
            {
                Patients = data,
                TotalCount = totalCount,
            };
        }
    }
}