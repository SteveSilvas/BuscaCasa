using Authenticator.Context;
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
        public async Task<List<Proprietario>> FindAll()
        {
            try
            {
                return await _dbContext.Proprietarios.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível conectar à base de dados. {0}", ex);
            }
        }
    }
}
