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
                            Id = new Guid("5c323051-fbe9-460a-91d6-94dbde327edd"),
                            AddedOn = new DateTime(2022, 3, 25, 17, 42, 38, 602, DateTimeKind.Local).AddTicks(8241),
                            AircraftTypeId = new Guid("1367842b-64e4-4eef-99ff-c0532e970857"),
                            AirlineId = new Guid("a82cd063-4c17-4fa6-8529-f2f146f0114c"),
                            FirstSeen = new DateTime(2021, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HasSpecialLivery = false,
                            LastSeen = new DateTime(2021, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ModifiedOn = new DateTime(2022, 3, 25, 17, 42, 38, 602, DateTimeKind.Local).AddTicks(8259),
                            Registration = "OO-SNJ"
                        },
                        new
                        {
                            Id = new Guid("956a73ad-423c-4dab-93bf-6ae177ca028d"),
                            AddedOn = new DateTime(2022, 3, 25, 17, 42, 38, 602, DateTimeKind.Local).AddTicks(8277),
                            AircraftTypeId = new Guid("99193d2c-6c76-4b34-aac8-994b39125a99"),
                            AirlineId = new Guid("92c70a1d-e55a-4e36-a504-1c477c3c4b1c"),
                            FirstSeen = new DateTime(2020, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HasSpecialLivery = false,
                            LastSeen = new DateTime(2021, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ModifiedOn = new DateTime(2022, 3, 25, 17, 42, 38, 602, DateTimeKind.Local).AddTicks(8281),
                            Registration = "OO-LOE"
                        },
                        new
                        {
                            Id = new Guid("3b169fe6-2105-4dcb-bf0c-f7433b3ec7fd"),
                            AddedOn = new DateTime(2022, 3, 25, 17, 42, 38, 602, DateTimeKind.Local).AddTicks(8288),
                            AircraftTypeId = new Guid("f10b801f-ef2d-481b-9cfe-4bfe6182a832"),
                            AirlineId = new Guid("8b8e3891-9fff-4a9c-94f4-28f357e83ac0"),
                            FirstSeen = new DateTime(2020, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            HasSpecialLivery = false,
                            LastSeen = new DateTime(2021, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ModifiedOn = new DateTime(2022, 3, 25, 17, 42, 38, 602, DateTimeKind.Local).AddTicks(8291),
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
                            AircraftId = new Guid("5c323051-fbe9-460a-91d6-94dbde327edd"),
                            AirportId = new Guid("e48a2d3d-2590-4612-b81d-8abb68ca8263")
                        },
                        new
                        {
                            AircraftId = new Guid("5c323051-fbe9-460a-91d6-94dbde327edd"),
                            AirportId = new Guid("e2be3bd6-4c7b-41f4-a5c8-a1940310ea7d")
                        },
                        new
                        {
                            AircraftId = new Guid("5c323051-fbe9-460a-91d6-94dbde327edd"),
                            AirportId = new Guid("d8806f32-bf51-4b76-8c4f-37e0f532a6a7")
                        },
                        new
                        {
                            AircraftId = new Guid("956a73ad-423c-4dab-93bf-6ae177ca028d"),
                            AirportId = new Guid("e48a2d3d-2590-4612-b81d-8abb68ca8263")
                        },
                        new
                        {
                            AircraftId = new Guid("956a73ad-423c-4dab-93bf-6ae177ca028d"),
                            AirportId = new Guid("e2be3bd6-4c7b-41f4-a5c8-a1940310ea7d")
                        },
                        new
                        {
                            AircraftId = new Guid("3b169fe6-2105-4dcb-bf0c-f7433b3ec7fd"),
                            AirportId = new Guid("d8806f32-bf51-4b76-8c4f-37e0f532a6a7")
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
                            Id = new Guid("1367842b-64e4-4eef-99ff-c0532e970857"),
                            AddedOn = new DateTime(2022, 3, 25, 17, 42, 38, 596, DateTimeKind.Local).AddTicks(3642),
                            Brand = "Airbus",
                            EmptyWeight = 42400,
                            FirstFlight = new DateTime(1987, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Height = 11.76,
                            ICAOCode = "A320",
                            Length = 37.57,
                            ModifiedOn = new DateTime(2022, 3, 25, 17, 42, 38, 601, DateTimeKind.Local).AddTicks(7386),
                            Type = "A320-200",
                            WingSpan = 34.100000000000001
                        },
                        new
                        {
                            Id = new Guid("99193d2c-6c76-4b34-aac8-994b39125a99"),
                            AddedOn = new DateTime(2022, 3, 25, 17, 42, 38, 601, DateTimeKind.Local).AddTicks(8234),
                            Brand = "Boeing",
                            EmptyWeight = 118000,
                            FirstFlight = new DateTime(2009, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Height = 16.899999999999999,
                            ICAOCode = "B788",
                            Length = 56.700000000000003,
                            ModifiedOn = new DateTime(2022, 3, 25, 17, 42, 38, 601, DateTimeKind.Local).AddTicks(8252),
                            Type = "787-8",
                            WingSpan = 60.100000000000001
                        },
                        new
                        {
                            Id = new Guid("f10b801f-ef2d-481b-9cfe-4bfe6182a832"),
                            AddedOn = new DateTime(2022, 3, 25, 17, 42, 38, 601, DateTimeKind.Local).AddTicks(8278),
                            Brand = "McDonnel Douglas",
                            EmptyWeight = 112748,
                            FirstFlight = new DateTime(1990, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Height = 17.600000000000001,
                            ICAOCode = "MD11",
                            Length = 61.399999999999999,
                            ModifiedOn = new DateTime(2022, 3, 25, 17, 42, 38, 601, DateTimeKind.Local).AddTicks(8282),
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
                            Id = new Guid("a82cd063-4c17-4fa6-8529-f2f146f0114c"),
                            AddedOn = new DateTime(2022, 3, 25, 17, 42, 38, 602, DateTimeKind.Local).AddTicks(1308),
                            FleetSize = 49,
                            HeadQuarter = "Diegem, België",
                            IATACode = "SN",
                            ICAOCode = "BEL",
                            MainAirport = "Brussels Airport",
                            ModifiedOn = new DateTime(2022, 3, 25, 17, 42, 38, 602, DateTimeKind.Local).AddTicks(1326),
                            Name = "Brussels Airlines"
                        },
                        new
                        {
                            Id = new Guid("92c70a1d-e55a-4e36-a504-1c477c3c4b1c"),
                            AddedOn = new DateTime(2022, 3, 25, 17, 42, 38, 602, DateTimeKind.Local).AddTicks(1344),
                            FleetSize = 32,
                            HeadQuarter = "Zaventem, België",
                            IATACode = "TB",
                            ICAOCode = "JAF",
                            MainAirport = "Brussels Airport",
                            ModifiedOn = new DateTime(2022, 3, 25, 17, 42, 38, 602, DateTimeKind.Local).AddTicks(1347),
                            Name = "TUI Fly"
                        },
                        new
                        {
                            Id = new Guid("8b8e3891-9fff-4a9c-94f4-28f357e83ac0"),
                            AddedOn = new DateTime(2022, 3, 25, 17, 42, 38, 602, DateTimeKind.Local).AddTicks(1353),
                            FleetSize = 18,
                            HeadQuarter = "Frankfurt, Duitsland",
                            IATACode = "LH",
                            ICAOCode = "GEC",
                            MainAirport = "Frankfurt am Main",
                            ModifiedOn = new DateTime(2022, 3, 25, 17, 42, 38, 602, DateTimeKind.Local).AddTicks(1357),
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
                            Id = new Guid("e48a2d3d-2590-4612-b81d-8abb68ca8263"),
                            AddedOn = new DateTime(2022, 3, 25, 17, 42, 38, 602, DateTimeKind.Local).AddTicks(4901),
                            City = "Zaventem",
                            Country = "België",
                            ElevationAMSL = 56,
                            IATACode = "BRU",
                            ICAOCode = "EBBR",
                            ModifiedOn = new DateTime(2022, 3, 25, 17, 42, 38, 602, DateTimeKind.Local).AddTicks(4919),
                            Name = "Brussels Airport",
                            RunwayAmount = 3,
                            TerminalAmount = 1
                        },
                        new
                        {
                            Id = new Guid("e2be3bd6-4c7b-41f4-a5c8-a1940310ea7d"),
                            AddedOn = new DateTime(2022, 3, 25, 17, 42, 38, 602, DateTimeKind.Local).AddTicks(4936),
                            City = "Nice",
                            Country = "Frankrijk",
                            ElevationAMSL = 4,
                            IATACode = "NCE",
                            ICAOCode = "LFMN",
                            ModifiedOn = new DateTime(2022, 3, 25, 17, 42, 38, 602, DateTimeKind.Local).AddTicks(4940),
                            Name = "Nice Côte d'Azur",
                            RunwayAmount = 2,
                            TerminalAmount = 3
                        },
                        new
                        {
                            Id = new Guid("d8806f32-bf51-4b76-8c4f-37e0f532a6a7"),
                            AddedOn = new DateTime(2022, 3, 25, 17, 42, 38, 602, DateTimeKind.Local).AddTicks(4947),
                            City = "Narita",
                            Country = "japan",
                            ElevationAMSL = 41,
                            IATACode = "NRT",
                            ICAOCode = "RJAA",
                            ModifiedOn = new DateTime(2022, 3, 25, 17, 42, 38, 602, DateTimeKind.Local).AddTicks(4951),
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
