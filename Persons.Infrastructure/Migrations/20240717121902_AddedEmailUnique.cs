using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persons.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedEmailUnique : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "EmailAddresses",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Code", "CountryRegionCode", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("0030d580-b35c-419b-9c5f-97e4d7fb7c15"), "AL", "EU", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8904), "Albania", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8904) },
                    { new Guid("0245f0a5-3c9c-4dc3-ae5e-411aa9231861"), "ES", "EU", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8842), "Spain", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8843) },
                    { new Guid("0731548a-3f90-4aaf-a1bc-57874f3ea69e"), "PL", "EU", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8872), "Poland", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8873) },
                    { new Guid("0a1c8607-6c62-46fc-af41-0ce343efa869"), "BA", "EU", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8892), "Bosnia and Herzegovina", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8893) },
                    { new Guid("0c4985c4-fd13-40e8-8aeb-681dc30a33d9"), "EE", "EU", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8928), "Estonia", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8929) },
                    { new Guid("0deca6d8-0838-4485-b964-b9a47b1945b9"), "IS", "EU", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8939), "Iceland", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8940) },
                    { new Guid("1219c431-9a2f-4010-9628-d8dca8efdfa0"), "SE", "EU", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8933), "Sweden", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8933) },
                    { new Guid("1d9a9a08-49df-4b2c-ac92-28e9ac899345"), "HR", "EU", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8888), "Croatia", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8888) },
                    { new Guid("1f979e39-06a9-4ceb-9287-4e02d787e671"), "TR", "EU", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8914), "Turkey", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8915) },
                    { new Guid("2355ba89-9338-4060-aba0-0b85de5e13af"), "IT", "EU", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8840), "Italy", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8840) },
                    { new Guid("2794bdcd-e04e-400b-99d0-57d79287f6c1"), "GR", "EU", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8906), "Greece", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8907) },
                    { new Guid("27a8534c-8621-4dfe-af57-e8ac879968ff"), "XK", "EU", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8897), "Kosovo", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8897) },
                    { new Guid("27e077a7-59b8-4529-93c5-c6a248096503"), "FI", "EU", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8930), "Finland", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8931) },
                    { new Guid("28336fcd-ed72-4476-b63d-d0e3abbe40c0"), "BY", "EU", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8919), "Belarus", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8920) },
                    { new Guid("2e84c99d-8eef-4eb8-934b-b2073c35838b"), "PT", "EU", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8855), "Portugal", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8856) },
                    { new Guid("64564d2f-e19c-43ed-8fb8-34f8ac487f3b"), "MK", "EU", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8901), "North Macedonia", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8902) },
                    { new Guid("646472bd-4ddb-4d43-a6ee-2e1ffaad7c39"), "RS", "EU", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8890), "Serbia", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8891) },
                    { new Guid("65f67b00-4ba8-4f81-86c9-36efe2f6e793"), "RO", "EU", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8912), "Romania", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8912) },
                    { new Guid("6dea4d3b-557a-4dc5-adeb-496ae03ce744"), "CH", "EU", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8870), "Switzerland", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8870) },
                    { new Guid("70f1f750-f80a-48ec-99ab-856cf48b8ff3"), "SI", "EU", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8885), "Slovenia", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8886) },
                    { new Guid("7a319f2b-495d-489e-9798-eefd435acc28"), "GB", "EU", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8944), "United Kingdom", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8944) },
                    { new Guid("7ec56ad0-95a4-4915-80bf-33a161c0d9a8"), "SK", "EU", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8883), "Slovakia", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8883) },
                    { new Guid("860fadc9-11eb-46b9-a7a6-6a05a1392532"), "DE", "EU", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8828), "Germany", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8832) },
                    { new Guid("869d9276-370d-4e26-a370-fd219f9fdd5e"), "AT", "EU", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8866), "Austria", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8867) },
                    { new Guid("8b1ef79c-ab8d-41d2-8c25-fb356d00bbcb"), "CZ", "EU", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8875), "Czech Republic", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8875) },
                    { new Guid("8f0ab2d0-f103-4a6e-aa73-e8194570cfb2"), "NO", "EU", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8935), "Norway", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8935) },
                    { new Guid("8fdf6c95-2975-48b2-aa2f-4a9208a5098d"), "UA", "EU", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8917), "Ukraine", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8917) },
                    { new Guid("a3bb9b89-961e-4e31-a0a3-bd1fc4b6af13"), "HU", "EU", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8880), "Hungary", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8881) },
                    { new Guid("b09b8094-d3b5-42a9-b5f1-876d72b144de"), "FR", "EU", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8836), "France", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8837) },
                    { new Guid("b494a40f-5be9-4aff-a313-ca9ef84e5892"), "ME", "EU", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8895), "Montenegro", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8895) },
                    { new Guid("bcb208e1-0ede-4e0f-a30f-37139e0d0e35"), "LT", "EU", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8923), "Lithuania", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8924) },
                    { new Guid("d0d1edfc-e09a-4d1e-87c6-a9c214fc26bf"), "BE", "EU", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8861), "Belgium", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8861) },
                    { new Guid("dafc5e99-cb59-4f24-9309-93b92c2b167a"), "LV", "EU", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8926), "Latvia", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8926) },
                    { new Guid("dcca438e-156e-4152-b8b6-89be6174c58b"), "LU", "EU", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8863), "Luxembourg", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8864) },
                    { new Guid("dd12dd09-57b5-42d1-9a78-dd60b383266d"), "IE", "EU", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8946), "Ireland", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8947) },
                    { new Guid("f4506af9-da77-4fd9-92be-542311cefbb4"), "NL", "EU", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8858), "Netherlands", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8859) },
                    { new Guid("f47602a3-74a9-4791-8a6b-5963aad87014"), "BG", "EU", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8909), "Bulgaria", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8910) },
                    { new Guid("f91ae38e-6260-406c-932f-b09bc40877c3"), "DK", "EU", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8937), "Denmark", new DateTime(2024, 7, 17, 12, 19, 1, 205, DateTimeKind.Utc).AddTicks(8938) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmailAddresses_Email",
                table: "EmailAddresses",
                column: "Email",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_EmailAddresses_Email",
                table: "EmailAddresses");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0030d580-b35c-419b-9c5f-97e4d7fb7c15"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0245f0a5-3c9c-4dc3-ae5e-411aa9231861"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0731548a-3f90-4aaf-a1bc-57874f3ea69e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0a1c8607-6c62-46fc-af41-0ce343efa869"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0c4985c4-fd13-40e8-8aeb-681dc30a33d9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0deca6d8-0838-4485-b964-b9a47b1945b9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1219c431-9a2f-4010-9628-d8dca8efdfa0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1d9a9a08-49df-4b2c-ac92-28e9ac899345"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1f979e39-06a9-4ceb-9287-4e02d787e671"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2355ba89-9338-4060-aba0-0b85de5e13af"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2794bdcd-e04e-400b-99d0-57d79287f6c1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("27a8534c-8621-4dfe-af57-e8ac879968ff"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("27e077a7-59b8-4529-93c5-c6a248096503"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("28336fcd-ed72-4476-b63d-d0e3abbe40c0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2e84c99d-8eef-4eb8-934b-b2073c35838b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("64564d2f-e19c-43ed-8fb8-34f8ac487f3b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("646472bd-4ddb-4d43-a6ee-2e1ffaad7c39"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("65f67b00-4ba8-4f81-86c9-36efe2f6e793"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6dea4d3b-557a-4dc5-adeb-496ae03ce744"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("70f1f750-f80a-48ec-99ab-856cf48b8ff3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7a319f2b-495d-489e-9798-eefd435acc28"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7ec56ad0-95a4-4915-80bf-33a161c0d9a8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("860fadc9-11eb-46b9-a7a6-6a05a1392532"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("869d9276-370d-4e26-a370-fd219f9fdd5e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8b1ef79c-ab8d-41d2-8c25-fb356d00bbcb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8f0ab2d0-f103-4a6e-aa73-e8194570cfb2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8fdf6c95-2975-48b2-aa2f-4a9208a5098d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a3bb9b89-961e-4e31-a0a3-bd1fc4b6af13"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b09b8094-d3b5-42a9-b5f1-876d72b144de"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b494a40f-5be9-4aff-a313-ca9ef84e5892"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bcb208e1-0ede-4e0f-a30f-37139e0d0e35"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d0d1edfc-e09a-4d1e-87c6-a9c214fc26bf"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("dafc5e99-cb59-4f24-9309-93b92c2b167a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("dcca438e-156e-4152-b8b6-89be6174c58b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("dd12dd09-57b5-42d1-9a78-dd60b383266d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f4506af9-da77-4fd9-92be-542311cefbb4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f47602a3-74a9-4791-8a6b-5963aad87014"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f91ae38e-6260-406c-932f-b09bc40877c3"));

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "EmailAddresses",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

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
    }
}
