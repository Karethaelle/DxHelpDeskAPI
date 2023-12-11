
using DxHelpDeskAPI.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DxHelpDeskAPI.Application.Interfaces
{
    public interface ITickettypeService
    {
        Task<IEnumerable<TickettypeDTO>> GetAllTickettypesAsync(bool trackChanges);
        Task<TickettypeDTO> GetTickettypeByIdAsync(int id, bool trackChanges);
        Task<IEnumerable<TickettypeDTO>> GetTickettypeByStatusAsync(int status, bool trackChanges);
        Task CreateTickettypeAsync(TickettypeDTO ticketTypeDTO);
        Task UpdateTickettypeAsync(TickettypeDTO ticketTypeDTO);
    }
}
