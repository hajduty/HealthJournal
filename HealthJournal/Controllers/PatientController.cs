using HealthJournal.Interfaces;
using HealthJournal.Mappers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HealthJournal.Controllers
{
    [Route("api/patient")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IPatientRepository _patientRepository;
        public PatientController(IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }

        [HttpGet("{id}")]
        [Authorize(Roles = "Admin")]
        public IActionResult GetFromId(int id)
        {
            var patient = _patientRepository.Get(id);
            if (patient == null)
            {
                return NotFound();
            }

            var dto = PatientMapper.PatientToDto(patient);

            return Ok(dto);
        }

        [HttpGet("detailed/{id}")]
        [Authorize(Roles = "Admin")]
        public IActionResult GetDetailedFromId(int id)
        {
            var patient = _patientRepository.Get(id);
            if (patient == null)
            {
                return NotFound();
            }

            var dto = PatientMapper.PatientToDto(patient);

            return Ok(dto);
        }

        [HttpGet("getAll")]
        [Authorize(Roles = "Admin")]
        public IActionResult GetAllPatients()
        {
            var patients = _patientRepository.GetAllPatients();

            if (patients != null) { return Ok(patients); }
            return NotFound();
        }

        [HttpGet("search")]
        [Authorize(Roles = "Admin")]
        public IActionResult SearchPatient([FromQuery] string query, int page, int pageSize)
        {
            if (string.IsNullOrWhiteSpace(query))
            {
                return BadRequest(new { Message = "Query cannot be empty." });
            }

            var data = _patientRepository.SearchPatient(query, page, pageSize);
            
            if (data != null) { return Ok(data); }
            return NotFound();
        }
    }
}
