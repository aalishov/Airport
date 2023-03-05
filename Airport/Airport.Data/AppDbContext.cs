namespace Airport.Data
{
    using Models;
    using Microsoft.EntityFrameworkCore;
    using System.Security.Cryptography.X509Certificates;

    public class AppDbContext : DbContext
    {
        private const string ConnectionString = @"Server=STEM-13\MSSQLSERVER01; Initial Catalog=AirportNewEf; Integrated Security=true; Trusted_Connection=true";

        public virtual DbSet<Aircraft> Aircrafts { get; set; }
        public virtual DbSet<AircraftType> AircraftTypes { get; set; }
        public virtual DbSet<Airport> Airports { get; set; }
        public virtual DbSet<FlightDestination> FlightDestinations { get; set; }
        public virtual DbSet<Passenger> Passengers { get; set; }
        public virtual DbSet<Pilot> Pilots { get; set; }
        public virtual DbSet<PilotAircraft> PilotsAircraft { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConnectionString);
            }
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Passenger>(
                option =>
                {
                    option
                        .Property(p => p.Email)
                        .IsUnicode(false);

                    option
                        .HasIndex(p => p.Email)
                        .IsUnique(true);
                });

            modelBuilder.Entity<FlightDestination>
                (
                        option =>
                        {
                            option
                        .HasOne(p => p.Airport)
                        .WithMany(p => p.StartDestinations)
                        .HasForeignKey(x => x.AirportId)
                        .OnDelete(DeleteBehavior.NoAction);

                            option
                    .HasOne(p => p.DestinationAirport)
                    .WithMany(p => p.Destinations)
                    .HasForeignKey(x => x.DestinationAirportId)
                    .OnDelete(DeleteBehavior.NoAction);
                        }

                );

            modelBuilder.Entity<AircraftType>(
                option =>
                {
                    option
                        .HasIndex(x => x.Name)
                        .IsUnique(true);
                });

            modelBuilder.Entity<PilotAircraft>(
                option =>
                {
                    option
                        .HasKey(x => new { x.AircraftId, x.PilotId });
                });

            modelBuilder.Entity<Airport>(
                option =>
                {
                    option
                        .HasIndex(x => x.Name)
                        .IsUnique(true);
                });
            modelBuilder.Entity<FlightDestination>(
                option =>
                {
                    option
                        .Property(x => x.TicketPrice)
                        .HasDefaultValue(15);
                });
        }
    }
}
