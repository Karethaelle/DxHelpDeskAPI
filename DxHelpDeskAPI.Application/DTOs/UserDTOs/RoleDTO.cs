using System;
using System.Collections.Generic;

namespace DxHelpDeskAPI.Application.DTOs;

public partial class RoleDTO
{
    public int Id { get; set; }

    public string? RoleName { get; set; }

    public int? Permissions { get; set; }

    public int? Status { get; set; }

    public string? Description { get; set; }
}
