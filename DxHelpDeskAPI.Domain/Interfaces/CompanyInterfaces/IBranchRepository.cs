using DxHelpDeskAPI.Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DxHelpDeskAPI.Domain.Interfaces
{
    public interface IBranchRepository : IRepositoryBase<Branch>
    {
        Task<IEnumerable<Branch>> GetAllBranchesAsync(bool trackChanges);
        Task<Branch> GetBranchByIdAsync(int id, bool trackChanges);
        Task<IEnumerable<Branch>> FindBranchByStatusAsync(int status, bool trackChanges);
        Task CreateBranchAsync(Branch branch);
        Task UpdateBranchAsync(Branch branch);
    }
}
