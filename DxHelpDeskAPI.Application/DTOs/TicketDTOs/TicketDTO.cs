using System;
using System.Collections.Generic;
namespace DxHelpDeskAPI.Application.DTOs;

public partial class TicketDTO
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public int? UserId { get; set; }

    public int? AssigneeId { get; set; }

    public int? TypeId { get; set; }

    public int? StatusId { get; set; }

    public int? PriorityId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? CompanyId { get; set; }

    public int? BranchId { get; set; }

    public virtual UserDTO? Assignee { get; set; }

    public virtual TicketpriorityDTO? Priority { get; set; }

    public virtual TicketstatusDTO? Status { get; set; }

    public virtual ICollection<TicketattachmentDTO> Ticketattachments { get; set; } = new List<TicketattachmentDTO>();

    public virtual ICollection<TicketcommentDTO> Ticketcomments { get; set; } = new List<TicketcommentDTO>();

    public virtual TicketdurationDTO? Ticketduration { get; set; }

    public virtual TickettypeDTO? Type { get; set; }

    public virtual UserDTO? User { get; set; }
}
