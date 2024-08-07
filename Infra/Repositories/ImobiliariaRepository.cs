using Authenticator.Context;
using Domain.Entities;
using Domain.Interfaces.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repositories
{
    public class ImobiliariaRepository : IImobiliariaRepository
    {
        private readonly PostgresDbContext _dbContext;
        public ImobiliariaRepository(PostgresDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Imobiliaria>> FindAll()
        {
            try
            {
                return await _dbContext.Imobiliarias.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível conectar à base de dados. {0}", ex);
            }
        }
    }
}
