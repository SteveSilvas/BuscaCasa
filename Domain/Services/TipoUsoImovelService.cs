using Domain.DTOs;
using Domain.Entities;
using Domain.Interfaces.IRepositories;
using Domain.Interfaces.IServices;

namespace Domain.Services
{
    public class TipoUsoImovelService : ITipoUsoImovelService
    {
        private readonly ITipoUsoImovelRepository _repository;

        public TipoUsoImovelService(ITipoUsoImovelRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<TipoUsoImovelDTO>> FindAll()
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
