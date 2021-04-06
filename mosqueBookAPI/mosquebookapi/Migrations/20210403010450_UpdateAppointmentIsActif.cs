using Microsoft.EntityFrameworkCore.Migrations;

namespace mosquebookapi.Migrations
{
    public partial class UpdateAppointmentIsActif : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActif",
                table: "Appointment",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActif",
                table: "Appointment");
        }
    }
}
