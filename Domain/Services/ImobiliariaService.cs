using Domain.DTOs;
using Domain.Entities;
using Domain.Interfaces.IRepositories;
using Domain.Interfaces.IServices;

namespace Domain.Services
{
    public class ImobiliariaService : IImobiliariaService
    {
        private readonly IImobiliariaRepository _repository;

        public ImobiliariaService(IImobiliariaRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<ImobiliariaDTO>> FindAll()
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
