namespace Airport.Data
{
    using Models;
    using Microsoft.EntityFrameworkCore;

    public class AppDbContext : DbContext
    {
        private const string ConnectionString = @"Server=STEM-13\MSSQLSERVER01; Initial Catalog=AirportEf; Integrated Security=true; Trusted_Connection=true";

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
                    option
                        .HasIndex(x => x.Country)
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
