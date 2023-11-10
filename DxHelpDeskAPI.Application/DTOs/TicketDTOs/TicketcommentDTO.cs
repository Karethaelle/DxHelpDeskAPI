using System;
using System.Collections.Generic;
using DxHelpDeskAPI.ViewModels.UserModels;

namespace DxHelpDeskAPI.Application.DTOs;

public partial class TicketcommentDTO
{
    public int Id { get; set; }

    public int? TicketId { get; set; }

    public int? UserId { get; set; }

    public string? Comment { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual TicketDTO? Ticket { get; set; }

    public virtual UserDTO? User { get; set; }
}
