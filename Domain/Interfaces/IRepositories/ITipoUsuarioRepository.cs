using Domain.DTOs;

namespace Domain.Interfaces.IRepositories
{
    public interface ITipoUsuarioRepository
    {
        Task<List<TipoUsuarioDTO>> FindAll();
    }
}
