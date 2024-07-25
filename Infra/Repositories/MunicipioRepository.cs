using Authenticator.Context;
using Domain.Entities;
using Domain.Interfaces.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repositories
{
    public class MunicipioRepository : IMunicipioRepository
    {
        private readonly PostgresDbContext _dbContext;
        public MunicipioRepository(PostgresDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Municipio>> FindAll()
        {
            try
            {
                return await _dbContext.Municipios.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível conectar à base de dados. {0}", ex);
            }
        }

        public async Task<Municipio?> FindByIdEstado(int idEstado)
        {
            try
            {
                return await _dbContext.Municipios.Where(m => m.EstadoId == idEstado).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível conectar à base de dados. {0}", ex);
            }
        }
    }
}
