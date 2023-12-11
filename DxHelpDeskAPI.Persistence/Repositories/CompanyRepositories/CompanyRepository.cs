using DxHelpDeskAPI.Domain.Entities.Models;
using DxHelpDeskAPI.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DxHelpDeskAPI.Persistence.Repositories
{
    internal sealed class CompanyRepository : RepositoryBase<Company>, ICompanyRepository
    {
        public CompanyRepository(DxHelpDeskDBContext context) : base(context)
        {
        }

        public async Task CreateCompanyAsync(Company company) =>
            await CreateAsync(company);

        public async Task<IEnumerable<Company>> GetCompanyByStatusAsync(int status, bool trackChanges) =>
            await GetByConditionAsync(c => c.Status.Equals(status) , trackChanges);

        public async Task<IEnumerable<Company>> GetAllCompaniesAsync(bool trackChanges) =>
            await GetAllAsync(trackChanges);

        public async Task<Company> GetCompanyByIdAsync(int id, bool trackChanges) =>
            await GetByIdAsync(id, trackChanges);

        public async Task UpdateCompanyAsync(Company company) =>
            await UpdateAsync(company);
    }
}
