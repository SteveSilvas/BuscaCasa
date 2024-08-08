using Domain.Entities;
using Domain.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;

namespace BuscaCasa.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TipoUsoImovelController : ControllerBase
    {
        private readonly ILogger<TipoUsoImovelController> _logger;
        private readonly ITipoUsoImovelService _service;

        public TipoUsoImovelController(ILogger<TipoUsoImovelController> logger, ITipoUsoImovelService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<TipoUsoImovel>> FindAll()
        {
            try
            {
                var TipoUsoImovels = await _service.FindAll();
                if (TipoUsoImovels == null)
                {
                    return NotFound();
                }
                return Ok(TipoUsoImovels);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao buscar endereço.");
                return BadRequest("An error occurred while fetching TipoUsoImovel.");
            }
        }
    }
}
