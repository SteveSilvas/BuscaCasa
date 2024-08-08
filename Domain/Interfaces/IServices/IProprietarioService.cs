using Domain.DTOs;

namespace Domain.Interfaces.IServices
{
    public interface IProprietarioService
    {
        Task<List<ProprietarioDTO>> FindAll();
    }
}
