using Domain.Entities;

namespace Domain.Interfaces.IServices
{
    public interface IEnderecoService
    {
        Task<List<Endereco>> FindAll();
    }
}
