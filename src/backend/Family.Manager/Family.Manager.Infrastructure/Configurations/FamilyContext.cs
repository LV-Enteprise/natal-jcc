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

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseNpgsql(
        //        "Server=127.0.0.1;Port=5433;Database=familymanager;User Id=postgres;Password=Skayline*869;");
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(FamilyContext).Assembly);
        }
    }
}
