using Domain.DTOs;

namespace Domain.Interfaces.IRepositories
{
    public interface IImobiliariaRepository
    {
        Task<List<ImobiliariaDTO>> FindAll();
    }
}
