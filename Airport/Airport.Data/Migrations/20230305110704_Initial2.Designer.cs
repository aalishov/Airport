﻿// <auto-generated />
using System;
using Airport.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Airport.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230305110704_Initial2")]
    partial class Initial2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Airport.Models.Aircraft", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Condition")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<int?>("FlightHours")
                        .HasColumnType("int");

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TypeId");

                    b.ToTable("Aircrafts");
                });

            modelBuilder.Entity("Airport.Models.AircraftType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("AircraftTypes");
                });

            modelBuilder.Entity("Airport.Models.Airport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Airports");
                });

            modelBuilder.Entity("Airport.Models.FlightDestination", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AircraftId")
                        .HasColumnType("int");

                    b.Property<int>("AirportId")
                        .HasColumnType("int");

                    b.Property<int>("DestinationAirportId")
                        .HasColumnType("int");

                    b.Property<int>("MaxTicketsCount")
                        .HasColumnType("int");

                    b.Property<DateTime>("Start")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TicketPrice")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(18,2)")
                        .HasDefaultValue(15m);

                    b.HasKey("Id");

                    b.HasIndex("AircraftId");

                    b.HasIndex("AirportId");

                    b.HasIndex("DestinationAirportId");

                    b.ToTable("FlightDestinations");
                });

            modelBuilder.Entity("Airport.Models.Passenger", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Passengers");
                });

            modelBuilder.Entity("Airport.Models.Pilot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<double?>("Rating")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Pilots");
                });

            modelBuilder.Entity("Airport.Models.PilotAircraft", b =>
                {
                    b.Property<int>("AircraftId")
                        .HasColumnType("int");

                    b.Property<int>("PilotId")
                        .HasColumnType("int");

                    b.HasKey("AircraftId", "PilotId");

                    b.HasIndex("PilotId");

                    b.ToTable("PilotsAircraft");
                });

            modelBuilder.Entity("Airport.Models.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FlightDestinationId")
                        .HasColumnType("int");

                    b.Property<int>("PassengerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReservationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Tickets")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FlightDestinationId");

                    b.HasIndex("PassengerId");

                    b.ToTable("Reservation");
                });

            modelBuilder.Entity("Airport.Models.Aircraft", b =>
                {
                    b.HasOne("Airport.Models.AircraftType", "Type")
                        .WithMany("Aircrafts")
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Airport.Models.FlightDestination", b =>
                {
                    b.HasOne("Airport.Models.Aircraft", "Aircraft")
                        .WithMany("FlightDestinations")
                        .HasForeignKey("AircraftId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Airport.Models.Airport", "Airport")
                        .WithMany("StartDestinations")
                        .HasForeignKey("AirportId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Airport.Models.Airport", "DestinationAirport")
                        .WithMany("Destinations")
                        .HasForeignKey("DestinationAirportId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("Airport.Models.PilotAircraft", b =>
                {
                    b.HasOne("Airport.Models.Aircraft", "Aircraft")
                        .WithMany("PilotsAircraft")
                        .HasForeignKey("AircraftId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Airport.Models.Pilot", "Pilot")
                        .WithMany("PilotsAircraft")
                        .HasForeignKey("PilotId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Airport.Models.Reservation", b =>
                {
                    b.HasOne("Airport.Models.FlightDestination", "FlightDestination")
                        .WithMany("Reservations")
                        .HasForeignKey("FlightDestinationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Airport.Models.Passenger", "Passenger")
                        .WithMany("Reservations")
                        .HasForeignKey("PassengerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
