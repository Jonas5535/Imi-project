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
                    Length = table.Column<double>(type: "float", nullable: true),
                    WingSpan = table.Column<double>(type: "float", nullable: true),
                    Height = table.Column<double>(type: "float", nullable: true),
                    EmptyWeight = table.Column<int>(type: "int", nullable: true),
                    AddedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                    AddedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                    AddedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                    Longitude = table.Column<double>(type: "float", nullable: true),
                    Latitude = table.Column<double>(type: "float", nullable: true),
                    AircraftTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AirlineId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AddedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                    { new Guid("660f2b42-dc0b-44b8-a974-69b812a8445e"), new DateTime(2022, 3, 25, 11, 16, 3, 622, DateTimeKind.Local).AddTicks(7483), "Airbus", 42400, new DateTime(1987, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.76, "A320", 37.57, new DateTime(2022, 3, 25, 11, 16, 3, 628, DateTimeKind.Local).AddTicks(6654), "A320-200", 34.100000000000001 },
                    { new Guid("dc2adf58-3856-46d8-86ce-eb1ddd69c539"), new DateTime(2022, 3, 25, 11, 16, 3, 628, DateTimeKind.Local).AddTicks(7571), "Boeing", 118000, new DateTime(2009, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 16.899999999999999, "B788", 56.700000000000003, new DateTime(2022, 3, 25, 11, 16, 3, 628, DateTimeKind.Local).AddTicks(7589), "787-8", 60.100000000000001 },
                    { new Guid("b4cb2d4b-3409-4b5a-a05f-4e5263e76989"), new DateTime(2022, 3, 25, 11, 16, 3, 628, DateTimeKind.Local).AddTicks(7612), "McDonnel Douglas", 112748, new DateTime(1990, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 17.600000000000001, "MD11", 61.399999999999999, new DateTime(2022, 3, 25, 11, 16, 3, 628, DateTimeKind.Local).AddTicks(7616), "MD-11", 51.700000000000003 }
                });

            migrationBuilder.InsertData(
                table: "Airlines",
                columns: new[] { "Id", "AddedOn", "FleetSize", "HeadQuarter", "IATACode", "ICAOCode", "MainAirport", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { new Guid("e167eccc-4a5e-497c-895d-c0bf59d9c798"), new DateTime(2022, 3, 25, 11, 16, 3, 629, DateTimeKind.Local).AddTicks(637), 49, "Diegem, België", "SN", "BEL", "Brussels Airport", new DateTime(2022, 3, 25, 11, 16, 3, 629, DateTimeKind.Local).AddTicks(660), "Brussels Airlines" },
                    { new Guid("da740992-5345-408d-b06c-3c1d648c5d6b"), new DateTime(2022, 3, 25, 11, 16, 3, 629, DateTimeKind.Local).AddTicks(676), 32, "Zaventem, België", "TB", "JAF", "Brussels Airport", new DateTime(2022, 3, 25, 11, 16, 3, 629, DateTimeKind.Local).AddTicks(681), "TUI Fly" },
                    { new Guid("25e897f3-0407-436a-b57d-9fa37d3515fb"), new DateTime(2022, 3, 25, 11, 16, 3, 629, DateTimeKind.Local).AddTicks(687), 18, "Frankfurt, Duitsland", "LH", "GEC", "Frankfurt am Main", new DateTime(2022, 3, 25, 11, 16, 3, 629, DateTimeKind.Local).AddTicks(690), "Lufthansa Cargo" }
                });

            migrationBuilder.InsertData(
                table: "Airports",
                columns: new[] { "Id", "AddedOn", "City", "Country", "ElevationAMSL", "IATACode", "ICAOCode", "ModifiedOn", "Name", "RunwayAmount", "TerminalAmount" },
                values: new object[,]
                {
                    { new Guid("a83fe1a7-5a0e-4671-b2c8-69ce4a99f88e"), new DateTime(2022, 3, 25, 11, 16, 3, 629, DateTimeKind.Local).AddTicks(4152), "Zaventem", "België", 56, "BRU", "EBBR", new DateTime(2022, 3, 25, 11, 16, 3, 629, DateTimeKind.Local).AddTicks(4170), "Brussels Airport", 3, 1 },
                    { new Guid("2b4b3bbe-0adc-4056-b13c-5ada9595cf18"), new DateTime(2022, 3, 25, 11, 16, 3, 629, DateTimeKind.Local).AddTicks(4187), "Nice", "Frankrijk", 4, "NCE", "LFMN", new DateTime(2022, 3, 25, 11, 16, 3, 629, DateTimeKind.Local).AddTicks(4191), "Nice Côte d'Azur", 2, 3 },
                    { new Guid("ea10f239-01a3-43e8-acf3-de0d808e855e"), new DateTime(2022, 3, 25, 11, 16, 3, 629, DateTimeKind.Local).AddTicks(4199), "Narita", "japan", 41, "NRT", "RJAA", new DateTime(2022, 3, 25, 11, 16, 3, 629, DateTimeKind.Local).AddTicks(4203), "Tokyo Narita Intl. Airport", 2, 3 }
                });

            migrationBuilder.InsertData(
                table: "Aircrafts",
                columns: new[] { "Id", "AddedOn", "AircraftTypeId", "AirlineId", "FirstSeen", "HasSpecialLivery", "Image", "LastSeen", "Latitude", "Longitude", "ModifiedOn", "Registration" },
                values: new object[] { new Guid("d2645723-1915-47e9-b17a-10851f823fda"), new DateTime(2022, 3, 25, 11, 16, 3, 629, DateTimeKind.Local).AddTicks(7915), new Guid("660f2b42-dc0b-44b8-a974-69b812a8445e"), new Guid("e167eccc-4a5e-497c-895d-c0bf59d9c798"), new DateTime(2021, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(2021, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2022, 3, 25, 11, 16, 3, 629, DateTimeKind.Local).AddTicks(7934), "OO-SNJ" });

            migrationBuilder.InsertData(
                table: "Aircrafts",
                columns: new[] { "Id", "AddedOn", "AircraftTypeId", "AirlineId", "FirstSeen", "HasSpecialLivery", "Image", "LastSeen", "Latitude", "Longitude", "ModifiedOn", "Registration" },
                values: new object[] { new Guid("5b6c4731-a504-43b0-a4d1-9e43dedf2488"), new DateTime(2022, 3, 25, 11, 16, 3, 629, DateTimeKind.Local).AddTicks(7952), new Guid("dc2adf58-3856-46d8-86ce-eb1ddd69c539"), new Guid("da740992-5345-408d-b06c-3c1d648c5d6b"), new DateTime(2020, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(2021, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2022, 3, 25, 11, 16, 3, 629, DateTimeKind.Local).AddTicks(7957), "OO-LOE" });

            migrationBuilder.InsertData(
                table: "Aircrafts",
                columns: new[] { "Id", "AddedOn", "AircraftTypeId", "AirlineId", "FirstSeen", "HasSpecialLivery", "Image", "LastSeen", "Latitude", "Longitude", "ModifiedOn", "Registration" },
                values: new object[] { new Guid("eb6e6d14-b5bc-4467-aa92-2c896cd9d1ea"), new DateTime(2022, 3, 25, 11, 16, 3, 629, DateTimeKind.Local).AddTicks(7964), new Guid("b4cb2d4b-3409-4b5a-a05f-4e5263e76989"), new Guid("25e897f3-0407-436a-b57d-9fa37d3515fb"), new DateTime(2020, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(2021, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2022, 3, 25, 11, 16, 3, 629, DateTimeKind.Local).AddTicks(7968), "D-ALCC" });

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
