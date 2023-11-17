using DxHelpDeskAPI.Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DxHelpDeskAPI.Domain.Interfaces
{
    public interface ITicketdurationRepository : IRepositoryBase<Ticketduration>
    {
        Task<IEnumerable<Ticketduration>> GetAllTicketdurationAsync(bool trackChanges);
        Task<Ticketduration> GetTicketdurationByIdAsync(int id, bool trackChanges);
        Task<IEnumerable<Ticketduration>> FindTicketdurationByStatusAsync(int status, bool trackChanges);
        Task CreateTicketdurationAsync(Ticketduration ticketDuration);
        Task UpdateTicketdurationAsync(Ticketduration ticketDuration);
    }
}
