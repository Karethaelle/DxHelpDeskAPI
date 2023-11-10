using System;
using System.Collections.Generic;

namespace DxHelpDeskAPI.Application.DTOs;

public partial class TickettypeDTO
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? Status { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<TicketDTO> Tickets { get; set; } = new List<TicketDTO>();
}
