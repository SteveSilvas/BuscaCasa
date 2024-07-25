using Domain.Entities;
using Domain.Interfaces.IRepositories;
using Domain.Interfaces.IServices;

namespace Domain.Services
{
    public class EnderecoService : IEnderecoService
    {
        private readonly IEnderecoRepository _enderecoRepository;

        public EnderecoService(IEnderecoRepository regiaoRepository)
        {
            _enderecoRepository = regiaoRepository;
        }

        public async Task<List<Endereco>> FindAll()
        {
            try
            {
                return await _enderecoRepository.FindAll();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro inesperado: {ex.Message}");
            }
        }
    }
}
