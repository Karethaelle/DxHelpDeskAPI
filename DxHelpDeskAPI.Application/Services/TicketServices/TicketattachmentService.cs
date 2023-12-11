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
    internal sealed class TicketattachmentService : ITicketattachmentService
    {
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
