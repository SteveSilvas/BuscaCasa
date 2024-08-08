using Domain.Entities;
using Domain.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;

namespace BuscaCasa.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProprietarioController : ControllerBase
    {
        private readonly ILogger<ProprietarioController> _logger;
        private readonly IProprietarioService _service;

        public ProprietarioController(ILogger<ProprietarioController> logger, IProprietarioService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<Proprietario>> FindAll()
        {
            try
            {
                var Proprietarios = await _service.FindAll();
                if (Proprietarios == null)
                {
                    return NotFound();
                }
                return Ok(Proprietarios);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao buscar endereço.");
                return BadRequest("An error occurred while fetching Proprietario.");
            }
        }
    }
}
