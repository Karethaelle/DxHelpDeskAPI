using DxHelpDeskAPI.Domain.Entities.Models;
using DxHelpDeskAPI.Domain.Interfaces;
using DxHelpDeskAPI.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DxHelpDeskAPI.Persistence.Repositories
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

        public Task<IEnumerable<Branch>> GetAllBranchesAsync(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<Branch> GetBranchByIdAsync(int id, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task UpdateBranchAsync(Branch branch)
        {
            throw new NotImplementedException();
        }
    }
}
