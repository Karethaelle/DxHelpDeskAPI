using DxHelpDeskAPI.Domain.Entities.Models;
using DxHelpDeskAPI.Domain.Interfaces.TicketInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DxHelpDeskAPI.Persistence.Repositories.TicketRepositories
{
    internal sealed class TickettypeRepository : RepositoryBase<Tickettype>, ITickettypeRepository
    {
        public TickettypeRepository(DxHelpDeskDBContext context) : base(context)
        {
        }

        public async Task CreateTickettypeAsync(Tickettype ticketType) =>
            await CreateAsync(ticketType);

        public async Task<IEnumerable<Tickettype>> GetTickettypeByStatusAsync(int status, bool trackChanges) =>
            await GetByConditionAsync(tt => tt.Status.Equals(status), trackChanges);

        public async Task<IEnumerable<Tickettype>> GetAllTickettypesAsync(bool trackChanges) =>
            await GetAllAsync(trackChanges);

        public async Task<Tickettype> GetTickettypeByIdAsync(int id, bool trackChanges) =>
            await GetByIdAsync(id, trackChanges);

        public async Task UpdateTickettypeAsync(Tickettype ticketType) =>
            await UpdateAsync(ticketType);
    }
}
