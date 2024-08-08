using Domain.Entities;
using Domain.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;

namespace BuscaCasa.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StatusUsuarioController : ControllerBase
    {
        private readonly ILogger<StatusUsuarioController> _logger;
        private readonly IStatusUsuarioService _service;

        public StatusUsuarioController(ILogger<StatusUsuarioController> logger, IStatusUsuarioService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<StatusUsuario>> FindAll()
        {
            try
            {
                var StatusUsuarios = await _service.FindAll();
                if (StatusUsuarios == null)
                {
                    return NotFound();
                }
                return Ok(StatusUsuarios);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao buscar endereço.");
                return BadRequest("An error occurred while fetching StatusUsuario.");
            }
        }
    }
}
