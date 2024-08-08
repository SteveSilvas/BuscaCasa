using Domain.DTOs;

namespace Domain.Interfaces.IServices
{
    public interface IMunicipioService
    {
        Task<List<MunicipioDTO>> FindAll();
        Task<MunicipioDTO?> FindByIdEstado(int idEstado);
    }
}
