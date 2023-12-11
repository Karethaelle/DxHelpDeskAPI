using DxHelpDeskAPI.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DxHelpDeskAPI.Application.Interfaces
{
    public interface IUserroleService
    {
        Task<IEnumerable<UserroleDTO>> GetAllUserrolesAsync(bool trackChanges);
        Task<UserroleDTO> GetUserroleByIdAsync(int id, bool trackChanges);
        Task CreateUserroleAsync(UserroleDTO UserRoleDTO);
        Task UpdateUserroleAsync(UserroleDTO UserRoleDTO);
    }
}
