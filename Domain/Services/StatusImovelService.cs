using Domain.DTOs;
using Domain.Entities;
using Domain.Interfaces.IRepositories;
using Domain.Interfaces.IServices;

namespace Domain.Services
{
    public class StatusImovelService : IStatusImovelService
    {
        private readonly IStatusImovelRepository _repository;

        public StatusImovelService(IStatusImovelRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<StatusImovelDTO>> FindAll()
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
