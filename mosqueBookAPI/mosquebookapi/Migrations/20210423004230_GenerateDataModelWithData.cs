using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace mosquebookapi.Migrations
{
    public partial class GenerateDataModelWithData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Appointment_Date",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Appointment");

            migrationBuilder.RenameColumn(
                name: "DateTime",
                table: "Event",
                newName: "Date");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "User",
                type: "varchar(255) CHARACTER SET utf8mb4",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "User",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "MosqueId",
                table: "EventType",
                type: "char(36)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "EventId",
                table: "Appointment",
                type: "char(36)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActif",
                table: "Appointment",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

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

            migrationBuilder.InsertData(
                table: "TemporaryAuthenticators",
                columns: new[] { "Id", "Token" },
                values: new object[] { 1, new Guid("29378c63-027c-4887-940e-784bd105cc42") });

            migrationBuilder.CreateIndex(
                name: "IX_User_PhoneNumber",
                table: "User",
                column: "PhoneNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EventType_MosqueId",
                table: "EventType",
                column: "MosqueId");

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
                name: "FK_Appointment_Event_EventId",
                table: "Appointment");

            migrationBuilder.DropForeignKey(
                name: "FK_EventType_Mosque_MosqueId",
                table: "EventType");

            migrationBuilder.DropTable(
                name: "TemporaryAuthenticators");

            migrationBuilder.DropIndex(
                name: "IX_User_PhoneNumber",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_EventType_MosqueId",
                table: "EventType");

            migrationBuilder.DropIndex(
                name: "IX_Appointment_EventId_UserId",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "User");

            migrationBuilder.DropColumn(
                name: "MosqueId",
                table: "EventType");

            migrationBuilder.DropColumn(
                name: "EventId",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "IsActif",
                table: "Appointment");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Event",
                newName: "DateTime");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "User",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255) CHARACTER SET utf8mb4");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Appointment",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_Date",
                table: "Appointment",
                column: "Date",
                unique: true);
        }
    }
}
