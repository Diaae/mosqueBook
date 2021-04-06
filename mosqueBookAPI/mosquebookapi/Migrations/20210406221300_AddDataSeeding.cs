using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace mosquebookapi.Migrations
{
    public partial class AddDataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "EventType",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { new Guid("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1"), "Allaho akbar", "Salat tarawih" });

            migrationBuilder.InsertData(
                table: "Mosque",
                columns: new[] { "Id", "Address", "Email", "Name", "PhoneNumber" },
                values: new object[] { new Guid("1a82c06a-4986-4ed3-b1dd-05271b4931d8"), "Jamila 07 RUE 900", "JamaaSouna@gmail.com", "Jamaa Souna", null });

            migrationBuilder.InsertData(
                table: "Event",
                columns: new[] { "Id", "Date", "Description", "EventTypeId", "MosqueId" },
                values: new object[] { new Guid("ee48fa11-be9a-4885-a244-98a0aedfbea5"), new DateTime(2021, 4, 10, 0, 13, 0, 30, DateTimeKind.Local).AddTicks(8842), "tarawih 1", new Guid("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1"), new Guid("1a82c06a-4986-4ed3-b1dd-05271b4931d8") });

            migrationBuilder.InsertData(
                table: "Event",
                columns: new[] { "Id", "Date", "Description", "EventTypeId", "MosqueId" },
                values: new object[] { new Guid("802e14d4-7c79-4740-aefc-6bf5b412129c"), new DateTime(2021, 4, 14, 0, 13, 0, 33, DateTimeKind.Local).AddTicks(2354), "tarawih 7", new Guid("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1"), new Guid("1a82c06a-4986-4ed3-b1dd-05271b4931d8") });

            migrationBuilder.InsertData(
                table: "Group",
                columns: new[] { "Id", "EventId", "MaxPlaces", "Name" },
                values: new object[] { new Guid("4a113557-d989-4243-af30-4d6906ce02de"), new Guid("ee48fa11-be9a-4885-a244-98a0aedfbea5"), 300, "Falouja" });

            migrationBuilder.InsertData(
                table: "Group",
                columns: new[] { "Id", "EventId", "MaxPlaces", "Name" },
                values: new object[] { new Guid("cf35efea-96a1-4f3a-943d-ae8389fb7337"), new Guid("802e14d4-7c79-4740-aefc-6bf5b412129c"), 10, "Samadi" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("4a113557-d989-4243-af30-4d6906ce02de"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("cf35efea-96a1-4f3a-943d-ae8389fb7337"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("802e14d4-7c79-4740-aefc-6bf5b412129c"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("ee48fa11-be9a-4885-a244-98a0aedfbea5"));

            migrationBuilder.DeleteData(
                table: "EventType",
                keyColumn: "Id",
                keyValue: new Guid("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1"));

            migrationBuilder.DeleteData(
                table: "Mosque",
                keyColumn: "Id",
                keyValue: new Guid("1a82c06a-4986-4ed3-b1dd-05271b4931d8"));
        }
    }
}
