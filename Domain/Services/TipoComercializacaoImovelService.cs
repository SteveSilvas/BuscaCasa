using Domain.DTOs;
using Domain.Entities;
using Domain.Interfaces.IRepositories;
using Domain.Interfaces.IServices;

namespace Domain.Services
{
    public class TipoComercializacaoImovelService : ITipoComercializacaoImovelService
    {
        private readonly ITipoComercializacaoImovelRepository _repository;

        public TipoComercializacaoImovelService(ITipoComercializacaoImovelRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<TipoComercializacaoImovelDTO>> FindAll()
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
