
using DxHelpDeskAPI.Domain.Interfaces;
using DxHelpDeskAPI.Infrastructure.Exceptions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DxHelpDeskAPI.Infrastructure.Repositories
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
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                // Handle concurrency issues (optimistic concurrency control)
                throw new DatabaseException("A concurrency error occurred while saving data.", ex);
            }
            catch (DbUpdateException ex)
            {
                // Handle known database update issues (e.g., violating constraints)
                if (ex.InnerException != null && ex.InnerException.Message.Contains("Violation of UNIQUE KEY constraint"))
                {
                    throw new DatabaseException("A duplicate record exists.", ex);
                }
                else
                {
                    throw new DatabaseException("An error occurred while updating the database.", ex);
                }
            }
            catch (Exception ex)
            {
                // Handle other unexpected exceptions
                throw new RepositoryException("An unexpected error occurred while saving changes.", ex);
            }
        }

    }
}
