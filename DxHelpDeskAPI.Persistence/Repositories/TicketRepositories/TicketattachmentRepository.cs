using DxHelpDeskAPI.Domain.Entities.Models;
using DxHelpDeskAPI.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DxHelpDeskAPI.Persistence.Repositories.TicketRepositories
{
    internal sealed class TicketattachmentRepository : RepositoryBase<Ticketattachment>, ITicketattachmentRepository
    {
        public TicketattachmentRepository(DxHelpDeskDBContext context) : base(context)
        {
        }

        public async Task CreateTicketattachmentAsync(Ticketattachment ticketAttachment) =>
            await CreateAsync(ticketAttachment);

        public async Task<IEnumerable<Ticketattachment>> GetAllTicketattachmentsAsync(bool trackChanges) =>
            await GetAllAsync(trackChanges);

        public async Task<Ticketattachment> GetTicketattachmentByIdAsync(int id, bool trackChanges) =>
            await GetByIdAsync(id, trackChanges);

        public async Task UpdateTicketattachmentAsync(Ticketattachment ticketAttachment) =>
            await UpdateAsync(ticketAttachment);
    }
}
