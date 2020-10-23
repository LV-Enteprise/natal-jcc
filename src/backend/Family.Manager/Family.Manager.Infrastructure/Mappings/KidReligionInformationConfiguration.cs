using Family.Manager.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Family.Manager.Infrastructure.Mappings
{
    public class KidReligionInformationConfiguration : IEntityTypeConfiguration<KidReligionInformation>
    {
        public void Configure(EntityTypeBuilder<KidReligionInformation> builder)
        {
            builder.ToTable("KidReligionInformation");
            builder.HasKey(kr => kr.Id);

            builder.Property(kr => kr.IsBaptized)
              .HasColumnType("boolean")
              .IsRequired();

            builder.Property(kr => kr.DoingCatechesis)
              .HasColumnType("boolean")
              .IsRequired();

            builder.Property(kr => kr.DoneCatechesis)
              .HasColumnType("boolean")
              .IsRequired();

            builder.Property(kr => kr.DoingPerse)
              .HasColumnType("boolean")
              .IsRequired();

            builder.Property(kr => kr.DonePerse)
              .HasColumnType("boolean")
              .IsRequired();

            builder.Property(kr => kr.DoingConfirmationSacrament)
              .HasColumnType("boolean")
              .IsRequired();

            builder.Property(kr => kr.DoneConfirmationSacrament)
              .HasColumnType("boolean")
              .IsRequired();
        }
    }
}
