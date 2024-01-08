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
    internal sealed class TicketstatusService : ITicketstatusService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        private readonly ILoggerManager _logger;

        public TicketstatusService(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
            _logger = logger;
        }
        public Task CreateTicketstatusAsync(TicketstatusDTO ticketStatusDTO)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TicketstatusDTO>> GetAllTicketstatusAsync(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<TicketstatusDTO> GetTicketstatusByIdAsync(int id, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TicketstatusDTO>> GetTicketstatusByStatusAsync(int status, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task UpdateTicketstatusAsync(TicketstatusDTO ticketStatusDTO)
        {
            throw new NotImplementedException();
        }
    }
}
