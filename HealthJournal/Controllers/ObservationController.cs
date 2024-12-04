using HealthJournal.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HealthJournal.Controllers
{
    [Route("api/observation")]
    [ApiController]
    public class ObservationController : ControllerBase
    {
        private readonly IObservationRepository _observationRepository;
        public ObservationController(IObservationRepository observationRepository)
        {
            _observationRepository = observationRepository;
        }

        [HttpGet("{encounterId}")]
        [Authorize(Roles = "Admin")]
        public IActionResult GetObservationFromId(int encounterId)
        {
            var result = _observationRepository.GetObservationsFromId(encounterId);
            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }
    }
}