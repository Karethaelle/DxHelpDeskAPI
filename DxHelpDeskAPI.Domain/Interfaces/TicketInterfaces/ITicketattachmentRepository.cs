using DxHelpDeskAPI.Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DxHelpDeskAPI.Domain.Interfaces
{
    public interface ITicketattachmentRepository : IRepositoryBase<Ticketattachment>
    {
        Task<IEnumerable<Ticketattachment>> GetAllTicketattachmentsAsync(bool trackChanges);
        Task<Ticketattachment> GetTicketattachmentByIdAsync(int id, bool trackChanges);
        Task<IEnumerable<Ticketattachment>> FindTicketattachmentByStatusAsync(int status, bool trackChanges);
        Task CreateTicketattachmentAsync(Ticketattachment ticketAttachment);
        Task UpdateTicketattachmentAsync(Ticketattachment ticketAttachment);
    }
}
