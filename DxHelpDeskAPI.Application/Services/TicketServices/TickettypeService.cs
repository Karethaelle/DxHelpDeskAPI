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
    internal sealed class TickettypeService : ITickettypeService
    {
        public Task CreateTickettypeAsync(TickettypeDTO ticketTypeDTO)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TickettypeDTO>> GetAllTickettypesAsync(bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<TickettypeDTO> GetTickettypeByIdAsync(int id, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TickettypeDTO>> GetTickettypeByStatusAsync(int status, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task UpdateTickettypeAsync(TickettypeDTO ticketTypeDTO)
        {
            throw new NotImplementedException();
        }
    }
}
