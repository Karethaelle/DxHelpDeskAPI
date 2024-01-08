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
    internal sealed class TicketpriorityService : ITicketpriorityService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        private readonly ILoggerManager _logger;

        public TicketpriorityService(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
            _logger = logger;
        }
        public Task CreateTicketpriorityAsync(TicketpriorityDTO ticketPriorityDTO)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TicketpriorityDTO>> GetAllTicketpriorityAsync(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<TicketpriorityDTO> GetTicketpriorityByIdAsync(int id, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TicketpriorityDTO>> GetTicketpriorityByStatusAsync(int status, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task UpdateTicketpriorityAsync(TicketpriorityDTO ticketPriorityDTO)
        {
            throw new NotImplementedException();
        }
    }
}
