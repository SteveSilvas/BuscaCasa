using Domain.DTOs;

namespace Domain.Interfaces.IRepositories
{
    public interface ITipoUsoImovelRepository
    {
        Task<List<TipoUsoImovelDTO>> FindAll();
    }
}
