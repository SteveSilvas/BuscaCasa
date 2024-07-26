using Authenticator.Context;
using Domain.Entities;
using Domain.Interfaces.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repositories
{
    public class TipoUsuarioRepository : ITipoUsuarioRepository
    {
        private readonly PostgresDbContext _dbContext;
        public TipoUsuarioRepository(PostgresDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<TipoUsuario>> FindAll()
        {
            return await _dbContext.TiposUsuarios.ToListAsync();
        }
    }
}
