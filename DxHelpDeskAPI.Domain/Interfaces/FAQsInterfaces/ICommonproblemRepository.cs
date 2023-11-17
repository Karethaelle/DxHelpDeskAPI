using DxHelpDeskAPI.Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DxHelpDeskAPI.Domain.Interfaces
{
    public interface ICommonproblemRepository : IRepositoryBase<Commonproblem>
    {
        Task<IEnumerable<Commonproblem>> GetAllCommonproblemsAsync(bool trackChanges);
        Task<Commonproblem> GetCommonproblemByIdAsync(int id, bool trackChanges);
        Task<IEnumerable<Commonproblem>> FindCommonproblemByStatusAsync(int status, bool trackChanges);
        Task CreateCommonproblemAsync(Commonproblem commonProblem);
        Task UpdateCommonproblemAsync(Commonproblem commonProblem);
    }
}
