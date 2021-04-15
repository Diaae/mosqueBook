using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace mosquebookapi.Migrations
{
    public partial class seedingNewDataTarawih : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("4ae8d4f8-7444-4aa5-9a80-af1c89f46805"),
                column: "Date",
                value: new DateTime(2021, 4, 15, 0, 36, 25, 675, DateTimeKind.Local).AddTicks(9029));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("513a6d9e-b4ee-4299-a945-241428be5114"),
                column: "Date",
                value: new DateTime(2021, 4, 15, 0, 36, 25, 675, DateTimeKind.Local).AddTicks(9026));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("802e14d4-7c79-4740-aefc-6bf5b412129c"),
                column: "Date",
                value: new DateTime(2021, 4, 15, 0, 36, 25, 675, DateTimeKind.Local).AddTicks(9009));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("c23ed31c-5ddc-4993-8b39-7665f43b7fd9"),
                column: "Date",
                value: new DateTime(2021, 4, 15, 0, 36, 25, 675, DateTimeKind.Local).AddTicks(9031));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("ee48fa11-be9a-4885-a244-98a0aedfbea5"),
                column: "Date",
                value: new DateTime(2021, 4, 15, 0, 36, 25, 675, DateTimeKind.Local).AddTicks(1723));

            migrationBuilder.UpdateData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("2740bdfd-d621-4f42-9ae5-34e24ddc4e85"),
                column: "MaxPlaces",
                value: 300);

            migrationBuilder.UpdateData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("3be97c6d-7a78-44df-b1a7-2f7a035600c6"),
                column: "MaxPlaces",
                value: 150);

            migrationBuilder.UpdateData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("a482283f-291a-43bd-8b88-6a4838e96998"),
                column: "MaxPlaces",
                value: 300);

            migrationBuilder.UpdateData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("b450b7fa-7104-4cc1-9b4e-a15c639ca61e"),
                column: "MaxPlaces",
                value: 150);

            migrationBuilder.UpdateData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("b5d9b806-d791-440a-b773-8380b7d237bd"),
                column: "MaxPlaces",
                value: 300);

            migrationBuilder.UpdateData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("cf35efea-96a1-4f3a-943d-ae8389fb7337"),
                column: "MaxPlaces",
                value: 300);

            migrationBuilder.UpdateData(
                table: "TemporaryAuthenticators",
                keyColumn: "Id",
                keyValue: 1,
                column: "Token",
                value: new Guid("7161863a-b4eb-4fe0-880a-0f96f384d87e"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("4ae8d4f8-7444-4aa5-9a80-af1c89f46805"),
                column: "Date",
                value: new DateTime(2021, 4, 15, 0, 31, 9, 294, DateTimeKind.Local).AddTicks(185));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("513a6d9e-b4ee-4299-a945-241428be5114"),
                column: "Date",
                value: new DateTime(2021, 4, 15, 0, 31, 9, 294, DateTimeKind.Local).AddTicks(180));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("802e14d4-7c79-4740-aefc-6bf5b412129c"),
                column: "Date",
                value: new DateTime(2021, 4, 15, 0, 31, 9, 294, DateTimeKind.Local).AddTicks(162));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("c23ed31c-5ddc-4993-8b39-7665f43b7fd9"),
                column: "Date",
                value: new DateTime(2021, 4, 15, 0, 31, 9, 294, DateTimeKind.Local).AddTicks(189));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("ee48fa11-be9a-4885-a244-98a0aedfbea5"),
                column: "Date",
                value: new DateTime(2021, 4, 15, 0, 31, 9, 293, DateTimeKind.Local).AddTicks(2087));

            migrationBuilder.UpdateData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("2740bdfd-d621-4f42-9ae5-34e24ddc4e85"),
                column: "MaxPlaces",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("3be97c6d-7a78-44df-b1a7-2f7a035600c6"),
                column: "MaxPlaces",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("a482283f-291a-43bd-8b88-6a4838e96998"),
                column: "MaxPlaces",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("b450b7fa-7104-4cc1-9b4e-a15c639ca61e"),
                column: "MaxPlaces",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("b5d9b806-d791-440a-b773-8380b7d237bd"),
                column: "MaxPlaces",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("cf35efea-96a1-4f3a-943d-ae8389fb7337"),
                column: "MaxPlaces",
                value: 10);

            migrationBuilder.UpdateData(
                table: "TemporaryAuthenticators",
                keyColumn: "Id",
                keyValue: 1,
                column: "Token",
                value: new Guid("13b47836-12f0-4a17-a4d9-b9239e9ed64a"));
        }
    }
}
