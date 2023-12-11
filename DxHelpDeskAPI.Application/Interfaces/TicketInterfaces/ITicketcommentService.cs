
using DxHelpDeskAPI.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DxHelpDeskAPI.Application.Interfaces
{
    public interface ITicketcommentService
    {
        Task<IEnumerable<TicketcommentDTO>> GetAllTicketcommentsAsync(bool trackChanges);
        Task<TicketcommentDTO> GetTicketcommentByIdAsync(int id, bool trackChanges);
        Task CreateTicketcommentAsync(TicketcommentDTO ticketCommentDTO);
        Task UpdateTicketcommentAsync(TicketcommentDTO ticketCommentDTO);
    }
}
