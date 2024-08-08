using Domain.DTOs;
using Domain.Entities;
using Domain.Interfaces.IRepositories;
using Domain.Interfaces.IServices;

namespace Domain.Services
{
    public class StatusUsuarioService : IStatusUsuarioService
    {
        private readonly IStatusUsuarioRepository _repository;

        public StatusUsuarioService(IStatusUsuarioRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<StatusUsuarioDTO>> FindAll()
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
