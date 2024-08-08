using Domain.DTOs;

namespace Domain.Interfaces.IServices
{
    public interface IStatusImovelService
    {
        Task<List<StatusImovelDTO>> FindAll();
    }
}
