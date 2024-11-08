using System.ComponentModel.DataAnnotations;

namespace HealthJournal.Models
{
    public class Encounter
    {
        [Key]
        public int Id { get; set; }
        public DateTime VisitDate { get; set; }
        public Patient Patient { get; set; }
        public List<Observation> Observations { get; set; }

    }
}
