using Authenticator.Context;
using Domain.DTOs;
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
        public async Task<List<TipoUsuarioDTO>> FindAll()
        {
            return await _dbContext.TiposUsuarios
                .Select(t => new TipoUsuarioDTO
                {
                    ID = t.ID,
                    Descricao = t.Descricao,
                })
                .ToListAsync();
        }
    }
}
