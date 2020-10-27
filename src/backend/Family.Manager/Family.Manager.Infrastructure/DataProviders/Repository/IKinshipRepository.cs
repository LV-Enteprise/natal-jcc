using Family.Manager.Domain.Entities;
using Family.Manager.Infrastructure.DataProviders.Repository.Abstract;
using System;

namespace Family.Manager.Infrastructure.DataProviders.Repository
{
    public interface IKinshipRepository : IRepositoryBase<Kinship, Guid>
    {
    }
}
