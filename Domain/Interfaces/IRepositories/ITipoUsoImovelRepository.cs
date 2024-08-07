using Domain.Entities;

namespace Domain.Interfaces.IRepositories
{
    public interface ITipoUsoImovelRepository
    {
        Task<List<TipoUsoImovel>> FindAll();
    }
}
