using Domain.Entities;
using Domain.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;

namespace BuscaCasa.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TipoComercializacaoController : ControllerBase
    {
        private readonly ILogger<TipoComercializacaoController> _logger;
        private readonly ITipoComercializacaoService _service;

        public TipoComercializacaoController(ILogger<TipoComercializacaoController> logger, ITipoComercializacaoService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<TipoComercializacao>> FindAll()
        {
            try
            {
                var TipoComercializacaos = await _service.FindAll();
                if (TipoComercializacaos == null)
                {
                    return NotFound();
                }
                return Ok(TipoComercializacaos);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao buscar endereço.");
                return BadRequest("An error occurred while fetching TipoComercializacao.");
            }
        }
    }
}
