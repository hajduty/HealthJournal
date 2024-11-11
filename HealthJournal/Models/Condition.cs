using System.ComponentModel.DataAnnotations;

namespace HealthJournal.Models
{
    public class Condition
    {
        [Key]
        public int Id { get; set; }
        public string ConditionName { get; set; }
        public int PatientId { get; set; }
        public Patient Patient { get; set; }
    }
}