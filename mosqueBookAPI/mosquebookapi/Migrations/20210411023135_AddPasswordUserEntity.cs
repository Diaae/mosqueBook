using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace mosquebookapi.Migrations
{
    public partial class AddPasswordUserEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "User",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("802e14d4-7c79-4740-aefc-6bf5b412129c"),
                column: "Date",
                value: new DateTime(2021, 4, 18, 4, 31, 34, 731, DateTimeKind.Local).AddTicks(4611));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("ee48fa11-be9a-4885-a244-98a0aedfbea5"),
                column: "Date",
                value: new DateTime(2021, 4, 14, 4, 31, 34, 729, DateTimeKind.Local).AddTicks(1302));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "User");

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("802e14d4-7c79-4740-aefc-6bf5b412129c"),
                column: "Date",
                value: new DateTime(2021, 4, 16, 2, 32, 12, 118, DateTimeKind.Local).AddTicks(7621));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("ee48fa11-be9a-4885-a244-98a0aedfbea5"),
                column: "Date",
                value: new DateTime(2021, 4, 12, 2, 32, 12, 115, DateTimeKind.Local).AddTicks(3324));
        }
    }
}
