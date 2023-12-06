using DxHelpDeskAPI.Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DxHelpDeskAPI.Domain.Interfaces
{
    public interface ITicketpriorityRepository : IRepositoryBase<Ticketpriority>
    {
        Task<IEnumerable<Ticketpriority>> GetAllTicketpriorityAsync(bool trackChanges);
        Task<Ticketpriority> GetTicketpriorityByIdAsync(int id, bool trackChanges);
        Task<IEnumerable<Ticketpriority>> GetTicketpriorityByStatusAsync(int status, bool trackChanges);
        Task CreateTicketpriorityAsync(Ticketpriority ticketPriority);
        Task UpdateTicketpriorityAsync(Ticketpriority ticketPriority);
    }
}
