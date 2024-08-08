using Authenticator.Context;
using Domain.DTOs;
using Domain.Entities;
using Domain.Interfaces.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repositories
{
    public class PropriedadeRepository : IPropriedadeRepository
    {
        private readonly PostgresDbContext _dbContext;
        public PropriedadeRepository(PostgresDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<PropriedadeDTO>> FindAll()
        {
            try
            {
                return await _dbContext.Propriedades
                    .Select(p => new PropriedadeDTO
                    {
                        ID = p.ID,
                        ImovelID = p.ImovelID,
                        ImobiliariaID = p.ImobiliariaID,
                        ProprietarioID = p.ProprietarioID,
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
