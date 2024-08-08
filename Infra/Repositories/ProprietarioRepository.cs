using Authenticator.Context;
using Domain.DTOs;
using Domain.Entities;
using Domain.Interfaces.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repositories
{
    public class ProprietarioRepository : IProprietarioRepository
    {
        private readonly PostgresDbContext _dbContext;
        public ProprietarioRepository(PostgresDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<ProprietarioDTO>> FindAll()
        {
            try
            {
                return await _dbContext.Proprietarios
                    .Select(p => new ProprietarioDTO
                    {
                        ID = p.ID,
                        UsuarioID = p.UsuarioID,
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
