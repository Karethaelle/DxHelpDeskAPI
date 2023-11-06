using System;
using System.Collections.Generic;

namespace DxHelpDeskAPI.ViewModels.UserModels;

public partial class Userrole
{
    public int? UserId { get; set; }

    public int? RoleId { get; set; }

    public virtual Role? Role { get; set; }

    public virtual User? User { get; set; }
}
