using Domain.Entities;
using Domain.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;

namespace BuscaCasa.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EstadoController : ControllerBase
    {
        private readonly ILogger<EstadoController> _logger;
        private readonly IEstadoService _service;

        public EstadoController(ILogger<EstadoController> logger, IEstadoService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<Estado>> FindAll()
        {
            try
            {
                var regioes = await _service.FindAll();
                if (regioes == null)
                {
                    return NotFound();
                }
                return Ok(regioes);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao buscar estados");
                return BadRequest("An error occurred while fetching estado.");
            }
        }
    }
}
