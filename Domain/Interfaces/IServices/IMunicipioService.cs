using Domain.Entities;

namespace Domain.Interfaces.IServices
{
    public interface IMunicipioService
    {
        Task<List<Municipio>> FindAll();
        Task<Municipio?> FindByIdEstado(int idEstado);
    }
}
