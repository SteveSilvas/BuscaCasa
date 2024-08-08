using Authenticator.Context;
using Domain.DTOs;
using Domain.Entities;
using Domain.Interfaces.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repositories
{
    public class StatusImovelRepository : IStatusImovelRepository
    {   
        private readonly PostgresDbContext _dbContext;
        public StatusImovelRepository(PostgresDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<StatusImovelDTO>> FindAll()
        {
            try
            {
                return await _dbContext.StatusImoveis
                    .Select(s => new StatusImovelDTO
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
