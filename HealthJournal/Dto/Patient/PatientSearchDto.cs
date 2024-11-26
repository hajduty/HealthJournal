using HealthJournal.Models;

namespace HealthJournal.Dto.Patient
{
    public class PatientSearchDto
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public string? UserId { get; set; }
    }
}