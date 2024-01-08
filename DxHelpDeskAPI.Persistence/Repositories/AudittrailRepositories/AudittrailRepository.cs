using DxHelpDeskAPI.Domain.Entities.Models;
using DxHelpDeskAPI.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace DxHelpDeskAPI.Infrastructure.Repositories
{
    internal sealed class AudittrailRepository : RepositoryBase<Audittrail>, IAudittrailRepository
    {
        public AudittrailRepository(DxHelpDeskDBContext context) : base(context)
        {
        }

        public async Task CreateAudittrailAsync(Audittrail audittrail) =>
            await CreateAsync(audittrail);

        public async Task<IEnumerable<Audittrail>> GetAllAudittrailsAsync(bool trackChanges) =>
            await GetAllAsync(trackChanges);

        public async Task<Audittrail> GetAudittrailByIdAsync(int id, bool trackChanges) =>
            await GetByIdAsync(id, trackChanges);

        public async Task UpdateAudittrailAsync(Audittrail audittrail) =>
            await UpdateAsync(audittrail);

    }
}
