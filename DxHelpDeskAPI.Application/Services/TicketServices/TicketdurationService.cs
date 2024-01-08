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
    internal sealed class TicketdurationService : ITicketdurationService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        private readonly ILoggerManager _logger;

        public TicketdurationService(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
            _logger = logger;
        }
        public Task CreateTicketdurationDTOAsync(TicketdurationDTO ticketdurationDTO)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TicketdurationDTO>> GetAllTicketdurationDTOAsync(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<TicketdurationDTO> GetTicketdurationDTOByIdAsync(int id, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task UpdateTicketdurationDTOAsync(TicketdurationDTO ticketdurationDTO)
        {
            throw new NotImplementedException();
        }
    }
}
