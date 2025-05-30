﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Projekt.Data;

#nullable disable

namespace Projekt.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250509132231_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Projekt.Models.Motor", b =>
                {
                    b.Property<int>("IdPojazdu")
                        .HasColumnType("integer");

                    b.Property<int>("PojemnoscSilnika")
                        .HasColumnType("integer");

                    b.HasKey("IdPojazdu");

                    b.ToTable("Motory");

                    b.HasData(
                        new
                        {
                            IdPojazdu = 2,
                            PojemnoscSilnika = 1000
                        });
                });

            modelBuilder.Entity("Projekt.Models.Osobowy", b =>
                {
                    b.Property<int>("IdPojazdu")
                        .HasColumnType("integer");

                    b.Property<int>("LiczbaDrzwi")
                        .HasColumnType("integer");

                    b.HasKey("IdPojazdu");

                    b.ToTable("Osobowe");

                    b.HasData(
                        new
                        {
                            IdPojazdu = 1,
                            LiczbaDrzwi = 3
                        },
                        new
                        {
                            IdPojazdu = 3,
                            LiczbaDrzwi = 5
                        });
                });

            modelBuilder.Entity("Projekt.Models.Pojazd", b =>
                {
                    b.Property<int>("IdPojazdu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("IdPojazdu"));

                    b.Property<string>("Marka")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<int>("RokProdukcji")
                        .HasColumnType("integer");

                    b.Property<string>("Typ")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.HasKey("IdPojazdu");

                    b.ToTable("Pojazdy");

                    b.HasData(
                        new
                        {
                            IdPojazdu = 1,
                            Marka = "Opel",
                            Model = "Corsa",
                            RokProdukcji = 2000,
                            Typ = "Osobowy"
                        },
                        new
                        {
                            IdPojazdu = 2,
                            Marka = "Yamaha",
                            Model = "R1",
                            RokProdukcji = 2015,
                            Typ = "Motor"
                        },
                        new
                        {
                            IdPojazdu = 3,
                            Marka = "Audi",
                            Model = "A6",
                            RokProdukcji = 2011,
                            Typ = "Osobowy"
                        });
                });

            modelBuilder.Entity("Projekt.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Login = "admin",
                            Password = "admin123"
                        });
                });

            modelBuilder.Entity("Projekt.Models.Motor", b =>
                {
                    b.HasOne("Projekt.Models.Pojazd", "Pojazd")
                        .WithOne("Motor")
                        .HasForeignKey("Projekt.Models.Motor", "IdPojazdu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pojazd");
                });

            modelBuilder.Entity("Projekt.Models.Osobowy", b =>
                {
                    b.HasOne("Projekt.Models.Pojazd", "Pojazd")
                        .WithOne("Osobowy")
                        .HasForeignKey("Projekt.Models.Osobowy", "IdPojazdu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pojazd");
                });

            modelBuilder.Entity("Projekt.Models.Pojazd", b =>
                {
                    b.Navigation("Motor")
                        .IsRequired();

                    b.Navigation("Osobowy")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
