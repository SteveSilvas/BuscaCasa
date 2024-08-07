using Authenticator.Context;
using Domain.Entities;
using Domain.Interfaces.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repositories
{
    public class StatusVisitaRepository : IStatusVisitaRepository
    {
        private readonly PostgresDbContext _dbContext;
        public StatusVisitaRepository(PostgresDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<StatusVisita>> FindAll()
        {
            try
            {
                return await _dbContext.StatusVisitas.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível conectar à base de dados. {0}", ex);
            }
        }
    }
}
