using DxHelpDeskAPI.Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DxHelpDeskAPI.Domain.Interfaces.TicketInterfaces
{
    public interface ITicketcommentRepository : IRepositoryBase<Ticketcomment>
    {
        Task<IEnumerable<Ticketcomment>> GetAllTicketcommentsAsync(bool trackChanges);
        Task<Ticketcomment> GetTicketcommentByIdAsync(int id, bool trackChanges);
        Task<IEnumerable<Ticketcomment>> FindTicketcommentByStatusAsync(int status, bool trackChanges);
        Task CreateTicketcommentAsync(Ticketcomment ticketComment);
        Task UpdateTicketcommentAsync(Ticketcomment ticketComment);
    }
}
