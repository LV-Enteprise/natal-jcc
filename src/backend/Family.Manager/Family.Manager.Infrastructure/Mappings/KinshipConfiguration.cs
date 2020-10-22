using Family.Manager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Family.Manager.Infrastructure.Mappings
{
    public class KinshipConfiguration : IEntityTypeConfiguration<Kinship>
    {
        public void Configure(EntityTypeBuilder<Kinship> builder)
        {
            builder.ToTable("Kinship");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Description)
                .HasColumnType("character varying(80)")
                .IsRequired();

            builder.Property(p => p.PersonName)
                .HasColumnType("character varying(255)")
                .IsRequired();
        }
    }
}
