using Domain.DTOs;

namespace Domain.Interfaces.IServices
{
    public interface ITipoComercializacaoService
    {
        Task<List<TipoComercializacaoDTO>> FindAll();
    }
}
