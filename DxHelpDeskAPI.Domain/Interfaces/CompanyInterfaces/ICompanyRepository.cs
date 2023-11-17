using DxHelpDeskAPI.Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DxHelpDeskAPI.Domain.Interfaces
{
    public interface ICompanyRepository : IRepositoryBase<Company>
    {
        Task<IEnumerable<Company>> GetAllCompaniesAsync(bool trackChanges);
        Task<Company> GetCompanyByIdAsync(int id, bool trackChanges);
        Task<IEnumerable<Company>> FindCompanyByStatusAsync(int status, bool trackChanges);
        Task CreateCompanyAsync(Company company);
        Task UpdateCompanyAsync(Company company);
    }
}
