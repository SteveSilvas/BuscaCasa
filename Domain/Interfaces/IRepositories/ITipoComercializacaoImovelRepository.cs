using Domain.Entities;

namespace Domain.Interfaces.IRepositories
{
    public interface ITipoComercializacaoImovelRepository
    {
        Task<List<TipoComercializacaoImovel>> FindAll();
    }
}
