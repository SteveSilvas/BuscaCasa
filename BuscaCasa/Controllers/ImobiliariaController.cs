using Domain.Entities;
using Domain.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;

namespace BuscaCasa.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ImobiliariaController : ControllerBase
    {
        private readonly ILogger<ImobiliariaController> _logger;
        private readonly IImobiliariaService _service;

        public ImobiliariaController(ILogger<ImobiliariaController> logger, IImobiliariaService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<Imobiliaria>> FindAll()
        {
            try
            {
                var Imobiliarias = await _service.FindAll();
                if (Imobiliarias == null)
                {
                    return NotFound();
                }
                return Ok(Imobiliarias);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao buscar endereço.");
                return BadRequest("An error occurred while fetching Imobiliaria.");
            }
        }
    }
}
