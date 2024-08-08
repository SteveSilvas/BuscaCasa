using Domain.DTOs;
using Domain.Entities;
using Domain.Interfaces.IRepositories;
using Domain.Interfaces.IServices;

namespace Domain.Services
{
    public class StatusVisitaService : IStatusVisitaService
    {
        private readonly IStatusVisitaRepository _repository;

        public StatusVisitaService(IStatusVisitaRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<StatusVisitaDTO>> FindAll()
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
