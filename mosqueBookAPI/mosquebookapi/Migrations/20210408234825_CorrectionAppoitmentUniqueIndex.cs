using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace mosquebookapi.Migrations
{
    public partial class CorrectionAppoitmentUniqueIndex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Appointment_Date",
                table: "Appointment");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Appointment_Date_UserId",
                table: "Appointment");

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

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_Date",
                table: "Appointment",
                column: "Date",
                unique: true);
        }
    }
}
