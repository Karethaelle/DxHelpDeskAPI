using System;
using System.Collections.Generic;

namespace DxHelpDeskAPI.Application.DTOs;

public partial class TicketattachmentDTO
{
    public int Id { get; set; }

    public int? TicketId { get; set; }

    public string? FileName { get; set; }

    public byte[]? FileData { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual TicketDTO? Ticket { get; set; }
}
