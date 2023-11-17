using DxHelpDeskAPI.Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DxHelpDeskAPI.Domain.Interfaces
{
    public interface ITicketRepository : IRepositoryBase<Ticket>
    {
        Task<IEnumerable<Ticket>> GetAllTicketsAsync(bool trackChanges);
        Task<Ticket> GetTicketByIdAsync(int id, bool trackChanges);
        Task<IEnumerable<Ticket>> GetTicketsByStatusAsync(int status, bool trackChanges);
        Task CreateTicketAsync(Ticket ticket);
        Task UpdateTicketAsync(Ticket ticket);

    }
}
