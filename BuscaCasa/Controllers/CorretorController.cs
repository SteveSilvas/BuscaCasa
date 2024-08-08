using Domain.Entities;
using Domain.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;

namespace BuscaCasa.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CorretorController : ControllerBase
    {
        private readonly ILogger<CorretorController> _logger;
        private readonly ICorretorService _service;

        public CorretorController(ILogger<CorretorController> logger, ICorretorService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<Corretor>> FindAll()
        {
            try
            {
                var Corretors = await _service.FindAll();
                if (Corretors == null)
                {
                    return NotFound();
                }
                return Ok(Corretors);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao buscar corretor.");
                return BadRequest("An error occurred while fetching Corretor.");
            }
        }
    }
}
