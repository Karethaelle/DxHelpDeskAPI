using DxHelpDeskAPI.Application.DTOs;
using DxHelpDeskAPI.Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DxHelpDeskAPI.Application.Interfaces
{
    public interface IBranchService
    {
        Task<IEnumerable<BranchDTO>> GetAllBranchesAsync(bool trackChanges);
        Task<BranchDTO> GetBranchByIdAsync(int id, bool trackChanges);
        Task<IEnumerable<BranchDTO>> GetBranchByStatusAsync(int status, bool trackChanges);
        Task CreateBranchAsync(BranchDTO branchDTO);
        Task UpdateBranchAsync(BranchDTO branchDTO);
    }
}
