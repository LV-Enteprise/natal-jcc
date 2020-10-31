﻿// <auto-generated />
using System;
using Family.Manager.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Family.Manager.Infrastructure.Migrations
{
    [DbContext(typeof(FamilyContext))]
    partial class FamilyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Family.Manager.Domain.Entities.Family", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("character varying(255)");

                    b.Property<string>("CellPhoneNumber")
                        .IsRequired()
                        .HasColumnType("character varying(11)");

                    b.Property<string>("ChurchInformation")
                        .HasColumnType("character varying(300)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("character varying(255)");

                    b.Property<string>("Observation")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("character varying(10)");

                    b.Property<string>("Religion")
                        .HasColumnType("character varying(80)");

                    b.Property<int>("TotalFamilyMembers")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Family");
                });

            modelBuilder.Entity("Family.Manager.Domain.Entities.Kid", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("date");

                    b.Property<Guid>("FamilyId")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("character varying(255)");

                    b.Property<string>("Observation")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("FamilyId");

                    b.ToTable("Kid");
                });

            modelBuilder.Entity("Family.Manager.Domain.Entities.KidReligionInformation", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<bool>("DoingCatechesis")
                        .HasColumnType("boolean");

                    b.Property<bool>("DoingConfirmationSacrament")
                        .HasColumnType("boolean");

                    b.Property<bool>("DoingPerse")
                        .HasColumnType("boolean");

                    b.Property<bool>("DoneCatechesis")
                        .HasColumnType("boolean");

                    b.Property<bool>("DoneConfirmationSacrament")
                        .HasColumnType("boolean");

                    b.Property<bool>("DonePerse")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsBaptized")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("KidReligionInformation");
                });

            modelBuilder.Entity("Family.Manager.Domain.Entities.Kinship", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("character varying(80)");

                    b.Property<Guid>("FamilyId")
                        .HasColumnType("uuid");

                    b.Property<string>("PersonName")
                        .IsRequired()
                        .HasColumnType("character varying(255)");

                    b.HasKey("Id");

                    b.HasIndex("FamilyId");

                    b.ToTable("Kinship");
                });

            modelBuilder.Entity("Family.Manager.Domain.Entities.Kid", b =>
                {
                    b.HasOne("Family.Manager.Domain.Entities.Family", "Family")
                        .WithMany("Kids")
                        .HasForeignKey("FamilyId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("Family.Manager.Domain.Entities.KidReligionInformation", b =>
                {
                    b.HasOne("Family.Manager.Domain.Entities.Kid", "Kid")
                        .WithOne("KidReligionInformation")
                        .HasForeignKey("Family.Manager.Domain.Entities.KidReligionInformation", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Family.Manager.Domain.Entities.Kinship", b =>
                {
                    b.HasOne("Family.Manager.Domain.Entities.Family", "Family")
                        .WithMany("Kinships")
                        .HasForeignKey("FamilyId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
