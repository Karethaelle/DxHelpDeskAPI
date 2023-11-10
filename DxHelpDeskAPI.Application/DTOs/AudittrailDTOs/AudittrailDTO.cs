using System;
using System.Collections.Generic;

namespace DxHelpDeskAPI.Application.DTOs;

public partial class AudittrailDTO
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public string? Action { get; set; }

    public string? Description { get; set; }

    public string? TableAffected { get; set; }

    public int? RecordId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual UserDTO? User { get; set; }
}
