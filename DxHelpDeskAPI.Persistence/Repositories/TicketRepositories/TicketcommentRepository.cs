using DxHelpDeskAPI.Domain.Entities.Models;
using DxHelpDeskAPI.Domain.Interfaces;
using DxHelpDeskAPI.Domain.Interfaces.TicketInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DxHelpDeskAPI.Persistence.Repositories.TicketRepositories
{
    internal sealed class TicketcommentRepository : RepositoryBase<Ticketcomment>, ITicketcommentRepository
    {
        public TicketcommentRepository(DxHelpDeskDBContext context) : base(context)
        {
        }

        public async Task CreateTicketcommentAsync(Ticketcomment ticketComment) =>
            await CreateAsync(ticketComment);
        public async Task<IEnumerable<Ticketcomment>> GetAllTicketcommentsAsync(bool trackChanges) =>
            await GetAllAsync(trackChanges);

        public async Task<Ticketcomment> GetTicketcommentByIdAsync(int id, bool trackChanges) =>
            await GetByIdAsync(id, trackChanges);

        public async Task UpdateTicketcommentAsync(Ticketcomment ticketComment) =>
            await UpdateAsync(ticketComment);
    }
}
