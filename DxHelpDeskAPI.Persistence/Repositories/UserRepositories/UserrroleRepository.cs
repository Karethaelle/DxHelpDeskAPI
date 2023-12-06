using DxHelpDeskAPI.Domain.Entities.Models;
using DxHelpDeskAPI.Domain.Interfaces.UserInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DxHelpDeskAPI.Persistence.Repositories.UserRepositories
{
    internal sealed class UserrroleRepository : RepositoryBase<Userrole>, IUserroleRepository
    {
        public UserrroleRepository(DxHelpDeskDBContext context) : base(context)
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
