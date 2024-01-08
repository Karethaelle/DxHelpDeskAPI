using DxHelpDeskAPI.Application.DTOs;
using DxHelpDeskAPI.Domain.Entities.Models;
using DxHelpDeskAPI.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DxHelpDeskAPI.Domain.Interfaces;

namespace DxHelpDeskAPI.Application.Services
{
    internal sealed class UserService : IUserService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        private readonly ILoggerManager _logger;

        public UserService(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
            _logger = logger;
        }
        public Task CreateUserAsync(UserDTO userDTO)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserDTO>> GetAllUsersAsync(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<UserDTO> GetUserByIdAsync(int id, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserDTO>> GetUserByStatusAsync(int status, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task UpdateUserAsync(UserDTO userDTO)
        {
            throw new NotImplementedException();
        }
    }
}
