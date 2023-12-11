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

        public Task CreateCommonproblemAsync(Commonproblem commonProblem)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Commonproblem>> GetAllCommonproblemsAsync(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<Commonproblem> GetCommonproblemByIdAsync(int id, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Commonproblem>> GetCommonproblemByStatusAsync(int status, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCommonproblemAsync(Commonproblem commonProblem)
        {
            throw new NotImplementedException();
        }
    }
}
