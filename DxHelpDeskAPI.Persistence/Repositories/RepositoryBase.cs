
using DxHelpDeskAPI.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DxHelpDeskAPI.Persistence.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected DxHelpDeskDBContext _context;
        protected DbSet<T> DbSet { get; }

        public RepositoryBase(DxHelpDeskDBContext context)
        {
            _context = context;
            DbSet = _context.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAllAsync(bool trackChanges)
        {
            if (trackChanges)
            {
                return await DbSet.ToListAsync();
            }
            else
            {
                return await DbSet.AsNoTracking().ToListAsync();
            }
        }

        public async Task<T> GetByIdAsync(int id, bool trackChanges)
        {
            if (trackChanges)
            {
                return await DbSet.FindAsync(id);
            }
            else
            {
                return await DbSet.AsNoTracking().FirstOrDefaultAsync();
            }
        }

        public async Task<IEnumerable<T>> GetByConditionAsync(Expression<Func<T, bool>> expression, bool trackChanges)
        {
            if (trackChanges)
            {
                return await DbSet.Where(expression).ToListAsync();
            }
            else
            {
                return await DbSet.Where(expression).AsNoTracking().ToListAsync();
            }
        }

        public async Task CreateAsync(T entity)
        {
            DbSet.Add(entity);
            await SaveAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            DbSet.Update(entity);
            await SaveAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            DbSet.Remove(entity);
            await SaveAsync();
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

    }
}
