using System;
using System.Collections.Generic;

namespace DxHelpDeskAPI.Application.DTOs;

public partial class TicketstatusDTO
{
    public int Id { get; set; }

    public string? StatusName { get; set; }

    public int? Status { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<TicketDTO> Tickets { get; set; } = new List<TicketDTO>();
}
