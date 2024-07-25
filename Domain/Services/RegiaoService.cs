using Domain.Entities;
using Domain.Interfaces.IRepositories;
using Domain.Interfaces.IServices;

namespace Domain.Services
{
    public class RegiaoService : IRegiaoService
    {
        private readonly IRegiaoRepository _regiaoRepository;

        public RegiaoService(IRegiaoRepository regiaoRepository)
        {
            _regiaoRepository = regiaoRepository;
        }

        public async Task<List<Regiao>> FindAll()
        {
            try
            {
                return await _regiaoRepository.FindAll();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro inesperado: {ex.Message}");
            }
        }
    }
}
