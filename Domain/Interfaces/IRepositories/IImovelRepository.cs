using Domain.DTOs;

namespace Domain.Interfaces.IRepositories
{
    public interface IImovelRepository
    {
        Task<List<ImovelDTO>> FindAll();
    }
}
