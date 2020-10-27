using Family.Manager.Infrastructure.DataProviders.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Family.Manager.Infrastructure.DataProviders.Repository
{
    public interface IFamilyRepository : IRepositoryBase<Domain.Entities.Family, Guid>
    {
        Task<IEnumerable<Domain.Entities.Family>> GetFamiliesWithKidsAndKinshipsAsync();
    }
}
