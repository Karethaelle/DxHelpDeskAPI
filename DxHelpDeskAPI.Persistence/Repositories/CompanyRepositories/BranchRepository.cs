using DxHelpDeskAPI.Domain.Entities.Models;
using DxHelpDeskAPI.Domain.Interfaces;
using DxHelpDeskAPI.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DxHelpDeskAPI.Infrastructure.Repositories
{
    internal sealed class BranchRepository : RepositoryBase<Branch>, IBranchRepository
    {
        public BranchRepository(DxHelpDeskDBContext context) : base(context)
        {
        }

        public async Task CreateBranchAsync(Branch branch) =>
            await CreateAsync(branch);

        public async Task<IEnumerable<Branch>> GetBranchByStatusAsync(int status, bool trackChanges) =>
            await GetByConditionAsync(b => b.Status.Equals(status), trackChanges);

        public async Task<IEnumerable<Branch>> GetAllBranchesAsync(bool trackChanges) =>
            await GetAllAsync(trackChanges);

        public async Task<Branch> GetBranchByIdAsync(int id, bool trackChanges) =>
            await GetBranchByIdAsync(id, trackChanges);
        public async Task UpdateBranchAsync(Branch branch) =>
            await UpdateAsync(branch);
    }
}
