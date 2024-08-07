using Domain.Entities;

namespace Domain.Interfaces.IRepositories
{
    public interface ICorretorRepository
    {
        Task<List<Corretor>> FindAll();
    }
}
