using HealthJournal.Dto.Encounter;
using HealthJournal.Dto.Observation;
using HealthJournal.Models;

namespace HealthJournal.Mappers
{
    public class EncounterMapper
    {
        public static Encounter ToEncounter(EncounterDto encounterDto, Patient patient)
        {
            return new Encounter
            {
                Patient = patient,
                Date = encounterDto.Date,
                PatientId = encounterDto.PatientId,
            };
        }

        public static EncounterDto ToEncounterDto(Encounter encounter)
        {
            return new EncounterDto
            {
                Date = encounter.Date,
                Observations = ObservationMapper.ToObservationDtos(encounter.Observations),
                PatientId = encounter.PatientId,
                Id = encounter.Id
            };
        }

        public static ICollection<EncounterDto> ToEncounterDtos(ICollection<Encounter> encounter)
        {
            return encounter.Select(encounter => ToEncounterDto(encounter)).ToList();
        }
    }
}