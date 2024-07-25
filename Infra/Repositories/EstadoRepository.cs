using Authenticator.Context;
using Domain.Entities;
using Domain.Interfaces.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repositories
{
    public class EstadoRepository : IEstadoRepository
    {
        private readonly PostgresDbContext _dbContext;
        public EstadoRepository(PostgresDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Estado>> FindAll()
        {
            try
            {
                return await _dbContext.Estados.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível conectar à base de dados. {0}", ex);
            }
        }
    }
}
