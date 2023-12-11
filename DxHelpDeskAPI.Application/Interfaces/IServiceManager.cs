using DxHelpDeskAPI.Domain.Interfaces.TicketInterfaces;
using DxHelpDeskAPI.Domain.Interfaces.UserInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DxHelpDeskAPI.Application.Interfaces
{
    public interface IServiceManager
    {
        IAudittrailService AuditTrailService { get; }
        ICompanyService CompanyService { get; }
        IBranchService BranchService { get; }
        ICommonproblemService CommonproblemService { get; }
        ITicketattachmentService TicketattachmentService { get; }
        ITicketcommentService TicketcommentService { get; }
        ITicketdurationService TicketdurationService { get; }
        ITicketpriorityService TicketpriorityService { get; }
        ITicketService TicketService { get; }
        ITicketstatusService TicketstatusService { get; }
        ITickettypeService TickettypeService { get; }
        IUserService UserService { get; }
        IRoleService RoleService { get; }
        IUserroleService UserroleService { get; }

        Task SaveAsync();
        Task BeginTransactionAsync();
        Task RollBackTransactionAsync();
        Task CommitTransactionAsync();
    }
}
