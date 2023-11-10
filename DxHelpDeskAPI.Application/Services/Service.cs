using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// DxHelpDeskAPI.Application/Services/Service.cs
using AutoMapper;
using DxHelpDeskAPI.Domain.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using DxHelpDeskAPI.Application.Interfaces;

namespace DxHelpDeskAPI.Application.Services
{
    public class Service<T, TDto> : IService<TDto>
        where T : class
        where TDto : class
    {
        private readonly IRepositoryBase<T> _repository;
        private readonly IMapper _mapper;

        public Service(IRepositoryBase<T> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<TDto>> GetAllAsync()
        {
            var entities = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<TDto>>(entities);
        }

        public async Task<TDto> GetByIdAsync(int id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return _mapper.Map<TDto>(entity);
        }

        public async Task CreateAsync(TDto dto)
        {
            var entity = _mapper.Map<T>(dto);
            await _repository.CreateAsync(entity);
        }

        public async Task UpdateAsync(int id, TDto dto)
        {
            var entity = _mapper.Map<T>(dto);
            await _repository.UpdateAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _repository.GetByIdAsync(id);
            await _repository.DeleteAsync(entity);
        }
    }
}

