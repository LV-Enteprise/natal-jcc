using Family.Manager.Domain.Entities;
using Family.Manager.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Family.Manager.Infrastructure.DataProviders.Repository
{
    public abstract class RepositoryBase<TEntity, UType> : IRepositoryBase<TEntity, UType> where TEntity : Entity<UType>
    {
        private readonly DbSet<TEntity> _dbSet;

        public RepositoryBase(FamilyContext context)
        {
            _dbSet = context.Set<TEntity>();
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }
    }
}
