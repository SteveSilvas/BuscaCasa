using Domain.DTOs;
using Domain.Entities;
using Domain.Interfaces.IRepositories;
using Domain.Interfaces.IServices;

namespace Domain.Services
{
    public class MunicipioService : IMunicipioService
    {
        private readonly IMunicipioRepository _repository;

        public MunicipioService(IMunicipioRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<MunicipioDTO>?> FindAll()
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

        public async Task<Municipio?> FindByIdEstado(int idEstado)
        {
            try
            {
                return await _repository.FindByIdEstado(idEstado);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro inesperado: {ex.Message}");
            }
        }
    }
}
