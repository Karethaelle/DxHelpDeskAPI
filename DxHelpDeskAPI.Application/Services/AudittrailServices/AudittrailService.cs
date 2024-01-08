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
    internal sealed class AudittrailService : IAudittrailService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        private readonly ILoggerManager _logger;

        public AudittrailService(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task CreateAudittrailAsync(AudittrailDTO audittrailDto)
        {
            try
            {
                var audittrailEntity = _mapper.Map<Audittrail>(audittrailDto);
                await _repositoryManager.AuditTrailRepository.CreateAudittrailAsync(audittrailEntity);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error in CreateAudittrailAsync: {ex.Message}");
                throw;
            }
        }

        public async Task<IEnumerable<AudittrailDTO>> GetAllAudittrailsAsync(bool trackChanges)
        {
            try
            {
                var audittrails = await _repositoryManager.AuditTrailRepository.GetAllAudittrailsAsync(trackChanges);
                return _mapper.Map<IEnumerable<AudittrailDTO>>(audittrails);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error in GetAllAudittrailsAsync: {ex.Message}");
                throw;
            }
        }

        public async Task<AudittrailDTO> GetAudittrailByIdAsync(int id, bool trackChanges)
        {
            try
            {
                var audittrail = await _repositoryManager.AuditTrailRepository.GetAudittrailByIdAsync(id, trackChanges);
                return _mapper.Map<AudittrailDTO>(audittrail);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error in GetAudittrailByIdAsync: {ex.Message}");
                throw;
            }
        }
        public async Task<IEnumerable<AudittrailDTO>> GetAudittrailByStatusAsync(int status, bool trackChanges)
        {
            try
            {
                var audittrail = await _repositoryManager.AuditTrailRepository.GetAudittrailByIdAsync(status, trackChanges);
                return _mapper.Map<IEnumerable<AudittrailDTO>>(audittrail);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error in GetAudittrailByStatusAsync: {ex.Message}");
                throw;
            }
        }

        public async Task UpdateAudittrailAsync(AudittrailDTO audittrailDto)
        {
            try
            {
                var existingAudittrail = await _repositoryManager.AuditTrailRepository.GetAudittrailByIdAsync(audittrailDto.Id, false);
                if (existingAudittrail == null)
                {
                    // Handle not found scenario
                    // You may throw an exception, return a specific response, etc.
                }

                _mapper.Map(audittrailDto, existingAudittrail);
                await _repositoryManager.AuditTrailRepository.UpdateAudittrailAsync(existingAudittrail);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error in UpdateAudittrailAsync: {ex.Message}");
                throw;
            }
        }
    }
}
