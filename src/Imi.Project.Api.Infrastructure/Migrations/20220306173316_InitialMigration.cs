using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Imi.Project.Api.Infrastructure.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AircraftTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ICAOCode = table.Column<string>(type: "nchar(4)", fixedLength: true, maxLength: 4, nullable: false),
                    FirstFlight = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Length = table.Column<double>(type: "float(5)", precision: 5, scale: 2, nullable: true),
                    WingSpan = table.Column<double>(type: "float(5)", precision: 5, scale: 2, nullable: true),
                    Height = table.Column<double>(type: "float(5)", precision: 5, scale: 2, nullable: true),
                    EmptyWeight = table.Column<int>(type: "int", precision: 6, nullable: true),
                    AddedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AircraftTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Airlines",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    IATACode = table.Column<string>(type: "nchar(2)", fixedLength: true, maxLength: 2, nullable: false),
                    ICAOCode = table.Column<string>(type: "nchar(3)", fixedLength: true, maxLength: 3, nullable: false),
                    MainAirport = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    HeadQuarter = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    FleetSize = table.Column<int>(type: "int", nullable: true),
                    AddedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Airlines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Airports",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IATACode = table.Column<string>(type: "nchar(3)", fixedLength: true, maxLength: 3, nullable: false),
                    ICAOCode = table.Column<string>(type: "nchar(4)", fixedLength: true, maxLength: 4, nullable: false),
                    ElevationAMSL = table.Column<int>(type: "int", precision: 4, nullable: true),
                    RunwayAmount = table.Column<int>(type: "int", precision: 2, nullable: true),
                    TerminalAmount = table.Column<int>(type: "int", precision: 2, nullable: true),
                    Country = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    City = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    AddedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Airports", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Aircrafts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Registration = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    HasSpecialLivery = table.Column<bool>(type: "bit", nullable: false),
                    FirstSeen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastSeen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Longitude = table.Column<double>(type: "float(8)", precision: 8, scale: 5, nullable: true),
                    Latitude = table.Column<double>(type: "float(8)", precision: 8, scale: 5, nullable: true),
                    AircraftTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AirlineId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AddedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aircrafts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Aircrafts_AircraftTypes_AircraftTypeId",
                        column: x => x.AircraftTypeId,
                        principalTable: "AircraftTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Aircrafts_Airlines_AirlineId",
                        column: x => x.AirlineId,
                        principalTable: "Airlines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AircraftAtAirports",
                columns: table => new
                {
                    AircraftId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AirportId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AircraftAtAirports", x => new { x.AircraftId, x.AirportId });
                    table.ForeignKey(
                        name: "FK_AircraftAtAirports_Aircrafts_AircraftId",
                        column: x => x.AircraftId,
                        principalTable: "Aircrafts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AircraftAtAirports_Airports_AirportId",
                        column: x => x.AirportId,
                        principalTable: "Airports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AircraftTypes",
                columns: new[] { "Id", "AddedOn", "Brand", "EmptyWeight", "FirstFlight", "Height", "ICAOCode", "Length", "ModifiedOn", "Type", "WingSpan" },
                values: new object[,]
                {
                    { new Guid("5551f78b-51f6-4abe-844a-bf0757f064f7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Airbus", 42400, new DateTime(1987, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.76, "A320", 37.57, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A320-200", 34.100000000000001 },
                    { new Guid("e8de0249-2860-4dc3-bad1-12a23787a730"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Boeing", 118000, new DateTime(2009, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 16.899999999999999, "B788", 56.700000000000003, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "787-8", 60.100000000000001 },
                    { new Guid("0074cf33-a3dc-4aee-9eff-faf4b2662b52"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "McDonnel Douglas", 112748, new DateTime(1990, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 17.600000000000001, "MD11", 61.399999999999999, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MD-11", 51.700000000000003 }
                });

            migrationBuilder.InsertData(
                table: "Airlines",
                columns: new[] { "Id", "AddedOn", "FleetSize", "HeadQuarter", "IATACode", "ICAOCode", "MainAirport", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { new Guid("2060867d-622e-48af-b7f7-454fa0b95a1d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 49, "Diegem, België", "SN", "BEL", "Brussels Airport", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brussels Airlines" },
                    { new Guid("c48b695d-0fb0-4867-ab89-21ae9a7f76c0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 32, "Zaventem, België", "TB", "JAF", "Brussels Airport", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "TUI Fly" },
                    { new Guid("6c841066-3347-4da3-90bb-2c9f2fab562a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, "Frankfurt, Duitsland", "LH", "GEC", "Frankfurt am Main", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lufthansa Cargo" }
                });

            migrationBuilder.InsertData(
                table: "Airports",
                columns: new[] { "Id", "AddedOn", "City", "Country", "ElevationAMSL", "IATACode", "ICAOCode", "ModifiedOn", "Name", "RunwayAmount", "TerminalAmount" },
                values: new object[,]
                {
                    { new Guid("c7e75a35-a2e4-45cb-920f-c2d3f58073a5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaventem", "België", 56, "BRU", "EBBR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brussels Airport", 3, 1 },
                    { new Guid("ae23c91d-dc3f-4076-bdf6-05c8043bcb89"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nice", "Frankrijk", 4, "NCE", "LFMN", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nice Côte d'Azur", 2, 3 },
                    { new Guid("cd552240-5afe-4bb4-a4d1-0e6ef0b39110"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Narita", "japan", 41, "NRT", "RJAA", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tokyo Narita Intl. Airport", 2, 3 }
                });

            migrationBuilder.InsertData(
                table: "Aircrafts",
                columns: new[] { "Id", "AddedOn", "AircraftTypeId", "AirlineId", "FirstSeen", "HasSpecialLivery", "Image", "LastSeen", "Latitude", "Longitude", "ModifiedOn", "Registration" },
                values: new object[] { new Guid("7ad87259-0659-4139-9e61-00a6d965b529"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5551f78b-51f6-4abe-844a-bf0757f064f7"), new Guid("2060867d-622e-48af-b7f7-454fa0b95a1d"), new DateTime(2021, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(2021, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "OO-SNJ" });

            migrationBuilder.InsertData(
                table: "Aircrafts",
                columns: new[] { "Id", "AddedOn", "AircraftTypeId", "AirlineId", "FirstSeen", "HasSpecialLivery", "Image", "LastSeen", "Latitude", "Longitude", "ModifiedOn", "Registration" },
                values: new object[] { new Guid("ab1e6496-f389-4b31-817c-f0eff8643b8b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e8de0249-2860-4dc3-bad1-12a23787a730"), new Guid("c48b695d-0fb0-4867-ab89-21ae9a7f76c0"), new DateTime(2020, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(2021, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "OO-LOE" });

            migrationBuilder.InsertData(
                table: "Aircrafts",
                columns: new[] { "Id", "AddedOn", "AircraftTypeId", "AirlineId", "FirstSeen", "HasSpecialLivery", "Image", "LastSeen", "Latitude", "Longitude", "ModifiedOn", "Registration" },
                values: new object[] { new Guid("b08f5c5a-0273-4ed7-bd8e-fada782fed7c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0074cf33-a3dc-4aee-9eff-faf4b2662b52"), new Guid("6c841066-3347-4da3-90bb-2c9f2fab562a"), new DateTime(2020, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(2021, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "D-ALCC" });

            migrationBuilder.CreateIndex(
                name: "IX_AircraftAtAirports_AirportId",
                table: "AircraftAtAirports",
                column: "AirportId");

            migrationBuilder.CreateIndex(
                name: "IX_Aircrafts_AircraftTypeId",
                table: "Aircrafts",
                column: "AircraftTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Aircrafts_AirlineId",
                table: "Aircrafts",
                column: "AirlineId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AircraftAtAirports");

            migrationBuilder.DropTable(
                name: "Aircrafts");

            migrationBuilder.DropTable(
                name: "Airports");

            migrationBuilder.DropTable(
                name: "AircraftTypes");

            migrationBuilder.DropTable(
                name: "Airlines");
        }
    }
}
