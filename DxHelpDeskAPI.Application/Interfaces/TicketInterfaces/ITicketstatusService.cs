using DxHelpDeskAPI.Application.DTOs;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DxHelpDeskAPI.Application.Interfaces
{
    public interface ITicketstatusService
    {
        Task<IEnumerable<TicketstatusDTO>> GetAllTicketstatusAsync(bool trackChanges);
        Task<TicketstatusDTO> GetTicketstatusByIdAsync(int id, bool trackChanges);
        Task<IEnumerable<TicketstatusDTO>> GetTicketstatusByStatusAsync(int status, bool trackChanges);
        Task CreateTicketstatusAsync(TicketstatusDTO ticketStatusDTO);
        Task UpdateTicketstatusAsync(TicketstatusDTO ticketStatusDTO);
    }
}
