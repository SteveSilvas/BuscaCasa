using Domain.DTOs;

namespace Domain.Interfaces.IServices
{
    public interface IImovelService
    {
        Task<List<ImovelDTO>> FindAll();
    }
}
