﻿using Boilerplate.Application.DTOs;
using Boilerplate.Application.Filters;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Boilerplate.Application.Interfaces
{
    public interface IHeroAppService : IDisposable
    {
        public Task<List<GetHeroDTO>> GetAll(GetHeroesFilter filter);

        public Task<GetHeroDTO> GetById(Guid id);

        public Task Create(GetHeroDTO hero);

        public Task Update(GetHeroDTO hero);

        public Task<bool> Delete(Guid id);

    }
}