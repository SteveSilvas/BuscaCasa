using Domain.DTOs;

namespace Domain.Interfaces.IRepositories
{
    public interface IStatusImovelRepository
    {
        Task<List<StatusImovelDTO>> FindAll();
    }
}
