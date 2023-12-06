using DxHelpDeskAPI.Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DxHelpDeskAPI.Domain.Interfaces
{
    public interface ITicketstatusRepository : IRepositoryBase<Ticketstatus>
    {
        Task<IEnumerable<Ticketstatus>> GetAllTicketstatusAsync(bool trackChanges);
        Task<Ticketstatus> GetTicketstatusByIdAsync(int id, bool trackChanges);
        Task<IEnumerable<Ticketstatus>> GetTicketstatusByStatusAsync(int status, bool trackChanges);
        Task CreateTicketstatusAsync(Ticketstatus ticketStatus);
        Task UpdateTicketstatusAsync(Ticketstatus ticketStatus);
    }
}
