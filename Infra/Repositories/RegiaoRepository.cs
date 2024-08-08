using Authenticator.Context;
using Domain.DTOs;
using Domain.Entities;
using Domain.Interfaces.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repositories
{
    public class RegiaoRepository : IRegiaoRepository
    {
        private readonly PostgresDbContext _dbContext;
        public RegiaoRepository(PostgresDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<RegiaoDTO>> FindAll()
        {
            try
            {
                return await _dbContext.Regioes
                    .Select(r => new RegiaoDTO
                    {
                        ID = r.ID,
                        Nome = r.Nome,
                        Sigla = r.Sigla,
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
