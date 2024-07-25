using Domain.Entities;

namespace Domain.Interfaces.IServices
{
    public interface IRegiaoService
    {
        Task<List<Regiao>> FindAll();
    }
}
