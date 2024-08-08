using Authenticator.Context;
using Domain.DTOs;
using Domain.Entities;
using Domain.Interfaces.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repositories
{
    public class CorretorRepository : ICorretorRepository
    {
        private readonly PostgresDbContext _dbContext;
        public CorretorRepository(PostgresDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<CorretorDTO>> FindAll()
        {
            try
            {
                return await _dbContext.Corretores
                    .Select(c => new CorretorDTO
                    {
                        ID = c.ID,
                        Sigla = c.Sigla,
                        ImobiliariaID = c.ImobiliariaID,
                        UsuarioID = c.UsuarioID
                    }).ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível conectar à base de dados. {0}", ex);
            }
        }
    }
}
