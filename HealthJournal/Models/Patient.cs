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
        public User User { get; set; }
        public List<Condition> Conditions { get; set; } = new List<Condition>();
        public List<Observation> Observations { get; set; } = new List<Observation>(); 
        public List<Encounter> Encounters { get; set; } = new List<Encounter>();
    }
}
