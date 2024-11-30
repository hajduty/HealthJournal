using HealthJournal.Dto.Encounter;
using HealthJournal.Interfaces;
using HealthJournal.Mappers;
using HealthJournal.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HealthJournal.Controllers
{
    [Route("api/encounter")]
    [ApiController]
    public class EncounterController : ControllerBase
    {
        private readonly IEncounterRepository _encounterRepository;
        private readonly IPatientRepository _patientRepository;
        private readonly IObservationRepository _observationRepository;
        public EncounterController(IEncounterRepository encounterRepository, IPatientRepository patientRepository, IObservationRepository observationRepository)
        {
            _encounterRepository = encounterRepository;
            _patientRepository = patientRepository;
            _observationRepository = observationRepository;
        }

        [HttpGet("encounters")]
        [Authorize(Roles = "Admin")]
        public IActionResult GetEncounters([FromQuery] string userId)
        {
            var encounters = _encounterRepository.GetEncounters(userId);

            if (encounters != null)
            {
                return Ok(encounters);
            }
            return NotFound();
        }

        [HttpPost("add")]
        public IActionResult AddEncounter([FromBody] EncounterDto encounter)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var patient = _patientRepository.Get(encounter.PatientId);

            if (patient == null)
            {
                return NotFound(new { message = "Patient not found." });
            }

            var createdEncounter = new Encounter { Date = encounter.Date, Patient = patient, PatientId = encounter.PatientId };

            var savedEncounter = _encounterRepository.Create(createdEncounter);

            if (savedEncounter == null)
            {
                return NotFound();
            }

            var observations = ObservationMapper.MapToObservations(encounter.Observations, patient, savedEncounter);

            foreach (var observation in observations)
            {
                observation.EncounterId = savedEncounter.Id;  // Set the foreign key for the encounter
                savedEncounter.Observations.Add(observation); // Add observation to the encounter's collection
                _observationRepository.Create(observation);     // Save the observation to the database
            }

            _encounterRepository.Update(savedEncounter.Id, savedEncounter);

            var result = EncounterMapper.ToEncounterDto(savedEncounter);

            return Ok(result);
        }
    }
}
