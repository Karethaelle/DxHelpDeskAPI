using DxHelpDeskAPI.Application.DTOs;
using DxHelpDeskAPI.Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DxHelpDeskAPI.Application.Interfaces
{
    public interface ICompanyService
    {
        Task<IEnumerable<CompanyDTO>> GetAllCompaniesAsync(bool trackChanges);
        Task<CompanyDTO> GetCompanyByIdAsync(int id, bool trackChanges);
        Task<IEnumerable<CompanyDTO>> GetCompanyByStatusAsync(int status, bool trackChanges);
        Task CreateCompanyAsync(CompanyDTO companyDTO);
        Task UpdateCompanyAsync(CompanyDTO companyDTO);
    }
}
