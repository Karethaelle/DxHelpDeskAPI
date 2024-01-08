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
    internal sealed class TicketService : ITicketService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        private readonly ILoggerManager _logger;

        public TicketService(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
            _logger = logger;
        }
        public Task CreateTicketAsync(TicketDTO ticketDTO)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TicketDTO>> GetAllTicketsAsync(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<TicketDTO> GetTicketByIdAsync(int id, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TicketDTO>> GetTicketsByStatusAsync(int status, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task UpdateTicketAsync(TicketDTO ticketDTO)
        {
            throw new NotImplementedException();
        }
    }
}
