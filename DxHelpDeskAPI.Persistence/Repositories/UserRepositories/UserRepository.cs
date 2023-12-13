using DxHelpDeskAPI.Domain.Entities.Models;
using DxHelpDeskAPI.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DxHelpDeskAPI.Persistence.Repositories
{
    internal sealed class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(DxHelpDeskDBContext context) : base(context)
        {
        }

        public async Task CreateUserAsync(User user) =>
            await CreateAsync(user);

        public async Task<IEnumerable<User>> GetUserByStatusAsync(int status, bool trackChanges) =>
            await GetByConditionAsync(u => u.Status.Equals(status), trackChanges);

        public async Task<IEnumerable<User>> GetAllUsersAsync(bool trackChanges) =>
            await GetAllAsync(trackChanges);

        public async Task<User> GetUserByIdAsync(int id, bool trackChanges) =>
            await GetByIdAsync(id, trackChanges);

        public async Task UpdateUserAsync(User user) =>
            await UpdateAsync(user);
    }
}
