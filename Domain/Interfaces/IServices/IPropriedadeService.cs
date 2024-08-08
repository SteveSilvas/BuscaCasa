using Domain.DTOs;

namespace Domain.Interfaces.IServices
{
    public interface IPropriedadeService
    {
        Task<List<PropriedadeDTO>> FindAll();
    }
}
