using Domain.DTOs;
using Domain.Entities;
using Domain.Interfaces.IRepositories;
using Domain.Interfaces.IServices;

namespace Domain.Services
{
    public class TipoConstrucaoImovelService : ITipoConstrucaoImovelService
    {
        private readonly ITipoConstrucaoImovelRepository _repository;

        public TipoConstrucaoImovelService(ITipoConstrucaoImovelRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<TipoConstrucaoImovelDTO>> FindAll()
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
