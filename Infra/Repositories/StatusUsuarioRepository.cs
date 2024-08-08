using Authenticator.Context;
using Domain.DTOs;
using Domain.Entities;
using Domain.Interfaces.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repositories
{
    public class StatusUsuarioRepository : IStatusUsuarioRepository
    {
        private readonly PostgresDbContext _dbContext;
        public StatusUsuarioRepository(PostgresDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<StatusUsuarioDTO>> FindAll()
        {
            try
            {
                return await _dbContext.StatusUsuarios
                         .Select(s => new StatusUsuarioDTO
                         {
                             ID = s.ID,
                             Descricao = s.Descricao,
                         })
                         .ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível conectar à base de dados. {0}", ex);
            }
        }
    }
}
