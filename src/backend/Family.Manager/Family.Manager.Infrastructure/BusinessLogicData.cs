using Family.Manager.Domain.Entities;
using Family.Manager.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Family.Manager.Infrastructure
{
    public class BusinessLogicData
    {
        private readonly FamilyContext _context;

        public BusinessLogicData(FamilyContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Kid>> GetAllKids()
        {
            return await _context.Kids.ToListAsync();
        }

        public async Task<IEnumerable<Domain.Entities.Family>> GetAllFamilies()
        {
            return await _context.Families
                .Include(x => x.Kinships)
                .Include(x => x.Kids)
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<Domain.Entities.Family> AddFamily(Domain.Entities.Family family)
        {
            _context.Add(family);
            await _context.SaveChangesAsync();
            return family;
        }

        public async Task<Kinship> AddKinship(Kinship kinship)
        {
            _context.Add(kinship);
            await _context.SaveChangesAsync();
            return kinship;
        }

        public async Task<Kid> AddKid(Kid kid)
        {
            _context.Add(kid);
            await _context.SaveChangesAsync();
            return kid;
        }

        public async Task<KidReligionInformation> AddKidReligionInformation(KidReligionInformation kidReligionInformation)
        {
            _context.Add(kidReligionInformation);
            await _context.SaveChangesAsync();
            return kidReligionInformation;
        }
    }
}
