using Authenticator.Context;
using Domain.DTOs;
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
        public async Task<List<EstadoDTO>> FindAll()
        {
            try
            {
                return await _dbContext.Estados
                    .Select(e => new EstadoDTO
                    {
                        ID = e.ID,
                        Nome = e.Nome,
                        Sigla = e.Sigla,
                        RegiaoId = e.RegiaoId,
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
