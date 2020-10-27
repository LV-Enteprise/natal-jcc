using Family.Manager.Domain.Entities;
using Family.Manager.Infrastructure.Configurations;
using Family.Manager.Infrastructure.DataProviders.Repository.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Family.Manager.Infrastructure.DataProviders.Repository
{
    public class KidRepository : RepositoryBase<Kid, Guid>, IKidRepository
    {
        private readonly FamilyContext _familyContext;

        public KidRepository(FamilyContext context) : base(context)
        {
            _familyContext = context;
        }

        public async Task<IEnumerable<Kid>> GetAllKidsAsync()
        {
            return await _familyContext.Kids
                .AsNoTracking()
                .Include(kid => kid.KidReligionInformation)
                .ToListAsync();
        }

        public async Task<Kid> GetKidByIdAsync(Guid id)
        {
            return await _familyContext.Kids.Where(kid => kid.Id == id)
                .AsNoTracking()
                .Include(kid => kid.KidReligionInformation)
                .FirstOrDefaultAsync();
        }
    }
}
