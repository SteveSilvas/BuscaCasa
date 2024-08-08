using Domain.DTOs;
using Domain.Entities;
using Domain.Interfaces.IRepositories;
using Domain.Interfaces.IServices;

namespace Domain.Services
{
    public class CorretorService : ICorretorService
    {
        private readonly ICorretorRepository _CorretorRepository;

        public CorretorService(ICorretorRepository regiaoRepository)
        {
            _CorretorRepository = regiaoRepository;
        }

        public async Task<List<CorretorDTO>> FindAll()
        {
            try
            {
                return await _CorretorRepository.FindAll();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro inesperado: {ex.Message}");
            }
        }
    }
}
