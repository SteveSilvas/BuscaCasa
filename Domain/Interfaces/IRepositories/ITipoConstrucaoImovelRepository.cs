using Domain.DTOs;

namespace Domain.Interfaces.IRepositories
{
    public interface ITipoConstrucaoImovelRepository
    {
        Task<List<TipoConstrucaoImovelDTO>> FindAll();
    }
}
