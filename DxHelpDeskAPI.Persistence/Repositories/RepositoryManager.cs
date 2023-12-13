using DxHelpDeskAPI.Domain.Exceptions;
using DxHelpDeskAPI.Domain.Interfaces;
using DxHelpDeskAPI.Persistence.Exceptions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
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
        private readonly Lazy<ITicketcommentRepository> _ticketcommentRepository;
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
        public ITicketcommentRepository TicketcommentRepository => _ticketcommentRepository.Value;
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
            _audittrailRepository = new Lazy<IAudittrailRepository>(() => new AudittrailRepository(repositoryContext));
            _companyRepository = new Lazy<ICompanyRepository>(() => new CompanyRepository(repositoryContext));
            _branchRepository = new Lazy<IBranchRepository>(() => new BranchRepository(repositoryContext));
            _commonproblemRepository = new Lazy<ICommonproblemRepository>(() => new CommonproblemRepository(repositoryContext));
            _ticketattachmentRepository = new Lazy<ITicketattachmentRepository>(() => new TicketattachmentRepository(repositoryContext));
            _ticketcommentRepository = new Lazy<ITicketcommentRepository>(() => new TicketcommentRepository(repositoryContext));
            _ticketdurationRepository = new Lazy<ITicketdurationRepository>(() => new TicketdurationRepository(repositoryContext));
            _ticketpriorityRepository = new Lazy<ITicketpriorityRepository>(() => new TicketpriorityRepository(repositoryContext));
            _ticketRepository = new Lazy<ITicketRepository>(() => new TicketRepository(repositoryContext));
            _ticketstatusRepository = new Lazy<ITicketstatusRepository>(() => new TicketstatusRepository(repositoryContext));
            _tickettypeRepository = new Lazy<ITickettypeRepository>(() => new TickettypeRepository(repositoryContext));
            _userRepository = new Lazy<IUserRepository>(() => new UserRepository(repositoryContext));
            _roleRepository = new Lazy<IRoleRepository>(() => new RoleRepository(repositoryContext));
            _userroleRepository = new Lazy<IUserroleRepository>(() => new UserroleRepository(repositoryContext));
            //_tickettypeRepository = new Lazy<IAudittrailRepository>(() => new AudittrailRepository(repositoryContext));
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
            catch (DbUpdateConcurrencyException ex)
            {
                // Handle concurrency exceptions
                throw new DatabaseException("A concurrency error occurred while saving data.", ex);
            }
            catch (DbUpdateException ex)
            {
                if (ex.InnerException != null && ex.InnerException.Message.Contains("Duplicate entry"))
                {
                    // Handle duplicate entry scenarios
                    throw new RepositoryException("Duplicate entry found.", ex);
                }
                else
                {
                    // Handle other database update exceptions
                    throw new RepositoryException("An error occurred while updating the database.", ex);
                }
            }
            catch (Exception ex)
            {
                // Handle other exceptions that are not specific to database operations
                throw new RepositoryException("An unexpected error occurred while saving changes.", ex);
            }
        }
    }
}
