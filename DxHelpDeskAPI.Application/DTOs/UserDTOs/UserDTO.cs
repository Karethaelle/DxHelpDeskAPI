using System;
using System.Collections.Generic;

namespace DxHelpDeskAPI.Application.DTOs;

public partial class UserDTO
{
    public int Id { get; set; }

    public string? Username { get; set; }

    public string? PasswordHash { get; set; }

    public string? Email { get; set; }

    public int? Status { get; set; }

    public string? Description { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<AudittrailDTO> Audittrails { get; set; } = new List<AudittrailDTO>();

    public virtual ICollection<TicketDTO> TicketAssignees { get; set; } = new List<TicketDTO>();

    public virtual ICollection<TicketDTO> TicketUsers { get; set; } = new List<TicketDTO>();

    public virtual ICollection<TicketcommentDTO> Ticketcomments { get; set; } = new List<TicketcommentDTO>();

    public virtual ICollection<BranchDTO> Branches { get; set; } = new List<BranchDTO>();

    public virtual ICollection<CompanyDTO> Companies { get; set; } = new List<CompanyDTO>();
}
