
using DxHelpDeskAPI.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DxHelpDeskAPI.Application.Interfaces
{
    public interface ITicketpriorityService
    {
        Task<IEnumerable<TicketpriorityDTO>> GetAllTicketpriorityAsync(bool trackChanges);
        Task<TicketpriorityDTO> GetTicketpriorityByIdAsync(int id, bool trackChanges);
        Task<IEnumerable<TicketpriorityDTO>> GetTicketpriorityByStatusAsync(int status, bool trackChanges);
        Task CreateTicketpriorityAsync(TicketpriorityDTO ticketPriorityDTO);
        Task UpdateTicketpriorityAsync(TicketpriorityDTO ticketPriorityDTO);
    }
}
