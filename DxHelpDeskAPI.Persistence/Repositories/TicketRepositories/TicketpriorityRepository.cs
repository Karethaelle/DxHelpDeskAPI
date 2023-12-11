using DxHelpDeskAPI.Domain.Entities.Models;
using DxHelpDeskAPI.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DxHelpDeskAPI.Persistence.Repositories
{
    internal sealed class TicketpriorityRepository : RepositoryBase<Ticketpriority>, ITicketpriorityRepository
    {
        public TicketpriorityRepository(DxHelpDeskDBContext context) : base(context)
        {
        }

        public async Task CreateTicketpriorityAsync(Ticketpriority ticketPriority) =>
            await CreateAsync(ticketPriority);

        public async Task<IEnumerable<Ticketpriority>> GetTicketpriorityByStatusAsync(int status, bool trackChanges) =>
            await GetByConditionAsync(tp => tp.Status.Equals(status) , trackChanges);

        public async Task<IEnumerable<Ticketpriority>> GetAllTicketpriorityAsync(bool trackChanges) =>
            await GetAllAsync(trackChanges);

        public async Task<Ticketpriority> GetTicketpriorityByIdAsync(int id, bool trackChanges) =>
            await GetByIdAsync(id, trackChanges);

        public async Task UpdateTicketpriorityAsync(Ticketpriority ticketPriority) =>
            await UpdateAsync(ticketPriority);
    }
}
