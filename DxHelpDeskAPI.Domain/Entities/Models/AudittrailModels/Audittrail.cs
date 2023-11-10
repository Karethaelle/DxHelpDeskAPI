using System;
using System.Collections.Generic;
using DxHelpDeskAPI.ViewModels.UserModels;

namespace DxHelpDeskAPI.ViewModels.AudittrailModels;

public partial class Audittrail
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public string? Action { get; set; }

    public string? Description { get; set; }

    public string? TableAffected { get; set; }

    public int? RecordId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual User? User { get; set; }
}
