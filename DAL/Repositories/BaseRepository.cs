using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace DAL.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private RebusContext _dbContext;

        public BaseRepository(RebusContext context)
        {
            _dbContext = context;
        }

        public async Task AddAsync(T entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<T>> GetAsync(Expression<Func<T, bool>> predicate = null)
        {
            return await _dbContext.Set<T>().Where(predicate ?? (pre => true)).ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbContext.FindAsync<T>(id);
        }

        public async Task<EntityEntry<T>> UpdateAsync(T entity)
        {
            var updatedEntity = _dbContext.Set<T>().Update(entity);
            await _dbContext.SaveChangesAsync();
            return updatedEntity;
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            _dbContext.Set<T>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }
    }
}
