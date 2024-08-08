using Domain.Entities;
using Domain.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;

namespace BuscaCasa.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ImovelController : ControllerBase
    {
        private readonly ILogger<ImovelController> _logger;
        private readonly IImovelService _service;

        public ImovelController(ILogger<ImovelController> logger, IImovelService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<Imovel>> FindAll()
        {
            try
            {
                var Imovels = await _service.FindAll();
                if (Imovels == null)
                {
                    return NotFound();
                }
                return Ok(Imovels);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao buscar endereço.");
                return BadRequest("An error occurred while fetching Imovel.");
            }
        }
    }
}
