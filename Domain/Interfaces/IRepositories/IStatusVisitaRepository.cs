using Domain.DTOs;

namespace Domain.Interfaces.IRepositories
{
    public interface IStatusVisitaRepository
    {
        Task<List<StatusVisitaDTO>> FindAll();
    }
}
