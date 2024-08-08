using Domain.DTOs;

namespace Domain.Interfaces.IServices
{
    public interface IImobiliariaService
    {
        Task<List<ImobiliariaDTO>> FindAll();
    }
}
