using Domain.Entities;
using Domain.Interfaces.IRepositories;
using Domain.Interfaces.IServices;

namespace Domain.Services
{
    public class EstadoService : IEstadoService
    {
        private readonly IEstadoRepository _estadoRepository;

        public EstadoService(IEstadoRepository estadoRepository)
        {
            _estadoRepository = estadoRepository;
        }

        public async Task<List<Estado>> FindAll()
        {
            try
            {
                return await _estadoRepository.FindAll();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro inesperado: {ex.Message}");
            }
        }
    }
}
