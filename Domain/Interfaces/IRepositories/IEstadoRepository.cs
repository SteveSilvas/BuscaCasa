using Domain.DTOs;

namespace Domain.Interfaces.IRepositories
{
    public interface IEstadoRepository
    {
        Task<List<EstadoDTO>> FindAll();
    }
}
