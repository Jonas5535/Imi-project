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
                    { new Guid("9ccfd83d-ff7b-4e76-8c12-7c0f0496b5c0"), new DateTime(2022, 3, 25, 13, 35, 27, 58, DateTimeKind.Local).AddTicks(4753), "Airbus", 42400, new DateTime(1987, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.76, "A320", 37.57, new DateTime(2022, 3, 25, 13, 35, 27, 63, DateTimeKind.Local).AddTicks(4246), "A320-200", 34.100000000000001 },
                    { new Guid("3a504b2e-11ec-4725-b1ed-5babee959c4b"), new DateTime(2022, 3, 25, 13, 35, 27, 63, DateTimeKind.Local).AddTicks(5028), "Boeing", 118000, new DateTime(2009, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 16.899999999999999, "B788", 56.700000000000003, new DateTime(2022, 3, 25, 13, 35, 27, 63, DateTimeKind.Local).AddTicks(5046), "787-8", 60.100000000000001 },
                    { new Guid("3d0fd8f6-e957-482a-9d3f-a0f93b2e78ec"), new DateTime(2022, 3, 25, 13, 35, 27, 63, DateTimeKind.Local).AddTicks(5067), "McDonnel Douglas", 112748, new DateTime(1990, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 17.600000000000001, "MD11", 61.399999999999999, new DateTime(2022, 3, 25, 13, 35, 27, 63, DateTimeKind.Local).AddTicks(5073), "MD-11", 51.700000000000003 }
                });

            migrationBuilder.InsertData(
                table: "Airlines",
                columns: new[] { "Id", "AddedOn", "FleetSize", "HeadQuarter", "IATACode", "ICAOCode", "MainAirport", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { new Guid("53f04903-180c-4cc4-9bc7-e5d9a1630ee0"), new DateTime(2022, 3, 25, 13, 35, 27, 63, DateTimeKind.Local).AddTicks(8094), 49, "Diegem, België", "SN", "BEL", "Brussels Airport", new DateTime(2022, 3, 25, 13, 35, 27, 63, DateTimeKind.Local).AddTicks(8114), "Brussels Airlines" },
                    { new Guid("3a368982-9f8c-4440-8dd7-abf13772175f"), new DateTime(2022, 3, 25, 13, 35, 27, 63, DateTimeKind.Local).AddTicks(8131), 32, "Zaventem, België", "TB", "JAF", "Brussels Airport", new DateTime(2022, 3, 25, 13, 35, 27, 63, DateTimeKind.Local).AddTicks(8135), "TUI Fly" },
                    { new Guid("c76bb1ce-8f7d-4bf2-8157-096c1514c2e0"), new DateTime(2022, 3, 25, 13, 35, 27, 63, DateTimeKind.Local).AddTicks(8142), 18, "Frankfurt, Duitsland", "LH", "GEC", "Frankfurt am Main", new DateTime(2022, 3, 25, 13, 35, 27, 63, DateTimeKind.Local).AddTicks(8145), "Lufthansa Cargo" }
                });

            migrationBuilder.InsertData(
                table: "Airports",
                columns: new[] { "Id", "AddedOn", "City", "Country", "ElevationAMSL", "IATACode", "ICAOCode", "ModifiedOn", "Name", "RunwayAmount", "TerminalAmount" },
                values: new object[,]
                {
                    { new Guid("b55c30f0-2987-42b2-b667-0d3892c97692"), new DateTime(2022, 3, 25, 13, 35, 27, 64, DateTimeKind.Local).AddTicks(1767), "Zaventem", "België", 56, "BRU", "EBBR", new DateTime(2022, 3, 25, 13, 35, 27, 64, DateTimeKind.Local).AddTicks(1785), "Brussels Airport", 3, 1 },
                    { new Guid("3df73cd2-3ed7-41eb-afcd-3a4103b3e992"), new DateTime(2022, 3, 25, 13, 35, 27, 64, DateTimeKind.Local).AddTicks(1802), "Nice", "Frankrijk", 4, "NCE", "LFMN", new DateTime(2022, 3, 25, 13, 35, 27, 64, DateTimeKind.Local).AddTicks(1807), "Nice Côte d'Azur", 2, 3 },
                    { new Guid("b2f35991-dc73-4a72-bbfe-cc4856d007fe"), new DateTime(2022, 3, 25, 13, 35, 27, 64, DateTimeKind.Local).AddTicks(1830), "Narita", "japan", 41, "NRT", "RJAA", new DateTime(2022, 3, 25, 13, 35, 27, 64, DateTimeKind.Local).AddTicks(1833), "Tokyo Narita Intl. Airport", 2, 3 }
                });

            migrationBuilder.InsertData(
                table: "Aircrafts",
                columns: new[] { "Id", "AddedOn", "AircraftTypeId", "AirlineId", "FirstSeen", "HasSpecialLivery", "Image", "LastSeen", "Latitude", "Longitude", "ModifiedOn", "Registration" },
                values: new object[] { new Guid("30bc296c-6b5e-4234-a31f-3a9918ed53a8"), new DateTime(2022, 3, 25, 13, 35, 27, 64, DateTimeKind.Local).AddTicks(5350), new Guid("9ccfd83d-ff7b-4e76-8c12-7c0f0496b5c0"), new Guid("53f04903-180c-4cc4-9bc7-e5d9a1630ee0"), new DateTime(2021, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(2021, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2022, 3, 25, 13, 35, 27, 64, DateTimeKind.Local).AddTicks(5371), "OO-SNJ" });

            migrationBuilder.InsertData(
                table: "Aircrafts",
                columns: new[] { "Id", "AddedOn", "AircraftTypeId", "AirlineId", "FirstSeen", "HasSpecialLivery", "Image", "LastSeen", "Latitude", "Longitude", "ModifiedOn", "Registration" },
                values: new object[] { new Guid("99caa744-4cbd-4fba-bf5e-ceb600ebee26"), new DateTime(2022, 3, 25, 13, 35, 27, 64, DateTimeKind.Local).AddTicks(5389), new Guid("3a504b2e-11ec-4725-b1ed-5babee959c4b"), new Guid("3a368982-9f8c-4440-8dd7-abf13772175f"), new DateTime(2020, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(2021, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2022, 3, 25, 13, 35, 27, 64, DateTimeKind.Local).AddTicks(5393), "OO-LOE" });

            migrationBuilder.InsertData(
                table: "Aircrafts",
                columns: new[] { "Id", "AddedOn", "AircraftTypeId", "AirlineId", "FirstSeen", "HasSpecialLivery", "Image", "LastSeen", "Latitude", "Longitude", "ModifiedOn", "Registration" },
                values: new object[] { new Guid("f552e1cc-10a8-4000-8fb3-4ccda599e88e"), new DateTime(2022, 3, 25, 13, 35, 27, 64, DateTimeKind.Local).AddTicks(5401), new Guid("3d0fd8f6-e957-482a-9d3f-a0f93b2e78ec"), new Guid("c76bb1ce-8f7d-4bf2-8157-096c1514c2e0"), new DateTime(2020, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(2021, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2022, 3, 25, 13, 35, 27, 64, DateTimeKind.Local).AddTicks(5405), "D-ALCC" });

            migrationBuilder.InsertData(
                table: "AircraftAtAirports",
                columns: new[] { "AircraftId", "AirportId" },
                values: new object[,]
                {
                    { new Guid("30bc296c-6b5e-4234-a31f-3a9918ed53a8"), new Guid("b55c30f0-2987-42b2-b667-0d3892c97692") },
                    { new Guid("30bc296c-6b5e-4234-a31f-3a9918ed53a8"), new Guid("3df73cd2-3ed7-41eb-afcd-3a4103b3e992") },
                    { new Guid("30bc296c-6b5e-4234-a31f-3a9918ed53a8"), new Guid("b2f35991-dc73-4a72-bbfe-cc4856d007fe") },
                    { new Guid("99caa744-4cbd-4fba-bf5e-ceb600ebee26"), new Guid("b55c30f0-2987-42b2-b667-0d3892c97692") },
                    { new Guid("99caa744-4cbd-4fba-bf5e-ceb600ebee26"), new Guid("3df73cd2-3ed7-41eb-afcd-3a4103b3e992") },
                    { new Guid("f552e1cc-10a8-4000-8fb3-4ccda599e88e"), new Guid("b2f35991-dc73-4a72-bbfe-cc4856d007fe") }
                });

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
