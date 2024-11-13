using Authenticator.Controllers;
using Domain.Entities;
using Domain.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;

namespace BuscaCasa.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegiaoController : ControllerBase
    {
        private readonly ILogger<RegiaoController> _logger;
        private readonly IRegiaoService _service;

        public RegiaoController(ILogger<RegiaoController> logger, IRegiaoService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<Regiao>> FindAll()
        {
            try
            {
                var regioes = await _service.FindAll();
                if (regioes == null)
                {
                    return NotFound();
                }
                return Ok(regioes);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao buscar regiões");
                return BadRequest("An error occurred while fetching regiao.");
            }
        }
    }
}
