using Domain.DTOs;

namespace Domain.Interfaces.IServices
{
    public interface ITipoComercializacaoImovelService
    {
        Task<List<TipoComercializacaoImovelDTO>> FindAll();
    }
}
