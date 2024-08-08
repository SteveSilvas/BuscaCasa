using Domain.DTOs;

namespace Domain.Interfaces.IServices
{
    public interface ITipoUsuarioService
    {
        Task<List<TipoUsuarioDTO>> FindAll();
    }
}
