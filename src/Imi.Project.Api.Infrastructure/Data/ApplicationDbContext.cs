using Imi.Project.Api.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Imi.Project.Api.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Aircraft> Aircrafts { get; set; }
        public DbSet<AircraftType> AircraftTypes { get; set; }
        public DbSet<Airline> Airlines { get; set; }
        public DbSet<Airport> Airports { get; set; }
        public DbSet<AircraftAtAirport> AircraftAtAirports { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region AircraftType
            modelBuilder.Entity<AircraftType>()
                .HasKey(at => at.Id);

            modelBuilder.Entity<AircraftType>()
                .Property(at => at.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<AircraftType>()
                .Property(at => at.Brand)
                .HasMaxLength(50)
                .IsRequired();

            modelBuilder.Entity<AircraftType>()
                .Property(at => at.Type)
                .HasMaxLength(30)
                .IsRequired();
            modelBuilder.Entity<AircraftType>()
                .Property(at => at.ICAOCode)
                .HasMaxLength(4)
                .IsFixedLength()
                .IsRequired();

            modelBuilder.Entity<AircraftType>()
                .Property(at => at.Length);

            modelBuilder.Entity<AircraftType>()
                .Property(at => at.WingSpan);

            modelBuilder.Entity<AircraftType>()
                .Property(at => at.Height);

            modelBuilder.Entity<AircraftType>()
                .Property(at => at.EmptyWeight);
            #endregion

            #region Airline
            modelBuilder.Entity<Airline>()
                .HasKey(al => al.Id);

            modelBuilder.Entity<Airline>()
                .Property(al => al.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Airline>()
                .Property(al => al.Name)
                .HasMaxLength(150)
                .IsRequired();

            modelBuilder.Entity<Airline>()
                .Property(al => al.IATACode)
                .HasMaxLength(2)
                .IsFixedLength()
                .IsRequired();

            modelBuilder.Entity<Airline>()
                .Property(al => al.ICAOCode)
                .HasMaxLength(3)
                .IsFixedLength()
                .IsRequired();

            modelBuilder.Entity<Airline>()
                .Property(al => al.MainAirport)
                .HasMaxLength(200);

            modelBuilder.Entity<Airline>()
                .Property(al => al.HeadQuarter)
                .HasMaxLength(200);
            #endregion

            #region Airport
            modelBuilder.Entity<Airport>()
                .HasKey(ap => ap.Id);

            modelBuilder.Entity<Airport>()
                .Property(al => al.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Airport>()
                .Property(ap => ap.Name)
                .HasMaxLength(200)
                .IsRequired();

            modelBuilder.Entity<Airport>()
                .Property(ap => ap.IATACode)
                .HasMaxLength(3)
                .IsFixedLength()
                .IsRequired();

            modelBuilder.Entity<Airport>()
                .Property(ap => ap.ICAOCode)
                .HasMaxLength(4)
                .IsFixedLength()
                .IsRequired();

            modelBuilder.Entity<Airport>()
                .Property(ap => ap.ElevationAMSL)
                .HasPrecision(4);

            modelBuilder.Entity<Airport>()
                .Property(ap => ap.RunwayAmount)
                .HasPrecision(2);

            modelBuilder.Entity<Airport>()
                .Property(ap => ap.TerminalAmount)
                .HasPrecision(2);

            modelBuilder.Entity<Airport>()
                .Property(ap => ap.Country)
                .HasMaxLength(200);

            modelBuilder.Entity<Airport>()
                .Property(ap => ap.City)
                .HasMaxLength(200);
            #endregion

            #region Aircraft
            modelBuilder.Entity<Aircraft>()
                .HasKey(a => a.Id);

            modelBuilder.Entity<Aircraft>()
                .Property(a => a.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Aircraft>()
                .Property(a => a.Registration)
                .HasMaxLength(6)
                .IsRequired();

            modelBuilder.Entity<Aircraft>()
                .Property(a => a.HasSpecialLivery)
                .IsRequired();

            modelBuilder.Entity<Aircraft>()
                .Property(a => a.FirstSeen)
                .IsRequired();

            modelBuilder.Entity<Aircraft>()
                .Property(a => a.LastSeen)
                .IsRequired();

            modelBuilder.Entity<Aircraft>()
                .Property(a => a.Longitude);

            modelBuilder.Entity<Aircraft>()
                .Property(a => a.Latitude);
            #endregion

            #region AircraftAtAirport
            modelBuilder.Entity<AircraftAtAirport>()
                .HasKey(aa => new { aa.AircraftId, aa.AirportId });
            #endregion

            ApplicationSeeder.Seed(modelBuilder);
        }
    }
}
