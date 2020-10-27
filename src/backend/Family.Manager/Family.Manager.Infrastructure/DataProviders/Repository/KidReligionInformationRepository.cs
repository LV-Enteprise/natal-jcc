using Family.Manager.Domain.Entities;
using Family.Manager.Infrastructure.Configurations;
using Family.Manager.Infrastructure.DataProviders.Repository.Abstract;
using System;

namespace Family.Manager.Infrastructure.DataProviders.Repository
{
    public class KidReligionInformationRepository : RepositoryBase<KidReligionInformation, Guid>, IKidReligionInformationRepository
    {
        public KidReligionInformationRepository(FamilyContext context) : base(context)
        {
        }
    }
}
