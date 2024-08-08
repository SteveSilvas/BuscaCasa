using Domain.Entities;
using Domain.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;

namespace BuscaCasa.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PropriedadeController : ControllerBase
    {
        private readonly ILogger<PropriedadeController> _logger;
        private readonly IPropriedadeService _service;

        public PropriedadeController(ILogger<PropriedadeController> logger, IPropriedadeService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<Propriedade>> FindAll()
        {
            try
            {
                var Propriedades = await _service.FindAll();
                if (Propriedades == null)
                {
                    return NotFound();
                }
                return Ok(Propriedades);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao buscar endereço.");
                return BadRequest("An error occurred while fetching Propriedade.");
            }
        }
    }
}
