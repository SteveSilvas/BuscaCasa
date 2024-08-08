using Domain.DTOs;

namespace Domain.Interfaces.IRepositories
{
    public interface IRegiaoRepository
    {
        Task<List<RegiaoDTO>> FindAll();
    }
}
