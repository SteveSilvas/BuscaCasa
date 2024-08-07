using Domain.Entities;

namespace Domain.Interfaces.IRepositories
{
    public interface ITipoConstrucaoImovelRepository
    {
        Task<List<TipoConstrucaoImovel>> FindAll();
    }
}
