using System.ComponentModel.DataAnnotations;

namespace HealthJournal.Models
{
    public class Observation
    {
        [Key]
        public int Id { get; set; }
        public string Type { get; set; }
        public double Value { get; set; }
        public int PatientId { get; set; }  // Foreign key
        public Patient Patient { get; set; }
        public int EncounterId { get; set; }  // Foreign key
        public Encounter Encounter { get; set; }
    }
}
