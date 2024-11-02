using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ProjectDataAccess.Abstractions
{
    public interface IGenericRepository<T> where T : class, new()
    {
        Task<IEnumerable<T>> GetAllAsync(bool tracking = true); // tracking parametri əlavə edildi
        Task<T> GetByIdAsync(int id);
        Task<IReadOnlyList<T>> GetWhereAsync(Expression<Func<T, bool>> expression);
        Task<bool> AddAsync(T entity);
        Task<bool> RemoveAsync(T entity); // Async olaraq adlandırıldı
        Task<bool> UpdateAsync(T entity); // Async olaraq adlandırıldı
        Task SaveChangesAsync();
    }
}
