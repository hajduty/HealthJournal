using HealthJournal.Models;
using System.ComponentModel.DataAnnotations;

namespace HealthJournal.Dto.Observation
{
    public class ObservationDto
    {
        [Required]
        public string Type { get; set; }

        [Required]
        public double Value { get; set; }

        [Required]
        public int EncounterId { get; set; }

        [Required]
        public int PatientId { get; set; }
    }
}