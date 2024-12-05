using HealthJournal.Models;
using System.ComponentModel.DataAnnotations;

namespace HealthJournal.Dto.Encounter
{
    public class EncounterDto
    {
        [Required]
        public int Id { get; set;}
        [Required]
        public DateTime Date { get; set; }

        [Required]
        public int PatientId { get; set; }

        [Required]
        public ICollection<Observation.ObservationDto> Observations { get; set; } = new List<Observation.ObservationDto>();
    }
}