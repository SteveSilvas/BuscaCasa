using Domain.DTOs;

namespace Domain.Interfaces.IServices
{
    public interface ITipoConstrucaoImovelService
    {
        Task<List<TipoConstrucaoImovelDTO>> FindAll();
    }
}
