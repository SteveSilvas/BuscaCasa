using Authenticator.Context;
using Domain.DTOs;
using Domain.Entities;
using Domain.Interfaces.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repositories
{
    public class ImovelRepository : IImovelRepository
    {
        private readonly PostgresDbContext _dbContext;
        public ImovelRepository(PostgresDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<ImovelDTO>> FindAll()
        {
            try
            {
                return await _dbContext.Imoveis
                    .Select(i => new ImovelDTO
                    {
                        ID = i.ID,
                        Nome = i.Nome,
                        Descricao = i.Descricao,
                        CreatedAt = i.CreatedAt,
                        UpdatedAt = i.UpdatedAt,
                        TipoUsoImovelID = i.TipoUsoImovelID,
                        TipoConstrucaoImovelID  = i.TipoConstrucaoImovelID,
                        StatusImovelID = i.StatusImovelID
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
