using DxHelpDeskAPI.Application.Interfaces;
using DxHelpDeskAPI.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// DxHelpDeskAPI.Application/Interfaces/IService.cs
namespace DxHelpDeskAPI.Application.Interfaces
{
    public interface IService<TDto> where TDto : class
    {
        Task<IEnumerable<TDto>> GetAllAsync();
        Task<TDto> GetByIdAsync(int id);
        Task CreateAsync(TDto dto);
        Task UpdateAsync(int id, TDto dto);
        Task DeleteAsync(int id);
    }
}
