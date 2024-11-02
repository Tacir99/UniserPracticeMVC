using Microsoft.EntityFrameworkCore;
using ProjectDataAcces.EntityFrameworks.Context;
using ProjectDataAccess.Abstractions;
using ProjectDataAccess.EntityFrameworks.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ProjectDataAccess.Concrete
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class, new()
    {
        private readonly ParfumContext _context;
        private DbSet<T> Table => _context.Set<T>();

        public GenericRepository(ParfumContext context)
        {
            _context = context;
        }

        public async Task<bool> AddAsync(T entity)
        {
            var addedState = await Table.AddAsync(entity);
            return addedState.State == EntityState.Added;
        }

        public async Task<IEnumerable<T>> GetAllAsync(bool tracking = true)
        {
            return tracking
                ? await Table.ToListAsync()
                : await Table.AsNoTracking().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
            => await Table.FindAsync(id);

        public async Task<IReadOnlyList<T>> GetWhereAsync(Expression<Func<T, bool>> expression)
            => await Table.Where(expression).ToListAsync();

        public async Task<bool> RemoveAsync(T entity)
        {
            var removed = Table.Remove(entity);
            await SaveChangesAsync();
            return removed.State == EntityState.Deleted;
        }

        public async Task<bool> UpdateAsync(T entity)
        {
            var updated = Table.Update(entity);
            await SaveChangesAsync();
            return updated.State == EntityState.Modified;
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
