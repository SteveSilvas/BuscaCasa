using Domain.Entities;

namespace Domain.Interfaces.IRepositories
{
    public interface ITipoUsuarioRepository
    {
        Task<List<TipoUsuario>> FindAll();
    }
}
