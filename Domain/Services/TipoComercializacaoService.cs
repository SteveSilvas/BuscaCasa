using Domain.DTOs;
using Domain.Entities;
using Domain.Interfaces.IRepositories;
using Domain.Interfaces.IServices;

namespace Domain.Services
{
    public class TipoComercializacaoService : ITipoComercializacaoService
    {
        private readonly ITipoComercializacaoRepository _repository;

        public TipoComercializacaoService(ITipoComercializacaoRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<TipoComercializacaoDTO>> FindAll()
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
