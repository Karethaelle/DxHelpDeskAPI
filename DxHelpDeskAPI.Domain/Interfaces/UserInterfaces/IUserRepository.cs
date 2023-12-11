using DxHelpDeskAPI.Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DxHelpDeskAPI.Domain.Interfaces
{
    public interface IUserRepository : IRepositoryBase<User>
    {
        Task<IEnumerable<User>> GetAllUsersAsync(bool trackChanges);
        Task<User> GetUserByIdAsync(int id, bool trackChanges);
        Task<IEnumerable<User>> GetUserByStatusAsync(int status, bool trackChanges);
        Task CreateUserAsync(User user);
        Task UpdateUserAsync(User user);
    }
}
