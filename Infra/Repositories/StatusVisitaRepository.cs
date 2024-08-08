using Authenticator.Context;
using Domain.DTOs;
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
        public async Task<List<StatusVisitaDTO>> FindAll()
        {
            try
            {
                return await _dbContext.StatusVisitas
                         .Select(s => new StatusVisitaDTO
                         {
                             ID = s.ID,
                             Descricao = s.Descricao,
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
