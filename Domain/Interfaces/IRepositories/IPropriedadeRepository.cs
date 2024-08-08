using Domain.DTOs;

namespace Domain.Interfaces.IRepositories
{
    public interface IPropriedadeRepository
    {
        Task<List<PropriedadeDTO>> FindAll();
    }
}
