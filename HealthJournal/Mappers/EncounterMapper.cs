﻿using HealthJournal.Dto.Encounter;
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
            };
        }
    }
}