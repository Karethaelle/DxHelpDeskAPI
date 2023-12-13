using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DxHelpDeskAPI.Domain.Entities.Models;
// DxHelpDeskAPI.Application/Mappings/MappingProfile.cs
using AutoMapper;
using DxHelpDeskAPI.Domain.Entities;
using DxHelpDeskAPI.Application.DTOs;
using System.Reflection;
using DxHelpDeskAPI.Application.Mappings.Extensions;

namespace DxHelpDeskAPI.Application.Mappings.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Audittrail, AudittrailDTO>().IgnoreAllVirtual();
            CreateMap<AudittrailDTO, Audittrail>().IgnoreAllVirtual();

            CreateMap<Branch, BranchDTO>().IgnoreAllVirtual();
            CreateMap<BranchDTO, Branch>().IgnoreAllVirtual();

            CreateMap<Company, AudittrailDTO>().IgnoreAllVirtual();
            CreateMap<Audittrail, Company>().IgnoreAllVirtual();

            CreateMap<Commonproblem, AudittrailDTO>().IgnoreAllVirtual();
            CreateMap<Audittrail, Commonproblem>().IgnoreAllVirtual();

            CreateMap<Ticket, TicketDTO>().IgnoreAllVirtual();
            CreateMap<TicketDTO, Ticket>().IgnoreAllVirtual();

            CreateMap<Ticketattachment, TicketattachmentDTO>().IgnoreAllVirtual();
            CreateMap<TicketattachmentDTO, Ticketattachment>().IgnoreAllVirtual();

            CreateMap<Ticketcomment, TicketcommentDTO>().IgnoreAllVirtual();
            CreateMap<TicketcommentDTO, Ticketcomment>().IgnoreAllVirtual();

            CreateMap<Ticketduration, TicketdurationDTO>().IgnoreAllVirtual();
            CreateMap<TicketdurationDTO, Ticketduration>().IgnoreAllVirtual();

            CreateMap<Ticketpriority, TicketpriorityDTO>().IgnoreAllVirtual();
            CreateMap<TicketpriorityDTO, Ticketpriority>().IgnoreAllVirtual();

            CreateMap<Ticketstatus, TicketstatusDTO>().IgnoreAllVirtual();
            CreateMap<TicketstatusDTO, Ticketstatus>().IgnoreAllVirtual();

            CreateMap<Tickettype, TickettypeDTO>().IgnoreAllVirtual();
            CreateMap<TickettypeDTO, Tickettype>().IgnoreAllVirtual();

            CreateMap<User, UserDTO>().IgnoreAllVirtual();
            CreateMap<UserDTO, User>().IgnoreAllVirtual();

            CreateMap<Role, RoleDTO>().IgnoreAllVirtual();
            CreateMap<RoleDTO, Role>().IgnoreAllVirtual();

            CreateMap<Userrole, UserroleDTO>().IgnoreAllVirtual();
            CreateMap<UserroleDTO, Userrole>().IgnoreAllVirtual();

        }
    }
}
