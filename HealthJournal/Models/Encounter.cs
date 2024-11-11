using System.ComponentModel.DataAnnotations;

namespace HealthJournal.Models
{
    public class Encounter
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int PatientId { get; set; }  // Foreign key
        public Patient Patient { get; set; }
        public ICollection<Observation> Observations { get; set; } = new List<Observation>();
    }
}
