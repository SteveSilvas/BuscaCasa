using Domain.DTOs;

namespace Domain.Interfaces.IRepositories
{
    public interface IProprietarioRepository
    {
        Task<List<ProprietarioDTO>> FindAll();
    }
}
