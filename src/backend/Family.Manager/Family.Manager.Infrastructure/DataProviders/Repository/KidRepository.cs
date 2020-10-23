using Family.Manager.Domain.Entities;
using Family.Manager.Infrastructure.Configurations;
using System;

namespace Family.Manager.Infrastructure.DataProviders.Repository
{
    public class KidRepository : RepositoryBase<Kid, Guid>, IRepositoryBase<Kid, Guid>
    {
        public KidRepository(FamilyContext context) : base(context)
        {
        }
    }
}
