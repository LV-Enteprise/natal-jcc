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
            builder.HasKey(k => k.Id);

            builder.Property(k => k.Description)
                .HasColumnType("character varying(80)")
                .IsRequired();

            builder.Property(k => k.PersonName)
                .HasColumnType("character varying(255)")
                .IsRequired();

            builder.HasOne(k => k.Family)
                   .WithMany(f => f.Kinships)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
