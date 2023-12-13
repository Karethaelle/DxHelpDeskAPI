
using DxHelpDeskAPI.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DxHelpDeskAPI.Application.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<UserDTO>> GetAllUsersAsync(bool trackChanges);
        Task<UserDTO> GetUserByIdAsync(int id, bool trackChanges);
        Task<IEnumerable<UserDTO>> GetUserByStatusAsync(int status, bool trackChanges);
        Task CreateUserAsync(UserDTO userDTO);
        Task UpdateUserAsync(UserDTO userDTO);
    }
}
