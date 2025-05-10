using Microsoft.EntityFrameworkCore;
using Projekt.Models;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Projekt.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Pojazd> Pojazdy { get; set; }
        public DbSet<Osobowy> Osobowe { get; set; }
        public DbSet<Motor> Motory { get; set; }
        public DbSet<User> Users { get; set; }

        // Konstruktor do DI
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Konstruktor bezparametrowy do migracji
        public AppDbContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            if (!optionsBuilder.IsConfigured)
            {
                
                var builder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

                var configuration = builder.Build();
                var connectionString = configuration.GetConnectionString("DefaultConnection");


                optionsBuilder.UseNpgsql(connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Relacja 1:1 Pojazd <-> Osobowy
            modelBuilder.Entity<Pojazd>()
                .HasOne(p => p.Osobowy)
                .WithOne(o => o.Pojazd)
                .HasForeignKey<Osobowy>(o => o.IdPojazdu)
                .OnDelete(DeleteBehavior.Cascade);

            // Relacja 1:1 Pojazd <-> Motor
            modelBuilder.Entity<Pojazd>()
                .HasOne(p => p.Motor)
                .WithOne(m => m.Pojazd)
                .HasForeignKey<Motor>(m => m.IdPojazdu)
                .OnDelete(DeleteBehavior.Cascade);

            // Seed przykładowych danych
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Login = "admin", Password = "admin123" }
            );
            modelBuilder.Entity<Pojazd>().HasData(
                new Pojazd { IdPojazdu = 1, Marka = "Opel", Model = "Corsa", RokProdukcji = 2000, Typ = "Osobowy" },
                new Pojazd { IdPojazdu = 2, Marka = "Yamaha", Model = "R1", RokProdukcji = 2015, Typ = "Motor" },
                new Pojazd { IdPojazdu = 3, Marka = "Audi", Model = "A6", RokProdukcji = 2011, Typ = "Osobowy" }
            );
            modelBuilder.Entity<Osobowy>().HasData(
                new Osobowy { IdPojazdu = 1, LiczbaDrzwi = 3 },
                new Osobowy { IdPojazdu = 3, LiczbaDrzwi = 5 }
            );
            modelBuilder.Entity<Motor>().HasData(
                new Motor { IdPojazdu = 2, PojemnoscSilnika = 1000 }
            );
        }
    }
}