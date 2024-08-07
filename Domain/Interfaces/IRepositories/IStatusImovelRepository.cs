using Domain.Entities;

namespace Domain.Interfaces.IRepositories
{
    public interface IStatusImovelRepository
    {
        Task<List<StatusImovel>> FindAll();
    }
}
