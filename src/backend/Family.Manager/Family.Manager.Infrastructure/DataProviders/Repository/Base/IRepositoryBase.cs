using Family.Manager.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Family.Manager.Infrastructure.DataProviders.Repository
{
    public interface IRepositoryBase<TEntity, UType> where TEntity : Entity<UType>
    {
        Task<IEnumerable<TEntity>> GetAll();
    }
}
