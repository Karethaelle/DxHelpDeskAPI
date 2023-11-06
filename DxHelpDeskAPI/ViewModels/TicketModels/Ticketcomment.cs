using System;
using System.Collections.Generic;
using DxHelpDeskAPI.ViewModels.UserModels;

namespace DxHelpDeskAPI.ViewModels.TicketModels;

public partial class Ticketcomment
{
    public int Id { get; set; }

    public int? TicketId { get; set; }

    public int? UserId { get; set; }

    public string? Comment { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual Ticket? Ticket { get; set; }

    public virtual User? User { get; set; }
}
