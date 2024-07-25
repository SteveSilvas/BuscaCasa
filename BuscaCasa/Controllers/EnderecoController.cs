using Domain.Entities;
using Domain.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;

namespace BuscaCasa.Controllers
{
    public class EnderecoController : ControllerBase
    {
        private readonly ILogger<EnderecoController> _logger;
        private readonly IEnderecoService _service;

        public EnderecoController(ILogger<EnderecoController> logger, IEnderecoService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<Endereco>> FindAll()
        {
            try
            {
                var enderecos = await _service.FindAll();
                if (enderecos == null)
                {
                    return NotFound();
                }
                return Ok(enderecos);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao buscar endereço.");
                return BadRequest("An error occurred while fetching endereco.");
            }
        }
    }
}
