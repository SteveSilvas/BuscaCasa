using Domain.DTOs;

namespace Domain.Interfaces.IRepositories
{
    public interface IMunicipioRepository
    {
        Task<List<MunicipioDTO>> FindAll();

        Task<MunicipioDTO?> FindByIdEstado(int idEstado);
    }
}
