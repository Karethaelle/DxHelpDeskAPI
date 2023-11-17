using DxHelpDeskAPI.Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DxHelpDeskAPI.Domain.Interfaces.UserInterfaces
{
    public interface IRoleRepository : IRepositoryBase<Role>
    {
        Task<IEnumerable<Role>> GetAllRolesAsync(bool trackChanges);
        Task<Role> GetRoleByIdAsync(int id, bool trackChanges);
        Task<IEnumerable<Role>> FindRoleByStatusAsync(int status, bool trackChanges);
        Task CreateRoleAsync(Role role);
        Task UpdateRoleAsync(Role role);
    }
}
