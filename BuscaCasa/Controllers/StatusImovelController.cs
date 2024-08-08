using Domain.Entities;
using Domain.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;

namespace BuscaCasa.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StatusImovelController : ControllerBase
    {
        private readonly ILogger<StatusImovelController> _logger;
        private readonly IStatusImovelService _service;

        public StatusImovelController(ILogger<StatusImovelController> logger, IStatusImovelService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<StatusImovel>> FindAll()
        {
            try
            {
                var StatusImovels = await _service.FindAll();
                if (StatusImovels == null)
                {
                    return NotFound();
                }
                return Ok(StatusImovels);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao buscar endereço.");
                return BadRequest("An error occurred while fetching StatusImovel.");
            }
        }
    }
}
