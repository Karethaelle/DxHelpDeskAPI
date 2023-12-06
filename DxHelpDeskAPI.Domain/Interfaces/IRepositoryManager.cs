using DxHelpDeskAPI.Domain.Interfaces.TicketInterfaces;
using DxHelpDeskAPI.Domain.Interfaces.UserInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DxHelpDeskAPI.Domain.Interfaces
{
    public interface IRepositoryManager
    {
        IAudittrailRepository AuditTrailRepository { get; }
        ICompanyRepository CompanyRepository { get; }
        IBranchRepository BranchRepository { get; }
        ICommonproblemRepository CommonproblemRepository { get; }
        ITicketattachmentRepository TicketattachmentRepository { get; }
        ITicketcommentRepository TicketcommentRepository { get; }
        ITicketdurationRepository TicketdurationRepository { get; }
        ITicketpriorityRepository TicketpriorityRepository { get; }
        ITicketRepository TicketRepository { get; }
        ITicketstatusRepository TicketstatusRepository { get; }
        ITickettypeRepository TickettypeRepository { get; }
        IUserRepository UserRepository { get; }
        IRoleRepository RoleRepository { get; }
        IUserroleRepository UserroleRepository { get; }

        Task SaveAsync();
        Task BeginTransactionAsync();
        Task RollBackTransactionAsync();
        Task CommitTransactionAsync();
    }
}
