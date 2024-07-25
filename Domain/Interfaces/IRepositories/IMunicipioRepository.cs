using Domain.Entities;

namespace Domain.Interfaces.IRepositories
{
    public interface IMunicipioRepository
    {
        Task<List<Municipio>> FindAll();

        Task<Municipio?> FindByIdEstado(int idEstado);
    }
}
