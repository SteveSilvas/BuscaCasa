using Domain.DTOs;
using Domain.Entities;
using Domain.Interfaces.IRepositories;
using Domain.Interfaces.IServices;

namespace Domain.Services
{
    public class ImovelService : IImovelService
    {
        private readonly IImovelRepository _repository;

        public ImovelService(IImovelRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<ImovelDTO>> FindAll()
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
