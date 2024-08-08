using Authenticator.Context;
using Domain.DTOs;
using Domain.Entities;
using Domain.Interfaces.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repositories
{
    public class EnderecoRepository : IEnderecoRepository
    {
        private readonly PostgresDbContext _dbContext;
        public EnderecoRepository(PostgresDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<EnderecoDTO>> FindAll()
        {
            try
            {
                return await _dbContext.Enderecos
                    .Select(e => new EnderecoDTO
                    {
                        ID = e.ID,
                        Rua = e.Rua,
                        Numero = e.Numero,
                        Complemento = e.Complemento,
                        Bairro = e.Bairro,
                        CEP = e.CEP,
                        MunicipioId = e.MunicipioId,
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
