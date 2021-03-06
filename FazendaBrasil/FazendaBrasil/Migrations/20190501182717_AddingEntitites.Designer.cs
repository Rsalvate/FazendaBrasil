﻿// <auto-generated />
using FazendaBrasil.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace FazendaBrasil.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190501182717_AddingEntitites")]
    partial class AddingEntitites
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FazendaBrasil.Domain.Animal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DeathDate");

                    b.Property<string>("Decription");

                    b.Property<byte[]>("Picture");

                    b.Property<DateTime>("PurchaseDate");

                    b.Property<double>("PurchaseWeight");

                    b.Property<DateTime>("SellingDate");

                    b.Property<double>("SellingWeight");

                    b.HasKey("Id");

                    b.ToTable("Animals");
                });

            modelBuilder.Entity("FazendaBrasil.Domain.AnimalMedication", b =>
                {
                    b.Property<int>("Id");

                    b.Property<int>("AnimalId");

                    b.Property<int>("MedicationId");

                    b.Property<DateTime>("UsageDate");

                    b.HasKey("Id", "AnimalId", "MedicationId");

                    b.HasIndex("AnimalId");

                    b.HasIndex("MedicationId");

                    b.ToTable("AnimalMedicationsanimalMedications");
                });

            modelBuilder.Entity("FazendaBrasil.Domain.Cattle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Decription");

                    b.HasKey("Id");

                    b.ToTable("Cattles");
                });

            modelBuilder.Entity("FazendaBrasil.Domain.CattleAnimal", b =>
                {
                    b.Property<int>("CattleId");

                    b.Property<int>("AnimalId");

                    b.HasKey("CattleId", "AnimalId");

                    b.HasIndex("AnimalId");

                    b.ToTable("CattleAnimals");
                });

            modelBuilder.Entity("FazendaBrasil.Domain.Frequency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<int>("RangeOfDays");

                    b.HasKey("Id");

                    b.ToTable("Frequencies");
                });

            modelBuilder.Entity("FazendaBrasil.Domain.Medication", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<DateTime>("PurchaseDate");

                    b.Property<double>("PurchasePrice");

                    b.Property<int?>("UsageFrequencyId");

                    b.HasKey("Id");

                    b.HasIndex("UsageFrequencyId");

                    b.ToTable("Medications");
                });

            modelBuilder.Entity("FazendaBrasil.Domain.Site", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<int>("MaximumCapacity");

                    b.Property<double>("Size");

                    b.HasKey("Id");

                    b.ToTable("Sites");
                });

            modelBuilder.Entity("FazendaBrasil.Domain.AnimalMedication", b =>
                {
                    b.HasOne("FazendaBrasil.Domain.Animal", "Animal")
                        .WithMany("AnimalMedications")
                        .HasForeignKey("AnimalId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FazendaBrasil.Domain.Medication", "Medication")
                        .WithMany()
                        .HasForeignKey("MedicationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FazendaBrasil.Domain.CattleAnimal", b =>
                {
                    b.HasOne("FazendaBrasil.Domain.Animal", "Animal")
                        .WithMany()
                        .HasForeignKey("AnimalId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FazendaBrasil.Domain.Cattle", "Cattle")
                        .WithMany("cattleAnimals")
                        .HasForeignKey("CattleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FazendaBrasil.Domain.Medication", b =>
                {
                    b.HasOne("FazendaBrasil.Domain.Frequency", "UsageFrequency")
                        .WithMany()
                        .HasForeignKey("UsageFrequencyId");
                });
#pragma warning restore 612, 618
        }
    }
}
