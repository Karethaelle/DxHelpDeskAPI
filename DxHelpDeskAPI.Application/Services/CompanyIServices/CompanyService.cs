using AutoMapper;
using DxHelpDeskAPI.Application.DTOs;
using DxHelpDeskAPI.Application.Interfaces;
using DxHelpDeskAPI.Domain.Entities.Models;
using DxHelpDeskAPI.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DxHelpDeskAPI.Application.Services
{
    internal sealed class CompanyService : ICompanyService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        private readonly ILoggerManager _logger;

        public CompanyService(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
            _logger = logger;
        }
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
