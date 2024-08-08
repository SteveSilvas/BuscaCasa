using Domain.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;

namespace BuscaCasa.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TipoConstrucaoImovelController : ControllerBase
    {
        private readonly ILogger<TipoConstrucaoImovelController> _logger;
        private readonly ITipoConstrucaoImovelService _service;

        public TipoConstrucaoImovelController(ILogger<TipoConstrucaoImovelController> logger, ITipoConstrucaoImovelService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<TipoConstrucaoImovelController>> FindAll()
        {
            try
            {
                var TipoConstrucaoImovels = await _service.FindAll();
                if (TipoConstrucaoImovels == null)
                {
                    return NotFound();
                }
                return Ok(TipoConstrucaoImovels);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao buscar endereço.");
                return BadRequest("An error occurred while fetching TipoConstrucaoImovel.");
            }
        }
    }
}
