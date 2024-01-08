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
    internal sealed class BranchService : IBranchService
    {
        //private readonly IBranchRepository _branchRepository;
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        private readonly ILoggerManager _logger;

        public BranchService(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task CreateBranchAsync(BranchDTO branchDTO)
        {
            try
            {
                var newBranch = _mapper.Map<Branch>(branchDTO);
                await _repositoryManager.BranchRepository.CreateBranchAsync(newBranch);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error in CreateBranchAsync: {ex.Message}");
                throw;
            }
        }

        public async Task<IEnumerable<BranchDTO>> GetAllBranchesAsync(bool trackChanges)
        {
            try
            {
                var branches = await _repositoryManager.BranchRepository.GetAllBranchesAsync(trackChanges);
                return _mapper.Map<IEnumerable<BranchDTO>>(branches);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error in GetAllBranchesAsync: {ex.Message}");
                throw;
            }
        }

        public async Task<BranchDTO> GetBranchByIdAsync(int id, bool trackChanges)
        {
            try
            {
                var audittrail = await _repositoryManager.BranchRepository.GetBranchByIdAsync(id, trackChanges);
                return _mapper.Map<BranchDTO>(audittrail);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error in GetBranchByIdAsync: {ex.Message}");
                throw;
            }
        }

        public async Task<IEnumerable<BranchDTO>> GetBranchByStatusAsync(int status, bool trackChanges)
        {
            try
            {
                var branch = await _repositoryManager.BranchRepository.GetBranchByStatusAsync(status, trackChanges);
                return _mapper.Map<IEnumerable<BranchDTO>>(branch);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error in GetBranchByStatusAsync: {ex.Message}");
                throw;
            }
        }

        public async Task UpdateBranchAsync(BranchDTO branchDTO)
        {
            try
            {
                var existingBranch = await _repositoryManager.BranchRepository.GetBranchByIdAsync(branchDTO.Id, false);
                if (existingBranch == null)
                {
                    // Handle not found scenario
                    // You may throw an exception, return a specific response, etc.
                }

                _mapper.Map(branchDTO, existingBranch);
                await _repositoryManager.BranchRepository.UpdateBranchAsync(existingBranch);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error in UpdateBranchAsync: {ex.Message}");
                throw;
            }
        }
    }
}
