using Domain.DTOs;
using Domain.Entities;
using Domain.Interfaces.IRepositories;
using Domain.Interfaces.IServices;

namespace Domain.Services
{
    public class PropriedadeService : IPropriedadeService
    {
        private readonly IPropriedadeRepository _repository;

        public PropriedadeService(IPropriedadeRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<PropriedadeDTO>> FindAll()
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
