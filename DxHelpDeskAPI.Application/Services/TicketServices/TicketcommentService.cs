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
    internal sealed class TicketcommentService : ITicketcommentService
    {
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
