using DxHelpDeskAPI.Application.DTOs;
using DxHelpDeskAPI.Application.Interfaces;
using DxHelpDeskAPI.Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DxHelpDeskAPI.Application.Services
{
    internal sealed class AudittrailService : IAudittrailService
    {
        public Task CreateAudittrailAsync(AudittrailDTO audittrailDTO)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AudittrailDTO>> GetAllAudittrailsAsync(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<AudittrailDTO> GetAudittrailByIdAsync(int id, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AudittrailDTO>> GetAudittrailByStatusAsync(int status, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAudittrailAsync(AudittrailDTO audittrailDTO)
        {
            throw new NotImplementedException();
        }
    }
}
