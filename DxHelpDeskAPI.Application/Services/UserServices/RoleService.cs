using DxHelpDeskAPI.Application.DTOs;
using DxHelpDeskAPI.Application.Interfaces;
using DxHelpDeskAPI.Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DxHelpDeskAPI.Application.Services
{
    internal sealed class RoleService : IRoleService
    {
        public Task CreateRoleAsync(RoleDTO roleDTO)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<RoleDTO>> GetAllRolesAsync(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<RoleDTO> GetRoleByIdAsync(int id, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<RoleDTO>> GetRoleByStatusAsync(int status, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task UpdateRoleAsync(RoleDTO roleDTO)
        {
            throw new NotImplementedException();
        }
    }
}
