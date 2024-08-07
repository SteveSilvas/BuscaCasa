using Authenticator.Context;
using Domain.Entities;
using Domain.Interfaces.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repositories
{
    public class TipoConstrucaoImovelRepository : ITipoConstrucaoImovelRepository
    {
        private readonly PostgresDbContext _dbContext;
        public TipoConstrucaoImovelRepository(PostgresDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<TipoConstrucaoImovel>> FindAll()
        {
            try
            {
                return await _dbContext.TiposConstrucoesImoveis.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível conectar à base de dados. {0}", ex);
            }
        }
    }
}
