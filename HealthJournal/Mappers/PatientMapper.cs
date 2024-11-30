using HealthJournal.Dto;
using HealthJournal.Models;

namespace HealthJournal.Mappers
{
    public class PatientMapper
    {
        public static PatientDto PatientToDto(Patient patient)
        {
            return new PatientDto
            {
                Id = patient.Id,
                UserId = patient.UserId,
                LastName = patient.LastName,
                FirstName = patient.FirstName,
                Age = patient.Age,
            };
        }
    }
}
