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

                    b.Property<DateTime?>("AddedOn")
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

                    b.Property<DateTime?>("ModifiedOn")
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
                            Id = new Guid("059fd843-b72a-489f-90ff-e4c9d420f5b1"),
                            AddedOn = new DateTime(2022, 3, 17, 13, 21, 27, 271, DateTimeKind.Local).AddTicks(1520),
                            AircraftTypeId = new Guid("88e02962-1877-42e6-ae7c-59d2a8d90bdb"),
                            AirlineId = new Guid("b56e1c5d-ae9f-4720-9962-096ac38f8e99"),
                            FirstSeen = new DateTime(2021, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HasSpecialLivery = false,
                            LastSeen = new DateTime(2021, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ModifiedOn = new DateTime(2022, 3, 17, 13, 21, 27, 271, DateTimeKind.Local).AddTicks(1538),
                            Registration = "OO-SNJ"
                        },
                        new
                        {
                            Id = new Guid("4e91be6b-1477-47ac-8fc6-9777fb2bec5a"),
                            AddedOn = new DateTime(2022, 3, 17, 13, 21, 27, 271, DateTimeKind.Local).AddTicks(1557),
                            AircraftTypeId = new Guid("b12f19d6-fa95-41a3-b44e-e2c327b12da1"),
                            AirlineId = new Guid("04a65fd0-ead5-49f9-bbde-9c93026d42bd"),
                            FirstSeen = new DateTime(2020, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HasSpecialLivery = false,
                            LastSeen = new DateTime(2021, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ModifiedOn = new DateTime(2022, 3, 17, 13, 21, 27, 271, DateTimeKind.Local).AddTicks(1560),
                            Registration = "OO-LOE"
                        },
                        new
                        {
                            Id = new Guid("e1c0ab7f-58ff-43ba-981e-cef16440bf9f"),
                            AddedOn = new DateTime(2022, 3, 17, 13, 21, 27, 271, DateTimeKind.Local).AddTicks(1569),
                            AircraftTypeId = new Guid("1221259b-c372-466a-9162-0af0bcf2d78b"),
                            AirlineId = new Guid("1f482fc7-44e4-4d22-b3be-13f883011a71"),
                            FirstSeen = new DateTime(2020, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HasSpecialLivery = false,
                            LastSeen = new DateTime(2021, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ModifiedOn = new DateTime(2022, 3, 17, 13, 21, 27, 271, DateTimeKind.Local).AddTicks(1572),
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

                    b.Property<DateTime?>("AddedOn")
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

                    b.Property<DateTime?>("ModifiedOn")
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
                            Id = new Guid("88e02962-1877-42e6-ae7c-59d2a8d90bdb"),
                            AddedOn = new DateTime(2022, 3, 17, 13, 21, 27, 264, DateTimeKind.Local).AddTicks(4601),
                            Brand = "Airbus",
                            EmptyWeight = 42400,
                            FirstFlight = new DateTime(1987, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Height = 11.76,
                            ICAOCode = "A320",
                            Length = 37.57,
                            ModifiedOn = new DateTime(2022, 3, 17, 13, 21, 27, 270, DateTimeKind.Local).AddTicks(564),
                            Type = "A320-200",
                            WingSpan = 34.100000000000001
                        },
                        new
                        {
                            Id = new Guid("b12f19d6-fa95-41a3-b44e-e2c327b12da1"),
                            AddedOn = new DateTime(2022, 3, 17, 13, 21, 27, 270, DateTimeKind.Local).AddTicks(1420),
                            Brand = "Boeing",
                            EmptyWeight = 118000,
                            FirstFlight = new DateTime(2009, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Height = 16.899999999999999,
                            ICAOCode = "B788",
                            Length = 56.700000000000003,
                            ModifiedOn = new DateTime(2022, 3, 17, 13, 21, 27, 270, DateTimeKind.Local).AddTicks(1437),
                            Type = "787-8",
                            WingSpan = 60.100000000000001
                        },
                        new
                        {
                            Id = new Guid("1221259b-c372-466a-9162-0af0bcf2d78b"),
                            AddedOn = new DateTime(2022, 3, 17, 13, 21, 27, 270, DateTimeKind.Local).AddTicks(1459),
                            Brand = "McDonnel Douglas",
                            EmptyWeight = 112748,
                            FirstFlight = new DateTime(1990, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Height = 17.600000000000001,
                            ICAOCode = "MD11",
                            Length = 61.399999999999999,
                            ModifiedOn = new DateTime(2022, 3, 17, 13, 21, 27, 270, DateTimeKind.Local).AddTicks(1464),
                            Type = "MD-11",
                            WingSpan = 51.700000000000003
                        });
                });

            modelBuilder.Entity("Imi.Project.Api.Core.Entities.Airline", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("AddedOn")
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

                    b.Property<DateTime?>("ModifiedOn")
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
                            Id = new Guid("b56e1c5d-ae9f-4720-9962-096ac38f8e99"),
                            AddedOn = new DateTime(2022, 3, 17, 13, 21, 27, 270, DateTimeKind.Local).AddTicks(4527),
                            FleetSize = 49,
                            HeadQuarter = "Diegem, België",
                            IATACode = "SN",
                            ICAOCode = "BEL",
                            MainAirport = "Brussels Airport",
                            ModifiedOn = new DateTime(2022, 3, 17, 13, 21, 27, 270, DateTimeKind.Local).AddTicks(4545),
                            Name = "Brussels Airlines"
                        },
                        new
                        {
                            Id = new Guid("04a65fd0-ead5-49f9-bbde-9c93026d42bd"),
                            AddedOn = new DateTime(2022, 3, 17, 13, 21, 27, 270, DateTimeKind.Local).AddTicks(4561),
                            FleetSize = 32,
                            HeadQuarter = "Zaventem, België",
                            IATACode = "TB",
                            ICAOCode = "JAF",
                            MainAirport = "Brussels Airport",
                            ModifiedOn = new DateTime(2022, 3, 17, 13, 21, 27, 270, DateTimeKind.Local).AddTicks(4565),
                            Name = "TUI Fly"
                        },
                        new
                        {
                            Id = new Guid("1f482fc7-44e4-4d22-b3be-13f883011a71"),
                            AddedOn = new DateTime(2022, 3, 17, 13, 21, 27, 270, DateTimeKind.Local).AddTicks(4583),
                            FleetSize = 18,
                            HeadQuarter = "Frankfurt, Duitsland",
                            IATACode = "LH",
                            ICAOCode = "GEC",
                            MainAirport = "Frankfurt am Main",
                            ModifiedOn = new DateTime(2022, 3, 17, 13, 21, 27, 270, DateTimeKind.Local).AddTicks(4587),
                            Name = "Lufthansa Cargo"
                        });
                });

            modelBuilder.Entity("Imi.Project.Api.Core.Entities.Airport", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("AddedOn")
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

                    b.Property<DateTime?>("ModifiedOn")
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
                            Id = new Guid("b6b302d0-e135-4516-901a-077c20a7ed74"),
                            AddedOn = new DateTime(2022, 3, 17, 13, 21, 27, 270, DateTimeKind.Local).AddTicks(8189),
                            City = "Zaventem",
                            Country = "België",
                            ElevationAMSL = 56,
                            IATACode = "BRU",
                            ICAOCode = "EBBR",
                            ModifiedOn = new DateTime(2022, 3, 17, 13, 21, 27, 270, DateTimeKind.Local).AddTicks(8208),
                            Name = "Brussels Airport",
                            RunwayAmount = 3,
                            TerminalAmount = 1
                        },
                        new
                        {
                            Id = new Guid("eb6091cf-7f90-4380-9fab-54075748ab6f"),
                            AddedOn = new DateTime(2022, 3, 17, 13, 21, 27, 270, DateTimeKind.Local).AddTicks(8224),
                            City = "Nice",
                            Country = "Frankrijk",
                            ElevationAMSL = 4,
                            IATACode = "NCE",
                            ICAOCode = "LFMN",
                            ModifiedOn = new DateTime(2022, 3, 17, 13, 21, 27, 270, DateTimeKind.Local).AddTicks(8228),
                            Name = "Nice Côte d'Azur",
                            RunwayAmount = 2,
                            TerminalAmount = 3
                        },
                        new
                        {
                            Id = new Guid("290a3080-1d18-429b-a205-2b9d042a2372"),
                            AddedOn = new DateTime(2022, 3, 17, 13, 21, 27, 270, DateTimeKind.Local).AddTicks(8236),
                            City = "Narita",
                            Country = "japan",
                            ElevationAMSL = 41,
                            IATACode = "NRT",
                            ICAOCode = "RJAA",
                            ModifiedOn = new DateTime(2022, 3, 17, 13, 21, 27, 270, DateTimeKind.Local).AddTicks(8240),
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
