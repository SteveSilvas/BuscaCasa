using Authenticator.Context;
using Domain.Entities;
using Domain.Interfaces.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repositories
{
    public class FavoritoRepository : IFavoritoRepository
    {
        private readonly PostgresDbContext _dbContext;
        public FavoritoRepository(PostgresDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Favorito>> FindAll()
        {
            try
            {
                return await _dbContext.Favoritos.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível conectar à base de dados. {0}", ex);
            }
        }
    }
}
