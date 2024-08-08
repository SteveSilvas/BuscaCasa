using Domain.DTOs;

namespace Domain.Interfaces.IServices
{
    public interface IEnderecoService
    {
        Task<List<EnderecoDTO>> FindAll();
    }
}
