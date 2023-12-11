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
    internal sealed class CompanyService : ICompanyService
    {
        public Task CreateCompanyAsync(CompanyDTO companyDTO)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CompanyDTO>> GetAllCompaniesAsync(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<CompanyDTO> GetCompanyByIdAsync(int id, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CompanyDTO>> GetCompanyByStatusAsync(int status, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCompanyAsync(CompanyDTO companyDTO)
        {
            throw new NotImplementedException();
        }
    }
}
