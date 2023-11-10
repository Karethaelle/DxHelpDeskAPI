using System;
using System.Collections.Generic;

namespace DxHelpDeskAPI.ViewModels.UserModels;

public partial class Role
{
    public int Id { get; set; }

    public string? RoleName { get; set; }

    public int? Permissions { get; set; }

    public int? Status { get; set; }

    public string? Description { get; set; }
}
