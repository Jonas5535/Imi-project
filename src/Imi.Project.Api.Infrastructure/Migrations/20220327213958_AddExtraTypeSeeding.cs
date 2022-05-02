using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Imi.Project.Api.Infrastructure.Migrations
{
    public partial class AddExtraTypeSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    { new Guid("56a340ed-4eda-424c-b2ea-20662fa20b25"), new DateTime(2022, 3, 27, 23, 39, 57, 791, DateTimeKind.Local).AddTicks(23), "Airbus", 42400, new DateTime(1987, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.76, "A320", 37.57, new DateTime(2022, 3, 27, 23, 39, 57, 796, DateTimeKind.Local).AddTicks(708), "A320-200", 34.100000000000001 },
                    { new Guid("b101b724-9cde-40b1-9407-a33cf9ba73d8"), new DateTime(2022, 3, 27, 23, 39, 57, 796, DateTimeKind.Local).AddTicks(1739), "Embraer", 27837, new DateTime(2004, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.57, "E190", 36.25, new DateTime(2022, 3, 27, 23, 39, 57, 796, DateTimeKind.Local).AddTicks(1744), "E190", 28.73 },
                    { new Guid("8b880175-fa1a-42c7-888a-1a3a3df9633e"), new DateTime(2022, 3, 27, 23, 39, 57, 796, DateTimeKind.Local).AddTicks(1723), "Boeing", 128850, new DateTime(2013, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 17.02, "B789", 62.810000000000002, new DateTime(2022, 3, 27, 23, 39, 57, 796, DateTimeKind.Local).AddTicks(1727), "787-9", 60.119999999999997 },
                    { new Guid("02fa61ed-ab6b-4c56-b8dc-a81e4c887847"), new DateTime(2022, 3, 27, 23, 39, 57, 796, DateTimeKind.Local).AddTicks(1707), "Boeing", 167829, new DateTime(2003, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 18.5, "B77W", 73.859999999999999, new DateTime(2022, 3, 27, 23, 39, 57, 796, DateTimeKind.Local).AddTicks(1712), "777-300ER", 64.799999999999997 },
                    { new Guid("a7cfc3e9-241a-43a0-9271-fc244be11781"), new DateTime(2022, 3, 27, 23, 39, 57, 796, DateTimeKind.Local).AddTicks(1674), "Airbus", 277145, new DateTime(2005, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 24.09, "A388", 72.719999999999999, new DateTime(2022, 3, 27, 23, 39, 57, 796, DateTimeKind.Local).AddTicks(1678), "A380-800", 79.75 },
                    { new Guid("dd7afdc9-571d-4805-839d-38076c8343bf"), new DateTime(2022, 3, 27, 23, 39, 57, 796, DateTimeKind.Local).AddTicks(1644), "Airbus", 155000, new DateTime(2016, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 17.079999999999998, "A35K", 73.790000000000006, new DateTime(2022, 3, 27, 23, 39, 57, 796, DateTimeKind.Local).AddTicks(1648), "A350-1000", 64.75 },
                    { new Guid("7b66dc3e-fb34-45c9-aff4-c06464928d7f"), new DateTime(2022, 3, 27, 23, 39, 57, 796, DateTimeKind.Local).AddTicks(1691), "Boeing", 197100, new DateTime(2010, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 19.399999999999999, "B748", 76.299999999999997, new DateTime(2022, 3, 27, 23, 39, 57, 796, DateTimeKind.Local).AddTicks(1695), "747-8", 68.400000000000006 },
                    { new Guid("83077924-814a-4d84-9a92-c8dce3575281"), new DateTime(2022, 3, 27, 23, 39, 57, 796, DateTimeKind.Local).AddTicks(1610), "Airbus", 40800, new DateTime(1995, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.76, "A319", 33.840000000000003, new DateTime(2022, 3, 27, 23, 39, 57, 796, DateTimeKind.Local).AddTicks(1614), "A319-100", 35.799999999999997 },
                    { new Guid("55f54bea-fb20-4bfd-bc0d-e0f9d7f1503c"), new DateTime(2022, 3, 27, 23, 39, 57, 796, DateTimeKind.Local).AddTicks(1595), "Airbus", 37080, new DateTime(2015, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.5, "BCS3", 38.710000000000001, new DateTime(2022, 3, 27, 23, 39, 57, 796, DateTimeKind.Local).AddTicks(1600), "A220-300", 35.100000000000001 },
                    { new Guid("7b9f4f05-3f05-40a9-93cf-9c87574e36e6"), new DateTime(2022, 3, 27, 23, 39, 57, 796, DateTimeKind.Local).AddTicks(1578), "Airbus", 35220, new DateTime(2013, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.5, "BCS1", 35.0, new DateTime(2022, 3, 27, 23, 39, 57, 796, DateTimeKind.Local).AddTicks(1582), "A220-100", 35.100000000000001 },
                    { new Guid("4eb5e5db-7940-46f6-8005-748107cfa5ad"), new DateTime(2022, 3, 27, 23, 39, 57, 796, DateTimeKind.Local).AddTicks(1560), "McDonnel Douglas", 112748, new DateTime(1990, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 17.600000000000001, "MD11", 61.399999999999999, new DateTime(2022, 3, 27, 23, 39, 57, 796, DateTimeKind.Local).AddTicks(1565), "MD-11", 51.700000000000003 },
                    { new Guid("63934e63-c16f-4dcd-824b-a69c5a33aa15"), new DateTime(2022, 3, 27, 23, 39, 57, 796, DateTimeKind.Local).AddTicks(1519), "Boeing", 118000, new DateTime(2009, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 16.899999999999999, "B788", 56.700000000000003, new DateTime(2022, 3, 27, 23, 39, 57, 796, DateTimeKind.Local).AddTicks(1538), "787-8", 60.100000000000001 },
                    { new Guid("3c22ac0c-ae43-4999-97ec-06aa3637b866"), new DateTime(2022, 3, 27, 23, 39, 57, 796, DateTimeKind.Local).AddTicks(1626), "Airbus", 131000, new DateTime(1991, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 16.989999999999998, "A343", 63.659999999999997, new DateTime(2022, 3, 27, 23, 39, 57, 796, DateTimeKind.Local).AddTicks(1631), "A340-300", 60.299999999999997 }
                });

            migrationBuilder.InsertData(
                table: "Airlines",
                columns: new[] { "Id", "AddedOn", "FleetSize", "HeadQuarter", "IATACode", "ICAOCode", "MainAirport", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { new Guid("92f346d7-d3eb-45df-9f11-f5befb7699ba"), new DateTime(2022, 3, 27, 23, 39, 57, 796, DateTimeKind.Local).AddTicks(4724), 49, "Diegem, België", "SN", "BEL", "Brussels Airport", new DateTime(2022, 3, 27, 23, 39, 57, 796, DateTimeKind.Local).AddTicks(4742), "Brussels Airlines" },
                    { new Guid("9e2ab0b8-a1e7-4993-b2f5-5253c9735456"), new DateTime(2022, 3, 27, 23, 39, 57, 796, DateTimeKind.Local).AddTicks(4759), 32, "Zaventem, België", "TB", "JAF", "Brussels Airport", new DateTime(2022, 3, 27, 23, 39, 57, 796, DateTimeKind.Local).AddTicks(4763), "TUI Fly" },
                    { new Guid("e5eccbe3-c8c0-47f4-86ba-94bc7b835127"), new DateTime(2022, 3, 27, 23, 39, 57, 796, DateTimeKind.Local).AddTicks(4769), 18, "Frankfurt, Duitsland", "LH", "GEC", "Frankfurt am Main", new DateTime(2022, 3, 27, 23, 39, 57, 796, DateTimeKind.Local).AddTicks(4773), "Lufthansa Cargo" }
                });

            migrationBuilder.InsertData(
                table: "Airports",
                columns: new[] { "Id", "AddedOn", "City", "Country", "ElevationAMSL", "IATACode", "ICAOCode", "ModifiedOn", "Name", "RunwayAmount", "TerminalAmount" },
                values: new object[,]
                {
                    { new Guid("09128316-01a3-4c14-a648-a688427be81c"), new DateTime(2022, 3, 27, 23, 39, 57, 796, DateTimeKind.Local).AddTicks(8304), "Nice", "Frankrijk", 4, "NCE", "LFMN", new DateTime(2022, 3, 27, 23, 39, 57, 796, DateTimeKind.Local).AddTicks(8308), "Nice Côte d'Azur", 2, 3 },
                    { new Guid("5ce20fa6-abf7-4a25-adfb-9fc1d4bf0168"), new DateTime(2022, 3, 27, 23, 39, 57, 796, DateTimeKind.Local).AddTicks(8270), "Zaventem", "België", 56, "BRU", "EBBR", new DateTime(2022, 3, 27, 23, 39, 57, 796, DateTimeKind.Local).AddTicks(8288), "Brussels Airport", 3, 1 },
                    { new Guid("d9814a1d-9508-4659-8bd3-d91bce395159"), new DateTime(2022, 3, 27, 23, 39, 57, 796, DateTimeKind.Local).AddTicks(8315), "Narita", "japan", 41, "NRT", "RJAA", new DateTime(2022, 3, 27, 23, 39, 57, 796, DateTimeKind.Local).AddTicks(8319), "Tokyo Narita Intl. Airport", 2, 3 }
                });

            migrationBuilder.InsertData(
                table: "Aircrafts",
                columns: new[] { "Id", "AddedOn", "AircraftTypeId", "AirlineId", "FirstSeen", "HasSpecialLivery", "Image", "LastSeen", "Latitude", "Longitude", "ModifiedOn", "Registration" },
                values: new object[] { new Guid("adb44fc9-9234-4f02-9dc0-dcb245eda784"), new DateTime(2022, 3, 27, 23, 39, 57, 797, DateTimeKind.Local).AddTicks(1701), new Guid("56a340ed-4eda-424c-b2ea-20662fa20b25"), new Guid("92f346d7-d3eb-45df-9f11-f5befb7699ba"), new DateTime(2021, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(2021, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2022, 3, 27, 23, 39, 57, 797, DateTimeKind.Local).AddTicks(1720), "OO-SNJ" });

            migrationBuilder.InsertData(
                table: "Aircrafts",
                columns: new[] { "Id", "AddedOn", "AircraftTypeId", "AirlineId", "FirstSeen", "HasSpecialLivery", "Image", "LastSeen", "Latitude", "Longitude", "ModifiedOn", "Registration" },
                values: new object[] { new Guid("3e96733e-cb1f-449f-9e1a-fbeca40001a4"), new DateTime(2022, 3, 27, 23, 39, 57, 797, DateTimeKind.Local).AddTicks(1738), new Guid("63934e63-c16f-4dcd-824b-a69c5a33aa15"), new Guid("9e2ab0b8-a1e7-4993-b2f5-5253c9735456"), new DateTime(2020, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(2021, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2022, 3, 27, 23, 39, 57, 797, DateTimeKind.Local).AddTicks(1742), "OO-LOE" });

            migrationBuilder.InsertData(
                table: "Aircrafts",
                columns: new[] { "Id", "AddedOn", "AircraftTypeId", "AirlineId", "FirstSeen", "HasSpecialLivery", "Image", "LastSeen", "Latitude", "Longitude", "ModifiedOn", "Registration" },
                values: new object[] { new Guid("789d6e24-033b-4a78-8038-2056afdb27c1"), new DateTime(2022, 3, 27, 23, 39, 57, 797, DateTimeKind.Local).AddTicks(1750), new Guid("4eb5e5db-7940-46f6-8005-748107cfa5ad"), new Guid("e5eccbe3-c8c0-47f4-86ba-94bc7b835127"), new DateTime(2020, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(2021, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2022, 3, 27, 23, 39, 57, 797, DateTimeKind.Local).AddTicks(1754), "D-ALCC" });

            migrationBuilder.InsertData(
                table: "AircraftAtAirports",
                columns: new[] { "AircraftId", "AirportId" },
                values: new object[,]
                {
                    { new Guid("adb44fc9-9234-4f02-9dc0-dcb245eda784"), new Guid("5ce20fa6-abf7-4a25-adfb-9fc1d4bf0168") },
                    { new Guid("adb44fc9-9234-4f02-9dc0-dcb245eda784"), new Guid("09128316-01a3-4c14-a648-a688427be81c") },
                    { new Guid("adb44fc9-9234-4f02-9dc0-dcb245eda784"), new Guid("d9814a1d-9508-4659-8bd3-d91bce395159") },
                    { new Guid("3e96733e-cb1f-449f-9e1a-fbeca40001a4"), new Guid("5ce20fa6-abf7-4a25-adfb-9fc1d4bf0168") },
                    { new Guid("3e96733e-cb1f-449f-9e1a-fbeca40001a4"), new Guid("09128316-01a3-4c14-a648-a688427be81c") },
                    { new Guid("789d6e24-033b-4a78-8038-2056afdb27c1"), new Guid("d9814a1d-9508-4659-8bd3-d91bce395159") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("3e96733e-cb1f-449f-9e1a-fbeca40001a4"), new Guid("09128316-01a3-4c14-a648-a688427be81c") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("3e96733e-cb1f-449f-9e1a-fbeca40001a4"), new Guid("5ce20fa6-abf7-4a25-adfb-9fc1d4bf0168") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("789d6e24-033b-4a78-8038-2056afdb27c1"), new Guid("d9814a1d-9508-4659-8bd3-d91bce395159") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("adb44fc9-9234-4f02-9dc0-dcb245eda784"), new Guid("09128316-01a3-4c14-a648-a688427be81c") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("adb44fc9-9234-4f02-9dc0-dcb245eda784"), new Guid("5ce20fa6-abf7-4a25-adfb-9fc1d4bf0168") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("adb44fc9-9234-4f02-9dc0-dcb245eda784"), new Guid("d9814a1d-9508-4659-8bd3-d91bce395159") });

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("02fa61ed-ab6b-4c56-b8dc-a81e4c887847"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("3c22ac0c-ae43-4999-97ec-06aa3637b866"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("55f54bea-fb20-4bfd-bc0d-e0f9d7f1503c"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("7b66dc3e-fb34-45c9-aff4-c06464928d7f"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("7b9f4f05-3f05-40a9-93cf-9c87574e36e6"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("83077924-814a-4d84-9a92-c8dce3575281"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("8b880175-fa1a-42c7-888a-1a3a3df9633e"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("a7cfc3e9-241a-43a0-9271-fc244be11781"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("b101b724-9cde-40b1-9407-a33cf9ba73d8"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("dd7afdc9-571d-4805-839d-38076c8343bf"));

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: new Guid("3e96733e-cb1f-449f-9e1a-fbeca40001a4"));

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: new Guid("789d6e24-033b-4a78-8038-2056afdb27c1"));

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: new Guid("adb44fc9-9234-4f02-9dc0-dcb245eda784"));

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: new Guid("09128316-01a3-4c14-a648-a688427be81c"));

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: new Guid("5ce20fa6-abf7-4a25-adfb-9fc1d4bf0168"));

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: new Guid("d9814a1d-9508-4659-8bd3-d91bce395159"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("4eb5e5db-7940-46f6-8005-748107cfa5ad"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("56a340ed-4eda-424c-b2ea-20662fa20b25"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("63934e63-c16f-4dcd-824b-a69c5a33aa15"));

            migrationBuilder.DeleteData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: new Guid("92f346d7-d3eb-45df-9f11-f5befb7699ba"));

            migrationBuilder.DeleteData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: new Guid("9e2ab0b8-a1e7-4993-b2f5-5253c9735456"));

            migrationBuilder.DeleteData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: new Guid("e5eccbe3-c8c0-47f4-86ba-94bc7b835127"));

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
        }
    }
}
