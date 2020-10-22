using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Family.Manager.Infrastructure.Mappings
{
    public class FamilyConfiguration : IEntityTypeConfiguration<Domain.Entities.Family>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Family> builder)
        {
            builder.ToTable("Family");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Address)
                .HasColumnType("character varying(255)")
                .IsRequired();

            builder.Property(p => p.PhoneNumber)
                .HasColumnType("character varying(10)")
                .IsRequired();

            builder.Property(p => p.CellPhoneNumber)
                .HasColumnType("character varying(11)")
                .IsRequired();

            builder.Property(p => p.Religion)
                .HasColumnType("character varying(80)");

            builder.Property(p => p.ChurchInformation)
                .HasColumnType("character varying(300)");

            builder.Property(p => p.Observation)
                .HasColumnType("text");

            builder.Property(p => p.TotalFamilyMembers)
                .HasColumnType("integer")
                .IsRequired();

            builder.HasMany(f => f.Kinships)
                   .WithOne(k => k.Family)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(f => f.Kids)
                   .WithOne(k => k.Family)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
