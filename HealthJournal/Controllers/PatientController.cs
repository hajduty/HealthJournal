using HealthJournal.Dto;
using HealthJournal.Dto.Account;
using HealthJournal.Interfaces;
using HealthJournal.Models;
using HealthJournal.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
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

        [HttpGet("getAllPatients")]
        [Authorize(Roles = "Admin")]
        public IActionResult GetAllPatients()
        {
            var patients = _patientRepository.GetAllPatients();

            if (patients != null) { return Ok(patients); }
            return Ok();
        }
    }
}
