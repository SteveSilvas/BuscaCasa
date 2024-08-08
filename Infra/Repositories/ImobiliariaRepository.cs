using Authenticator.Context;
using Domain.DTOs;
using Domain.Interfaces.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repositories
{
    public class ImobiliariaRepository : IImobiliariaRepository
    {
        private readonly PostgresDbContext _dbContext;
        public ImobiliariaRepository(PostgresDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<ImobiliariaDTO>> FindAll()
        {
            try
            {
                return await _dbContext.Imobiliarias
                    .Select(i => new ImobiliariaDTO
                    {
                        ID = i.ID,
                        Nome = i.Nome,
                        CNPJ = i.CNPJ,
                        Email = i.Email,
                        Telefone = i.Telefone,
                        EnderecoID = i.EnderecoID,
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
