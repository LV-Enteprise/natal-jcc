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
            builder.HasKey(k => k.Id);

            builder.Property(k => k.Name)
              .HasColumnType("character varying(255)")
              .IsRequired();

            builder.Property(k => k.BirthDate)
                .HasColumnType("date")
                .IsRequired();

            builder.Property(k => k.Observation)
                .HasColumnType("text");

            builder.HasOne(k => k.Family)
                   .WithMany(f => f.Kids)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(k => k.KidReligionInformation)
                   .WithOne(kr => kr.Kid)
                   .HasForeignKey<KidReligionInformation>(kr => kr.Id)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
