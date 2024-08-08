using Domain.Entities;
using Domain.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;

namespace BuscaCasa.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StatusVisitaController : ControllerBase
    {
        private readonly ILogger<StatusVisitaController> _logger;
        private readonly IStatusVisitaService _service;

        public StatusVisitaController(ILogger<StatusVisitaController> logger, IStatusVisitaService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<StatusVisita>> FindAll()
        {
            try
            {
                var StatusVisitas = await _service.FindAll();
                if (StatusVisitas == null)
                {
                    return NotFound();
                }
                return Ok(StatusVisitas);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao buscar endereço.");
                return BadRequest("An error occurred while fetching StatusVisita.");
            }
        }
    }
}
