using Authenticator.Context;
using Domain.Entities;
using Domain.Interfaces.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repositories
{
    public class TipoComercializacaoRepository : ITipoComercializacaoRepository
    {
        private readonly PostgresDbContext _dbContext;
        public TipoComercializacaoRepository(PostgresDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<TipoComercializacao>> FindAll()
        {
            try
            {
                return await _dbContext.TiposComercializacoes.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível conectar à base de dados. {0}", ex);
            }
        }
    }
}
