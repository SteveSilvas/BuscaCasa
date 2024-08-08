using Domain.DTOs;
using Domain.Entities;
using Domain.Interfaces.IRepositories;
using Domain.Interfaces.IServices;

namespace Domain.Services
{
    public class ProprietarioService : IProprietarioService
    {
        private readonly IProprietarioRepository _repository;

        public ProprietarioService(IProprietarioRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<ProprietarioDTO>> FindAll()
        {
            try
            {
                return await _repository.FindAll();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro inesperado: {ex.Message}");
            }
        }
    }
}
