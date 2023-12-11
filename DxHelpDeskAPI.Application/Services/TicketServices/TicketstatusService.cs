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
    internal sealed class TicketstatusService : ITicketstatusService
    {
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
