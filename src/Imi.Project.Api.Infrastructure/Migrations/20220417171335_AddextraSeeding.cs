using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Imi.Project.Api.Infrastructure.Migrations
{
    public partial class AddextraSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("5bccee53-e535-4499-8eb5-6b4a386d7ab2"), new DateTime(2022, 4, 17, 19, 13, 34, 409, DateTimeKind.Local).AddTicks(5426), "Airbus", 42400, new DateTime(1987, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.76, "A320", 37.57, new DateTime(2022, 4, 17, 19, 13, 34, 414, DateTimeKind.Local).AddTicks(7106), "A320-200", 34.100000000000001 },
                    { new Guid("3bc815c7-d174-419b-956e-9da1e1b082de"), new DateTime(2022, 4, 17, 19, 13, 34, 414, DateTimeKind.Local).AddTicks(8371), "Embraer", 27837, new DateTime(2004, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.57, "E190", 36.25, new DateTime(2022, 4, 17, 19, 13, 34, 414, DateTimeKind.Local).AddTicks(8375), "E190", 28.73 },
                    { new Guid("4888f02a-0d09-4349-a7a9-ace80b7e4d44"), new DateTime(2022, 4, 17, 19, 13, 34, 414, DateTimeKind.Local).AddTicks(8352), "Boeing", 135500, new DateTime(2017, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 17.02, "B78X", 68.280000000000001, new DateTime(2022, 4, 17, 19, 13, 34, 414, DateTimeKind.Local).AddTicks(8356), "787-10", 60.119999999999997 },
                    { new Guid("2ae21be1-be05-4553-9b46-323c925c5a33"), new DateTime(2022, 4, 17, 19, 13, 34, 414, DateTimeKind.Local).AddTicks(8337), "Boeing", 128850, new DateTime(2013, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 17.02, "B789", 62.810000000000002, new DateTime(2022, 4, 17, 19, 13, 34, 414, DateTimeKind.Local).AddTicks(8341), "787-9", 60.119999999999997 },
                    { new Guid("510991c9-792c-4ca5-b1db-f7b646f629ba"), new DateTime(2022, 4, 17, 19, 13, 34, 414, DateTimeKind.Local).AddTicks(8321), "Boeing", 167829, new DateTime(2003, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 18.5, "B77W", 73.859999999999999, new DateTime(2022, 4, 17, 19, 13, 34, 414, DateTimeKind.Local).AddTicks(8325), "777-300ER", 64.799999999999997 },
                    { new Guid("6df95d12-e71d-4e4f-8da8-1e44e51a0794"), new DateTime(2022, 4, 17, 19, 13, 34, 414, DateTimeKind.Local).AddTicks(8306), "Boeing", 197100, new DateTime(2010, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 19.399999999999999, "B748", 76.299999999999997, new DateTime(2022, 4, 17, 19, 13, 34, 414, DateTimeKind.Local).AddTicks(8310), "747-8", 68.400000000000006 },
                    { new Guid("4a88eb40-23ee-4100-ba56-2fb8ea551faf"), new DateTime(2022, 4, 17, 19, 13, 34, 414, DateTimeKind.Local).AddTicks(8291), "Boeing", 183523, new DateTime(1988, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 19.41, "B744", 70.659999999999997, new DateTime(2022, 4, 17, 19, 13, 34, 414, DateTimeKind.Local).AddTicks(8295), "747-400", 64.439999999999998 },
                    { new Guid("2d67f058-6028-4f76-a8d0-88c245f1d3f4"), new DateTime(2022, 4, 17, 19, 13, 34, 414, DateTimeKind.Local).AddTicks(8275), "Boeing", 45070, new DateTime(2016, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.289999999999999, "B38M", 39.520000000000003, new DateTime(2022, 4, 17, 19, 13, 34, 414, DateTimeKind.Local).AddTicks(8279), "737-MAX 8", 35.920000000000002 },
                    { new Guid("98547d04-ab7e-49e7-8877-d507e854e73e"), new DateTime(2022, 4, 17, 19, 13, 34, 414, DateTimeKind.Local).AddTicks(8260), "Boeing", 41145, new DateTime(1994, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.0, "B738", 40.0, new DateTime(2022, 4, 17, 19, 13, 34, 414, DateTimeKind.Local).AddTicks(8264), "737-800", 34.32 },
                    { new Guid("e92c3784-f9ea-476a-838e-43e093e51211"), new DateTime(2022, 4, 17, 19, 13, 34, 414, DateTimeKind.Local).AddTicks(8225), "Airbus", 155000, new DateTime(2016, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 17.079999999999998, "A35K", 73.790000000000006, new DateTime(2022, 4, 17, 19, 13, 34, 414, DateTimeKind.Local).AddTicks(8229), "A350-1000", 64.75 },
                    { new Guid("792d35d2-79a1-4e8d-8700-09f1ade367ef"), new DateTime(2022, 4, 17, 19, 13, 34, 414, DateTimeKind.Local).AddTicks(8210), "Airbus", 142400, new DateTime(2013, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 17.050000000000001, "A359", 66.799999999999997, new DateTime(2022, 4, 17, 19, 13, 34, 414, DateTimeKind.Local).AddTicks(8214), "A350-900", 64.75 },
                    { new Guid("46495c9e-8bf5-4c83-8b53-d1b067170e01"), new DateTime(2022, 4, 17, 19, 13, 34, 414, DateTimeKind.Local).AddTicks(8195), "Airbus", 177800, new DateTime(2001, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 17.93, "A346", 76.359999999999999, new DateTime(2022, 4, 17, 19, 13, 34, 414, DateTimeKind.Local).AddTicks(8199), "A340-600", 63.450000000000003 },
                    { new Guid("b9f3705c-75d3-4ca6-a5da-ef6d1b72c7a2"), new DateTime(2022, 4, 17, 19, 13, 34, 414, DateTimeKind.Local).AddTicks(8180), "Airbus", 131000, new DateTime(1991, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 16.989999999999998, "A343", 63.659999999999997, new DateTime(2022, 4, 17, 19, 13, 34, 414, DateTimeKind.Local).AddTicks(8184), "A340-300", 60.299999999999997 },
                    { new Guid("38d15406-95a1-466a-a20b-24db2215e1fd"), new DateTime(2022, 4, 17, 19, 13, 34, 414, DateTimeKind.Local).AddTicks(8243), "Airbus", 277145, new DateTime(2005, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 24.09, "A388", 72.719999999999999, new DateTime(2022, 4, 17, 19, 13, 34, 414, DateTimeKind.Local).AddTicks(8249), "A380-800", 79.75 },
                    { new Guid("5831e3ac-d936-48ff-a56b-4a7464fc641f"), new DateTime(2022, 4, 17, 19, 13, 34, 414, DateTimeKind.Local).AddTicks(8147), "Airbus", 132000, new DateTime(2018, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 17.390000000000001, "A338", 58.82, new DateTime(2022, 4, 17, 19, 13, 34, 414, DateTimeKind.Local).AddTicks(8152), "A330-800", 64.0 },
                    { new Guid("6dcf2a86-727c-4186-8f17-9d6f44ddcba7"), new DateTime(2022, 4, 17, 19, 13, 34, 414, DateTimeKind.Local).AddTicks(7952), "Boeing", 118000, new DateTime(2009, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 16.899999999999999, "B788", 56.700000000000003, new DateTime(2022, 4, 17, 19, 13, 34, 414, DateTimeKind.Local).AddTicks(7970), "787-8", 60.100000000000001 },
                    { new Guid("27572042-f02e-4e5d-9c0b-8b1acff4e9f9"), new DateTime(2022, 4, 17, 19, 13, 34, 414, DateTimeKind.Local).AddTicks(8165), "Airbus", 135000, new DateTime(2017, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 16.789999999999999, "A339", 63.659999999999997, new DateTime(2022, 4, 17, 19, 13, 34, 414, DateTimeKind.Local).AddTicks(8169), "A330-900", 64.0 },
                    { new Guid("428aa8c2-cb5f-4483-b3b4-66bc4253f4e9"), new DateTime(2022, 4, 17, 19, 13, 34, 414, DateTimeKind.Local).AddTicks(8014), "Airbus", 35220, new DateTime(2013, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.5, "BCS1", 35.0, new DateTime(2022, 4, 17, 19, 13, 34, 414, DateTimeKind.Local).AddTicks(8018), "A220-100", 35.100000000000001 },
                    { new Guid("71b6bb40-c477-44f2-98fd-5934fc97e654"), new DateTime(2022, 4, 17, 19, 13, 34, 414, DateTimeKind.Local).AddTicks(8030), "Airbus", 37080, new DateTime(2015, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.5, "BCS3", 38.710000000000001, new DateTime(2022, 4, 17, 19, 13, 34, 414, DateTimeKind.Local).AddTicks(8034), "A220-300", 35.100000000000001 },
                    { new Guid("7cd6b4ce-1a78-4989-a751-742781b9da07"), new DateTime(2022, 4, 17, 19, 13, 34, 414, DateTimeKind.Local).AddTicks(8044), "Airbus", 40800, new DateTime(1995, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.76, "A319", 33.840000000000003, new DateTime(2022, 4, 17, 19, 13, 34, 414, DateTimeKind.Local).AddTicks(8048), "A319-100", 35.799999999999997 },
                    { new Guid("7573e137-1385-498e-b5a2-f14864c077b0"), new DateTime(2022, 4, 17, 19, 13, 34, 414, DateTimeKind.Local).AddTicks(7996), "McDonnel Douglas", 112748, new DateTime(1990, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 17.600000000000001, "MD11", 61.399999999999999, new DateTime(2022, 4, 17, 19, 13, 34, 414, DateTimeKind.Local).AddTicks(8000), "MD-11", 51.700000000000003 },
                    { new Guid("dde8c4ab-2dc4-4dd9-a39d-7f4a54eb0bb8"), new DateTime(2022, 4, 17, 19, 13, 34, 414, DateTimeKind.Local).AddTicks(8079), "Airbus", 44300, new DateTime(2014, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.76, "A20N", 37.57, new DateTime(2022, 4, 17, 19, 13, 34, 414, DateTimeKind.Local).AddTicks(8083), "A320-neo", 35.799999999999997 },
                    { new Guid("293caa8a-1bab-44ca-8c62-f42a3d6c31aa"), new DateTime(2022, 4, 17, 19, 13, 34, 414, DateTimeKind.Local).AddTicks(8096), "Airbus", 50100, new DateTime(2016, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.76, "A21N", 44.509999999999998, new DateTime(2022, 4, 17, 19, 13, 34, 414, DateTimeKind.Local).AddTicks(8100), "A321-neo", 35.799999999999997 },
                    { new Guid("fce7912b-4d41-4fe1-a804-2f4d3f779150"), new DateTime(2022, 4, 17, 19, 13, 34, 414, DateTimeKind.Local).AddTicks(8116), "Airbus", 120600, new DateTime(1997, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 17.390000000000001, "A332", 58.82, new DateTime(2022, 4, 17, 19, 13, 34, 414, DateTimeKind.Local).AddTicks(8120), "A330-200", 60.299999999999997 },
                    { new Guid("61a95e91-af3d-45f2-a42c-3bb2611c237a"), new DateTime(2022, 4, 17, 19, 13, 34, 414, DateTimeKind.Local).AddTicks(8132), "Airbus", 129400, new DateTime(1992, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 16.789999999999999, "A333", 63.659999999999997, new DateTime(2022, 4, 17, 19, 13, 34, 414, DateTimeKind.Local).AddTicks(8136), "A330-300", 60.299999999999997 },
                    { new Guid("35cc1075-c87e-4285-940d-87ef38645348"), new DateTime(2022, 4, 17, 19, 13, 34, 414, DateTimeKind.Local).AddTicks(8059), "Airbus", 48500, new DateTime(1993, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.76, "A321", 44.509999999999998, new DateTime(2022, 4, 17, 19, 13, 34, 414, DateTimeKind.Local).AddTicks(8063), "A321-200", 35.799999999999997 }
                });

            migrationBuilder.InsertData(
                table: "Airlines",
                columns: new[] { "Id", "AddedOn", "FleetSize", "HeadQuarter", "IATACode", "ICAOCode", "MainAirport", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { new Guid("22f0cba0-7997-42db-ab90-58f4b6c75576"), new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(1630), 318, "Luton, Engeland", "U2", "EZY", "London Luton Airport", new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(1634), "Easyjet" },
                    { new Guid("7612a468-e8f5-432f-b9a3-213b94471a2b"), new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(1692), 213, "Tokyo, Japan", "NH", "ANA", "Tokyo Narita Airport", new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(1695), "All Nippon Airways" },
                    { new Guid("e3ff878c-164d-44d0-93ee-8a3f2349a365"), new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(1682), 254, "Dubai, Verenigde Arabische Emiraten", "EK", "UAE", "Dubai Intl. Airport", new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(1686), "Emirates" },
                    { new Guid("98121394-7229-4ff4-8c1b-513d2d629515"), null, 316, "Saint-Laurent, Canada", "AC", "ACA", "Toronto Pearson Intl. Airport", null, "Air Canada" },
                    { new Guid("ea10430f-6d65-4914-8f67-6286bb359956"), new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(1669), 854, "Willis Tower, Chicago", "UA", "UAL", "Chicago O'Hare Airport", new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(1672), "United Airlines" },
                    { new Guid("99aa6247-694a-4cb8-9012-0e68cda3ada3"), new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(1659), 8, "Mont-Saint-Guilbert, België", "KF", "ABB", "Charleroi Airport", new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(1663), "Air Belgium" },
                    { new Guid("84a99f91-7c55-42bf-9d56-b9181f73c783"), new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(1650), 22, "Sandweiler, Luxemburg", "CV", "CLX", "Luxembourg Airport", new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(1654), "Cargolux" },
                    { new Guid("65819ca4-830f-4903-8c12-552d18fa1f89"), new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(1640), 33, "Mārupe, Letland", "BT", "BTI", "Riga International Airport", new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(1644), "Air Baltic" },
                    { new Guid("e9ed18d2-0155-41bd-a960-67aa895156e7"), new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(1621), 502, "Dublin, Ierland", "FR", "RYR", "Dublin Airport", new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(1624), "Ryanair" },
                    { new Guid("b1330568-5fde-4284-8e47-6446a0e1ad6e"), new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(1555), 75, "Lissabon, Portugal", "TP", "TAP", "Lisbon Airport", new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(1559), "TAP Portugal" },
                    { new Guid("23bf7cb5-1c07-44bf-8c78-5061c71a5387"), new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(1601), 214, "Tremblay-en-France, Frankrijk", "AF", "AFR", "Paris Charles de Gaulle", new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(1605), "Air France" },
                    { new Guid("d5605544-b08c-4eee-88da-8357f5d16e6a"), new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(1584), 277, "Keulen, Duitsland", "LH", "DLH", "Frankurt Am Main", new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(1589), "Lufthansa" },
                    { new Guid("d4327525-e5cb-46ee-a8d4-b0ebed6bef5b"), new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(1575), 57, "Haarlemmermeer, Nederland", "Wa", "KLC", "Amsterdam Schiphol", new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(1579), "KLM Cityhopper" },
                    { new Guid("f832af6e-0fac-4a7f-8bc1-9e2c8376ee7b"), new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(1565), 149, "Amstelveen, Nederland", "KL", "KLM", "Amsterdam Schiphol", new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(1569), "KLM" },
                    { new Guid("d4493829-1fa6-44e4-8822-1030b104c650"), new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(1545), 18, "Frankfurt, Duitsland", "LH", "GEC", "Frankfurt am Main", new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(1549), "Lufthansa Cargo" },
                    { new Guid("97582f54-a34d-43c2-bcf4-28a6e9ba5649"), new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(1533), 32, "Zaventem, België", "TB", "JAF", "Brussels Airport", new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(1538), "TUI Fly" }
                });

            migrationBuilder.InsertData(
                table: "Airlines",
                columns: new[] { "Id", "AddedOn", "FleetSize", "HeadQuarter", "IATACode", "ICAOCode", "MainAirport", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { new Guid("503f27af-be85-418c-afcc-d82b5217d48b"), new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(1498), 49, "Diegem, België", "SN", "BEL", "Brussels Airport", new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(1517), "Brussels Airlines" },
                    { new Guid("11d028a6-d669-4d70-8bdf-30bef430aa9d"), new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(1611), 254, "Londen, Engeland", "BA", "BAW", "Londen Heathrow", new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(1615), "British Airways" }
                });

            migrationBuilder.InsertData(
                table: "Airports",
                columns: new[] { "Id", "AddedOn", "City", "Country", "ElevationAMSL", "IATACode", "ICAOCode", "ModifiedOn", "Name", "RunwayAmount", "TerminalAmount" },
                values: new object[,]
                {
                    { new Guid("230da083-c4c0-4ceb-a642-5ed387f86f02"), new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(5483), "Sandweiler", "Luxemburg", 376, "LUX", "ELLX", new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(5487), "Luxembourg Airport", 1, 2 },
                    { new Guid("5f28fbaf-47bc-4742-84ab-9f00a6ba56d5"), new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(5473), "Tokyo", "Japan", 6, "HND", "RJTT", new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(5476), "Tokyo Haneda Intl. Airport", 4, 3 },
                    { new Guid("93d67ded-8be2-455f-bc83-87cb3e051cd7"), new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(5463), "Los Angeles", "USA", 39, "LAX", "KLAX", new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(5467), "Los Angeles Intl. Airport", 4, 9 },
                    { new Guid("e30a59e5-a736-49f3-92df-eea41c55a47b"), new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(5453), "Dubai", "Verenigde Arabische Emiraten", 19, "DXB", "OMDB", new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(5456), "Dubai Intl. Airport", 2, 3 },
                    { new Guid("9e56ebbd-f55a-4aff-9c52-32420df50e6b"), new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(5443), "Mārupe", "Letland", 11, "RIX", "EVRA", new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(5446), "Riga Intl. Airport", 1, 1 },
                    { new Guid("6ba0bafb-84e3-4a1f-971b-e0833e6621e2"), new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(5429), "	Roissy-en-France", "Frankrijk", 392, "CDG", "LFPG", new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(5436), "Paris CDG Airport", 4, 3 },
                    { new Guid("75e0c4df-32f6-485a-a509-f8d8a47aebf4"), new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(5332), "Kelsterbach", "Duitsland", 111, "FRA", "EDDF", new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(5335), "Franfurt Airport", 4, 2 },
                    { new Guid("2699ec94-bddc-4ebd-a38c-c1d2959a2077"), new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(5408), "Newark", "USA", 5, "EWR", "KEWR", new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(5412), "Newark Liberty Intl. Airport", 3, 3 },
                    { new Guid("4f3f9394-62eb-4bc6-a245-69e4f12fdc3b"), new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(5391), "New York City", "USA", 4, "JFK", "KJFK", new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(5395), "New York JFK Airport", 4, 6 },
                    { new Guid("058ab0f8-3219-4620-9995-71615ccd9e8d"), new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(5319), "Narita", "Japan", 41, "NRT", "RJAA", new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(5323), "Tokyo Narita Intl. Airport", 2, 3 },
                    { new Guid("2eebd904-43bb-424a-9df2-70d5742f57b5"), new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(5307), "Nice", "Frankrijk", 4, "NCE", "LFMN", new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(5311), "Nice Côte d'Azur", 2, 3 },
                    { new Guid("f04caa02-18a8-4738-b502-4b88e0e07d57"), new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(5271), "Zaventem", "België", 56, "BRU", "EBBR", new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(5290), "Brussels Airport", 3, 1 },
                    { new Guid("7152bdb4-ef5c-4df3-882d-5008c9d945d4"), new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(5497), "Hillingdon", "Engeland", 25, "LHR", "EGLL", new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(5500), "London Heathrow Airport", 2, 5 },
                    { new Guid("b338019c-9432-4087-8065-b86c67c73d99"), new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(5419), "Haarlemmermeer", "Nederland", -3, "AMS", "EHAM", new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(5423), "Amsterdam Schiphol Airport", 6, 1 },
                    { new Guid("c08d9317-58ff-4329-8387-e4f561d081f2"), new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(5508), "Crawley", "Engeland", 62, "LGW", "EGKK", new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(5512), "London Gatwick Airport", 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Aircrafts",
                columns: new[] { "Id", "AddedOn", "AircraftTypeId", "AirlineId", "FirstSeen", "HasSpecialLivery", "Image", "LastSeen", "Latitude", "Longitude", "ModifiedOn", "Registration" },
                values: new object[,]
                {
                    { new Guid("292bbfe3-38d3-42e0-bb6a-e6dce315587a"), new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(8935), new Guid("5bccee53-e535-4499-8eb5-6b4a386d7ab2"), new Guid("503f27af-be85-418c-afcc-d82b5217d48b"), new DateTime(2021, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(2021, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(8955), "OO-SNJ" },
                    { new Guid("de6b1b12-53c1-46a1-977a-0d4937834b6f"), new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(8972), new Guid("6dcf2a86-727c-4186-8f17-9d6f44ddcba7"), new Guid("97582f54-a34d-43c2-bcf4-28a6e9ba5649"), new DateTime(2020, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(2021, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(8976), "OO-LOE" },
                    { new Guid("ee0de343-1153-482d-ab95-ff99c73e0ecf"), new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(8983), new Guid("7573e137-1385-498e-b5a2-f14864c077b0"), new Guid("d4493829-1fa6-44e4-8822-1030b104c650"), new DateTime(2020, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(2021, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(8987), "D-ALCC" },
                    { new Guid("1745e404-4b28-4149-b9fe-531155c23ecd"), new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(9116), new Guid("4888f02a-0d09-4349-a7a9-ace80b7e4d44"), new Guid("d4327525-e5cb-46ee-a8d4-b0ebed6bef5b"), new DateTime(2021, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(2021, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(9120), "PH-EZT" },
                    { new Guid("e6023493-3b11-455b-b267-b8c22bb6c860"), new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(9056), new Guid("e92c3784-f9ea-476a-838e-43e093e51211"), new Guid("11d028a6-d669-4d70-8bdf-30bef430aa9d"), new DateTime(2020, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(2021, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(9059), "G-XWBA" },
                    { new Guid("b16d7c51-fdb4-48af-866f-a6ea2557c169"), new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(9067), new Guid("71b6bb40-c477-44f2-98fd-5934fc97e654"), new Guid("65819ca4-830f-4903-8c12-552d18fa1f89"), new DateTime(2020, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, new DateTime(2021, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(9071), "YL-CSJ" },
                    { new Guid("d16af67e-b1f1-4b06-a4ee-13c3b07775eb"), new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(9077), new Guid("71b6bb40-c477-44f2-98fd-5934fc97e654"), new Guid("65819ca4-830f-4903-8c12-552d18fa1f89"), new DateTime(2020, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, new DateTime(2021, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(9081), "YL-CSK" },
                    { new Guid("c602a852-a597-4093-828c-23ec6ddab28c"), new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(9089), new Guid("71b6bb40-c477-44f2-98fd-5934fc97e654"), new Guid("65819ca4-830f-4903-8c12-552d18fa1f89"), new DateTime(2020, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, new DateTime(2020, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(9093), "YL-CSL" },
                    { new Guid("a94802d6-d9c1-428b-a07c-7fdc1184dbf2"), new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(9101), new Guid("71b6bb40-c477-44f2-98fd-5934fc97e654"), new Guid("65819ca4-830f-4903-8c12-552d18fa1f89"), new DateTime(2020, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(2020, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(9106), "YL-CSN" },
                    { new Guid("f6109708-d349-4c3e-b4dc-c46b1bf6f9cf"), new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(8994), new Guid("6df95d12-e71d-4e4f-8da8-1e44e51a0794"), new Guid("84a99f91-7c55-42bf-9d56-b9181f73c783"), new DateTime(2020, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, new DateTime(2021, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(8998), "LX-VCF" },
                    { new Guid("e15037c7-4cbd-47f1-b8c2-ad929d2e9eb1"), new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(9045), new Guid("b9f3705c-75d3-4ca6-a5da-ef6d1b72c7a2"), new Guid("99aa6247-694a-4cb8-9012-0e68cda3ada3"), new DateTime(2020, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(2021, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(9049), "OO-ABA" },
                    { new Guid("515140d5-994b-4c09-9b13-aa68d33399e3"), new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(9017), new Guid("38d15406-95a1-466a-a20b-24db2215e1fd"), new Guid("e3ff878c-164d-44d0-93ee-8a3f2349a365"), new DateTime(2020, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(2021, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(9021), "A6-EDD" },
                    { new Guid("0c45d114-e98a-434b-a4c1-d6836888372a"), new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(9034), new Guid("510991c9-792c-4ca5-b1db-f7b646f629ba"), new Guid("e3ff878c-164d-44d0-93ee-8a3f2349a365"), new DateTime(2020, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, new DateTime(2021, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(9038), "A6-ECI" },
                    { new Guid("23338895-ea6c-42ee-b3ed-41238eda8e55"), new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(9006), new Guid("2ae21be1-be05-4553-9b46-323c925c5a33"), new Guid("7612a468-e8f5-432f-b9a3-213b94471a2b"), new DateTime(2020, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), true, null, new DateTime(2020, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2022, 4, 17, 19, 13, 34, 415, DateTimeKind.Local).AddTicks(9009), "JA873A" }
                });

            migrationBuilder.InsertData(
                table: "AircraftAtAirports",
                columns: new[] { "AircraftId", "AirportId" },
                values: new object[,]
                {
                    { new Guid("292bbfe3-38d3-42e0-bb6a-e6dce315587a"), new Guid("f04caa02-18a8-4738-b502-4b88e0e07d57") },
                    { new Guid("23338895-ea6c-42ee-b3ed-41238eda8e55"), new Guid("058ab0f8-3219-4620-9995-71615ccd9e8d") },
                    { new Guid("0c45d114-e98a-434b-a4c1-d6836888372a"), new Guid("b338019c-9432-4087-8065-b86c67c73d99") },
                    { new Guid("0c45d114-e98a-434b-a4c1-d6836888372a"), new Guid("7152bdb4-ef5c-4df3-882d-5008c9d945d4") },
                    { new Guid("0c45d114-e98a-434b-a4c1-d6836888372a"), new Guid("f04caa02-18a8-4738-b502-4b88e0e07d57") },
                    { new Guid("0c45d114-e98a-434b-a4c1-d6836888372a"), new Guid("e30a59e5-a736-49f3-92df-eea41c55a47b") },
                    { new Guid("515140d5-994b-4c09-9b13-aa68d33399e3"), new Guid("93d67ded-8be2-455f-bc83-87cb3e051cd7") },
                    { new Guid("515140d5-994b-4c09-9b13-aa68d33399e3"), new Guid("7152bdb4-ef5c-4df3-882d-5008c9d945d4") },
                    { new Guid("515140d5-994b-4c09-9b13-aa68d33399e3"), new Guid("6ba0bafb-84e3-4a1f-971b-e0833e6621e2") },
                    { new Guid("515140d5-994b-4c09-9b13-aa68d33399e3"), new Guid("e30a59e5-a736-49f3-92df-eea41c55a47b") },
                    { new Guid("e15037c7-4cbd-47f1-b8c2-ad929d2e9eb1"), new Guid("c08d9317-58ff-4329-8387-e4f561d081f2") },
                    { new Guid("e15037c7-4cbd-47f1-b8c2-ad929d2e9eb1"), new Guid("f04caa02-18a8-4738-b502-4b88e0e07d57") },
                    { new Guid("f6109708-d349-4c3e-b4dc-c46b1bf6f9cf"), new Guid("e30a59e5-a736-49f3-92df-eea41c55a47b") },
                    { new Guid("f6109708-d349-4c3e-b4dc-c46b1bf6f9cf"), new Guid("4f3f9394-62eb-4bc6-a245-69e4f12fdc3b") },
                    { new Guid("f6109708-d349-4c3e-b4dc-c46b1bf6f9cf"), new Guid("93d67ded-8be2-455f-bc83-87cb3e051cd7") },
                    { new Guid("23338895-ea6c-42ee-b3ed-41238eda8e55"), new Guid("5f28fbaf-47bc-4742-84ab-9f00a6ba56d5") },
                    { new Guid("f6109708-d349-4c3e-b4dc-c46b1bf6f9cf"), new Guid("230da083-c4c0-4ceb-a642-5ed387f86f02") },
                    { new Guid("c602a852-a597-4093-828c-23ec6ddab28c"), new Guid("9e56ebbd-f55a-4aff-9c52-32420df50e6b") },
                    { new Guid("d16af67e-b1f1-4b06-a4ee-13c3b07775eb"), new Guid("2eebd904-43bb-424a-9df2-70d5742f57b5") },
                    { new Guid("d16af67e-b1f1-4b06-a4ee-13c3b07775eb"), new Guid("f04caa02-18a8-4738-b502-4b88e0e07d57") },
                    { new Guid("d16af67e-b1f1-4b06-a4ee-13c3b07775eb"), new Guid("9e56ebbd-f55a-4aff-9c52-32420df50e6b") },
                    { new Guid("b16d7c51-fdb4-48af-866f-a6ea2557c169"), new Guid("2eebd904-43bb-424a-9df2-70d5742f57b5") },
                    { new Guid("b16d7c51-fdb4-48af-866f-a6ea2557c169"), new Guid("9e56ebbd-f55a-4aff-9c52-32420df50e6b") },
                    { new Guid("e6023493-3b11-455b-b267-b8c22bb6c860"), new Guid("7152bdb4-ef5c-4df3-882d-5008c9d945d4") },
                    { new Guid("e6023493-3b11-455b-b267-b8c22bb6c860"), new Guid("c08d9317-58ff-4329-8387-e4f561d081f2") },
                    { new Guid("1745e404-4b28-4149-b9fe-531155c23ecd"), new Guid("b338019c-9432-4087-8065-b86c67c73d99") },
                    { new Guid("ee0de343-1153-482d-ab95-ff99c73e0ecf"), new Guid("058ab0f8-3219-4620-9995-71615ccd9e8d") },
                    { new Guid("de6b1b12-53c1-46a1-977a-0d4937834b6f"), new Guid("2eebd904-43bb-424a-9df2-70d5742f57b5") },
                    { new Guid("de6b1b12-53c1-46a1-977a-0d4937834b6f"), new Guid("f04caa02-18a8-4738-b502-4b88e0e07d57") },
                    { new Guid("292bbfe3-38d3-42e0-bb6a-e6dce315587a"), new Guid("058ab0f8-3219-4620-9995-71615ccd9e8d") },
                    { new Guid("292bbfe3-38d3-42e0-bb6a-e6dce315587a"), new Guid("2eebd904-43bb-424a-9df2-70d5742f57b5") },
                    { new Guid("a94802d6-d9c1-428b-a07c-7fdc1184dbf2"), new Guid("9e56ebbd-f55a-4aff-9c52-32420df50e6b") },
                    { new Guid("23338895-ea6c-42ee-b3ed-41238eda8e55"), new Guid("f04caa02-18a8-4738-b502-4b88e0e07d57") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("0c45d114-e98a-434b-a4c1-d6836888372a"), new Guid("7152bdb4-ef5c-4df3-882d-5008c9d945d4") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("0c45d114-e98a-434b-a4c1-d6836888372a"), new Guid("b338019c-9432-4087-8065-b86c67c73d99") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("0c45d114-e98a-434b-a4c1-d6836888372a"), new Guid("e30a59e5-a736-49f3-92df-eea41c55a47b") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("0c45d114-e98a-434b-a4c1-d6836888372a"), new Guid("f04caa02-18a8-4738-b502-4b88e0e07d57") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("1745e404-4b28-4149-b9fe-531155c23ecd"), new Guid("b338019c-9432-4087-8065-b86c67c73d99") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("23338895-ea6c-42ee-b3ed-41238eda8e55"), new Guid("058ab0f8-3219-4620-9995-71615ccd9e8d") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("23338895-ea6c-42ee-b3ed-41238eda8e55"), new Guid("5f28fbaf-47bc-4742-84ab-9f00a6ba56d5") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("23338895-ea6c-42ee-b3ed-41238eda8e55"), new Guid("f04caa02-18a8-4738-b502-4b88e0e07d57") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("292bbfe3-38d3-42e0-bb6a-e6dce315587a"), new Guid("058ab0f8-3219-4620-9995-71615ccd9e8d") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("292bbfe3-38d3-42e0-bb6a-e6dce315587a"), new Guid("2eebd904-43bb-424a-9df2-70d5742f57b5") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("292bbfe3-38d3-42e0-bb6a-e6dce315587a"), new Guid("f04caa02-18a8-4738-b502-4b88e0e07d57") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("515140d5-994b-4c09-9b13-aa68d33399e3"), new Guid("6ba0bafb-84e3-4a1f-971b-e0833e6621e2") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("515140d5-994b-4c09-9b13-aa68d33399e3"), new Guid("7152bdb4-ef5c-4df3-882d-5008c9d945d4") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("515140d5-994b-4c09-9b13-aa68d33399e3"), new Guid("93d67ded-8be2-455f-bc83-87cb3e051cd7") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("515140d5-994b-4c09-9b13-aa68d33399e3"), new Guid("e30a59e5-a736-49f3-92df-eea41c55a47b") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("a94802d6-d9c1-428b-a07c-7fdc1184dbf2"), new Guid("9e56ebbd-f55a-4aff-9c52-32420df50e6b") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("b16d7c51-fdb4-48af-866f-a6ea2557c169"), new Guid("2eebd904-43bb-424a-9df2-70d5742f57b5") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("b16d7c51-fdb4-48af-866f-a6ea2557c169"), new Guid("9e56ebbd-f55a-4aff-9c52-32420df50e6b") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("c602a852-a597-4093-828c-23ec6ddab28c"), new Guid("9e56ebbd-f55a-4aff-9c52-32420df50e6b") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("d16af67e-b1f1-4b06-a4ee-13c3b07775eb"), new Guid("2eebd904-43bb-424a-9df2-70d5742f57b5") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("d16af67e-b1f1-4b06-a4ee-13c3b07775eb"), new Guid("9e56ebbd-f55a-4aff-9c52-32420df50e6b") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("d16af67e-b1f1-4b06-a4ee-13c3b07775eb"), new Guid("f04caa02-18a8-4738-b502-4b88e0e07d57") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("de6b1b12-53c1-46a1-977a-0d4937834b6f"), new Guid("2eebd904-43bb-424a-9df2-70d5742f57b5") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("de6b1b12-53c1-46a1-977a-0d4937834b6f"), new Guid("f04caa02-18a8-4738-b502-4b88e0e07d57") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("e15037c7-4cbd-47f1-b8c2-ad929d2e9eb1"), new Guid("c08d9317-58ff-4329-8387-e4f561d081f2") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("e15037c7-4cbd-47f1-b8c2-ad929d2e9eb1"), new Guid("f04caa02-18a8-4738-b502-4b88e0e07d57") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("e6023493-3b11-455b-b267-b8c22bb6c860"), new Guid("7152bdb4-ef5c-4df3-882d-5008c9d945d4") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("e6023493-3b11-455b-b267-b8c22bb6c860"), new Guid("c08d9317-58ff-4329-8387-e4f561d081f2") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("ee0de343-1153-482d-ab95-ff99c73e0ecf"), new Guid("058ab0f8-3219-4620-9995-71615ccd9e8d") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("f6109708-d349-4c3e-b4dc-c46b1bf6f9cf"), new Guid("230da083-c4c0-4ceb-a642-5ed387f86f02") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("f6109708-d349-4c3e-b4dc-c46b1bf6f9cf"), new Guid("4f3f9394-62eb-4bc6-a245-69e4f12fdc3b") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("f6109708-d349-4c3e-b4dc-c46b1bf6f9cf"), new Guid("93d67ded-8be2-455f-bc83-87cb3e051cd7") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("f6109708-d349-4c3e-b4dc-c46b1bf6f9cf"), new Guid("e30a59e5-a736-49f3-92df-eea41c55a47b") });

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("27572042-f02e-4e5d-9c0b-8b1acff4e9f9"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("293caa8a-1bab-44ca-8c62-f42a3d6c31aa"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("2d67f058-6028-4f76-a8d0-88c245f1d3f4"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("35cc1075-c87e-4285-940d-87ef38645348"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("3bc815c7-d174-419b-956e-9da1e1b082de"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("428aa8c2-cb5f-4483-b3b4-66bc4253f4e9"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("46495c9e-8bf5-4c83-8b53-d1b067170e01"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("4a88eb40-23ee-4100-ba56-2fb8ea551faf"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("5831e3ac-d936-48ff-a56b-4a7464fc641f"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("61a95e91-af3d-45f2-a42c-3bb2611c237a"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("792d35d2-79a1-4e8d-8700-09f1ade367ef"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("7cd6b4ce-1a78-4989-a751-742781b9da07"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("98547d04-ab7e-49e7-8877-d507e854e73e"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("dde8c4ab-2dc4-4dd9-a39d-7f4a54eb0bb8"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("fce7912b-4d41-4fe1-a804-2f4d3f779150"));

            migrationBuilder.DeleteData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: new Guid("22f0cba0-7997-42db-ab90-58f4b6c75576"));

            migrationBuilder.DeleteData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: new Guid("23bf7cb5-1c07-44bf-8c78-5061c71a5387"));

            migrationBuilder.DeleteData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: new Guid("98121394-7229-4ff4-8c1b-513d2d629515"));

            migrationBuilder.DeleteData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: new Guid("b1330568-5fde-4284-8e47-6446a0e1ad6e"));

            migrationBuilder.DeleteData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: new Guid("d5605544-b08c-4eee-88da-8357f5d16e6a"));

            migrationBuilder.DeleteData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: new Guid("e9ed18d2-0155-41bd-a960-67aa895156e7"));

            migrationBuilder.DeleteData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: new Guid("ea10430f-6d65-4914-8f67-6286bb359956"));

            migrationBuilder.DeleteData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: new Guid("f832af6e-0fac-4a7f-8bc1-9e2c8376ee7b"));

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: new Guid("2699ec94-bddc-4ebd-a38c-c1d2959a2077"));

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: new Guid("75e0c4df-32f6-485a-a509-f8d8a47aebf4"));

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: new Guid("0c45d114-e98a-434b-a4c1-d6836888372a"));

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: new Guid("1745e404-4b28-4149-b9fe-531155c23ecd"));

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: new Guid("23338895-ea6c-42ee-b3ed-41238eda8e55"));

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: new Guid("292bbfe3-38d3-42e0-bb6a-e6dce315587a"));

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: new Guid("515140d5-994b-4c09-9b13-aa68d33399e3"));

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: new Guid("a94802d6-d9c1-428b-a07c-7fdc1184dbf2"));

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: new Guid("b16d7c51-fdb4-48af-866f-a6ea2557c169"));

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: new Guid("c602a852-a597-4093-828c-23ec6ddab28c"));

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: new Guid("d16af67e-b1f1-4b06-a4ee-13c3b07775eb"));

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: new Guid("de6b1b12-53c1-46a1-977a-0d4937834b6f"));

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: new Guid("e15037c7-4cbd-47f1-b8c2-ad929d2e9eb1"));

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: new Guid("e6023493-3b11-455b-b267-b8c22bb6c860"));

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: new Guid("ee0de343-1153-482d-ab95-ff99c73e0ecf"));

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: new Guid("f6109708-d349-4c3e-b4dc-c46b1bf6f9cf"));

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: new Guid("058ab0f8-3219-4620-9995-71615ccd9e8d"));

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: new Guid("230da083-c4c0-4ceb-a642-5ed387f86f02"));

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: new Guid("2eebd904-43bb-424a-9df2-70d5742f57b5"));

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: new Guid("4f3f9394-62eb-4bc6-a245-69e4f12fdc3b"));

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: new Guid("5f28fbaf-47bc-4742-84ab-9f00a6ba56d5"));

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: new Guid("6ba0bafb-84e3-4a1f-971b-e0833e6621e2"));

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: new Guid("7152bdb4-ef5c-4df3-882d-5008c9d945d4"));

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: new Guid("93d67ded-8be2-455f-bc83-87cb3e051cd7"));

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: new Guid("9e56ebbd-f55a-4aff-9c52-32420df50e6b"));

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: new Guid("b338019c-9432-4087-8065-b86c67c73d99"));

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: new Guid("c08d9317-58ff-4329-8387-e4f561d081f2"));

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: new Guid("e30a59e5-a736-49f3-92df-eea41c55a47b"));

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: new Guid("f04caa02-18a8-4738-b502-4b88e0e07d57"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("2ae21be1-be05-4553-9b46-323c925c5a33"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("38d15406-95a1-466a-a20b-24db2215e1fd"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("4888f02a-0d09-4349-a7a9-ace80b7e4d44"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("510991c9-792c-4ca5-b1db-f7b646f629ba"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("5bccee53-e535-4499-8eb5-6b4a386d7ab2"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("6dcf2a86-727c-4186-8f17-9d6f44ddcba7"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("6df95d12-e71d-4e4f-8da8-1e44e51a0794"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("71b6bb40-c477-44f2-98fd-5934fc97e654"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("7573e137-1385-498e-b5a2-f14864c077b0"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("b9f3705c-75d3-4ca6-a5da-ef6d1b72c7a2"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("e92c3784-f9ea-476a-838e-43e093e51211"));

            migrationBuilder.DeleteData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: new Guid("11d028a6-d669-4d70-8bdf-30bef430aa9d"));

            migrationBuilder.DeleteData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: new Guid("503f27af-be85-418c-afcc-d82b5217d48b"));

            migrationBuilder.DeleteData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: new Guid("65819ca4-830f-4903-8c12-552d18fa1f89"));

            migrationBuilder.DeleteData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: new Guid("7612a468-e8f5-432f-b9a3-213b94471a2b"));

            migrationBuilder.DeleteData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: new Guid("84a99f91-7c55-42bf-9d56-b9181f73c783"));

            migrationBuilder.DeleteData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: new Guid("97582f54-a34d-43c2-bcf4-28a6e9ba5649"));

            migrationBuilder.DeleteData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: new Guid("99aa6247-694a-4cb8-9012-0e68cda3ada3"));

            migrationBuilder.DeleteData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: new Guid("d4327525-e5cb-46ee-a8d4-b0ebed6bef5b"));

            migrationBuilder.DeleteData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: new Guid("d4493829-1fa6-44e4-8822-1030b104c650"));

            migrationBuilder.DeleteData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: new Guid("e3ff878c-164d-44d0-93ee-8a3f2349a365"));

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
    }
}
