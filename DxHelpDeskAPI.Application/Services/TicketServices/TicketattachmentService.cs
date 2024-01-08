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
    internal sealed class TicketattachmentService : ITicketattachmentService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        private readonly ILoggerManager _logger;

        public TicketattachmentService(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
            _logger = logger;
        }
        public Task CreateTicketattachmentDTOAsync(TicketattachmentDTO ticketattachmentDTO)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TicketattachmentDTO>> GetAllTicketattachmentDTOsAsync(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<TicketattachmentDTO> GetTicketattachmentDTOByIdAsync(int id, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task UpdateTicketattachmentDTOAsync(TicketattachmentDTO ticketattachmentDTO)
        {
            throw new NotImplementedException();
        }
    }
}
