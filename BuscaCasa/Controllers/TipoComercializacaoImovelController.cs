using Domain.Entities;
using Domain.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;

namespace BuscaCasa.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TipoComercializacaoImovelController : ControllerBase
    {
        private readonly ILogger<TipoComercializacaoImovelController> _logger;
        private readonly ITipoComercializacaoImovelService _service;

        public TipoComercializacaoImovelController(ILogger<TipoComercializacaoImovelController> logger, ITipoComercializacaoImovelService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<TipoComercializacaoImovel>> FindAll()
        {
            try
            {
                var TipoComercializacaoImovels = await _service.FindAll();
                if (TipoComercializacaoImovels == null)
                {
                    return NotFound();
                }
                return Ok(TipoComercializacaoImovels);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao buscar endereço.");
                return BadRequest("An error occurred while fetching TipoComercializacaoImovel.");
            }
        }
    }
}
