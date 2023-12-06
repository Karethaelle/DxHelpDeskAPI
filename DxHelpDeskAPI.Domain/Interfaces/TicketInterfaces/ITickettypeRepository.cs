using DxHelpDeskAPI.Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DxHelpDeskAPI.Domain.Interfaces.TicketInterfaces
{
    public interface ITickettypeRepository : IRepositoryBase<Tickettype>
    {
        Task<IEnumerable<Tickettype>> GetAllTickettypesAsync(bool trackChanges);
        Task<Tickettype> GetTickettypeByIdAsync(int id, bool trackChanges);
        Task<IEnumerable<Tickettype>> GetTickettypeByStatusAsync(int status, bool trackChanges);
        Task CreateTickettypeAsync(Tickettype ticketType);
        Task UpdateTickettypeAsync(Tickettype ticketType);
    }
}
