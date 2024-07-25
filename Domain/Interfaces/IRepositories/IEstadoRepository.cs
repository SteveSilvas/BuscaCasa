using Domain.Entities;

namespace Domain.Interfaces.IRepositories
{
    public interface IEstadoRepository
    {
        Task<List<Estado>> FindAll();
    }
}
