using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace mosquebookapi.Migrations
{
    public partial class AddUniqueIndexPhoneNumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "User",
                type: "varchar(255) CHARACTER SET utf8mb4",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4");

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("802e14d4-7c79-4740-aefc-6bf5b412129c"),
                column: "Date",
                value: new DateTime(2021, 4, 15, 22, 0, 38, 80, DateTimeKind.Local).AddTicks(5602));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("ee48fa11-be9a-4885-a244-98a0aedfbea5"),
                column: "Date",
                value: new DateTime(2021, 4, 11, 22, 0, 38, 78, DateTimeKind.Local).AddTicks(3857));

            migrationBuilder.CreateIndex(
                name: "IX_User_PhoneNumber",
                table: "User",
                column: "PhoneNumber",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_User_PhoneNumber",
                table: "User");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "User",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255) CHARACTER SET utf8mb4");

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("802e14d4-7c79-4740-aefc-6bf5b412129c"),
                column: "Date",
                value: new DateTime(2021, 4, 14, 0, 13, 0, 33, DateTimeKind.Local).AddTicks(2354));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("ee48fa11-be9a-4885-a244-98a0aedfbea5"),
                column: "Date",
                value: new DateTime(2021, 4, 10, 0, 13, 0, 30, DateTimeKind.Local).AddTicks(8842));
        }
    }
}
