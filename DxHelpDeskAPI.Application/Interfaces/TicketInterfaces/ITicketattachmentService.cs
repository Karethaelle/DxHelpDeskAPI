using DxHelpDeskAPI.Application.DTOs;
using DxHelpDeskAPI.Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DxHelpDeskAPI.Application.Interfaces
{
    public interface ITicketattachmentService
    {
        Task<IEnumerable<TicketattachmentDTO>> GetAllTicketattachmentDTOsAsync(bool trackChanges);
        Task<TicketattachmentDTO> GetTicketattachmentDTOByIdAsync(int id, bool trackChanges);
        Task CreateTicketattachmentDTOAsync(TicketattachmentDTO ticketattachmentDTO);
        Task UpdateTicketattachmentDTOAsync(TicketattachmentDTO ticketattachmentDTO);
    }
}
