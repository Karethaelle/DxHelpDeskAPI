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
    internal sealed class TicketcommentService : ITicketcommentService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        private readonly ILoggerManager _logger;

        public TicketcommentService(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
            _logger = logger;
        }
        public Task CreateTicketcommentAsync(TicketcommentDTO ticketCommentDTO)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TicketcommentDTO>> GetAllTicketcommentsAsync(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<TicketcommentDTO> GetTicketcommentByIdAsync(int id, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task UpdateTicketcommentAsync(TicketcommentDTO ticketCommentDTO)
        {
            throw new NotImplementedException();
        }
    }
}
