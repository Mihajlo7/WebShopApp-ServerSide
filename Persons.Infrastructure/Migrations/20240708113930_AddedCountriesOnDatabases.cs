using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persons.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedCountriesOnDatabases : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Code", "CountryRegionCode", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0082ebd0-cb4b-43cc-923b-bf05c0979c16"), "RS", "EU", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9116), "Serbia", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9116) },
                    { new Guid("02c7465a-07d3-4966-a546-1318060ebccb"), "ME", "EU", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9122), "Montenegro", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9123) },
                    { new Guid("08102b65-4b66-4dd0-926d-64488917c3a3"), "NO", "EU", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9159), "Norway", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9159) },
                    { new Guid("1bc7f8e9-4383-438a-a00d-ecfda3531ede"), "CH", "EU", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9100), "Switzerland", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9101) },
                    { new Guid("260812c2-13fe-4e25-baaf-331cfc2e5a3c"), "PT", "EU", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9086), "Portugal", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9086) },
                    { new Guid("2d87c895-e6bd-474c-b52c-7dd641ad31c3"), "AT", "EU", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9095), "Austria", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9096) },
                    { new Guid("47947286-8cce-4caa-8d34-8705d0f674ac"), "DK", "EU", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9161), "Denmark", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9162) },
                    { new Guid("49ba6fff-9c83-474c-bb6d-fd425712ecb1"), "CZ", "EU", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9105), "Czech Republic", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9105) },
                    { new Guid("510f0d45-7f30-42cf-8c86-23555bfdb062"), "DE", "EU", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9060), "Germany", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9063) },
                    { new Guid("5c886ed8-e899-4399-83c4-778afd005344"), "UA", "EU", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9141), "Ukraine", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9142) },
                    { new Guid("5cdd1c84-fc02-4422-9f7c-8bde74a09b53"), "GB", "EU", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9166), "United Kingdom", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9166) },
                    { new Guid("61076fe8-8815-47fa-be7d-49fcd81afe79"), "HU", "EU", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9107), "Hungary", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9107) },
                    { new Guid("6354dbb6-054b-487d-9b5b-2b586cccc613"), "GR", "EU", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9131), "Greece", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9131) },
                    { new Guid("653686de-6c7d-4893-bdba-f3028c49d411"), "BA", "EU", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9120), "Bosnia and Herzegovina", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9120) },
                    { new Guid("683e2142-d8b7-424d-ad63-f28b26b83991"), "SE", "EU", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9155), "Sweden", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9155) },
                    { new Guid("6f8987d8-f0b6-41f6-b72b-e78a21b24b8d"), "BG", "EU", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9133), "Bulgaria", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9133) },
                    { new Guid("70daeae1-7521-40b3-a5de-4cb5c45c6c7a"), "LU", "EU", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9093), "Luxembourg", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9094) },
                    { new Guid("73f2d800-9b7f-4f3c-995d-5e25c575627d"), "LV", "EU", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9148), "Latvia", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9148) },
                    { new Guid("7c38fd4e-a529-48c8-8b2a-e7422b105984"), "RO", "EU", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9135), "Romania", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9136) },
                    { new Guid("80276af8-bf72-43ae-9421-91aa41d2c580"), "PL", "EU", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9102), "Poland", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9103) },
                    { new Guid("869d522f-5e78-4fe1-8f24-24f009ad6e98"), "EE", "EU", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9150), "Estonia", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9151) },
                    { new Guid("8fff77af-8b82-45f5-922a-bf3251618e2e"), "NL", "EU", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9088), "Netherlands", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9089) },
                    { new Guid("96ab5910-b083-4abc-b022-8e6b70568364"), "HR", "EU", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9114), "Croatia", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9114) },
                    { new Guid("9940d27b-1544-4efe-8765-5a217d920191"), "SI", "EU", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9111), "Slovenia", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9112) },
                    { new Guid("a1c942b2-6dba-482f-a165-51ca5fa8a913"), "FI", "EU", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9153), "Finland", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9153) },
                    { new Guid("b3f63a37-c580-444c-863f-cb6eaaaf132e"), "IS", "EU", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9164), "Iceland", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9164) },
                    { new Guid("b8a7abe6-88af-449b-955b-198e2a3a09fa"), "IE", "EU", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9168), "Ireland", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9168) },
                    { new Guid("bb1229e2-e50f-4c31-bc99-e53df6bb89a7"), "XK", "EU", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9124), "Kosovo", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9125) },
                    { new Guid("c0b9ae96-5503-45bf-adc5-2fea34106dcb"), "BE", "EU", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9091), "Belgium", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9091) },
                    { new Guid("c14444fb-d674-4120-9311-082ae781e178"), "AL", "EU", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9129), "Albania", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9129) },
                    { new Guid("ca4ca9ac-ab2d-4cc5-9df0-b21bc160869a"), "IT", "EU", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9081), "Italy", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9081) },
                    { new Guid("ca9e90e6-1cd2-4af7-ae5c-f639a49d216b"), "ES", "EU", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9083), "Spain", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9084) },
                    { new Guid("d2792a79-10cf-41c8-a919-3a72d81d7bc1"), "TR", "EU", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9139), "Turkey", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9139) },
                    { new Guid("ddd5b4d2-cbf2-438b-8d43-0099c02269ca"), "BY", "EU", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9143), "Belarus", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9144) },
                    { new Guid("dfee7b37-cabc-4bb9-9f34-fd7775a24ce4"), "FR", "EU", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9077), "France", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9078) },
                    { new Guid("e8743957-f433-4841-99bb-7ec841971f3c"), "LT", "EU", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9146), "Lithuania", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9146) },
                    { new Guid("ec635e29-634d-4d61-88d3-0a4c5f3c9ade"), "MK", "EU", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9127), "North Macedonia", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9127) },
                    { new Guid("fc19ec95-7b96-4821-a590-9808f1053ff1"), "SK", "EU", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9109), "Slovakia", new DateTime(2024, 7, 8, 11, 39, 29, 623, DateTimeKind.Utc).AddTicks(9110) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0082ebd0-cb4b-43cc-923b-bf05c0979c16"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("02c7465a-07d3-4966-a546-1318060ebccb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("08102b65-4b66-4dd0-926d-64488917c3a3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1bc7f8e9-4383-438a-a00d-ecfda3531ede"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("260812c2-13fe-4e25-baaf-331cfc2e5a3c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2d87c895-e6bd-474c-b52c-7dd641ad31c3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("47947286-8cce-4caa-8d34-8705d0f674ac"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("49ba6fff-9c83-474c-bb6d-fd425712ecb1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("510f0d45-7f30-42cf-8c86-23555bfdb062"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5c886ed8-e899-4399-83c4-778afd005344"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5cdd1c84-fc02-4422-9f7c-8bde74a09b53"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("61076fe8-8815-47fa-be7d-49fcd81afe79"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6354dbb6-054b-487d-9b5b-2b586cccc613"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("653686de-6c7d-4893-bdba-f3028c49d411"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("683e2142-d8b7-424d-ad63-f28b26b83991"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6f8987d8-f0b6-41f6-b72b-e78a21b24b8d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("70daeae1-7521-40b3-a5de-4cb5c45c6c7a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("73f2d800-9b7f-4f3c-995d-5e25c575627d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7c38fd4e-a529-48c8-8b2a-e7422b105984"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("80276af8-bf72-43ae-9421-91aa41d2c580"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("869d522f-5e78-4fe1-8f24-24f009ad6e98"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8fff77af-8b82-45f5-922a-bf3251618e2e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("96ab5910-b083-4abc-b022-8e6b70568364"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9940d27b-1544-4efe-8765-5a217d920191"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a1c942b2-6dba-482f-a165-51ca5fa8a913"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b3f63a37-c580-444c-863f-cb6eaaaf132e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b8a7abe6-88af-449b-955b-198e2a3a09fa"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bb1229e2-e50f-4c31-bc99-e53df6bb89a7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c0b9ae96-5503-45bf-adc5-2fea34106dcb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c14444fb-d674-4120-9311-082ae781e178"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ca4ca9ac-ab2d-4cc5-9df0-b21bc160869a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ca9e90e6-1cd2-4af7-ae5c-f639a49d216b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d2792a79-10cf-41c8-a919-3a72d81d7bc1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ddd5b4d2-cbf2-438b-8d43-0099c02269ca"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("dfee7b37-cabc-4bb9-9f34-fd7775a24ce4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e8743957-f433-4841-99bb-7ec841971f3c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ec635e29-634d-4d61-88d3-0a4c5f3c9ade"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fc19ec95-7b96-4821-a590-9808f1053ff1"));
        }
    }
}
