using Domain.Entities;

namespace Domain.Interfaces.IRepositories
{
    public interface IEnderecoRepository
    {
        Task<List<Endereco>> FindAll();
    }
}
