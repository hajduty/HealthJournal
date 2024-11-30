using HealthJournal.Dto.Observation;
using HealthJournal.Models;

namespace HealthJournal.Mappers
{
    public class ObservationMapper
    {
        public static Observation MapToObservation(ObservationDto observationDto, Patient patient, Encounter encounter)
        {
            return new Observation
            {
                Encounter = encounter,
                Patient = patient,
                PatientId = observationDto.PatientId,
                EncounterId = observationDto.EncounterId,
                Value = observationDto.Value,
                Type = observationDto.Type,
            };
        }

        public static ICollection<Observation> MapToObservations(ICollection<ObservationDto> observationDtos, Patient patient, Encounter encounter)
        {
            return observationDtos.Select(dto => MapToObservation(dto, patient, encounter)).ToList();
        }

        public static ObservationDto ToObservationDto(Observation observation)
        {
            return new ObservationDto
            {
                EncounterId = observation.EncounterId,
                PatientId = observation.PatientId,
                Type = observation.Type,
                Value = observation.Value,
            };
        }

        public static ICollection<ObservationDto> ToObservationDtos(ICollection<Observation> observations)
        {
            return observations.Select(observation => ToObservationDto(observation)).ToList();
        }
    }
}