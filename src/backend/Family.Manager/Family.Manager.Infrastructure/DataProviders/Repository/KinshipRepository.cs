using Family.Manager.Infrastructure.Configurations;
using Family.Manager.Infrastructure.DataProviders.Repository.Abstract;
using System;

namespace Family.Manager.Infrastructure.DataProviders.Repository
{
    public class KinshipRepository : RepositoryBase<Domain.Entities.Kinship, Guid>, IKinshipRepository
    {
        public KinshipRepository(FamilyContext context) : base(context)
        {
        }
    }
}
