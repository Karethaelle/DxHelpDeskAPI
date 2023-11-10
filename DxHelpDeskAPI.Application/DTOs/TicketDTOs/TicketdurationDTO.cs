using System;
using System.Collections.Generic;

namespace DxHelpDeskAPI.Application.DTOs;

public partial class TicketdurationDTO
{
    public int TicketId { get; set; }

    public int? TotalHours { get; set; }

    public virtual TicketDTO Ticket { get; set; } = null!;
}
