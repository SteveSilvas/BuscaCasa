using Domain.Entities;

namespace Domain.Interfaces.IServices
{
    public interface ITipoUsuarioService
    {
        Task<List<TipoUsuario>> FindAll();
    }
}
