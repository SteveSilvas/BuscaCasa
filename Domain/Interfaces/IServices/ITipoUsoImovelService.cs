using Domain.DTOs;

namespace Domain.Interfaces.IServices
{
    public interface ITipoUsoImovelService
    {
        Task<List<TipoUsoImovelDTO>> FindAll();
    }
}
