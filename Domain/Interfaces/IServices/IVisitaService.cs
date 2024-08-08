using Domain.DTOs;

namespace Domain.Interfaces.IServices
{
    public interface IVisitaService
    {
        Task<List<VisitaDTO>> FindAll();
    }
}
