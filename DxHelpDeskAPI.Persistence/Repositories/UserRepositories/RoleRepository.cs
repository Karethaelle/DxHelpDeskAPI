using DxHelpDeskAPI.Domain.Entities.Models;
using DxHelpDeskAPI.Domain.Interfaces.UserInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DxHelpDeskAPI.Persistence.Repositories.UserRepositories
{
    internal sealed class RoleRepository : RepositoryBase<Role>, IRoleRepository
    {
        public RoleRepository(DxHelpDeskDBContext context) : base(context)
        {
        }

        public async Task CreateRoleAsync(Role role) =>
            await CreateAsync(role);

        public async Task<IEnumerable<Role>> GetRoleByStatusAsync(int status, bool trackChanges) =>
            await GetByConditionAsync(r => r.Status.Equals(status), trackChanges);

        public Task<IEnumerable<Role>> GetAllRolesAsync(bool trackChanges) =>
            GetAllAsync(trackChanges);

        public async Task<Role> GetRoleByIdAsync(int id, bool trackChanges) => 
            await GetByIdAsync(id, trackChanges);

        public async Task UpdateRoleAsync(Role role) =>
            await UpdateAsync(role);
    }
}
