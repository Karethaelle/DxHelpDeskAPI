using DxHelpDeskAPI.Domain.Entities.Models;
using DxHelpDeskAPI.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DxHelpDeskAPI.Persistence.Repositories
{
    internal sealed class TicketdurationRepository : RepositoryBase<Ticketduration>, ITicketdurationRepository
    {
        public TicketdurationRepository(DxHelpDeskDBContext context) : base(context)
        {
        }

        public async Task CreateTicketdurationAsync(Ticketduration ticketDuration) =>
            await CreateAsync(ticketDuration);

        public async Task<IEnumerable<Ticketduration>> GetAllTicketdurationAsync(bool trackChanges) =>
            await GetAllAsync(trackChanges);

        public async Task<Ticketduration> GetTicketdurationByIdAsync(int id, bool trackChanges) =>
            await GetByIdAsync(id, trackChanges);

        public async Task UpdateTicketdurationAsync(Ticketduration ticketDuration) =>
            await UpdateAsync(ticketDuration);
    }
}
