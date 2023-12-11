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
    internal sealed class CommonproblemService : ICommonproblemService
    {
        public Task CreateCommonproblemAsync(CommonproblemDTO commonProblemDTO)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CommonproblemDTO>> GetAllCommonproblemsAsync(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<CommonproblemDTO> GetCommonproblemByIdAsync(int id, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CommonproblemDTO>> GetCommonproblemByStatusAsync(int status, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCommonproblemAsync(CommonproblemDTO commonProblemDTO)
        {
            throw new NotImplementedException();
        }
    }
}
