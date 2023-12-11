using DxHelpDeskAPI.Application.DTOs;
using DxHelpDeskAPI.Application.Interfaces;
using DxHelpDeskAPI.Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DxHelpDeskAPI.Application.Services
{
    internal sealed class BranchService : IBranchService
    {
        public Task CreateBranchAsync(BranchDTO branchDTO)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<BranchDTO>> GetAllBranchesAsync(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<BranchDTO> GetBranchByIdAsync(int id, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<BranchDTO>> GetBranchByStatusAsync(int status, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task UpdateBranchAsync(BranchDTO branchDTO)
        {
            throw new NotImplementedException();
        }
    }
}
