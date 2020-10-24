using Family.Manager.Infrastructure.Configurations;
using Family.Manager.Infrastructure.DataProviders.Repository.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Family.Manager.Infrastructure.DataProviders.Repository
{
    public class FamilyRepository : RepositoryBase<Domain.Entities.Family, Guid>, IFamilyRepository
    {
        private readonly FamilyContext _context;

        public FamilyRepository(FamilyContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Domain.Entities.Family>> GetFamiliesWithKidsAndKinshipsAsync()
        {
            return await _context.Families
                .AsNoTracking()
                .Include(f => f.Kinships)
                .Include(f => f.Kids)
                .ThenInclude(k => k.KidReligionInformation)
                .ToListAsync();
        }
    }
}
