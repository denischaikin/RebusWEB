using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace DAL.Repositories
{
    public interface IBaseRepository<T> where T : class
    {
        Task AddAsync(T entity);
        Task<List<T>> GetAsync(Expression<Func<T, bool>> predicate = null);
        Task<T> GetByIdAsync(int id);
        Task<EntityEntry<T>> UpdateAsync(T entity);
        Task DeleteAsync(int id);
    }
}
