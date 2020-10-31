using Family.Manager.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Family.Manager.Infrastructure.DataProviders.Repository.Abstract
{
    public interface IRepositoryBase<TEntity, TKey> where TEntity : Entity<TKey>
    {
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(TKey key);
        Task CreateAsync(TEntity entity);
        Task BulkInsertAsync(IEnumerable<TEntity> entities);
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync(TEntity entity);
        Task SaveChangesAsync();
    }
}
