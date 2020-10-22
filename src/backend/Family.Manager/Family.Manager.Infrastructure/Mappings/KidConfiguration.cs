using Family.Manager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Family.Manager.Infrastructure.Mappings
{
    public class KidConfiguration : IEntityTypeConfiguration<Kid>
    {
        public void Configure(EntityTypeBuilder<Kid> builder)
        {
            builder.ToTable("Kid");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name)
              .HasColumnType("character varying(255)")
              .IsRequired();

            builder.OwnsOne(p => p.KidReligionInformation)
              .Property(p => p.IsBaptized)
              .HasColumnType("boolean")
              .IsRequired();
            
            builder.OwnsOne(p => p.KidReligionInformation)
              .Property(p => p.DoingCatechesis)
              .HasColumnType("boolean")
              .IsRequired();
            
            builder.OwnsOne(p => p.KidReligionInformation)
              .Property(p => p.DoneCatechesis)
              .HasColumnType("boolean")
              .IsRequired();
            
            builder.OwnsOne(p => p.KidReligionInformation)
              .Property(p => p.DoingPerse)
              .HasColumnType("boolean")
              .IsRequired();
            
            builder.OwnsOne(p => p.KidReligionInformation)
              .Property(p => p.DonePerse)
              .HasColumnType("boolean")
              .IsRequired();
            
            builder.OwnsOne(p => p.KidReligionInformation)
              .Property(p => p.DoingConfirmationSacrament)
              .HasColumnType("boolean")
              .IsRequired();
            
            builder.OwnsOne(p => p.KidReligionInformation)
              .Property(p => p.DoneConfirmationSacrament)
              .HasColumnType("boolean")
              .IsRequired();

            builder.Property(p => p.BirthDate)
                .HasColumnType("date")
                .IsRequired();

            builder.Property(p => p.Observation)
                .HasColumnType("text");
        }
    }
}
