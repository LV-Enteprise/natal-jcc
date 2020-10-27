using Family.Manager.Domain.Entities;
using Family.Manager.Infrastructure.DataProviders.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Family.Manager.Infrastructure.DataProviders.Repository
{
    public interface IKidRepository : IRepositoryBase<Kid, Guid>
    {
        Task<IEnumerable<Kid>> GetAllKidsAsync();
        Task<Kid> GetKidByIdAsync(Guid id);
    }
}
