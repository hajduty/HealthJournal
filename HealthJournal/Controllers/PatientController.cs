using HealthJournal.Dto;
using HealthJournal.Dto.Account;
using HealthJournal.Dto.Patient;
using HealthJournal.Interfaces;
using HealthJournal.Models;
using HealthJournal.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Protocols.Configuration;

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
