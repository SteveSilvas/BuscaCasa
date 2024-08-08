using Domain.DTOs;

namespace Domain.Interfaces.IServices
{
    public interface ICorretorService
    {
        Task<List<CorretorDTO>> FindAll();
    }
}
