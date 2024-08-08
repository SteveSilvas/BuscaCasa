using Domain.DTOs;

namespace Domain.Interfaces.IServices
{
    public interface IEstadoService
    {
        Task<List<EstadoDTO>> FindAll();
    }
}
