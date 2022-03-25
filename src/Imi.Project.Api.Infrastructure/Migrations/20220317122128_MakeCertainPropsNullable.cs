using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Imi.Project.Api.Infrastructure.Migrations
{
    public partial class MakeCertainPropsNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: new Guid("7ad87259-0659-4139-9e61-00a6d965b529"));

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: new Guid("ab1e6496-f389-4b31-817c-f0eff8643b8b"));

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: new Guid("b08f5c5a-0273-4ed7-bd8e-fada782fed7c"));

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: new Guid("ae23c91d-dc3f-4076-bdf6-05c8043bcb89"));

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: new Guid("c7e75a35-a2e4-45cb-920f-c2d3f58073a5"));

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: new Guid("cd552240-5afe-4bb4-a4d1-0e6ef0b39110"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("0074cf33-a3dc-4aee-9eff-faf4b2662b52"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("5551f78b-51f6-4abe-844a-bf0757f064f7"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("e8de0249-2860-4dc3-bad1-12a23787a730"));

            migrationBuilder.DeleteData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: new Guid("2060867d-622e-48af-b7f7-454fa0b95a1d"));

            migrationBuilder.DeleteData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: new Guid("6c841066-3347-4da3-90bb-2c9f2fab562a"));

            migrationBuilder.DeleteData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: new Guid("c48b695d-0fb0-4867-ab89-21ae9a7f76c0"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "Airports",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedOn",
                table: "Airports",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "Airlines",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedOn",
                table: "Airlines",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "AircraftTypes",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedOn",
                table: "AircraftTypes",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "Aircrafts",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedOn",
                table: "Aircrafts",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.InsertData(
                table: "AircraftTypes",
                columns: new[] { "Id", "AddedOn", "Brand", "EmptyWeight", "FirstFlight", "Height", "ICAOCode", "Length", "ModifiedOn", "Type", "WingSpan" },
                values: new object[,]
                {
                    { new Guid("88e02962-1877-42e6-ae7c-59d2a8d90bdb"), new DateTime(2022, 3, 17, 13, 21, 27, 264, DateTimeKind.Local).AddTicks(4601), "Airbus", 42400, new DateTime(1987, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.76, "A320", 37.57, new DateTime(2022, 3, 17, 13, 21, 27, 270, DateTimeKind.Local).AddTicks(564), "A320-200", 34.100000000000001 },
                    { new Guid("b12f19d6-fa95-41a3-b44e-e2c327b12da1"), new DateTime(2022, 3, 17, 13, 21, 27, 270, DateTimeKind.Local).AddTicks(1420), "Boeing", 118000, new DateTime(2009, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 16.899999999999999, "B788", 56.700000000000003, new DateTime(2022, 3, 17, 13, 21, 27, 270, DateTimeKind.Local).AddTicks(1437), "787-8", 60.100000000000001 },
                    { new Guid("1221259b-c372-466a-9162-0af0bcf2d78b"), new DateTime(2022, 3, 17, 13, 21, 27, 270, DateTimeKind.Local).AddTicks(1459), "McDonnel Douglas", 112748, new DateTime(1990, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 17.600000000000001, "MD11", 61.399999999999999, new DateTime(2022, 3, 17, 13, 21, 27, 270, DateTimeKind.Local).AddTicks(1464), "MD-11", 51.700000000000003 }
                });

            migrationBuilder.InsertData(
                table: "Airlines",
                columns: new[] { "Id", "AddedOn", "FleetSize", "HeadQuarter", "IATACode", "ICAOCode", "MainAirport", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { new Guid("b56e1c5d-ae9f-4720-9962-096ac38f8e99"), new DateTime(2022, 3, 17, 13, 21, 27, 270, DateTimeKind.Local).AddTicks(4527), 49, "Diegem, België", "SN", "BEL", "Brussels Airport", new DateTime(2022, 3, 17, 13, 21, 27, 270, DateTimeKind.Local).AddTicks(4545), "Brussels Airlines" },
                    { new Guid("04a65fd0-ead5-49f9-bbde-9c93026d42bd"), new DateTime(2022, 3, 17, 13, 21, 27, 270, DateTimeKind.Local).AddTicks(4561), 32, "Zaventem, België", "TB", "JAF", "Brussels Airport", new DateTime(2022, 3, 17, 13, 21, 27, 270, DateTimeKind.Local).AddTicks(4565), "TUI Fly" },
                    { new Guid("1f482fc7-44e4-4d22-b3be-13f883011a71"), new DateTime(2022, 3, 17, 13, 21, 27, 270, DateTimeKind.Local).AddTicks(4583), 18, "Frankfurt, Duitsland", "LH", "GEC", "Frankfurt am Main", new DateTime(2022, 3, 17, 13, 21, 27, 270, DateTimeKind.Local).AddTicks(4587), "Lufthansa Cargo" }
                });

            migrationBuilder.InsertData(
                table: "Airports",
                columns: new[] { "Id", "AddedOn", "City", "Country", "ElevationAMSL", "IATACode", "ICAOCode", "ModifiedOn", "Name", "RunwayAmount", "TerminalAmount" },
                values: new object[,]
                {
                    { new Guid("b6b302d0-e135-4516-901a-077c20a7ed74"), new DateTime(2022, 3, 17, 13, 21, 27, 270, DateTimeKind.Local).AddTicks(8189), "Zaventem", "België", 56, "BRU", "EBBR", new DateTime(2022, 3, 17, 13, 21, 27, 270, DateTimeKind.Local).AddTicks(8208), "Brussels Airport", 3, 1 },
                    { new Guid("eb6091cf-7f90-4380-9fab-54075748ab6f"), new DateTime(2022, 3, 17, 13, 21, 27, 270, DateTimeKind.Local).AddTicks(8224), "Nice", "Frankrijk", 4, "NCE", "LFMN", new DateTime(2022, 3, 17, 13, 21, 27, 270, DateTimeKind.Local).AddTicks(8228), "Nice Côte d'Azur", 2, 3 },
                    { new Guid("290a3080-1d18-429b-a205-2b9d042a2372"), new DateTime(2022, 3, 17, 13, 21, 27, 270, DateTimeKind.Local).AddTicks(8236), "Narita", "japan", 41, "NRT", "RJAA", new DateTime(2022, 3, 17, 13, 21, 27, 270, DateTimeKind.Local).AddTicks(8240), "Tokyo Narita Intl. Airport", 2, 3 }
                });

            migrationBuilder.InsertData(
                table: "Aircrafts",
                columns: new[] { "Id", "AddedOn", "AircraftTypeId", "AirlineId", "FirstSeen", "HasSpecialLivery", "Image", "LastSeen", "Latitude", "Longitude", "ModifiedOn", "Registration" },
                values: new object[] { new Guid("059fd843-b72a-489f-90ff-e4c9d420f5b1"), new DateTime(2022, 3, 17, 13, 21, 27, 271, DateTimeKind.Local).AddTicks(1520), new Guid("88e02962-1877-42e6-ae7c-59d2a8d90bdb"), new Guid("b56e1c5d-ae9f-4720-9962-096ac38f8e99"), new DateTime(2021, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(2021, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2022, 3, 17, 13, 21, 27, 271, DateTimeKind.Local).AddTicks(1538), "OO-SNJ" });

            migrationBuilder.InsertData(
                table: "Aircrafts",
                columns: new[] { "Id", "AddedOn", "AircraftTypeId", "AirlineId", "FirstSeen", "HasSpecialLivery", "Image", "LastSeen", "Latitude", "Longitude", "ModifiedOn", "Registration" },
                values: new object[] { new Guid("4e91be6b-1477-47ac-8fc6-9777fb2bec5a"), new DateTime(2022, 3, 17, 13, 21, 27, 271, DateTimeKind.Local).AddTicks(1557), new Guid("b12f19d6-fa95-41a3-b44e-e2c327b12da1"), new Guid("04a65fd0-ead5-49f9-bbde-9c93026d42bd"), new DateTime(2020, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(2021, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2022, 3, 17, 13, 21, 27, 271, DateTimeKind.Local).AddTicks(1560), "OO-LOE" });

            migrationBuilder.InsertData(
                table: "Aircrafts",
                columns: new[] { "Id", "AddedOn", "AircraftTypeId", "AirlineId", "FirstSeen", "HasSpecialLivery", "Image", "LastSeen", "Latitude", "Longitude", "ModifiedOn", "Registration" },
                values: new object[] { new Guid("e1c0ab7f-58ff-43ba-981e-cef16440bf9f"), new DateTime(2022, 3, 17, 13, 21, 27, 271, DateTimeKind.Local).AddTicks(1569), new Guid("1221259b-c372-466a-9162-0af0bcf2d78b"), new Guid("1f482fc7-44e4-4d22-b3be-13f883011a71"), new DateTime(2020, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(2021, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2022, 3, 17, 13, 21, 27, 271, DateTimeKind.Local).AddTicks(1572), "D-ALCC" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: new Guid("059fd843-b72a-489f-90ff-e4c9d420f5b1"));

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: new Guid("4e91be6b-1477-47ac-8fc6-9777fb2bec5a"));

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: new Guid("e1c0ab7f-58ff-43ba-981e-cef16440bf9f"));

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: new Guid("290a3080-1d18-429b-a205-2b9d042a2372"));

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: new Guid("b6b302d0-e135-4516-901a-077c20a7ed74"));

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: new Guid("eb6091cf-7f90-4380-9fab-54075748ab6f"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("1221259b-c372-466a-9162-0af0bcf2d78b"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("88e02962-1877-42e6-ae7c-59d2a8d90bdb"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("b12f19d6-fa95-41a3-b44e-e2c327b12da1"));

            migrationBuilder.DeleteData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: new Guid("04a65fd0-ead5-49f9-bbde-9c93026d42bd"));

            migrationBuilder.DeleteData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: new Guid("1f482fc7-44e4-4d22-b3be-13f883011a71"));

            migrationBuilder.DeleteData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: new Guid("b56e1c5d-ae9f-4720-9962-096ac38f8e99"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "Airports",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedOn",
                table: "Airports",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "Airlines",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedOn",
                table: "Airlines",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "AircraftTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedOn",
                table: "AircraftTypes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedOn",
                table: "Aircrafts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddedOn",
                table: "Aircrafts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

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
        }
    }
}
