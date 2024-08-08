using Domain.DTOs;

namespace Domain.Interfaces.IRepositories
{
    public interface IStatusUsuarioRepository
    {
        Task<List<StatusUsuarioDTO>> FindAll();
    }
}
