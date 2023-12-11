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
    internal sealed class TicketService : ITicketService
    {
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
