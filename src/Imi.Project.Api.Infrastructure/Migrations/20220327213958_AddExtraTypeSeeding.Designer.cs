// <auto-generated />
using System;
using Imi.Project.Api.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Imi.Project.Api.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220327213958_AddExtraTypeSeeding")]
    partial class AddExtraTypeSeeding
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
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
                        .HasColumnType("float");

                    b.Property<double?>("Longitude")
                        .HasColumnType("float");

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
                            Id = new Guid("adb44fc9-9234-4f02-9dc0-dcb245eda784"),
                            AddedOn = new DateTime(2022, 3, 27, 23, 39, 57, 797, DateTimeKind.Local).AddTicks(1701),
                            AircraftTypeId = new Guid("56a340ed-4eda-424c-b2ea-20662fa20b25"),
                            AirlineId = new Guid("92f346d7-d3eb-45df-9f11-f5befb7699ba"),
                            FirstSeen = new DateTime(2021, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HasSpecialLivery = false,
                            LastSeen = new DateTime(2021, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ModifiedOn = new DateTime(2022, 3, 27, 23, 39, 57, 797, DateTimeKind.Local).AddTicks(1720),
                            Registration = "OO-SNJ"
                        },
                        new
                        {
                            Id = new Guid("3e96733e-cb1f-449f-9e1a-fbeca40001a4"),
                            AddedOn = new DateTime(2022, 3, 27, 23, 39, 57, 797, DateTimeKind.Local).AddTicks(1738),
                            AircraftTypeId = new Guid("63934e63-c16f-4dcd-824b-a69c5a33aa15"),
                            AirlineId = new Guid("9e2ab0b8-a1e7-4993-b2f5-5253c9735456"),
                            FirstSeen = new DateTime(2020, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HasSpecialLivery = false,
                            LastSeen = new DateTime(2021, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ModifiedOn = new DateTime(2022, 3, 27, 23, 39, 57, 797, DateTimeKind.Local).AddTicks(1742),
                            Registration = "OO-LOE"
                        },
                        new
                        {
                            Id = new Guid("789d6e24-033b-4a78-8038-2056afdb27c1"),
                            AddedOn = new DateTime(2022, 3, 27, 23, 39, 57, 797, DateTimeKind.Local).AddTicks(1750),
                            AircraftTypeId = new Guid("4eb5e5db-7940-46f6-8005-748107cfa5ad"),
                            AirlineId = new Guid("e5eccbe3-c8c0-47f4-86ba-94bc7b835127"),
                            FirstSeen = new DateTime(2020, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HasSpecialLivery = false,
                            LastSeen = new DateTime(2021, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ModifiedOn = new DateTime(2022, 3, 27, 23, 39, 57, 797, DateTimeKind.Local).AddTicks(1754),
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

                    b.HasData(
                        new
                        {
                            AircraftId = new Guid("adb44fc9-9234-4f02-9dc0-dcb245eda784"),
                            AirportId = new Guid("5ce20fa6-abf7-4a25-adfb-9fc1d4bf0168")
                        },
                        new
                        {
                            AircraftId = new Guid("adb44fc9-9234-4f02-9dc0-dcb245eda784"),
                            AirportId = new Guid("09128316-01a3-4c14-a648-a688427be81c")
                        },
                        new
                        {
                            AircraftId = new Guid("adb44fc9-9234-4f02-9dc0-dcb245eda784"),
                            AirportId = new Guid("d9814a1d-9508-4659-8bd3-d91bce395159")
                        },
                        new
                        {
                            AircraftId = new Guid("3e96733e-cb1f-449f-9e1a-fbeca40001a4"),
                            AirportId = new Guid("5ce20fa6-abf7-4a25-adfb-9fc1d4bf0168")
                        },
                        new
                        {
                            AircraftId = new Guid("3e96733e-cb1f-449f-9e1a-fbeca40001a4"),
                            AirportId = new Guid("09128316-01a3-4c14-a648-a688427be81c")
                        },
                        new
                        {
                            AircraftId = new Guid("789d6e24-033b-4a78-8038-2056afdb27c1"),
                            AirportId = new Guid("d9814a1d-9508-4659-8bd3-d91bce395159")
                        });
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
                        .HasColumnType("int");

                    b.Property<DateTime?>("FirstFlight")
                        .HasColumnType("datetime2");

                    b.Property<double?>("Height")
                        .HasColumnType("float");

                    b.Property<string>("ICAOCode")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nchar(4)")
                        .IsFixedLength(true);

                    b.Property<double?>("Length")
                        .HasColumnType("float");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<double?>("WingSpan")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("AircraftTypes");

                    b.HasData(
                        new
                        {
                            Id = new Guid("56a340ed-4eda-424c-b2ea-20662fa20b25"),
                            AddedOn = new DateTime(2022, 3, 27, 23, 39, 57, 791, DateTimeKind.Local).AddTicks(23),
                            Brand = "Airbus",
                            EmptyWeight = 42400,
                            FirstFlight = new DateTime(1987, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Height = 11.76,
                            ICAOCode = "A320",
                            Length = 37.57,
                            ModifiedOn = new DateTime(2022, 3, 27, 23, 39, 57, 796, DateTimeKind.Local).AddTicks(708),
                            Type = "A320-200",
                            WingSpan = 34.100000000000001
                        },
                        new
                        {
                            Id = new Guid("63934e63-c16f-4dcd-824b-a69c5a33aa15"),
                            AddedOn = new DateTime(2022, 3, 27, 23, 39, 57, 796, DateTimeKind.Local).AddTicks(1519),
                            Brand = "Boeing",
                            EmptyWeight = 118000,
                            FirstFlight = new DateTime(2009, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Height = 16.899999999999999,
                            ICAOCode = "B788",
                            Length = 56.700000000000003,
                            ModifiedOn = new DateTime(2022, 3, 27, 23, 39, 57, 796, DateTimeKind.Local).AddTicks(1538),
                            Type = "787-8",
                            WingSpan = 60.100000000000001
                        },
                        new
                        {
                            Id = new Guid("4eb5e5db-7940-46f6-8005-748107cfa5ad"),
                            AddedOn = new DateTime(2022, 3, 27, 23, 39, 57, 796, DateTimeKind.Local).AddTicks(1560),
                            Brand = "McDonnel Douglas",
                            EmptyWeight = 112748,
                            FirstFlight = new DateTime(1990, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Height = 17.600000000000001,
                            ICAOCode = "MD11",
                            Length = 61.399999999999999,
                            ModifiedOn = new DateTime(2022, 3, 27, 23, 39, 57, 796, DateTimeKind.Local).AddTicks(1565),
                            Type = "MD-11",
                            WingSpan = 51.700000000000003
                        },
                        new
                        {
                            Id = new Guid("7b9f4f05-3f05-40a9-93cf-9c87574e36e6"),
                            AddedOn = new DateTime(2022, 3, 27, 23, 39, 57, 796, DateTimeKind.Local).AddTicks(1578),
                            Brand = "Airbus",
                            EmptyWeight = 35220,
                            FirstFlight = new DateTime(2013, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Height = 11.5,
                            ICAOCode = "BCS1",
                            Length = 35.0,
                            ModifiedOn = new DateTime(2022, 3, 27, 23, 39, 57, 796, DateTimeKind.Local).AddTicks(1582),
                            Type = "A220-100",
                            WingSpan = 35.100000000000001
                        },
                        new
                        {
                            Id = new Guid("55f54bea-fb20-4bfd-bc0d-e0f9d7f1503c"),
                            AddedOn = new DateTime(2022, 3, 27, 23, 39, 57, 796, DateTimeKind.Local).AddTicks(1595),
                            Brand = "Airbus",
                            EmptyWeight = 37080,
                            FirstFlight = new DateTime(2015, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Height = 11.5,
                            ICAOCode = "BCS3",
                            Length = 38.710000000000001,
                            ModifiedOn = new DateTime(2022, 3, 27, 23, 39, 57, 796, DateTimeKind.Local).AddTicks(1600),
                            Type = "A220-300",
                            WingSpan = 35.100000000000001
                        },
                        new
                        {
                            Id = new Guid("83077924-814a-4d84-9a92-c8dce3575281"),
                            AddedOn = new DateTime(2022, 3, 27, 23, 39, 57, 796, DateTimeKind.Local).AddTicks(1610),
                            Brand = "Airbus",
                            EmptyWeight = 40800,
                            FirstFlight = new DateTime(1995, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Height = 11.76,
                            ICAOCode = "A319",
                            Length = 33.840000000000003,
                            ModifiedOn = new DateTime(2022, 3, 27, 23, 39, 57, 796, DateTimeKind.Local).AddTicks(1614),
                            Type = "A319-100",
                            WingSpan = 35.799999999999997
                        },
                        new
                        {
                            Id = new Guid("3c22ac0c-ae43-4999-97ec-06aa3637b866"),
                            AddedOn = new DateTime(2022, 3, 27, 23, 39, 57, 796, DateTimeKind.Local).AddTicks(1626),
                            Brand = "Airbus",
                            EmptyWeight = 131000,
                            FirstFlight = new DateTime(1991, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Height = 16.989999999999998,
                            ICAOCode = "A343",
                            Length = 63.659999999999997,
                            ModifiedOn = new DateTime(2022, 3, 27, 23, 39, 57, 796, DateTimeKind.Local).AddTicks(1631),
                            Type = "A340-300",
                            WingSpan = 60.299999999999997
                        },
                        new
                        {
                            Id = new Guid("dd7afdc9-571d-4805-839d-38076c8343bf"),
                            AddedOn = new DateTime(2022, 3, 27, 23, 39, 57, 796, DateTimeKind.Local).AddTicks(1644),
                            Brand = "Airbus",
                            EmptyWeight = 155000,
                            FirstFlight = new DateTime(2016, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Height = 17.079999999999998,
                            ICAOCode = "A35K",
                            Length = 73.790000000000006,
                            ModifiedOn = new DateTime(2022, 3, 27, 23, 39, 57, 796, DateTimeKind.Local).AddTicks(1648),
                            Type = "A350-1000",
                            WingSpan = 64.75
                        },
                        new
                        {
                            Id = new Guid("a7cfc3e9-241a-43a0-9271-fc244be11781"),
                            AddedOn = new DateTime(2022, 3, 27, 23, 39, 57, 796, DateTimeKind.Local).AddTicks(1674),
                            Brand = "Airbus",
                            EmptyWeight = 277145,
                            FirstFlight = new DateTime(2005, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Height = 24.09,
                            ICAOCode = "A388",
                            Length = 72.719999999999999,
                            ModifiedOn = new DateTime(2022, 3, 27, 23, 39, 57, 796, DateTimeKind.Local).AddTicks(1678),
                            Type = "A380-800",
                            WingSpan = 79.75
                        },
                        new
                        {
                            Id = new Guid("7b66dc3e-fb34-45c9-aff4-c06464928d7f"),
                            AddedOn = new DateTime(2022, 3, 27, 23, 39, 57, 796, DateTimeKind.Local).AddTicks(1691),
                            Brand = "Boeing",
                            EmptyWeight = 197100,
                            FirstFlight = new DateTime(2010, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Height = 19.399999999999999,
                            ICAOCode = "B748",
                            Length = 76.299999999999997,
                            ModifiedOn = new DateTime(2022, 3, 27, 23, 39, 57, 796, DateTimeKind.Local).AddTicks(1695),
                            Type = "747-8",
                            WingSpan = 68.400000000000006
                        },
                        new
                        {
                            Id = new Guid("02fa61ed-ab6b-4c56-b8dc-a81e4c887847"),
                            AddedOn = new DateTime(2022, 3, 27, 23, 39, 57, 796, DateTimeKind.Local).AddTicks(1707),
                            Brand = "Boeing",
                            EmptyWeight = 167829,
                            FirstFlight = new DateTime(2003, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Height = 18.5,
                            ICAOCode = "B77W",
                            Length = 73.859999999999999,
                            ModifiedOn = new DateTime(2022, 3, 27, 23, 39, 57, 796, DateTimeKind.Local).AddTicks(1712),
                            Type = "777-300ER",
                            WingSpan = 64.799999999999997
                        },
                        new
                        {
                            Id = new Guid("8b880175-fa1a-42c7-888a-1a3a3df9633e"),
                            AddedOn = new DateTime(2022, 3, 27, 23, 39, 57, 796, DateTimeKind.Local).AddTicks(1723),
                            Brand = "Boeing",
                            EmptyWeight = 128850,
                            FirstFlight = new DateTime(2013, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Height = 17.02,
                            ICAOCode = "B789",
                            Length = 62.810000000000002,
                            ModifiedOn = new DateTime(2022, 3, 27, 23, 39, 57, 796, DateTimeKind.Local).AddTicks(1727),
                            Type = "787-9",
                            WingSpan = 60.119999999999997
                        },
                        new
                        {
                            Id = new Guid("b101b724-9cde-40b1-9407-a33cf9ba73d8"),
                            AddedOn = new DateTime(2022, 3, 27, 23, 39, 57, 796, DateTimeKind.Local).AddTicks(1739),
                            Brand = "Embraer",
                            EmptyWeight = 27837,
                            FirstFlight = new DateTime(2004, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Height = 10.57,
                            ICAOCode = "E190",
                            Length = 36.25,
                            ModifiedOn = new DateTime(2022, 3, 27, 23, 39, 57, 796, DateTimeKind.Local).AddTicks(1744),
                            Type = "E190",
                            WingSpan = 28.73
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
                            Id = new Guid("92f346d7-d3eb-45df-9f11-f5befb7699ba"),
                            AddedOn = new DateTime(2022, 3, 27, 23, 39, 57, 796, DateTimeKind.Local).AddTicks(4724),
                            FleetSize = 49,
                            HeadQuarter = "Diegem, België",
                            IATACode = "SN",
                            ICAOCode = "BEL",
                            MainAirport = "Brussels Airport",
                            ModifiedOn = new DateTime(2022, 3, 27, 23, 39, 57, 796, DateTimeKind.Local).AddTicks(4742),
                            Name = "Brussels Airlines"
                        },
                        new
                        {
                            Id = new Guid("9e2ab0b8-a1e7-4993-b2f5-5253c9735456"),
                            AddedOn = new DateTime(2022, 3, 27, 23, 39, 57, 796, DateTimeKind.Local).AddTicks(4759),
                            FleetSize = 32,
                            HeadQuarter = "Zaventem, België",
                            IATACode = "TB",
                            ICAOCode = "JAF",
                            MainAirport = "Brussels Airport",
                            ModifiedOn = new DateTime(2022, 3, 27, 23, 39, 57, 796, DateTimeKind.Local).AddTicks(4763),
                            Name = "TUI Fly"
                        },
                        new
                        {
                            Id = new Guid("e5eccbe3-c8c0-47f4-86ba-94bc7b835127"),
                            AddedOn = new DateTime(2022, 3, 27, 23, 39, 57, 796, DateTimeKind.Local).AddTicks(4769),
                            FleetSize = 18,
                            HeadQuarter = "Frankfurt, Duitsland",
                            IATACode = "LH",
                            ICAOCode = "GEC",
                            MainAirport = "Frankfurt am Main",
                            ModifiedOn = new DateTime(2022, 3, 27, 23, 39, 57, 796, DateTimeKind.Local).AddTicks(4773),
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
                            Id = new Guid("5ce20fa6-abf7-4a25-adfb-9fc1d4bf0168"),
                            AddedOn = new DateTime(2022, 3, 27, 23, 39, 57, 796, DateTimeKind.Local).AddTicks(8270),
                            City = "Zaventem",
                            Country = "België",
                            ElevationAMSL = 56,
                            IATACode = "BRU",
                            ICAOCode = "EBBR",
                            ModifiedOn = new DateTime(2022, 3, 27, 23, 39, 57, 796, DateTimeKind.Local).AddTicks(8288),
                            Name = "Brussels Airport",
                            RunwayAmount = 3,
                            TerminalAmount = 1
                        },
                        new
                        {
                            Id = new Guid("09128316-01a3-4c14-a648-a688427be81c"),
                            AddedOn = new DateTime(2022, 3, 27, 23, 39, 57, 796, DateTimeKind.Local).AddTicks(8304),
                            City = "Nice",
                            Country = "Frankrijk",
                            ElevationAMSL = 4,
                            IATACode = "NCE",
                            ICAOCode = "LFMN",
                            ModifiedOn = new DateTime(2022, 3, 27, 23, 39, 57, 796, DateTimeKind.Local).AddTicks(8308),
                            Name = "Nice Côte d'Azur",
                            RunwayAmount = 2,
                            TerminalAmount = 3
                        },
                        new
                        {
                            Id = new Guid("d9814a1d-9508-4659-8bd3-d91bce395159"),
                            AddedOn = new DateTime(2022, 3, 27, 23, 39, 57, 796, DateTimeKind.Local).AddTicks(8315),
                            City = "Narita",
                            Country = "japan",
                            ElevationAMSL = 41,
                            IATACode = "NRT",
                            ICAOCode = "RJAA",
                            ModifiedOn = new DateTime(2022, 3, 27, 23, 39, 57, 796, DateTimeKind.Local).AddTicks(8319),
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
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Imi.Project.Api.Core.Entities.Airline", "Airline")
                        .WithMany("Aircrafts")
                        .HasForeignKey("AirlineId")
                        .OnDelete(DeleteBehavior.Restrict)
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
