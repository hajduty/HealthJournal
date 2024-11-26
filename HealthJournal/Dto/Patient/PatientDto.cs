using HealthJournal.Models;
using System.ComponentModel.DataAnnotations;

namespace HealthJournal.Dto
{
    public class PatientDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string? UserId { get; set; }
        public User User { get; set; }
    }
}
