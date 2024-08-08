using Authenticator.Context;
using Domain.DTOs;
using Domain.Entities;
using Domain.Interfaces.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repositories
{
    public class TipoConstrucaoImovelRepository : ITipoConstrucaoImovelRepository
    {
        private readonly PostgresDbContext _dbContext;
        public TipoConstrucaoImovelRepository(PostgresDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<TipoConstrucaoImovelDTO>> FindAll()
        {
            try
            {
                return await _dbContext.TiposConstrucoesImoveis
                    .Select(t => new TipoConstrucaoImovelDTO
                    {
                        ID = t.ID,
                        Descricao = t.Descricao,
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
