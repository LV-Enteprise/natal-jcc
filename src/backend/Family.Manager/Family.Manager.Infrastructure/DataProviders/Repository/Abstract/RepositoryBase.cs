using Family.Manager.Domain.Entities;
using Family.Manager.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Family.Manager.Infrastructure.DataProviders.Repository.Abstract
{
    public abstract class RepositoryBase<TEntity, TKey> : IRepositoryBase<TEntity, TKey> where TEntity : Entity<TKey>
    {
        private readonly DbSet<TEntity> _dbSet;
        private readonly FamilyContext _familyContext;

        public RepositoryBase(FamilyContext context)
        {
            _familyContext = context;
            _dbSet = context.Set<TEntity>();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(TKey key)
        {
            return await _dbSet.FindAsync(key);
        }

        public async Task CreateAsync(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
            await SaveChangesAsync();
        }

        public async Task UpdateAsync(TEntity entity)
        {
            _familyContext.Entry(entity).State = EntityState.Modified;
            await SaveChangesAsync();
        }

        public async Task DeleteAsync(TEntity entity)
        {
            _dbSet.Remove(entity);
            await SaveChangesAsync();
        }

        public async Task SaveChangesAsync()
        {
            _ = await _familyContext.SaveChangesAsync();
        }
    }
}
