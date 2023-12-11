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
    internal sealed class TicketdurationService : ITicketdurationService
    {
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
