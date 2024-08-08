using Domain.DTOs;
using Domain.Entities;
using Domain.Interfaces.IRepositories;
using Domain.Interfaces.IServices;

namespace Domain.Services
{
    public class VisitaService : IVisitaService
    {
        private readonly IVisitaRepository _repository;

        public VisitaService(IVisitaRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<VisitaDTO>> FindAll()
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
