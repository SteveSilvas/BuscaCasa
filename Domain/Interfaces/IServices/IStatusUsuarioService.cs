using Domain.DTOs;

namespace Domain.Interfaces.IServices
{
    public interface IStatusUsuarioService
    {
        Task<List<StatusUsuarioDTO>> FindAll();
    }
}
