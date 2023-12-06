using DxHelpDeskAPI.Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DxHelpDeskAPI.Domain.Interfaces
{
    public interface IAudittrailRepository : IRepositoryBase<Audittrail>
    {
        Task<IEnumerable<Audittrail>> GetAllAudittrailsAsync(bool trackChanges);
        Task<Audittrail> GetAudittrailByIdAsync(int id, bool trackChanges);
        Task<IEnumerable<Audittrail>> GetAudittrailByStatusAsync(int status, bool trackChanges);
        Task CreateAudittrailAsync(Audittrail audittrail);
        Task UpdateAudittrailAsync(Audittrail audittrail);
    }
}
