using AutoMapper;
using DxHelpDeskAPI.Application.DTOs;
using DxHelpDeskAPI.Application.Interfaces;
using DxHelpDeskAPI.Domain.Entities.Models;
using DxHelpDeskAPI.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DxHelpDeskAPI.Application.Services
{
    internal sealed class UserroleService : IUserroleService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        private readonly ILoggerManager _logger;

        public UserroleService(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
            _logger = logger;
        }
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
