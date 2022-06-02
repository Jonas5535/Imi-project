using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Imi.Project.Api.Infrastructure.Migrations
{
    public partial class AddImagesToSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("d0f6e18b-fdfb-47a5-aee8-291672abf248"), new DateTime(2022, 6, 2, 17, 3, 7, 605, DateTimeKind.Local).AddTicks(5718), "Airbus", 42400, new DateTime(1987, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.76, "A320", 37.57, new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(4582), "A320-200", 34.100000000000001 },
                    { new Guid("e2277b3b-0c45-465e-9e55-4b06ca5ab320"), new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(5889), "Embraer", 27837, new DateTime(2004, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 10.57, "E190", 36.25, new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(5893), "E190", 28.73 },
                    { new Guid("5ae76cf4-a778-4cca-b949-de90a3ad8e44"), new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(5871), "Boeing", 135500, new DateTime(2017, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 17.02, "B78X", 68.280000000000001, new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(5875), "787-10", 60.119999999999997 },
                    { new Guid("089e20c3-662c-471f-a31a-73479818bce6"), new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(5856), "Boeing", 128850, new DateTime(2013, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 17.02, "B789", 62.810000000000002, new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(5860), "787-9", 60.119999999999997 },
                    { new Guid("ea604c2f-a468-4610-b2c4-67254e09c9e9"), new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(5842), "Boeing", 167829, new DateTime(2003, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 18.5, "B77W", 73.859999999999999, new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(5846), "777-300ER", 64.799999999999997 },
                    { new Guid("8031c796-ee62-40ea-bbbd-287db9b748c6"), new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(5828), "Boeing", 197100, new DateTime(2010, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 19.399999999999999, "B748", 76.299999999999997, new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(5831), "747-8", 68.400000000000006 },
                    { new Guid("ca223507-ec42-4aaf-b9a0-c7009a9bcb02"), new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(5813), "Boeing", 183523, new DateTime(1988, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 19.41, "B744", 70.659999999999997, new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(5817), "747-400", 64.439999999999998 },
                    { new Guid("a34b4e69-a43d-4373-a4f5-d627532d6b83"), new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(5798), "Boeing", 45070, new DateTime(2016, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.289999999999999, "B38M", 39.520000000000003, new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(5802), "737-MAX 8", 35.920000000000002 },
                    { new Guid("d0e1c5ae-1695-41ae-9dca-1d39dec9c867"), new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(5780), "Boeing", 41145, new DateTime(1994, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 12.0, "B738", 40.0, new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(5784), "737-800", 34.32 },
                    { new Guid("a918c937-d09b-49c4-88d6-2a04955b2145"), new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(5683), "Airbus", 155000, new DateTime(2016, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 17.079999999999998, "A35K", 73.790000000000006, new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(5686), "A350-1000", 64.75 },
                    { new Guid("e3fe0847-d6ad-4c06-ac0d-4524132b8524"), new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(5668), "Airbus", 142400, new DateTime(2013, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 17.050000000000001, "A359", 66.799999999999997, new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(5672), "A350-900", 64.75 },
                    { new Guid("889d61b9-f656-4148-8096-1ad3b04df613"), new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(5653), "Airbus", 177800, new DateTime(2001, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 17.93, "A346", 76.359999999999999, new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(5656), "A340-600", 63.450000000000003 },
                    { new Guid("82aaaa67-255e-4e3a-8308-516fee583a4b"), new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(5636), "Airbus", 131000, new DateTime(1991, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 16.989999999999998, "A343", 63.659999999999997, new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(5640), "A340-300", 60.299999999999997 },
                    { new Guid("9841abae-4be4-4da4-a2af-77af641c9348"), new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(5764), "Airbus", 277145, new DateTime(2005, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 24.09, "A388", 72.719999999999999, new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(5769), "A380-800", 79.75 },
                    { new Guid("5cd4da33-4ad0-4ae0-96dd-9872dd3a7895"), new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(5607), "Airbus", 132000, new DateTime(2018, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 17.390000000000001, "A338", 58.82, new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(5611), "A330-800", 64.0 },
                    { new Guid("9573390e-aab9-483a-9cba-75fc30fdc81b"), new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(5418), "Boeing", 118000, new DateTime(2009, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 16.899999999999999, "B788", 56.700000000000003, new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(5436), "787-8", 60.100000000000001 },
                    { new Guid("75cf6016-3055-4eff-83be-9ca0b3464232"), new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(5621), "Airbus", 135000, new DateTime(2017, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 16.789999999999999, "A339", 63.659999999999997, new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(5625), "A330-900", 64.0 },
                    { new Guid("4049f23d-a9d4-4a80-a46d-072ea7d2caf2"), new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(5479), "Airbus", 35220, new DateTime(2013, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.5, "BCS1", 35.0, new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(5483), "A220-100", 35.100000000000001 },
                    { new Guid("fc076baf-62e1-4e49-9151-cf9c77656b28"), new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(5496), "Airbus", 37080, new DateTime(2015, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.5, "BCS3", 38.710000000000001, new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(5500), "A220-300", 35.100000000000001 },
                    { new Guid("001cfcbc-4b72-490b-b495-d3363bb9a499"), new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(5511), "Airbus", 40800, new DateTime(1995, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.76, "A319", 33.840000000000003, new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(5515), "A319-100", 35.799999999999997 },
                    { new Guid("3f9ea1d7-71f0-4577-b55c-bf2ed58805e3"), new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(5460), "McDonnel Douglas", 112748, new DateTime(1990, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 17.600000000000001, "MD11", 61.399999999999999, new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(5464), "MD-11", 51.700000000000003 },
                    { new Guid("29aeea55-f59b-4e63-9af7-f98eaf5e8937"), new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(5541), "Airbus", 44300, new DateTime(2014, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.76, "A20N", 37.57, new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(5545), "A320-neo", 35.799999999999997 },
                    { new Guid("1f36b76a-77b0-4f2e-83b6-f280fae00fce"), new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(5556), "Airbus", 50100, new DateTime(2016, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.76, "A21N", 44.509999999999998, new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(5560), "A321-neo", 35.799999999999997 },
                    { new Guid("181e8515-d557-447f-a78c-6ee4c08943e2"), new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(5576), "Airbus", 120600, new DateTime(1997, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 17.390000000000001, "A332", 58.82, new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(5580), "A330-200", 60.299999999999997 },
                    { new Guid("8bf6be8c-5f12-4451-a1ba-1fe0bc5b5301"), new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(5591), "Airbus", 129400, new DateTime(1992, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 16.789999999999999, "A333", 63.659999999999997, new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(5596), "A330-300", 60.299999999999997 },
                    { new Guid("86394a02-f047-4530-9579-83ad47dbc1e1"), new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(5527), "Airbus", 48500, new DateTime(1993, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 11.76, "A321", 44.509999999999998, new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(5531), "A321-200", 35.799999999999997 }
                });

            migrationBuilder.InsertData(
                table: "Airlines",
                columns: new[] { "Id", "AddedOn", "FleetSize", "HeadQuarter", "IATACode", "ICAOCode", "MainAirport", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { new Guid("7869c2f5-00b4-4817-b1d4-b375e09af828"), new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(9127), 318, "Luton, Engeland", "U2", "EZY", "London Luton Airport", new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(9131), "Easyjet" },
                    { new Guid("3dd0aca4-548c-4cf0-b540-b035334fea20"), new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(9189), 213, "Tokyo, Japan", "NH", "ANA", "Tokyo Narita Airport", new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(9193), "All Nippon Airways" },
                    { new Guid("37e18490-4683-47aa-a27f-359f0bb60525"), new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(9180), 254, "Dubai, Verenigde Arabische Emiraten", "EK", "UAE", "Dubai Intl. Airport", new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(9183), "Emirates" },
                    { new Guid("e348e371-91ba-447e-b11a-7154c5d57c09"), null, 316, "Saint-Laurent, Canada", "AC", "ACA", "Toronto Pearson Intl. Airport", null, "Air Canada" },
                    { new Guid("f902dc81-28d7-4fea-938e-7cc3f82c8c0d"), new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(9166), 854, "Willis Tower, Chicago", "UA", "UAL", "Chicago O'Hare Airport", new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(9169), "United Airlines" },
                    { new Guid("95fb0ecc-eb8a-4021-a8dd-9c1b0e38a86c"), new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(9156), 8, "Mont-Saint-Guilbert, België", "KF", "ABB", "Charleroi Airport", new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(9160), "Air Belgium" },
                    { new Guid("0e182523-012e-443a-af95-bf0061309655"), new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(9145), 22, "Sandweiler, Luxemburg", "CV", "CLX", "Luxembourg Airport", new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(9149), "Cargolux" },
                    { new Guid("47fb36ab-ec0b-48dd-853a-0c0d3124f40f"), new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(9136), 33, "Mārupe, Letland", "BT", "BTI", "Riga International Airport", new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(9140), "Air Baltic" },
                    { new Guid("6272ae88-71e6-4c99-8086-9faa2c68f748"), new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(9118), 502, "Dublin, Ierland", "FR", "RYR", "Dublin Airport", new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(9122), "Ryanair" },
                    { new Guid("1b07a3e0-a6d6-4bf0-b71a-56c7122f69e6"), new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(9055), 75, "Lissabon, Portugal", "TP", "TAP", "Lisbon Airport", new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(9059), "TAP Portugal" },
                    { new Guid("24d11e58-cacc-4ee7-bda6-42531f511d59"), new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(9100), 214, "Tremblay-en-France, Frankrijk", "AF", "AFR", "Paris Charles de Gaulle", new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(9104), "Air France" },
                    { new Guid("4062c02f-f788-4062-a41f-a3ef56d69925"), new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(9085), 277, "Keulen, Duitsland", "LH", "DLH", "Frankurt Am Main", new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(9089), "Lufthansa" },
                    { new Guid("a0ea4c8d-446c-479f-8127-b1a1969dab48"), new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(9075), 57, "Haarlemmermeer, Nederland", "Wa", "KLC", "Amsterdam Schiphol", new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(9080), "KLM Cityhopper" },
                    { new Guid("8e80b1fe-5dd5-4c47-b2df-8da7c3f7f477"), new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(9065), 149, "Amstelveen, Nederland", "KL", "KLM", "Amsterdam Schiphol", new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(9068), "KLM" },
                    { new Guid("7ecaef2a-45f1-4930-b623-e9b660cda8eb"), new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(9046), 18, "Frankfurt, Duitsland", "LH", "GEC", "Frankfurt am Main", new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(9050), "Lufthansa Cargo" },
                    { new Guid("43f568b9-f5dc-4e6f-b429-3bcb6c23229c"), new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(9036), 32, "Zaventem, België", "TB", "JAF", "Brussels Airport", new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(9040), "TUI Fly" }
                });

            migrationBuilder.InsertData(
                table: "Airlines",
                columns: new[] { "Id", "AddedOn", "FleetSize", "HeadQuarter", "IATACode", "ICAOCode", "MainAirport", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { new Guid("964ea51d-0d8b-4d6a-b7da-47c93094deab"), new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(9000), 49, "Diegem, België", "SN", "BEL", "Brussels Airport", new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(9020), "Brussels Airlines" },
                    { new Guid("b43188f5-5029-4446-bdef-22117a111ced"), new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(9110), 254, "Londen, Engeland", "BA", "BAW", "Londen Heathrow", new DateTime(2022, 6, 2, 17, 3, 7, 610, DateTimeKind.Local).AddTicks(9113), "British Airways" }
                });

            migrationBuilder.InsertData(
                table: "Airports",
                columns: new[] { "Id", "AddedOn", "City", "Country", "ElevationAMSL", "IATACode", "ICAOCode", "ModifiedOn", "Name", "RunwayAmount", "TerminalAmount" },
                values: new object[,]
                {
                    { new Guid("f6ea5ef6-d748-481b-9be1-3c7a9d90f3e6"), new DateTime(2022, 6, 2, 17, 3, 7, 611, DateTimeKind.Local).AddTicks(2891), "Sandweiler", "Luxemburg", 376, "LUX", "ELLX", new DateTime(2022, 6, 2, 17, 3, 7, 611, DateTimeKind.Local).AddTicks(2895), "Luxembourg Airport", 1, 2 },
                    { new Guid("a3b509c1-1fda-491c-827c-b9042f327479"), new DateTime(2022, 6, 2, 17, 3, 7, 611, DateTimeKind.Local).AddTicks(2880), "Tokyo", "Japan", 6, "HND", "RJTT", new DateTime(2022, 6, 2, 17, 3, 7, 611, DateTimeKind.Local).AddTicks(2884), "Tokyo Haneda Intl. Airport", 4, 3 },
                    { new Guid("e6eb509a-68de-4ba0-8b34-b797d1266cfc"), new DateTime(2022, 6, 2, 17, 3, 7, 611, DateTimeKind.Local).AddTicks(2870), "Los Angeles", "USA", 39, "LAX", "KLAX", new DateTime(2022, 6, 2, 17, 3, 7, 611, DateTimeKind.Local).AddTicks(2874), "Los Angeles Intl. Airport", 4, 9 },
                    { new Guid("8c9dadf9-b912-4798-8be9-cc56ed66a1ce"), new DateTime(2022, 6, 2, 17, 3, 7, 611, DateTimeKind.Local).AddTicks(2860), "Dubai", "Verenigde Arabische Emiraten", 19, "DXB", "OMDB", new DateTime(2022, 6, 2, 17, 3, 7, 611, DateTimeKind.Local).AddTicks(2864), "Dubai Intl. Airport", 2, 3 },
                    { new Guid("143d781c-12ca-4045-bba3-eaf3f03bb91e"), new DateTime(2022, 6, 2, 17, 3, 7, 611, DateTimeKind.Local).AddTicks(2849), "Mārupe", "Letland", 11, "RIX", "EVRA", new DateTime(2022, 6, 2, 17, 3, 7, 611, DateTimeKind.Local).AddTicks(2853), "Riga Intl. Airport", 1, 1 },
                    { new Guid("585133d3-f45d-4754-961c-bd30487a53b3"), new DateTime(2022, 6, 2, 17, 3, 7, 611, DateTimeKind.Local).AddTicks(2838), "	Roissy-en-France", "Frankrijk", 392, "CDG", "LFPG", new DateTime(2022, 6, 2, 17, 3, 7, 611, DateTimeKind.Local).AddTicks(2842), "Paris CDG Airport", 4, 3 },
                    { new Guid("2346a541-4408-4bae-b53b-e4744ebf265f"), new DateTime(2022, 6, 2, 17, 3, 7, 611, DateTimeKind.Local).AddTicks(2790), "Kelsterbach", "Duitsland", 111, "FRA", "EDDF", new DateTime(2022, 6, 2, 17, 3, 7, 611, DateTimeKind.Local).AddTicks(2794), "Franfurt Airport", 4, 2 },
                    { new Guid("7c0357cc-74d6-48e8-a135-95c752614c53"), new DateTime(2022, 6, 2, 17, 3, 7, 611, DateTimeKind.Local).AddTicks(2818), "Newark", "USA", 5, "EWR", "KEWR", new DateTime(2022, 6, 2, 17, 3, 7, 611, DateTimeKind.Local).AddTicks(2821), "Newark Liberty Intl. Airport", 3, 3 },
                    { new Guid("3eec65ab-1991-4530-9a50-67cf55bc210a"), new DateTime(2022, 6, 2, 17, 3, 7, 611, DateTimeKind.Local).AddTicks(2801), "New York City", "USA", 4, "JFK", "KJFK", new DateTime(2022, 6, 2, 17, 3, 7, 611, DateTimeKind.Local).AddTicks(2805), "New York JFK Airport", 4, 6 },
                    { new Guid("df0696f7-36ac-4ed6-bdb4-8fec95f0af48"), new DateTime(2022, 6, 2, 17, 3, 7, 611, DateTimeKind.Local).AddTicks(2779), "Narita", "Japan", 41, "NRT", "RJAA", new DateTime(2022, 6, 2, 17, 3, 7, 611, DateTimeKind.Local).AddTicks(2784), "Tokyo Narita Intl. Airport", 2, 3 },
                    { new Guid("3404a4fa-a787-4e57-8fbe-3db8d2185b63"), new DateTime(2022, 6, 2, 17, 3, 7, 611, DateTimeKind.Local).AddTicks(2768), "Nice", "Frankrijk", 4, "NCE", "LFMN", new DateTime(2022, 6, 2, 17, 3, 7, 611, DateTimeKind.Local).AddTicks(2772), "Nice Côte d'Azur", 2, 3 },
                    { new Guid("6fa77f39-e609-43f1-8e66-fe2a0e9447ca"), new DateTime(2022, 6, 2, 17, 3, 7, 611, DateTimeKind.Local).AddTicks(2733), "Zaventem", "België", 56, "BRU", "EBBR", new DateTime(2022, 6, 2, 17, 3, 7, 611, DateTimeKind.Local).AddTicks(2751), "Brussels Airport", 3, 1 },
                    { new Guid("01b6c3fe-dfa7-4c0f-b4ca-1497ecc447f7"), new DateTime(2022, 6, 2, 17, 3, 7, 611, DateTimeKind.Local).AddTicks(2905), "Hillingdon", "Engeland", 25, "LHR", "EGLL", new DateTime(2022, 6, 2, 17, 3, 7, 611, DateTimeKind.Local).AddTicks(2908), "London Heathrow Airport", 2, 5 },
                    { new Guid("3a466d81-3466-4fad-81eb-500eb7be8974"), new DateTime(2022, 6, 2, 17, 3, 7, 611, DateTimeKind.Local).AddTicks(2828), "Haarlemmermeer", "Nederland", -3, "AMS", "EHAM", new DateTime(2022, 6, 2, 17, 3, 7, 611, DateTimeKind.Local).AddTicks(2832), "Amsterdam Schiphol Airport", 6, 1 },
                    { new Guid("b2291ef3-86d3-48b4-8bd9-1ee098e57de7"), new DateTime(2022, 6, 2, 17, 3, 7, 611, DateTimeKind.Local).AddTicks(2915), "Crawley", "Engeland", 62, "LGW", "EGKK", new DateTime(2022, 6, 2, 17, 3, 7, 611, DateTimeKind.Local).AddTicks(2918), "London Gatwick Airport", 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Aircrafts",
                columns: new[] { "Id", "AddedOn", "AircraftTypeId", "AirlineId", "FirstSeen", "HasSpecialLivery", "Image", "LastSeen", "Latitude", "Longitude", "ModifiedOn", "Registration" },
                values: new object[,]
                {
                    { new Guid("6923ed57-0854-43f6-bace-b46e03c3de8c"), new DateTime(2022, 6, 2, 17, 3, 7, 611, DateTimeKind.Local).AddTicks(6620), new Guid("d0f6e18b-fdfb-47a5-aee8-291672abf248"), new Guid("964ea51d-0d8b-4d6a-b7da-47c93094deab"), new DateTime(2021, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "images/IMG_2232.jpg", new DateTime(2021, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2022, 6, 2, 17, 3, 7, 611, DateTimeKind.Local).AddTicks(6640), "OO-SNJ" },
                    { new Guid("15bcb431-d45f-4b41-9f33-53abf736a754"), new DateTime(2022, 6, 2, 17, 3, 7, 611, DateTimeKind.Local).AddTicks(6703), new Guid("9841abae-4be4-4da4-a2af-77af641c9348"), new Guid("37e18490-4683-47aa-a27f-359f0bb60525"), new DateTime(2020, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "images/13047_1527973248.jpg", new DateTime(2021, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2022, 6, 2, 17, 3, 7, 611, DateTimeKind.Local).AddTicks(6707), "A6-EDD" },
                    { new Guid("5b460cc3-59f9-47bf-8190-a9b225e1d189"), new DateTime(2022, 6, 2, 17, 3, 7, 611, DateTimeKind.Local).AddTicks(6881), new Guid("5ae76cf4-a778-4cca-b949-de90a3ad8e44"), new Guid("f902dc81-28d7-4fea-938e-7cc3f82c8c0d"), new DateTime(2020, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "images/N12003_EBBR_11-02-22_6.jpg", new DateTime(2022, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2022, 6, 2, 17, 3, 7, 611, DateTimeKind.Local).AddTicks(6885), "N12003" },
                    { new Guid("3c550127-de5f-42dd-9690-427a6416c999"), new DateTime(2022, 6, 2, 17, 3, 7, 611, DateTimeKind.Local).AddTicks(6732), new Guid("82aaaa67-255e-4e3a-8308-516fee583a4b"), new Guid("95fb0ecc-eb8a-4021-a8dd-9c1b0e38a86c"), new DateTime(2020, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "images/12199_1554835793.jpg", new DateTime(2021, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2022, 6, 2, 17, 3, 7, 611, DateTimeKind.Local).AddTicks(6736), "OO-ABA" },
                    { new Guid("30ccb879-5e24-40df-b7cf-836b0ad16313"), new DateTime(2022, 6, 2, 17, 3, 7, 611, DateTimeKind.Local).AddTicks(6681), new Guid("8031c796-ee62-40ea-bbbd-287db9b748c6"), new Guid("0e182523-012e-443a-af95-bf0061309655"), new DateTime(2020, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "images/93540_1598318875.jpg", new DateTime(2021, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2022, 6, 2, 17, 3, 7, 611, DateTimeKind.Local).AddTicks(6685), "LX-VCF" },
                    { new Guid("3a7bb1bd-c0c9-4a77-8980-b768afe916f7"), new DateTime(2022, 6, 2, 17, 3, 7, 611, DateTimeKind.Local).AddTicks(6847), new Guid("fc076baf-62e1-4e49-9151-cf9c77656b28"), new Guid("47fb36ab-ec0b-48dd-853a-0c0d3124f40f"), new DateTime(2020, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "images/44344_1544504053.jpg", new DateTime(2020, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2022, 6, 2, 17, 3, 7, 611, DateTimeKind.Local).AddTicks(6850), "YL-CSN" },
                    { new Guid("5a8946dc-22b3-49d6-bf6d-6a20ed5f6c62"), new DateTime(2022, 6, 2, 17, 3, 7, 611, DateTimeKind.Local).AddTicks(6835), new Guid("fc076baf-62e1-4e49-9151-cf9c77656b28"), new Guid("47fb36ab-ec0b-48dd-853a-0c0d3124f40f"), new DateTime(2020, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "images/1195582.jpg", new DateTime(2020, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2022, 6, 2, 17, 3, 7, 611, DateTimeKind.Local).AddTicks(6838), "YL-CSL" },
                    { new Guid("3d520553-7aa5-4fa8-bd2d-13491944bf66"), new DateTime(2022, 6, 2, 17, 3, 7, 611, DateTimeKind.Local).AddTicks(6721), new Guid("ea604c2f-a468-4610-b2c4-67254e09c9e9"), new Guid("37e18490-4683-47aa-a27f-359f0bb60525"), new DateTime(2020, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "images/IMG_2065.jpg", new DateTime(2021, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2022, 6, 2, 17, 3, 7, 611, DateTimeKind.Local).AddTicks(6724), "A6-EQA" },
                    { new Guid("5d7a1249-8579-4fa0-80c2-57be7bf61cf1"), new DateTime(2022, 6, 2, 17, 3, 7, 611, DateTimeKind.Local).AddTicks(6824), new Guid("fc076baf-62e1-4e49-9151-cf9c77656b28"), new Guid("47fb36ab-ec0b-48dd-853a-0c0d3124f40f"), new DateTime(2020, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "images/1309661.jpg", new DateTime(2021, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2022, 6, 2, 17, 3, 7, 611, DateTimeKind.Local).AddTicks(6828), "YL-CSK" },
                    { new Guid("fd7b2470-8c66-4dd4-9add-f95992d71e1e"), new DateTime(2022, 6, 2, 17, 3, 7, 611, DateTimeKind.Local).AddTicks(6743), new Guid("a918c937-d09b-49c4-88d6-2a04955b2145"), new Guid("b43188f5-5029-4446-bdef-22117a111ced"), new DateTime(2020, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "images/10569_1567245788.jpg", new DateTime(2021, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2022, 6, 2, 17, 3, 7, 611, DateTimeKind.Local).AddTicks(6746), "G-XWBA" },
                    { new Guid("8f8b2f77-97c0-4c41-8012-6025057b2473"), new DateTime(2022, 6, 2, 17, 3, 7, 611, DateTimeKind.Local).AddTicks(6857), new Guid("e2277b3b-0c45-465e-9e55-4b06ca5ab320"), new Guid("a0ea4c8d-446c-479f-8127-b1a1969dab48"), new DateTime(2021, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "images/12946_1520765802.jpg", new DateTime(2021, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2022, 6, 2, 17, 3, 7, 611, DateTimeKind.Local).AddTicks(6860), "PH-EZT" },
                    { new Guid("aa0fa9f1-39a2-4f78-9104-5f9e364781fc"), new DateTime(2022, 6, 2, 17, 3, 7, 611, DateTimeKind.Local).AddTicks(6671), new Guid("3f9ea1d7-71f0-4577-b55c-bf2ed58805e3"), new Guid("7ecaef2a-45f1-4930-b623-e9b660cda8eb"), new DateTime(2020, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "images/1179688.jpg", new DateTime(2021, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2022, 6, 2, 17, 3, 7, 611, DateTimeKind.Local).AddTicks(6674), "D-ALCC" },
                    { new Guid("83162727-ffde-463c-84d1-6b5d8e333128"), new DateTime(2022, 6, 2, 17, 3, 7, 611, DateTimeKind.Local).AddTicks(6891), new Guid("d0e1c5ae-1695-41ae-9dca-1d39dec9c867"), new Guid("43f568b9-f5dc-4e6f-b429-3bcb6c23229c"), new DateTime(2020, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "images/OO-TNB-EBBR_11-02-22_4.jpg", new DateTime(2022, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2022, 6, 2, 17, 3, 7, 611, DateTimeKind.Local).AddTicks(6895), "OO-TNB" },
                    { new Guid("e5431a32-caf1-47c7-8b13-a630132a284a"), new DateTime(2022, 6, 2, 17, 3, 7, 611, DateTimeKind.Local).AddTicks(6659), new Guid("9573390e-aab9-483a-9cba-75fc30fdc81b"), new Guid("43f568b9-f5dc-4e6f-b429-3bcb6c23229c"), new DateTime(2020, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "images/95656_1575311187.jpg", new DateTime(2021, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2022, 6, 2, 17, 3, 7, 611, DateTimeKind.Local).AddTicks(6663), "OO-LOE" },
                    { new Guid("4d00c895-268d-428c-b8c2-484c87edd9c3"), new DateTime(2022, 6, 2, 17, 3, 7, 611, DateTimeKind.Local).AddTicks(6870), new Guid("001cfcbc-4b72-490b-b495-d3363bb9a499"), new Guid("964ea51d-0d8b-4d6a-b7da-47c93094deab"), new DateTime(2021, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "images/OO-SSL_EBBR_11-02-22_4.jpg", new DateTime(2022, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2022, 6, 2, 17, 3, 7, 611, DateTimeKind.Local).AddTicks(6874), "OO-SSL" },
                    { new Guid("981c7c2e-5b32-424a-a4f9-a599bbb4db08"), new DateTime(2022, 6, 2, 17, 3, 7, 611, DateTimeKind.Local).AddTicks(6753), new Guid("fc076baf-62e1-4e49-9151-cf9c77656b28"), new Guid("47fb36ab-ec0b-48dd-853a-0c0d3124f40f"), new DateTime(2020, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "images/27669_1580328749.jpg", new DateTime(2021, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2022, 6, 2, 17, 3, 7, 611, DateTimeKind.Local).AddTicks(6756), "YL-CSJ" },
                    { new Guid("ae818817-2306-4afe-9daf-6909daffd85d"), new DateTime(2022, 6, 2, 17, 3, 7, 611, DateTimeKind.Local).AddTicks(6692), new Guid("089e20c3-662c-471f-a31a-73479818bce6"), new Guid("3dd0aca4-548c-4cf0-b540-b035334fea20"), new DateTime(2020, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "images/IMG_2287.jpg", new DateTime(2020, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, new DateTime(2022, 6, 2, 17, 3, 7, 611, DateTimeKind.Local).AddTicks(6696), "JA872A" }
                });

            migrationBuilder.InsertData(
                table: "AircraftAtAirports",
                columns: new[] { "AircraftId", "AirportId" },
                values: new object[,]
                {
                    { new Guid("6923ed57-0854-43f6-bace-b46e03c3de8c"), new Guid("6fa77f39-e609-43f1-8e66-fe2a0e9447ca") },
                    { new Guid("30ccb879-5e24-40df-b7cf-836b0ad16313"), new Guid("e6eb509a-68de-4ba0-8b34-b797d1266cfc") },
                    { new Guid("30ccb879-5e24-40df-b7cf-836b0ad16313"), new Guid("3eec65ab-1991-4530-9a50-67cf55bc210a") },
                    { new Guid("30ccb879-5e24-40df-b7cf-836b0ad16313"), new Guid("8c9dadf9-b912-4798-8be9-cc56ed66a1ce") },
                    { new Guid("3c550127-de5f-42dd-9690-427a6416c999"), new Guid("6fa77f39-e609-43f1-8e66-fe2a0e9447ca") },
                    { new Guid("3c550127-de5f-42dd-9690-427a6416c999"), new Guid("b2291ef3-86d3-48b4-8bd9-1ee098e57de7") },
                    { new Guid("5b460cc3-59f9-47bf-8190-a9b225e1d189"), new Guid("6fa77f39-e609-43f1-8e66-fe2a0e9447ca") },
                    { new Guid("5b460cc3-59f9-47bf-8190-a9b225e1d189"), new Guid("7c0357cc-74d6-48e8-a135-95c752614c53") },
                    { new Guid("30ccb879-5e24-40df-b7cf-836b0ad16313"), new Guid("f6ea5ef6-d748-481b-9be1-3c7a9d90f3e6") },
                    { new Guid("15bcb431-d45f-4b41-9f33-53abf736a754"), new Guid("8c9dadf9-b912-4798-8be9-cc56ed66a1ce") },
                    { new Guid("15bcb431-d45f-4b41-9f33-53abf736a754"), new Guid("01b6c3fe-dfa7-4c0f-b4ca-1497ecc447f7") },
                    { new Guid("15bcb431-d45f-4b41-9f33-53abf736a754"), new Guid("e6eb509a-68de-4ba0-8b34-b797d1266cfc") },
                    { new Guid("3d520553-7aa5-4fa8-bd2d-13491944bf66"), new Guid("8c9dadf9-b912-4798-8be9-cc56ed66a1ce") },
                    { new Guid("3d520553-7aa5-4fa8-bd2d-13491944bf66"), new Guid("6fa77f39-e609-43f1-8e66-fe2a0e9447ca") },
                    { new Guid("3d520553-7aa5-4fa8-bd2d-13491944bf66"), new Guid("01b6c3fe-dfa7-4c0f-b4ca-1497ecc447f7") },
                    { new Guid("3d520553-7aa5-4fa8-bd2d-13491944bf66"), new Guid("3a466d81-3466-4fad-81eb-500eb7be8974") },
                    { new Guid("ae818817-2306-4afe-9daf-6909daffd85d"), new Guid("df0696f7-36ac-4ed6-bdb4-8fec95f0af48") },
                    { new Guid("15bcb431-d45f-4b41-9f33-53abf736a754"), new Guid("585133d3-f45d-4754-961c-bd30487a53b3") },
                    { new Guid("3a7bb1bd-c0c9-4a77-8980-b768afe916f7"), new Guid("143d781c-12ca-4045-bba3-eaf3f03bb91e") },
                    { new Guid("5a8946dc-22b3-49d6-bf6d-6a20ed5f6c62"), new Guid("143d781c-12ca-4045-bba3-eaf3f03bb91e") },
                    { new Guid("5d7a1249-8579-4fa0-80c2-57be7bf61cf1"), new Guid("3404a4fa-a787-4e57-8fbe-3db8d2185b63") },
                    { new Guid("6923ed57-0854-43f6-bace-b46e03c3de8c"), new Guid("3404a4fa-a787-4e57-8fbe-3db8d2185b63") },
                    { new Guid("6923ed57-0854-43f6-bace-b46e03c3de8c"), new Guid("df0696f7-36ac-4ed6-bdb4-8fec95f0af48") },
                    { new Guid("4d00c895-268d-428c-b8c2-484c87edd9c3"), new Guid("6fa77f39-e609-43f1-8e66-fe2a0e9447ca") },
                    { new Guid("4d00c895-268d-428c-b8c2-484c87edd9c3"), new Guid("3404a4fa-a787-4e57-8fbe-3db8d2185b63") },
                    { new Guid("4d00c895-268d-428c-b8c2-484c87edd9c3"), new Guid("01b6c3fe-dfa7-4c0f-b4ca-1497ecc447f7") },
                    { new Guid("e5431a32-caf1-47c7-8b13-a630132a284a"), new Guid("6fa77f39-e609-43f1-8e66-fe2a0e9447ca") },
                    { new Guid("e5431a32-caf1-47c7-8b13-a630132a284a"), new Guid("3404a4fa-a787-4e57-8fbe-3db8d2185b63") },
                    { new Guid("83162727-ffde-463c-84d1-6b5d8e333128"), new Guid("6fa77f39-e609-43f1-8e66-fe2a0e9447ca") },
                    { new Guid("83162727-ffde-463c-84d1-6b5d8e333128"), new Guid("3404a4fa-a787-4e57-8fbe-3db8d2185b63") },
                    { new Guid("aa0fa9f1-39a2-4f78-9104-5f9e364781fc"), new Guid("df0696f7-36ac-4ed6-bdb4-8fec95f0af48") },
                    { new Guid("8f8b2f77-97c0-4c41-8012-6025057b2473"), new Guid("3a466d81-3466-4fad-81eb-500eb7be8974") },
                    { new Guid("fd7b2470-8c66-4dd4-9add-f95992d71e1e"), new Guid("b2291ef3-86d3-48b4-8bd9-1ee098e57de7") },
                    { new Guid("fd7b2470-8c66-4dd4-9add-f95992d71e1e"), new Guid("01b6c3fe-dfa7-4c0f-b4ca-1497ecc447f7") },
                    { new Guid("981c7c2e-5b32-424a-a4f9-a599bbb4db08"), new Guid("143d781c-12ca-4045-bba3-eaf3f03bb91e") },
                    { new Guid("981c7c2e-5b32-424a-a4f9-a599bbb4db08"), new Guid("3404a4fa-a787-4e57-8fbe-3db8d2185b63") },
                    { new Guid("5d7a1249-8579-4fa0-80c2-57be7bf61cf1"), new Guid("143d781c-12ca-4045-bba3-eaf3f03bb91e") },
                    { new Guid("5d7a1249-8579-4fa0-80c2-57be7bf61cf1"), new Guid("6fa77f39-e609-43f1-8e66-fe2a0e9447ca") },
                    { new Guid("ae818817-2306-4afe-9daf-6909daffd85d"), new Guid("a3b509c1-1fda-491c-827c-b9042f327479") },
                    { new Guid("ae818817-2306-4afe-9daf-6909daffd85d"), new Guid("6fa77f39-e609-43f1-8e66-fe2a0e9447ca") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("15bcb431-d45f-4b41-9f33-53abf736a754"), new Guid("01b6c3fe-dfa7-4c0f-b4ca-1497ecc447f7") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("15bcb431-d45f-4b41-9f33-53abf736a754"), new Guid("585133d3-f45d-4754-961c-bd30487a53b3") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("15bcb431-d45f-4b41-9f33-53abf736a754"), new Guid("8c9dadf9-b912-4798-8be9-cc56ed66a1ce") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("15bcb431-d45f-4b41-9f33-53abf736a754"), new Guid("e6eb509a-68de-4ba0-8b34-b797d1266cfc") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("30ccb879-5e24-40df-b7cf-836b0ad16313"), new Guid("3eec65ab-1991-4530-9a50-67cf55bc210a") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("30ccb879-5e24-40df-b7cf-836b0ad16313"), new Guid("8c9dadf9-b912-4798-8be9-cc56ed66a1ce") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("30ccb879-5e24-40df-b7cf-836b0ad16313"), new Guid("e6eb509a-68de-4ba0-8b34-b797d1266cfc") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("30ccb879-5e24-40df-b7cf-836b0ad16313"), new Guid("f6ea5ef6-d748-481b-9be1-3c7a9d90f3e6") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("3a7bb1bd-c0c9-4a77-8980-b768afe916f7"), new Guid("143d781c-12ca-4045-bba3-eaf3f03bb91e") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("3c550127-de5f-42dd-9690-427a6416c999"), new Guid("6fa77f39-e609-43f1-8e66-fe2a0e9447ca") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("3c550127-de5f-42dd-9690-427a6416c999"), new Guid("b2291ef3-86d3-48b4-8bd9-1ee098e57de7") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("3d520553-7aa5-4fa8-bd2d-13491944bf66"), new Guid("01b6c3fe-dfa7-4c0f-b4ca-1497ecc447f7") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("3d520553-7aa5-4fa8-bd2d-13491944bf66"), new Guid("3a466d81-3466-4fad-81eb-500eb7be8974") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("3d520553-7aa5-4fa8-bd2d-13491944bf66"), new Guid("6fa77f39-e609-43f1-8e66-fe2a0e9447ca") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("3d520553-7aa5-4fa8-bd2d-13491944bf66"), new Guid("8c9dadf9-b912-4798-8be9-cc56ed66a1ce") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("4d00c895-268d-428c-b8c2-484c87edd9c3"), new Guid("01b6c3fe-dfa7-4c0f-b4ca-1497ecc447f7") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("4d00c895-268d-428c-b8c2-484c87edd9c3"), new Guid("3404a4fa-a787-4e57-8fbe-3db8d2185b63") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("4d00c895-268d-428c-b8c2-484c87edd9c3"), new Guid("6fa77f39-e609-43f1-8e66-fe2a0e9447ca") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("5a8946dc-22b3-49d6-bf6d-6a20ed5f6c62"), new Guid("143d781c-12ca-4045-bba3-eaf3f03bb91e") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("5b460cc3-59f9-47bf-8190-a9b225e1d189"), new Guid("6fa77f39-e609-43f1-8e66-fe2a0e9447ca") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("5b460cc3-59f9-47bf-8190-a9b225e1d189"), new Guid("7c0357cc-74d6-48e8-a135-95c752614c53") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("5d7a1249-8579-4fa0-80c2-57be7bf61cf1"), new Guid("143d781c-12ca-4045-bba3-eaf3f03bb91e") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("5d7a1249-8579-4fa0-80c2-57be7bf61cf1"), new Guid("3404a4fa-a787-4e57-8fbe-3db8d2185b63") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("5d7a1249-8579-4fa0-80c2-57be7bf61cf1"), new Guid("6fa77f39-e609-43f1-8e66-fe2a0e9447ca") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("6923ed57-0854-43f6-bace-b46e03c3de8c"), new Guid("3404a4fa-a787-4e57-8fbe-3db8d2185b63") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("6923ed57-0854-43f6-bace-b46e03c3de8c"), new Guid("6fa77f39-e609-43f1-8e66-fe2a0e9447ca") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("6923ed57-0854-43f6-bace-b46e03c3de8c"), new Guid("df0696f7-36ac-4ed6-bdb4-8fec95f0af48") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("83162727-ffde-463c-84d1-6b5d8e333128"), new Guid("3404a4fa-a787-4e57-8fbe-3db8d2185b63") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("83162727-ffde-463c-84d1-6b5d8e333128"), new Guid("6fa77f39-e609-43f1-8e66-fe2a0e9447ca") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("8f8b2f77-97c0-4c41-8012-6025057b2473"), new Guid("3a466d81-3466-4fad-81eb-500eb7be8974") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("981c7c2e-5b32-424a-a4f9-a599bbb4db08"), new Guid("143d781c-12ca-4045-bba3-eaf3f03bb91e") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("981c7c2e-5b32-424a-a4f9-a599bbb4db08"), new Guid("3404a4fa-a787-4e57-8fbe-3db8d2185b63") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("aa0fa9f1-39a2-4f78-9104-5f9e364781fc"), new Guid("df0696f7-36ac-4ed6-bdb4-8fec95f0af48") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("ae818817-2306-4afe-9daf-6909daffd85d"), new Guid("6fa77f39-e609-43f1-8e66-fe2a0e9447ca") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("ae818817-2306-4afe-9daf-6909daffd85d"), new Guid("a3b509c1-1fda-491c-827c-b9042f327479") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("ae818817-2306-4afe-9daf-6909daffd85d"), new Guid("df0696f7-36ac-4ed6-bdb4-8fec95f0af48") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("e5431a32-caf1-47c7-8b13-a630132a284a"), new Guid("3404a4fa-a787-4e57-8fbe-3db8d2185b63") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("e5431a32-caf1-47c7-8b13-a630132a284a"), new Guid("6fa77f39-e609-43f1-8e66-fe2a0e9447ca") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("fd7b2470-8c66-4dd4-9add-f95992d71e1e"), new Guid("01b6c3fe-dfa7-4c0f-b4ca-1497ecc447f7") });

            migrationBuilder.DeleteData(
                table: "AircraftAtAirports",
                keyColumns: new[] { "AircraftId", "AirportId" },
                keyValues: new object[] { new Guid("fd7b2470-8c66-4dd4-9add-f95992d71e1e"), new Guid("b2291ef3-86d3-48b4-8bd9-1ee098e57de7") });

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("181e8515-d557-447f-a78c-6ee4c08943e2"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("1f36b76a-77b0-4f2e-83b6-f280fae00fce"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("29aeea55-f59b-4e63-9af7-f98eaf5e8937"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("4049f23d-a9d4-4a80-a46d-072ea7d2caf2"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("5cd4da33-4ad0-4ae0-96dd-9872dd3a7895"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("75cf6016-3055-4eff-83be-9ca0b3464232"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("86394a02-f047-4530-9579-83ad47dbc1e1"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("889d61b9-f656-4148-8096-1ad3b04df613"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("8bf6be8c-5f12-4451-a1ba-1fe0bc5b5301"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("a34b4e69-a43d-4373-a4f5-d627532d6b83"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("ca223507-ec42-4aaf-b9a0-c7009a9bcb02"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("e3fe0847-d6ad-4c06-ac0d-4524132b8524"));

            migrationBuilder.DeleteData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: new Guid("1b07a3e0-a6d6-4bf0-b71a-56c7122f69e6"));

            migrationBuilder.DeleteData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: new Guid("24d11e58-cacc-4ee7-bda6-42531f511d59"));

            migrationBuilder.DeleteData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: new Guid("4062c02f-f788-4062-a41f-a3ef56d69925"));

            migrationBuilder.DeleteData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: new Guid("6272ae88-71e6-4c99-8086-9faa2c68f748"));

            migrationBuilder.DeleteData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: new Guid("7869c2f5-00b4-4817-b1d4-b375e09af828"));

            migrationBuilder.DeleteData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: new Guid("8e80b1fe-5dd5-4c47-b2df-8da7c3f7f477"));

            migrationBuilder.DeleteData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: new Guid("e348e371-91ba-447e-b11a-7154c5d57c09"));

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: new Guid("2346a541-4408-4bae-b53b-e4744ebf265f"));

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: new Guid("15bcb431-d45f-4b41-9f33-53abf736a754"));

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: new Guid("30ccb879-5e24-40df-b7cf-836b0ad16313"));

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: new Guid("3a7bb1bd-c0c9-4a77-8980-b768afe916f7"));

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: new Guid("3c550127-de5f-42dd-9690-427a6416c999"));

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: new Guid("3d520553-7aa5-4fa8-bd2d-13491944bf66"));

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: new Guid("4d00c895-268d-428c-b8c2-484c87edd9c3"));

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: new Guid("5a8946dc-22b3-49d6-bf6d-6a20ed5f6c62"));

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: new Guid("5b460cc3-59f9-47bf-8190-a9b225e1d189"));

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: new Guid("5d7a1249-8579-4fa0-80c2-57be7bf61cf1"));

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: new Guid("6923ed57-0854-43f6-bace-b46e03c3de8c"));

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: new Guid("83162727-ffde-463c-84d1-6b5d8e333128"));

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: new Guid("8f8b2f77-97c0-4c41-8012-6025057b2473"));

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: new Guid("981c7c2e-5b32-424a-a4f9-a599bbb4db08"));

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: new Guid("aa0fa9f1-39a2-4f78-9104-5f9e364781fc"));

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: new Guid("ae818817-2306-4afe-9daf-6909daffd85d"));

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: new Guid("e5431a32-caf1-47c7-8b13-a630132a284a"));

            migrationBuilder.DeleteData(
                table: "Aircrafts",
                keyColumn: "Id",
                keyValue: new Guid("fd7b2470-8c66-4dd4-9add-f95992d71e1e"));

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: new Guid("01b6c3fe-dfa7-4c0f-b4ca-1497ecc447f7"));

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: new Guid("143d781c-12ca-4045-bba3-eaf3f03bb91e"));

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: new Guid("3404a4fa-a787-4e57-8fbe-3db8d2185b63"));

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: new Guid("3a466d81-3466-4fad-81eb-500eb7be8974"));

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: new Guid("3eec65ab-1991-4530-9a50-67cf55bc210a"));

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: new Guid("585133d3-f45d-4754-961c-bd30487a53b3"));

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: new Guid("6fa77f39-e609-43f1-8e66-fe2a0e9447ca"));

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: new Guid("7c0357cc-74d6-48e8-a135-95c752614c53"));

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: new Guid("8c9dadf9-b912-4798-8be9-cc56ed66a1ce"));

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: new Guid("a3b509c1-1fda-491c-827c-b9042f327479"));

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: new Guid("b2291ef3-86d3-48b4-8bd9-1ee098e57de7"));

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: new Guid("df0696f7-36ac-4ed6-bdb4-8fec95f0af48"));

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: new Guid("e6eb509a-68de-4ba0-8b34-b797d1266cfc"));

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Id",
                keyValue: new Guid("f6ea5ef6-d748-481b-9be1-3c7a9d90f3e6"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("001cfcbc-4b72-490b-b495-d3363bb9a499"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("089e20c3-662c-471f-a31a-73479818bce6"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("3f9ea1d7-71f0-4577-b55c-bf2ed58805e3"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("5ae76cf4-a778-4cca-b949-de90a3ad8e44"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("8031c796-ee62-40ea-bbbd-287db9b748c6"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("82aaaa67-255e-4e3a-8308-516fee583a4b"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("9573390e-aab9-483a-9cba-75fc30fdc81b"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("9841abae-4be4-4da4-a2af-77af641c9348"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("a918c937-d09b-49c4-88d6-2a04955b2145"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("d0e1c5ae-1695-41ae-9dca-1d39dec9c867"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("d0f6e18b-fdfb-47a5-aee8-291672abf248"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("e2277b3b-0c45-465e-9e55-4b06ca5ab320"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("ea604c2f-a468-4610-b2c4-67254e09c9e9"));

            migrationBuilder.DeleteData(
                table: "AircraftTypes",
                keyColumn: "Id",
                keyValue: new Guid("fc076baf-62e1-4e49-9151-cf9c77656b28"));

            migrationBuilder.DeleteData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: new Guid("0e182523-012e-443a-af95-bf0061309655"));

            migrationBuilder.DeleteData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: new Guid("37e18490-4683-47aa-a27f-359f0bb60525"));

            migrationBuilder.DeleteData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: new Guid("3dd0aca4-548c-4cf0-b540-b035334fea20"));

            migrationBuilder.DeleteData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: new Guid("43f568b9-f5dc-4e6f-b429-3bcb6c23229c"));

            migrationBuilder.DeleteData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: new Guid("47fb36ab-ec0b-48dd-853a-0c0d3124f40f"));

            migrationBuilder.DeleteData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: new Guid("7ecaef2a-45f1-4930-b623-e9b660cda8eb"));

            migrationBuilder.DeleteData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: new Guid("95fb0ecc-eb8a-4021-a8dd-9c1b0e38a86c"));

            migrationBuilder.DeleteData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: new Guid("964ea51d-0d8b-4d6a-b7da-47c93094deab"));

            migrationBuilder.DeleteData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: new Guid("a0ea4c8d-446c-479f-8127-b1a1969dab48"));

            migrationBuilder.DeleteData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: new Guid("b43188f5-5029-4446-bdef-22117a111ced"));

            migrationBuilder.DeleteData(
                table: "Airlines",
                keyColumn: "Id",
                keyValue: new Guid("f902dc81-28d7-4fea-938e-7cc3f82c8c0d"));

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
    }
}
