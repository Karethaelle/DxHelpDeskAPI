using DxHelpDeskAPI.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DxHelpDeskAPI.Application.Interfaces
{
    public interface ITicketdurationService
    {
        Task<IEnumerable<TicketdurationDTO>> GetAllTicketdurationDTOAsync(bool trackChanges);
        Task<TicketdurationDTO> GetTicketdurationDTOByIdAsync(int id, bool trackChanges);
        Task CreateTicketdurationDTOAsync(TicketdurationDTO ticketdurationDTO);
        Task UpdateTicketdurationDTOAsync(TicketdurationDTO ticketdurationDTO);
    }
}
