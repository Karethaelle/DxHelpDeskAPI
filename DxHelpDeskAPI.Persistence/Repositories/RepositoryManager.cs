using DxHelpDeskAPI.Domain.Interfaces;
using DxHelpDeskAPI.Domain.Interfaces.TicketInterfaces;
using DxHelpDeskAPI.Domain.Interfaces.UserInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DxHelpDeskAPI.Persistence.Repositories
{
    public sealed class RepositoryManager : IRepositoryManager
    {
        private readonly DxHelpDeskDBContext _repositoryContext;

        private readonly Lazy<IAudittrailRepository> _audittrailRepository;
        private readonly Lazy<ICompanyRepository> _companyRepository;
        private readonly Lazy<IBranchRepository> _branchRepository;
        private readonly Lazy<ICommonproblemRepository> _commonproblemRepository;
        private readonly Lazy<ITicketattachmentRepository> _ticketattachmentRepository;
        private readonly Lazy<ITicketcommentRepository> _icketcommentRepository;
        private readonly Lazy<ITicketdurationRepository> _ticketdurationRepository;
        private readonly Lazy<ITicketpriorityRepository> _ticketpriorityRepository;
        private readonly Lazy<ITicketRepository> _ticketRepository;
        private readonly Lazy<ITicketstatusRepository> _ticketstatusRepository;
        private readonly Lazy<ITickettypeRepository> _tickettypeRepository;
        private readonly Lazy<IUserRepository> _userRepository;
        private readonly Lazy<IRoleRepository> _roleRepository;
        private readonly Lazy<IUserroleRepository> _userroleRepository;

        public IAudittrailRepository AuditTrailRepository => _audittrailRepository.Value;
        public ICompanyRepository CompanyRepository => _companyRepository.Value;
        public IBranchRepository BranchRepository => _branchRepository.Value;
        public ICommonproblemRepository CommonproblemRepository => _commonproblemRepository.Value;
        public ITicketattachmentRepository TicketattachmentRepository => _ticketattachmentRepository.Value;
        public ITicketcommentRepository TicketcommentRepository => _icketcommentRepository.Value;
        public ITicketdurationRepository TicketdurationRepository => _ticketdurationRepository.Value;
        public ITicketpriorityRepository TicketpriorityRepository => _ticketpriorityRepository.Value;
        public ITicketRepository TicketRepository => _ticketRepository.Value;
        public ITicketstatusRepository TicketstatusRepository => _ticketstatusRepository.Value;
        public ITickettypeRepository TickettypeRepository => _tickettypeRepository.Value;
        public IUserRepository UserRepository => _userRepository.Value;
        public IRoleRepository RoleRepository => _roleRepository.Value;
        public IUserroleRepository UserroleRepository => _userroleRepository.Value;

        public RepositoryManager(DxHelpDeskDBContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }
        public async Task BeginTransactionAsync() => await _repositoryContext.Database.BeginTransactionAsync();
        public async Task RollBackTransactionAsync() => await _repositoryContext.Database.RollbackTransactionAsync();
        public async Task CommitTransactionAsync() => await _repositoryContext.Database.CommitTransactionAsync();
        public async Task SaveAsync()
        {
            try
            {
                await _repositoryContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null && ex.InnerException.Message != "")
                {
                    if (ex.InnerException.Message.Contains("Duplicate entry"))
                        throw new CustomExceptionConflict(ex.InnerException.Message);
                    else
                        throw new CustomExceptionBadRequest(ex.InnerException.Message);
                }
                else
                {
                    throw new CustomExceptionBadRequest(ex.Message);
                }
            }
        }
    }
}
