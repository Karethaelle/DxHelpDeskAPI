using System;
using System.Collections.Generic;

namespace DxHelpDeskAPI.Application.DTOs;

public partial class CompanyDTO
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? Status { get; set; }

    public string? Description { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<BranchDTO> Branches { get; set; } = new List<BranchDTO>();

    public virtual ICollection<UserDTO> Users { get; set; } = new List<UserDTO>();
}
