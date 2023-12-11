
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DxHelpDeskAPI.Application.DTOs;
using DxHelpDeskAPI.Domain.Entities.Models;

namespace DxHelpDeskAPI.Application.Interfaces
{
    public interface IAudittrailService
    {
        Task<IEnumerable<AudittrailDTO>> GetAllAudittrailsAsync(bool trackChanges);
        Task<AudittrailDTO> GetAudittrailByIdAsync(int id, bool trackChanges);
        Task<IEnumerable<AudittrailDTO>> GetAudittrailByStatusAsync(int status, bool trackChanges);
        Task CreateAudittrailAsync(AudittrailDTO audittrailDTO);
        Task UpdateAudittrailAsync(AudittrailDTO audittrailDTO);
    }
}
