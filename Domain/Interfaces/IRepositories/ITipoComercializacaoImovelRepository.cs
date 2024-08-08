using Domain.DTOs;

namespace Domain.Interfaces.IRepositories
{
    public interface ITipoComercializacaoImovelRepository
    {
        Task<List<TipoComercializacaoImovelDTO>> FindAll();
    }
}
