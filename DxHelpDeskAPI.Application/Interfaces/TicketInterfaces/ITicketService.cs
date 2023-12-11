
using DxHelpDeskAPI.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DxHelpDeskAPI.Application.Interfaces
{
    public interface ITicketService
    {
        Task<IEnumerable<TicketDTO>> GetAllTicketsAsync(bool trackChanges);
        Task<TicketDTO> GetTicketByIdAsync(int id, bool trackChanges);
        Task<IEnumerable<TicketDTO>> GetTicketsByStatusAsync(int status, bool trackChanges);
        Task CreateTicketAsync(TicketDTO ticketDTO);
        Task UpdateTicketAsync(TicketDTO ticketDTO);

    }
}
