using Microsoft.EntityFrameworkCore.Migrations;

namespace mosquebookapi.Migrations
{
    public partial class UpdateEventDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateTime",
                table: "Event",
                newName: "Date");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Event",
                newName: "DateTime");
        }
    }
}
