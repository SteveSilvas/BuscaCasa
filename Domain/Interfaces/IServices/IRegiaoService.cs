using Domain.DTOs;

namespace Domain.Interfaces.IServices
{
    public interface IRegiaoService
    {
        Task<List<RegiaoDTO>> FindAll();
    }
}
