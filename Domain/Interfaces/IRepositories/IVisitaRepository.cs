using Domain.DTOs;

namespace Domain.Interfaces.IRepositories
{
    public interface IVisitaRepository
    {
        Task<List<VisitaDTO>> FindAll();
    }
}
