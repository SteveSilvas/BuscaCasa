using Authenticator.Controllers;
using Domain.Entities;
using Domain.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;

namespace BuscaCasa.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MunicipioController : ControllerBase
    {
        private readonly ILogger<MunicipioController> _logger;
        private readonly IMunicipioService _service;

        public MunicipioController(ILogger<MunicipioController> logger, IMunicipioService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<Municipio>> FindAll()
        {
            try
            {
                var municipios = await _service.FindAll();
                if (municipios == null)
                {
                    return NotFound();
                }
                return Ok(municipios);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao buscar municipios.");
                return BadRequest("An error occurred while fetching user.");
            }
        }

        [HttpGet("{idEstado}")]
        public async Task<ActionResult<Municipio>> GetUserAsync(int idEstado)
        {
            try
            {
                var user = await _service.FindByIdEstado(idEstado);
                if (user == null)
                {
                    return NotFound();
                }
                return Ok(user);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while fetching user with ID {0}", idEstado);
                return BadRequest("An error occurred while fetching user.");
            }
        }
    }
}
