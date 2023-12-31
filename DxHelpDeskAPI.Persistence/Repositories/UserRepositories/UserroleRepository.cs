﻿using DxHelpDeskAPI.Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DxHelpDeskAPI.Domain.Interfaces;

namespace DxHelpDeskAPI.Infrastructure.Repositories
{
    internal sealed class UserroleRepository : RepositoryBase<Userrole>, IUserroleRepository
    {
        public UserroleRepository(DxHelpDeskDBContext context) : base(context)
        {
        }

        public async Task CreateUserroleAsync(Userrole UserRole) =>
            await CreateAsync(UserRole);

        public Task<IEnumerable<Userrole>> GetAllUserrolesAsync(bool trackChanges) =>
            GetAllAsync(trackChanges);
        public async Task<Userrole> GetUserroleByIdAsync(int id, bool trackChanges) =>
            await GetUserroleByIdAsync(id, trackChanges);

        public async Task UpdateUserroleAsync(Userrole UserRole) =>
            await UpdateAsync(UserRole);
    }
}
