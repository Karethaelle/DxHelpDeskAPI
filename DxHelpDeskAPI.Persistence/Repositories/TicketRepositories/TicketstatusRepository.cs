using DxHelpDeskAPI.Domain.Entities.Models;
using DxHelpDeskAPI.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DxHelpDeskAPI.Persistence.Repositories.TicketRepositories
{
    internal sealed class TicketstatusRepository : RepositoryBase<Ticketstatus>, ITicketstatusRepository
    {
        public TicketstatusRepository(DxHelpDeskDBContext context) : base(context)
        {
        }

        public async Task CreateTicketstatusAsync(Ticketstatus ticketStatus) => await CreateAsync(ticketStatus);

        public async Task<IEnumerable<Ticketstatus>> GetTicketstatusByStatusAsync(int status, bool trackChanges) =>
            await GetByConditionAsync(ts => ts.Status.Equals(status), trackChanges);

        public async Task<IEnumerable<Ticketstatus>> GetAllTicketstatusAsync(bool trackChanges) =>
            await GetAllAsync(trackChanges);

        public async Task<Ticketstatus> GetTicketstatusByIdAsync(int id, bool trackChanges) =>
            await GetByIdAsync(id, trackChanges);

        public async Task UpdateTicketstatusAsync(Ticketstatus ticketStatus) =>
            await UpdateAsync(ticketStatus);
    }
}
