using Domain.DTOs;

namespace Domain.Interfaces.IRepositories
{
    public interface IEnderecoRepository
    {
        Task<List<EnderecoDTO>> FindAll();
    }
}
