using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Family.Manager.Infrastructure.Mappings
{
    public class FamilyConfiguration : IEntityTypeConfiguration<Domain.Entities.Family>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.Family> builder)
        {
            builder.ToTable("Family");
            builder.HasKey(f => f.Id);

            builder.Property(f => f.Address)
                .HasColumnType("character varying(255)")
                .IsRequired();

            builder.Property(f => f.PhoneNumber)
                .HasColumnType("character varying(10)")
                .IsRequired();

            builder.Property(f => f.CellPhoneNumber)
                .HasColumnType("character varying(11)")
                .IsRequired();

            builder.Property(f => f.Religion)
                .HasColumnType("character varying(80)");

            builder.Property(f => f.ChurchInformation)
                .HasColumnType("character varying(300)");

            builder.Property(f => f.Observation)
                .HasColumnType("text");

            builder.Property(f => f.TotalFamilyMembers)
                .HasColumnType("integer")
                .IsRequired();
        }
    }
}
