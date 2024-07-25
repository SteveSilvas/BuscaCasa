using Domain.Entities;

namespace Domain.Interfaces.IServices
{
    public interface IEstadoService
    {
        Task<List<Estado>> FindAll();
    }
}
