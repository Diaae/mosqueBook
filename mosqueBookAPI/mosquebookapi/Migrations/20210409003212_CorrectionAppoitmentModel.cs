using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace mosquebookapi.Migrations
{
    public partial class CorrectionAppoitmentModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Appointment_Date_UserId",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Appointment");

            migrationBuilder.AddColumn<Guid>(
                name: "EventId",
                table: "Appointment",
                type: "char(36)",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_EventId_UserId",
                table: "Appointment",
                columns: new[] { "EventId", "UserId" },
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointment_Event_EventId",
                table: "Appointment",
                column: "EventId",
                principalTable: "Event",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointment_Event_EventId",
                table: "Appointment");

            migrationBuilder.DropIndex(
                name: "IX_Appointment_EventId_UserId",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "EventId",
                table: "Appointment");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Appointment",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("802e14d4-7c79-4740-aefc-6bf5b412129c"),
                column: "Date",
                value: new DateTime(2021, 4, 16, 1, 48, 24, 397, DateTimeKind.Local).AddTicks(8112));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("ee48fa11-be9a-4885-a244-98a0aedfbea5"),
                column: "Date",
                value: new DateTime(2021, 4, 12, 1, 48, 24, 394, DateTimeKind.Local).AddTicks(6910));

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_Date_UserId",
                table: "Appointment",
                columns: new[] { "Date", "UserId" },
                unique: true);
        }
    }
}
