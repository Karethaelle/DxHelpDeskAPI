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
    internal sealed class UserroleService : IUserroleService
    {
        public Task CreateUserroleAsync(UserroleDTO UserRoleDTO)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserroleDTO>> GetAllUserrolesAsync(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<UserroleDTO> GetUserroleByIdAsync(int id, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task UpdateUserroleAsync(UserroleDTO UserRoleDTO)
        {
            throw new NotImplementedException();
        }
    }
}
