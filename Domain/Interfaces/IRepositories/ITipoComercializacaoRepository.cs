using Domain.DTOs;

namespace Domain.Interfaces.IRepositories
{
    public interface ITipoComercializacaoRepository
    {
        Task<List<TipoComercializacaoDTO>> FindAll();
    }
}
