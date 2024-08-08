using Authenticator.Context;
using Domain.DTOs;
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
        public async Task<List<FavoritoDTO>> FindAll()
        {
            try
            {
                return await _dbContext.Favoritos
                    .Select(f => new FavoritoDTO
                    {
                        ID = f.ID,
                        ImovelID = f.ImovelID,
                        UsuarioID = f.UsuarioID,
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
