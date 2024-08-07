﻿using Authenticator.Context;
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
        public async Task<List<Imovel>> FindAll()
        {
            try
            {
                return await _dbContext.Imoveis.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível conectar à base de dados. {0}", ex);
            }
        }
    }
}