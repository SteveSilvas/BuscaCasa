using Domain.DTOs;
using Domain.Entities;
using Domain.Interfaces.IRepositories;
using Domain.Interfaces.IServices;

namespace Domain.Services
{
    public class EstadoService : IEstadoService
    {
        private readonly IEstadoRepository _repository;

        public EstadoService(IEstadoRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<EstadoDTO>> FindAll()
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
