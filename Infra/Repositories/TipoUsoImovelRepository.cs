using Authenticator.Context;
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
        public async Task<List<TipoUsoImovel>> FindAll()
        {
            try
            {
                return await _dbContext.TiposUsosImoveis.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível conectar à base de dados. {0}", ex);
            }
        }
    }
}
