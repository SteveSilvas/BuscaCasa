using Domain.DTOs;
using Domain.Entities;
using Domain.Interfaces.IRepositories;
using Domain.Interfaces.IServices;

namespace Domain.Services
{
    public class FavoritoService : IFavoritoService
    {
        private readonly IFavoritoRepository _repository;

        public FavoritoService(IFavoritoRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<FavoritoDTO>> FindAll()
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
