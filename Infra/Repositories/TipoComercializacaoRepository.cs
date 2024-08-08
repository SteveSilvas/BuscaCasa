﻿using Authenticator.Context;
using Domain.DTOs;
using Domain.Entities;
using Domain.Interfaces.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repositories
{
    public class TipoComercializacaoRepository : ITipoComercializacaoRepository
    {
        private readonly PostgresDbContext _dbContext;
        public TipoComercializacaoRepository(PostgresDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<TipoComercializacaoDTO>> FindAll()
        {
            try
            {
                return await _dbContext.TiposComercializacoes
                    .Select(t => new TipoComercializacaoDTO
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
