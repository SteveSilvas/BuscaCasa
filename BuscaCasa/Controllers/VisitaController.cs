using Domain.Entities;
using Domain.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;

namespace BuscaCasa.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VisitaController : ControllerBase
    {
        private readonly ILogger<VisitaController> _logger;
        private readonly IVisitaService _service;

        public VisitaController(ILogger<VisitaController> logger, IVisitaService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<Visita>> FindAll()
        {
            try
            {
                var Visitas = await _service.FindAll();
                if (Visitas == null)
                {
                    return NotFound();
                }
                return Ok(Visitas);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao buscar endereço.");
                return BadRequest("An error occurred while fetching Visita.");
            }
        }
    }
}
