using DxHelpDeskAPI.Domain.Entities.Models;
using DxHelpDeskAPI.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DxHelpDeskAPI.Persistence.Repositories
{
    internal sealed class AudittrailRepository : RepositoryBase<Audittrail>, IAudittrailRepository
    {
        public AudittrailRepository(DxHelpDeskDBContext context) : base(context)
        {
        }

        public Task CreateAudittrailAsync(Audittrail audittrail)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Audittrail>> FindAudittrailByStatusAsync(int status, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Audittrail>> GetAllAudittrailsAsync(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<Audittrail> GetAudittrailByIdAsync(int id, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAudittrailAsync(Audittrail audittrail)
        {
            throw new NotImplementedException();
        }

    }
}
