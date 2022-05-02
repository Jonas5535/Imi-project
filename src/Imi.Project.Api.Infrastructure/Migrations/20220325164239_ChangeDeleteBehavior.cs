using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Imi.Project.Api.Infrastructure.Migrations
{
    public partial class ChangeDeleteBehavior : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aircrafts_AircraftTypes_AircraftTypeId",
                table: "Aircrafts");

            migrationBuilder.DropForeignKey(
                name: "FK_Aircrafts_Airlines_AirlineId",
                table: "Aircrafts");

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("30bc296c-6b5e-4234-a31f-3a9918ed53a8"), new Guid("3df73cd2-3ed7-41eb-afcd-3a4103b3e992") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("30bc296c-6b5e-4234-a31f-3a9918ed53a8"), new Guid("b2f35991-dc73-4a72-bbfe-cc4856d007fe") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("30bc296c-6b5e-4234-a31f-3a9918ed53a8"), new Guid("b55c30f0-2987-42b2-b667-0d3892c97692") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("99caa744-4cbd-4fba-bf5e-ceb600ebee26"), new Guid("3df73cd2-3ed7-41eb-afcd-3a4103b3e992") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("99caa744-4cbd-4fba-bf5e-ceb600ebee26"), new Guid("b55c30f0-2987-42b2-b667-0d3892c97692") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("f552e1cc-10a8-4000-8fb3-4ccda599e88e"), new Guid("b2f35991-dc73-4a72-bbfe-cc4856d007fe") });

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: new Guid("30bc296c-6b5e-4234-a31f-3a9918ed53a8"));

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: new Guid("99caa744-4cbd-4fba-bf5e-ceb600ebee26"));

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: new Guid("f552e1cc-10a8-4000-8fb3-4ccda599e88e"));

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: new Guid("3df73cd2-3ed7-41eb-afcd-3a4103b3e992"));

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: new Guid("b2f35991-dc73-4a72-bbfe-cc4856d007fe"));

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: new Guid("b55c30f0-2987-42b2-b667-0d3892c97692"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("3a504b2e-11ec-4725-b1ed-5babee959c4b"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("3d0fd8f6-e957-482a-9d3f-a0f93b2e78ec"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("9ccfd83d-ff7b-4e76-8c12-7c0f0496b5c0"));

            migrationBuilder.DeleteData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: new Guid("3a368982-9f8c-4440-8dd7-abf13772175f"));

            migrationBuilder.DeleteData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: new Guid("53f04903-180c-4cc4-9bc7-e5d9a1630ee0"));

            migrationBuilder.DeleteData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: new Guid("c76bb1ce-8f7d-4bf2-8157-096c1514c2e0"));

            migrationBuilder.InsertData(
                table: "AircraftTypes",
                columns: new[] { "Id", "AddedOn", "Brand", "EmptyWeight", "FirstFlight", "Height", "ICAOCode", "Length", "ModifiedOn", "Type", "WingSpan" },
                values: new object[,]
                {
                    { new Guid("1367842b-64e4-4eef-99ff-c0532e970857"), new DateTime(2022, 3, 25, 17, 42, 38, 596, DateTimeKind.Local).AddTicks(3642), "Airbus", 42400, new DateTime(1987, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.76, "A320", 37.57, new DateTime(2022, 3, 25, 17, 42, 38, 601, DateTimeKind.Local).AddTicks(7386), "A320-200", 34.100000000000001 },
                    { new Guid("99193d2c-6c76-4b34-aac8-994b39125a99"), new DateTime(2022, 3, 25, 17, 42, 38, 601, DateTimeKind.Local).AddTicks(8234), "Boeing", 118000, new DateTime(2009, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 16.899999999999999, "B788", 56.700000000000003, new DateTime(2022, 3, 25, 17, 42, 38, 601, DateTimeKind.Local).AddTicks(8252), "787-8", 60.100000000000001 },
                    { new Guid("f10b801f-ef2d-481b-9cfe-4bfe6182a832"), new DateTime(2022, 3, 25, 17, 42, 38, 601, DateTimeKind.Local).AddTicks(8278), "McDonnel Douglas", 112748, new DateTime(1990, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 17.600000000000001, "MD11", 61.399999999999999, new DateTime(2022, 3, 25, 17, 42, 38, 601, DateTimeKind.Local).AddTicks(8282), "MD-11", 51.700000000000003 }
                });

            migrationBuilder.InsertData(
                table: "Airlines",
                columns: new[] { "Id", "AddedOn", "FleetSize", "HeadQuarter", "IATACode", "ICAOCode", "MainAirport", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { new Guid("a82cd063-4c17-4fa6-8529-f2f146f0114c"), new DateTime(2022, 3, 25, 17, 42, 38, 602, DateTimeKind.Local).AddTicks(1308), 49, "Diegem, België", "SN", "BEL", "Brussels Airport", new DateTime(2022, 3, 25, 17, 42, 38, 602, DateTimeKind.Local).AddTicks(1326), "Brussels Airlines" },
                    { new Guid("92c70a1d-e55a-4e36-a504-1c477c3c4b1c"), new DateTime(2022, 3, 25, 17, 42, 38, 602, DateTimeKind.Local).AddTicks(1344), 32, "Zaventem, België", "TB", "JAF", "Brussels Airport", new DateTime(2022, 3, 25, 17, 42, 38, 602, DateTimeKind.Local).AddTicks(1347), "TUI Fly" },
                    { new Guid("8b8e3891-9fff-4a9c-94f4-28f357e83ac0"), new DateTime(2022, 3, 25, 17, 42, 38, 602, DateTimeKind.Local).AddTicks(1353), 18, "Frankfurt, Duitsland", "LH", "GEC", "Frankfurt am Main", new DateTime(2022, 3, 25, 17, 42, 38, 602, DateTimeKind.Local).AddTicks(1357), "Lufthansa Cargo" }
                });

            migrationBuilder.InsertData(
                table: "Airports",
                columns: new[] { "Id", "AddedOn", "City", "Country", "ElevationAMSL", "IATACode", "ICAOCode", "ModifiedOn", "Name", "RunwayAmount", "TerminalAmount" },
                values: new object[,]
                {
                    { new Guid("e48a2d3d-2590-4612-b81d-8abb68ca8263"), new DateTime(2022, 3, 25, 17, 42, 38, 602, DateTimeKind.Local).AddTicks(4901), "Zaventem", "België", 56, "BRU", "EBBR", new DateTime(2022, 3, 25, 17, 42, 38, 602, DateTimeKind.Local).AddTicks(4919), "Brussels Airport", 3, 1 },
                    { new Guid("e2be3bd6-4c7b-41f4-a5c8-a1940310ea7d"), new DateTime(2022, 3, 25, 17, 42, 38, 602, DateTimeKind.Local).AddTicks(4936), "Nice", "Frankrijk", 4, "NCE", "LFMN", new DateTime(2022, 3, 25, 17, 42, 38, 602, DateTimeKind.Local).AddTicks(4940), "Nice Côte d'Azur", 2, 3 },
                    { new Guid("d8806f32-bf51-4b76-8c4f-37e0f532a6a7"), new DateTime(2022, 3, 25, 17, 42, 38, 602, DateTimeKind.Local).AddTicks(4947), "Narita", "japan", 41, "NRT", "RJAA", new DateTime(2022, 3, 25, 17, 42, 38, 602, DateTimeKind.Local).AddTicks(4951), "Tokyo Narita Intl. Airport", 2, 3 }
                });

            migrationBuilder.InsertData(
                table: "Aircrafts",
                columns: new[] { "Id", "AddedOn", "AircraftTypeId", "AirlineId", "FirstSeen", "HasSpecialLivery", "Image", "LastSeen", "Latitude", "Longitude", "ModifiedOn", "Registration" },
                values: new object[] { new Guid("5c323051-fbe9-460a-91d6-94dbde327edd"), new DateTime(2022, 3, 25, 17, 42, 38, 602, DateTimeKind.Local).AddTicks(8241), new Guid("1367842b-64e4-4eef-99ff-c0532e970857"), new Guid("a82cd063-4c17-4fa6-8529-f2f146f0114c"), new DateTime(2021, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(2021, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2022, 3, 25, 17, 42, 38, 602, DateTimeKind.Local).AddTicks(8259), "OO-SNJ" });

            migrationBuilder.InsertData(
                table: "Aircrafts",
                columns: new[] { "Id", "AddedOn", "AircraftTypeId", "AirlineId", "FirstSeen", "HasSpecialLivery", "Image", "LastSeen", "Latitude", "Longitude", "ModifiedOn", "Registration" },
                values: new object[] { new Guid("956a73ad-423c-4dab-93bf-6ae177ca028d"), new DateTime(2022, 3, 25, 17, 42, 38, 602, DateTimeKind.Local).AddTicks(8277), new Guid("99193d2c-6c76-4b34-aac8-994b39125a99"), new Guid("92c70a1d-e55a-4e36-a504-1c477c3c4b1c"), new DateTime(2020, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(2021, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2022, 3, 25, 17, 42, 38, 602, DateTimeKind.Local).AddTicks(8281), "OO-LOE" });

            migrationBuilder.InsertData(
                table: "Aircrafts",
                columns: new[] { "Id", "AddedOn", "AircraftTypeId", "AirlineId", "FirstSeen", "HasSpecialLivery", "Image", "LastSeen", "Latitude", "Longitude", "ModifiedOn", "Registration" },
                values: new object[] { new Guid("3b169fe6-2105-4dcb-bf0c-f7433b3ec7fd"), new DateTime(2022, 3, 25, 17, 42, 38, 602, DateTimeKind.Local).AddTicks(8288), new Guid("f10b801f-ef2d-481b-9cfe-4bfe6182a832"), new Guid("8b8e3891-9fff-4a9c-94f4-28f357e83ac0"), new DateTime(2020, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(2021, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2022, 3, 25, 17, 42, 38, 602, DateTimeKind.Local).AddTicks(8291), "D-ALCC" });

            migrationBuilder.InsertData(
                table: "AircraftAtAirports",
                columns: new[] { "AircraftId", "AirportId" },
                values: new object[,]
                {
                    { new Guid("5c323051-fbe9-460a-91d6-94dbde327edd"), new Guid("e48a2d3d-2590-4612-b81d-8abb68ca8263") },
                    { new Guid("5c323051-fbe9-460a-91d6-94dbde327edd"), new Guid("e2be3bd6-4c7b-41f4-a5c8-a1940310ea7d") },
                    { new Guid("5c323051-fbe9-460a-91d6-94dbde327edd"), new Guid("d8806f32-bf51-4b76-8c4f-37e0f532a6a7") },
                    { new Guid("956a73ad-423c-4dab-93bf-6ae177ca028d"), new Guid("e48a2d3d-2590-4612-b81d-8abb68ca8263") },
                    { new Guid("956a73ad-423c-4dab-93bf-6ae177ca028d"), new Guid("e2be3bd6-4c7b-41f4-a5c8-a1940310ea7d") },
                    { new Guid("3b169fe6-2105-4dcb-bf0c-f7433b3ec7fd"), new Guid("d8806f32-bf51-4b76-8c4f-37e0f532a6a7") }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Aircrafts_AircraftTypes_AircraftTypeId",
                table: "Aircrafts",
                column: "AircraftTypeId",
                principalTable: "AircraftTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Aircrafts_Airlines_AirlineId",
                table: "Aircrafts",
                column: "AirlineId",
                principalTable: "Airlines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aircrafts_AircraftTypes_AircraftTypeId",
                table: "Aircrafts");

            migrationBuilder.DropForeignKey(
                name: "FK_Aircrafts_Airlines_AirlineId",
                table: "Aircrafts");

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("3b169fe6-2105-4dcb-bf0c-f7433b3ec7fd"), new Guid("d8806f32-bf51-4b76-8c4f-37e0f532a6a7") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("5c323051-fbe9-460a-91d6-94dbde327edd"), new Guid("d8806f32-bf51-4b76-8c4f-37e0f532a6a7") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("5c323051-fbe9-460a-91d6-94dbde327edd"), new Guid("e2be3bd6-4c7b-41f4-a5c8-a1940310ea7d") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("5c323051-fbe9-460a-91d6-94dbde327edd"), new Guid("e48a2d3d-2590-4612-b81d-8abb68ca8263") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("956a73ad-423c-4dab-93bf-6ae177ca028d"), new Guid("e2be3bd6-4c7b-41f4-a5c8-a1940310ea7d") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("956a73ad-423c-4dab-93bf-6ae177ca028d"), new Guid("e48a2d3d-2590-4612-b81d-8abb68ca8263") });

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: new Guid("3b169fe6-2105-4dcb-bf0c-f7433b3ec7fd"));

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: new Guid("5c323051-fbe9-460a-91d6-94dbde327edd"));

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: new Guid("956a73ad-423c-4dab-93bf-6ae177ca028d"));

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: new Guid("d8806f32-bf51-4b76-8c4f-37e0f532a6a7"));

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: new Guid("e2be3bd6-4c7b-41f4-a5c8-a1940310ea7d"));

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: new Guid("e48a2d3d-2590-4612-b81d-8abb68ca8263"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("1367842b-64e4-4eef-99ff-c0532e970857"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("99193d2c-6c76-4b34-aac8-994b39125a99"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("f10b801f-ef2d-481b-9cfe-4bfe6182a832"));

            migrationBuilder.DeleteData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: new Guid("8b8e3891-9fff-4a9c-94f4-28f357e83ac0"));

            migrationBuilder.DeleteData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: new Guid("92c70a1d-e55a-4e36-a504-1c477c3c4b1c"));

            migrationBuilder.DeleteData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: new Guid("a82cd063-4c17-4fa6-8529-f2f146f0114c"));

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

            migrationBuilder.AddForeignKey(
                name: "FK_Aircrafts_AircraftTypes_AircraftTypeId",
                table: "Aircrafts",
                column: "AircraftTypeId",
                principalTable: "AircraftTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Aircrafts_Airlines_AirlineId",
                table: "Aircrafts",
                column: "AirlineId",
                principalTable: "Airlines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
