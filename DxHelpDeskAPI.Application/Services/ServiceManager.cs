using DxHelpDeskAPI.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DxHelpDeskAPI.Application.Services
{
    public sealed class ServiceManager : IServiceManager
    {
        public IAudittrailService AuditTrailService => throw new NotImplementedException();

        public ICompanyService CompanyService => throw new NotImplementedException();

        public IBranchService BranchService => throw new NotImplementedException();

        public ICommonproblemService CommonproblemService => throw new NotImplementedException();

        public ITicketattachmentService TicketattachmentService => throw new NotImplementedException();

        public ITicketcommentService TicketcommentService => throw new NotImplementedException();

        public ITicketdurationService TicketdurationService => throw new NotImplementedException();

        public ITicketpriorityService TicketpriorityService => throw new NotImplementedException();

        public ITicketService TicketService => throw new NotImplementedException();

        public ITicketstatusService TicketstatusService => throw new NotImplementedException();

        public ITickettypeService TickettypeService => throw new NotImplementedException();

        public IUserService UserService => throw new NotImplementedException();

        public IRoleService RoleService => throw new NotImplementedException();

        public IUserroleService UserroleService => throw new NotImplementedException();

        public Task BeginTransactionAsync()
        {
            throw new NotImplementedException();
        }

        public Task CommitTransactionAsync()
        {
            throw new NotImplementedException();
        }

        public Task RollBackTransactionAsync()
        {
            throw new NotImplementedException();
        }

        public Task SaveAsync()
        {
            throw new NotImplementedException();
        }
    }
}
