﻿// <auto-generated />
using System;
using Imi.Project.Api.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Imi.Project.Api.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Imi.Project.Api.Core.Entities.Aircraft", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("AddedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("AircraftTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AirlineId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("FirstSeen")
                        .HasColumnType("datetime2");

                    b.Property<bool>("HasSpecialLivery")
                        .HasColumnType("bit");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastSeen")
                        .HasColumnType("datetime2");

                    b.Property<double?>("Latitude")
                        .HasPrecision(8, 5)
                        .HasColumnType("float(8)");

                    b.Property<double?>("Longitude")
                        .HasPrecision(8, 5)
                        .HasColumnType("float(8)");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Registration")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.HasKey("Id");

                    b.HasIndex("AircraftTypeId");

                    b.HasIndex("AirlineId");

                    b.ToTable("Aircrafts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("7ad87259-0659-4139-9e61-00a6d965b529"),
                            AddedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            AircraftTypeId = new Guid("5551f78b-51f6-4abe-844a-bf0757f064f7"),
                            AirlineId = new Guid("2060867d-622e-48af-b7f7-454fa0b95a1d"),
                            FirstSeen = new DateTime(2021, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HasSpecialLivery = false,
                            LastSeen = new DateTime(2021, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Registration = "OO-SNJ"
                        },
                        new
                        {
                            Id = new Guid("ab1e6496-f389-4b31-817c-f0eff8643b8b"),
                            AddedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            AircraftTypeId = new Guid("e8de0249-2860-4dc3-bad1-12a23787a730"),
                            AirlineId = new Guid("c48b695d-0fb0-4867-ab89-21ae9a7f76c0"),
                            FirstSeen = new DateTime(2020, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HasSpecialLivery = false,
                            LastSeen = new DateTime(2021, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Registration = "OO-LOE"
                        },
                        new
                        {
                            Id = new Guid("b08f5c5a-0273-4ed7-bd8e-fada782fed7c"),
                            AddedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            AircraftTypeId = new Guid("0074cf33-a3dc-4aee-9eff-faf4b2662b52"),
                            AirlineId = new Guid("6c841066-3347-4da3-90bb-2c9f2fab562a"),
                            FirstSeen = new DateTime(2020, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HasSpecialLivery = false,
                            LastSeen = new DateTime(2021, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Registration = "D-ALCC"
                        });
                });

            modelBuilder.Entity("Imi.Project.Api.Core.Entities.AircraftAtAirport", b =>
                {
                    b.Property<Guid>("AircraftId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AirportId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("AircraftId", "AirportId");

                    b.HasIndex("AirportId");

                    b.ToTable("AircraftAtAirports");
                });

            modelBuilder.Entity("Imi.Project.Api.Core.Entities.AircraftType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("AddedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("EmptyWeight")
                        .HasPrecision(6)
                        .HasColumnType("int");

                    b.Property<DateTime?>("FirstFlight")
                        .HasColumnType("datetime2");

                    b.Property<double?>("Height")
                        .HasPrecision(5, 2)
                        .HasColumnType("float(5)");

                    b.Property<string>("ICAOCode")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nchar(4)")
                        .IsFixedLength(true);

                    b.Property<double?>("Length")
                        .HasPrecision(5, 2)
                        .HasColumnType("float(5)");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<double?>("WingSpan")
                        .HasPrecision(5, 2)
                        .HasColumnType("float(5)");

                    b.HasKey("Id");

                    b.ToTable("AircraftTypes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5551f78b-51f6-4abe-844a-bf0757f064f7"),
                            AddedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Brand = "Airbus",
                            EmptyWeight = 42400,
                            FirstFlight = new DateTime(1987, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Height = 11.76,
                            ICAOCode = "A320",
                            Length = 37.57,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "A320-200",
                            WingSpan = 34.100000000000001
                        },
                        new
                        {
                            Id = new Guid("e8de0249-2860-4dc3-bad1-12a23787a730"),
                            AddedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Brand = "Boeing",
                            EmptyWeight = 118000,
                            FirstFlight = new DateTime(2009, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Height = 16.899999999999999,
                            ICAOCode = "B788",
                            Length = 56.700000000000003,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "787-8",
                            WingSpan = 60.100000000000001
                        },
                        new
                        {
                            Id = new Guid("0074cf33-a3dc-4aee-9eff-faf4b2662b52"),
                            AddedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Brand = "McDonnel Douglas",
                            EmptyWeight = 112748,
                            FirstFlight = new DateTime(1990, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Height = 17.600000000000001,
                            ICAOCode = "MD11",
                            Length = 61.399999999999999,
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "MD-11",
                            WingSpan = 51.700000000000003
                        });
                });

            modelBuilder.Entity("Imi.Project.Api.Core.Entities.Airline", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("AddedOn")
                        .HasColumnType("datetime2");

                    b.Property<int?>("FleetSize")
                        .HasColumnType("int");

                    b.Property<string>("HeadQuarter")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("IATACode")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("nchar(2)")
                        .IsFixedLength(true);

                    b.Property<string>("ICAOCode")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nchar(3)")
                        .IsFixedLength(true);

                    b.Property<string>("MainAirport")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Airlines");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2060867d-622e-48af-b7f7-454fa0b95a1d"),
                            AddedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FleetSize = 49,
                            HeadQuarter = "Diegem, België",
                            IATACode = "SN",
                            ICAOCode = "BEL",
                            MainAirport = "Brussels Airport",
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Brussels Airlines"
                        },
                        new
                        {
                            Id = new Guid("c48b695d-0fb0-4867-ab89-21ae9a7f76c0"),
                            AddedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FleetSize = 32,
                            HeadQuarter = "Zaventem, België",
                            IATACode = "TB",
                            ICAOCode = "JAF",
                            MainAirport = "Brussels Airport",
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "TUI Fly"
                        },
                        new
                        {
                            Id = new Guid("6c841066-3347-4da3-90bb-2c9f2fab562a"),
                            AddedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FleetSize = 18,
                            HeadQuarter = "Frankfurt, Duitsland",
                            IATACode = "LH",
                            ICAOCode = "GEC",
                            MainAirport = "Frankfurt am Main",
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Lufthansa Cargo"
                        });
                });

            modelBuilder.Entity("Imi.Project.Api.Core.Entities.Airport", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("AddedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("City")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Country")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int?>("ElevationAMSL")
                        .HasPrecision(4)
                        .HasColumnType("int");

                    b.Property<string>("IATACode")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nchar(3)")
                        .IsFixedLength(true);

                    b.Property<string>("ICAOCode")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nchar(4)")
                        .IsFixedLength(true);

                    b.Property<DateTime>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int?>("RunwayAmount")
                        .HasPrecision(2)
                        .HasColumnType("int");

                    b.Property<int?>("TerminalAmount")
                        .HasPrecision(2)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Airports");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c7e75a35-a2e4-45cb-920f-c2d3f58073a5"),
                            AddedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            City = "Zaventem",
                            Country = "België",
                            ElevationAMSL = 56,
                            IATACode = "BRU",
                            ICAOCode = "EBBR",
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Brussels Airport",
                            RunwayAmount = 3,
                            TerminalAmount = 1
                        },
                        new
                        {
                            Id = new Guid("ae23c91d-dc3f-4076-bdf6-05c8043bcb89"),
                            AddedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            City = "Nice",
                            Country = "Frankrijk",
                            ElevationAMSL = 4,
                            IATACode = "NCE",
                            ICAOCode = "LFMN",
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Nice Côte d'Azur",
                            RunwayAmount = 2,
                            TerminalAmount = 3
                        },
                        new
                        {
                            Id = new Guid("cd552240-5afe-4bb4-a4d1-0e6ef0b39110"),
                            AddedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            City = "Narita",
                            Country = "japan",
                            ElevationAMSL = 41,
                            IATACode = "NRT",
                            ICAOCode = "RJAA",
                            ModifiedOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Tokyo Narita Intl. Airport",
                            RunwayAmount = 2,
                            TerminalAmount = 3
                        });
                });

            modelBuilder.Entity("Imi.Project.Api.Core.Entities.Aircraft", b =>
                {
                    b.HasOne("Imi.Project.Api.Core.Entities.AircraftType", "AircraftType")
                        .WithMany("Aircrafts")
                        .HasForeignKey("AircraftTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Imi.Project.Api.Core.Entities.Airline", "Airline")
                        .WithMany("Aircrafts")
                        .HasForeignKey("AirlineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AircraftType");

                    b.Navigation("Airline");
                });

            modelBuilder.Entity("Imi.Project.Api.Core.Entities.AircraftAtAirport", b =>
                {
                    b.HasOne("Imi.Project.Api.Core.Entities.Aircraft", "Aircraft")
                        .WithMany("SpottedAtAirports")
                        .HasForeignKey("AircraftId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Imi.Project.Api.Core.Entities.Airport", "Airport")
                        .WithMany("AircraftsAtAirport")
                        .HasForeignKey("AirportId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Aircraft");

                    b.Navigation("Airport");
                });

            modelBuilder.Entity("Imi.Project.Api.Core.Entities.Aircraft", b =>
                {
                    b.Navigation("SpottedAtAirports");
                });

            modelBuilder.Entity("Imi.Project.Api.Core.Entities.AircraftType", b =>
                {
                    b.Navigation("Aircrafts");
                });

            modelBuilder.Entity("Imi.Project.Api.Core.Entities.Airline", b =>
                {
                    b.Navigation("Aircrafts");
                });

            modelBuilder.Entity("Imi.Project.Api.Core.Entities.Airport", b =>
                {
                    b.Navigation("AircraftsAtAirport");
                });
#pragma warning restore 612, 618
        }
    }
}
