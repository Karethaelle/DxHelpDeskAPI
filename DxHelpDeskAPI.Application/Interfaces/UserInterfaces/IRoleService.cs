using DxHelpDeskAPI.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DxHelpDeskAPI.Application.Interfaces
{
    public interface IRoleService
    {
        Task<IEnumerable<RoleDTO>> GetAllRolesAsync(bool trackChanges);
        Task<RoleDTO> GetRoleByIdAsync(int id, bool trackChanges);
        Task<IEnumerable<RoleDTO>> GetRoleByStatusAsync(int status, bool trackChanges);
        Task CreateRoleAsync(RoleDTO roleDTO);
        Task UpdateRoleAsync(RoleDTO roleDTO);
    }
}
