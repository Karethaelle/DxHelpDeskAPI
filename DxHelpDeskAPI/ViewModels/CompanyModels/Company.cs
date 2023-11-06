using System;
using System.Collections.Generic;
using DxHelpDeskAPI.ViewModels.UserModels;

namespace DxHelpDeskAPI.ViewModels.CompanyModels;

public partial class Company
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? Status { get; set; }

    public string? Description { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<Branch> Branches { get; set; } = new List<Branch>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
