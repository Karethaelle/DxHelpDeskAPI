using DxHelpDeskAPI.Domain.Entities.Models;
using DxHelpDeskAPI.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DxHelpDeskAPI.Persistence.Repositories
{
    internal sealed class CommonproblemRepository : RepositoryBase<Commonproblem>, ICommonproblemRepository
    {
        public CommonproblemRepository(DxHelpDeskDBContext context) : base(context)
        {
        }

        public async Task CreateCommonproblemAsync(Commonproblem commonProblem) => 
            await CreateAsync(commonProblem);

        public async Task<IEnumerable<Commonproblem>> GetAllCommonproblemsAsync(bool trackChanges) => 
            await GetAllAsync(trackChanges);

        public async Task<Commonproblem> GetCommonproblemByIdAsync(int id, bool trackChanges) => 
            await GetCommonproblemByIdAsync(id, trackChanges);

        public async Task<IEnumerable<Commonproblem>> GetCommonproblemByStatusAsync(int status, bool trackChanges) =>
            await GetByConditionAsync(cp => cp.Status.Equals(status), trackChanges);

        public async Task UpdateCommonproblemAsync(Commonproblem commonProblem) =>
            await UpdateAsync(commonProblem);
    }
}
