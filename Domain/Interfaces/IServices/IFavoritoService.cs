using Domain.DTOs;

namespace Domain.Interfaces.IServices
{
    public interface IFavoritoService
    {
        Task<List<FavoritoDTO>> FindAll();
    }
}
