using Domain.DTOs;

namespace Domain.Interfaces.IServices
{
    public interface IStatusVisitaService
    {
        Task<List<StatusVisitaDTO>> FindAll();
    }
}
