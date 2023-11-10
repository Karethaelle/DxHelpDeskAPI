using System;
using System.Collections.Generic;

namespace DxHelpDeskAPI.Application.DTOs;

public partial class UserroleDTO
{
    public int? UserId { get; set; }

    public int? RoleId { get; set; }

    public virtual RoleDTO? Role { get; set; }

    public virtual UserDTO? User { get; set; }
}
