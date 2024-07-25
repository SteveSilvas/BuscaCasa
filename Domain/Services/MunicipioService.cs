using Domain.Entities;
using Domain.Interfaces.IRepositories;
using Domain.Interfaces.IServices;

namespace Domain.Services
{
    public class MunicipioService : IMunicipioService
    {
        private readonly IMunicipioRepository _municipioRepository;

        public MunicipioService(IMunicipioRepository municipioRepository)
        {
            _municipioRepository = municipioRepository;
        }

        public async Task<List<Municipio>?> FindAll()
        {
            try
            {
                return await _municipioRepository.FindAll();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro inesperado: {ex.Message}");
            }
        }

        public async Task<Municipio?> FindByIdEstado(int idEstado)
        {
            try
            {
                return await _municipioRepository.FindByIdEstado(idEstado);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro inesperado: {ex.Message}");
            }
        }
    }
}
