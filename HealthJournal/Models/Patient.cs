using System.ComponentModel.DataAnnotations;

namespace HealthJournal.Models
{
    public class Patient
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string? UserId { get; set; }
        public User User { get; set; }
        public ICollection<Condition> Conditions { get; set; } = new List<Condition>();
        public ICollection<Observation> Observations { get; set; } = new List<Observation>();
        public ICollection<Encounter> Encounters { get; set; } = new List<Encounter>();
    }
}
