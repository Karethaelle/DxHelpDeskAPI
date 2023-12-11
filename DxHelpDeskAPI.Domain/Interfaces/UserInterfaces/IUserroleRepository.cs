using DxHelpDeskAPI.Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DxHelpDeskAPI.Domain.Interfaces
{
    public interface IUserroleRepository : IRepositoryBase<Userrole>
    {
        Task<IEnumerable<Userrole>> GetAllUserrolesAsync(bool trackChanges);
        Task<Userrole> GetUserroleByIdAsync(int id, bool trackChanges);
        Task CreateUserroleAsync(Userrole UserRole);
        Task UpdateUserroleAsync(Userrole UserRole);
    }
}
