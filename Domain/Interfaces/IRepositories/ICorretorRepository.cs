using Domain.DTOs;

namespace Domain.Interfaces.IRepositories
{
    public interface ICorretorRepository
    {
        Task<List<CorretorDTO>> FindAll();
    }
}
