using Family.Manager.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Family.Manager.Infrastructure.Configurations
{
    public class FamilyContext : DbContext
    {
        public FamilyContext(DbContextOptions options)
            : base(options) { }

        public DbSet<Domain.Entities.Family> Families { get; set; }
        public DbSet<Kinship> Kinships { get; set; }
        public DbSet<Kid> Kids { get; set; }
        public DbSet<KidReligionInformation> KidsReligionInformation { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(FamilyContext).Assembly);
        }
    }
}
