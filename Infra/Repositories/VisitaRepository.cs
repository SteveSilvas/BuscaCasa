using Authenticator.Context;
using Domain.DTOs;
using Domain.Entities;
using Domain.Interfaces.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repositories
{
    public class VisitaRepository : IVisitaRepository
    {
        private readonly PostgresDbContext _dbContext;
        public VisitaRepository(PostgresDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<VisitaDTO>> FindAll()
        {
            try
            {
                return await _dbContext.Visitas
                    .Select(v => new VisitaDTO
                    {
                        ID = v.ID,
                        Data = v.Data,
                        CorretorID = v.CorretorID,
                        ImovelID = v.ImovelID,
                        UsuarioID = v.UsuarioID,    
                        StatusVisitaID = v.StatusVisitaID   
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
