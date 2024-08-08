using Domain.Entities;
using Domain.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;

namespace BuscaCasa.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FavoritoController : ControllerBase
    {
        private readonly ILogger<FavoritoController> _logger;
        private readonly IFavoritoService _service;

        public FavoritoController(ILogger<FavoritoController> logger, IFavoritoService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<Favorito>> FindAll()
        {
            try
            {
                var Favoritos = await _service.FindAll();
                if (Favoritos == null)
                {
                    return NotFound();
                }
                return Ok(Favoritos);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao buscar endereço.");
                return BadRequest("An error occurred while fetching Favorito.");
            }
        }
    }
}
