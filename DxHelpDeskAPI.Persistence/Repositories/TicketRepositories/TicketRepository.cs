using DxHelpDeskAPI.Domain.Entities.Models;
using DxHelpDeskAPI.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DxHelpDeskAPI.Persistence.Repositories
{
    internal sealed class TicketRepository : RepositoryBase<Ticket>, ITicketRepository
    {
        public TicketRepository(DxHelpDeskDBContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Ticket>> GetAllTicketsAsync(bool trackChanges) =>
            await GetAllAsync(trackChanges);

        public async Task<Ticket> GetTicketByIdAsync(int id, bool trackChanges) =>
            await GetTicketByIdAsync(id, trackChanges);

        public async Task<IEnumerable<Ticket>> GetTicketsByStatusAsync(int status, bool trackChanges) => 
            await GetByConditionAsync(t => t.StatusId.Equals(status),trackChanges);

        public async Task CreateTicketAsync(Ticket ticket) => await CreateAsync(ticket);

        public async Task UpdateTicketAsync(Ticket ticket) => await UpdateAsync(ticket);
    }
}
