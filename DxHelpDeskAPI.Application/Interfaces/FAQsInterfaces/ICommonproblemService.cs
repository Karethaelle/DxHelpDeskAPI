using DxHelpDeskAPI.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DxHelpDeskAPI.Application.Interfaces
{
    public interface ICommonproblemService
    { 
        Task<IEnumerable<CommonproblemDTO>> GetAllCommonproblemsAsync(bool trackChanges);
        Task<CommonproblemDTO> GetCommonproblemByIdAsync(int id, bool trackChanges);
        Task<IEnumerable<CommonproblemDTO>> GetCommonproblemByStatusAsync(int status, bool trackChanges);
        Task CreateCommonproblemAsync(CommonproblemDTO commonProblemDTO);
        Task UpdateCommonproblemAsync(CommonproblemDTO commonProblemDTO);
    }
}
