using AutoMapper;
using DxHelpDeskAPI.Application.Interfaces;
using DxHelpDeskAPI.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DxHelpDeskAPI.Application.Services
{
    public sealed class ServiceManager : IServiceManager
    {

        private readonly Lazy<IAudittrailService> _audittrailService;
        private readonly Lazy<ICompanyService> _companyService;
        private readonly Lazy<IBranchService> _branchService;
        private readonly Lazy<ICommonproblemService> _commonproblemService;
        private readonly Lazy<ITicketattachmentService> _ticketattachmentService;
        private readonly Lazy<ITicketcommentService> _ticketcommentService;
        private readonly Lazy<ITicketdurationService> _ticketdurationService;
        private readonly Lazy<ITicketpriorityService> _ticketpriorityService;
        private readonly Lazy<ITicketService> _ticketService;
        private readonly Lazy<ITicketstatusService> _ticketstatusService;
        private readonly Lazy<ITickettypeService> _tickettypeService;
        private readonly Lazy<IUserService> _userService;
        private readonly Lazy<IRoleService> _roleService;
        private readonly Lazy<IUserroleService> _userroleService;

        public IAudittrailService AuditTrailService => _audittrailService.Value;
        public ICompanyService CompanyService => _companyService.Value;
        public IBranchService BranchService => _branchService.Value;
        public ICommonproblemService CommonproblemService => _commonproblemService.Value;
        public ITicketattachmentService TicketattachmentService => _ticketattachmentService.Value;
        public ITicketcommentService TicketcommentService => _ticketcommentService.Value;
        public ITicketdurationService TicketdurationService => _ticketdurationService.Value;
        public ITicketpriorityService TicketpriorityService => _ticketpriorityService.Value;
        public ITicketService TicketService => _ticketService.Value;
        public ITicketstatusService TicketstatusService => _ticketstatusService.Value;
        public ITickettypeService TickettypeService => _tickettypeService.Value;
        public IUserService UserService => _userService.Value;
        public IRoleService RoleService => _roleService.Value;
        public IUserroleService UserroleService => _userroleService.Value;

        public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
        {
            _audittrailService = new Lazy<IAudittrailService>(() => new AudittrailService(repositoryManager, logger, mapper));
            _companyService = new Lazy<ICompanyService>(() => new CompanyService(repositoryManager, logger, mapper));
            _branchService = new Lazy<IBranchService>(() => new BranchService(repositoryManager, logger, mapper));
            _commonproblemService = new Lazy<ICommonproblemService>(() => new CommonproblemService(repositoryManager, logger, mapper));
            _ticketattachmentService = new Lazy<ITicketattachmentService>(() => new TicketattachmentService(repositoryManager, logger, mapper));
            _ticketcommentService = new Lazy<ITicketcommentService>(() => new TicketcommentService(repositoryManager, logger, mapper));
            _ticketdurationService = new Lazy<ITicketdurationService>(() => new TicketdurationService(repositoryManager, logger, mapper));
            _ticketpriorityService = new Lazy<ITicketpriorityService>(() => new TicketpriorityService(repositoryManager, logger, mapper));
            _ticketService = new Lazy<ITicketService>(() => new TicketService(repositoryManager, logger, mapper));
            _ticketstatusService = new Lazy<ITicketstatusService>(() => new TicketstatusService(repositoryManager, logger, mapper));
            _tickettypeService = new Lazy<ITickettypeService>(() => new TickettypeService(repositoryManager, logger, mapper));
            _userService = new Lazy<IUserService>(() => new UserService(repositoryManager, logger, mapper));
            _roleService = new Lazy<IRoleService>(() => new RoleService(repositoryManager, logger, mapper));
            _userroleService = new Lazy<IUserroleService>(() => new UserroleService(repositoryManager, logger, mapper));
        }
    }
}
