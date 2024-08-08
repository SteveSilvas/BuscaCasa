using Domain.DTOs;

namespace Domain.Interfaces.IRepositories
{
    public interface IFavoritoRepository
    {
        Task<List<FavoritoDTO>> FindAll();
    }
}
