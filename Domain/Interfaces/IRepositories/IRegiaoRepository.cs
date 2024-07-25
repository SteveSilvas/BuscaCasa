﻿using Domain.Entities;

namespace Domain.Interfaces.IRepositories
{
    public interface IRegiaoRepository
    {
        Task<List<Regiao>> FindAll();
    }
}
