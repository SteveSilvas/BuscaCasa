using Authenticator.Context;
using Domain.DTOs;
using Domain.Interfaces.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repositories
{
    public class TipoComercializacaoImovelRepository : ITipoComercializacaoImovelRepository
    {
        private readonly PostgresDbContext _dbContext;
        public TipoComercializacaoImovelRepository(PostgresDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<TipoComercializacaoImovelDTO>> FindAll()
        {
            try
            {
                return await _dbContext.TiposComercializacoesImoveis
                    .Select(t => new TipoComercializacaoImovelDTO
                    {
                        ID = t.ID,
                        Valor = t.Valor,
                        ImovelID = t.ImovelID,
                        TipoComercializacaoID = t.TipoComercializacaoID
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
