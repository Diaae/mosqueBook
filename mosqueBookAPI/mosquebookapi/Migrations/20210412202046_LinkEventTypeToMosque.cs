using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace mosquebookapi.Migrations
{
    public partial class LinkEventTypeToMosque : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Event_Mosque_MosqueId",
                table: "Event");

            migrationBuilder.DropIndex(
                name: "IX_Event_MosqueId",
                table: "Event");

            migrationBuilder.DropColumn(
                name: "MosqueId",
                table: "Event");

            migrationBuilder.AddColumn<Guid>(
                name: "MosqueId",
                table: "EventType",
                type: "char(36)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("802e14d4-7c79-4740-aefc-6bf5b412129c"),
                column: "Date",
                value: new DateTime(2021, 4, 19, 22, 20, 46, 243, DateTimeKind.Local).AddTicks(6933));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("ee48fa11-be9a-4885-a244-98a0aedfbea5"),
                column: "Date",
                value: new DateTime(2021, 4, 15, 22, 20, 46, 241, DateTimeKind.Local).AddTicks(5628));

            migrationBuilder.UpdateData(
                table: "TemporaryAuthenticators",
                keyColumn: "Id",
                keyValue: 1,
                column: "Token",
                value: new Guid("fca6c19c-7b03-4557-b5c4-327ef8771f05"));

            migrationBuilder.CreateIndex(
                name: "IX_EventType_MosqueId",
                table: "EventType",
                column: "MosqueId");

            migrationBuilder.AddForeignKey(
                name: "FK_EventType_Mosque_MosqueId",
                table: "EventType",
                column: "MosqueId",
                principalTable: "Mosque",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventType_Mosque_MosqueId",
                table: "EventType");

            migrationBuilder.DropIndex(
                name: "IX_EventType_MosqueId",
                table: "EventType");

            migrationBuilder.DropColumn(
                name: "MosqueId",
                table: "EventType");

            migrationBuilder.AddColumn<Guid>(
                name: "MosqueId",
                table: "Event",
                type: "char(36)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("802e14d4-7c79-4740-aefc-6bf5b412129c"),
                columns: new[] { "Date", "MosqueId" },
                values: new object[] { new DateTime(2021, 4, 18, 23, 8, 46, 846, DateTimeKind.Local).AddTicks(3949), new Guid("1a82c06a-4986-4ed3-b1dd-05271b4931d8") });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("ee48fa11-be9a-4885-a244-98a0aedfbea5"),
                columns: new[] { "Date", "MosqueId" },
                values: new object[] { new DateTime(2021, 4, 14, 23, 8, 46, 844, DateTimeKind.Local).AddTicks(3248), new Guid("1a82c06a-4986-4ed3-b1dd-05271b4931d8") });

            migrationBuilder.UpdateData(
                table: "TemporaryAuthenticators",
                keyColumn: "Id",
                keyValue: 1,
                column: "Token",
                value: new Guid("42959ca4-174b-46b8-9dd4-b45621117079"));

            migrationBuilder.CreateIndex(
                name: "IX_Event_MosqueId",
                table: "Event",
                column: "MosqueId");

            migrationBuilder.AddForeignKey(
                name: "FK_Event_Mosque_MosqueId",
                table: "Event",
                column: "MosqueId",
                principalTable: "Mosque",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
