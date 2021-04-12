using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace mosquebookapi.Migrations
{
    public partial class AddTemporaryAuthenticator : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TemporaryAuthenticators",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Token = table.Column<Guid>(type: "char(36)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemporaryAuthenticators", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("802e14d4-7c79-4740-aefc-6bf5b412129c"),
                column: "Date",
                value: new DateTime(2021, 4, 18, 23, 8, 46, 846, DateTimeKind.Local).AddTicks(3949));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("ee48fa11-be9a-4885-a244-98a0aedfbea5"),
                column: "Date",
                value: new DateTime(2021, 4, 14, 23, 8, 46, 844, DateTimeKind.Local).AddTicks(3248));

            migrationBuilder.InsertData(
                table: "TemporaryAuthenticators",
                columns: new[] { "Id", "Token" },
                values: new object[] { 1, new Guid("42959ca4-174b-46b8-9dd4-b45621117079") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TemporaryAuthenticators");

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
    }
}
