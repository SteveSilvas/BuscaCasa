using Authenticator.Context;
using Domain.DTOs;
using Domain.Entities;
using Domain.Interfaces.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repositories
{
    public class TipoUsoImovelRepository : ITipoUsoImovelRepository
    {
        private readonly PostgresDbContext _dbContext;
        public TipoUsoImovelRepository(PostgresDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<TipoUsoImovelDTO>> FindAll()
        {
            try
            {
                return await _dbContext.TiposUsosImoveis
                    .Select(t => new TipoUsoImovelDTO
                    {
                        ID = t.ID,
                        Descricao = t.Descricao,
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
