using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace mosquebookapi.Migrations
{
    public partial class seedingNewData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("ee48fa11-be9a-4885-a244-98a0aedfbea5"),
                columns: new[] { "Date", "Description" },
                values: new object[] { new DateTime(2021, 4, 15, 0, 31, 9, 293, DateTimeKind.Local).AddTicks(2087), "" });

            migrationBuilder.UpdateData(
                table: "EventType",
                keyColumn: "Id",
                keyValue: new Guid("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1"),
                columns: new[] { "Description", "MosqueId", "Name" },
                values: new object[] { "", new Guid("1a82c06a-4986-4ed3-b1dd-05271b4931d8"), "Fajr" });

            migrationBuilder.InsertData(
                table: "EventType",
                columns: new[] { "Id", "Description", "MosqueId", "Name" },
                values: new object[,]
                {
                    { new Guid("d5d109a9-ac86-40ef-a783-b4c0b8fefaa1"), "", new Guid("1a82c06a-4986-4ed3-b1dd-05271b4931d8"), "Dohr" },
                    { new Guid("d5d109a9-ac86-40ef-a783-b5c0b8fefaa1"), "", new Guid("1a82c06a-4986-4ed3-b1dd-05271b4931d8"), "Asr" },
                    { new Guid("d5d109a9-ac86-40ef-a783-b6c0b8fefaa1"), "", new Guid("1a82c06a-4986-4ed3-b1dd-05271b4931d8"), "Maghreb" },
                    { new Guid("d5d109a9-ac86-40ef-a783-b7c0b8fefaa1"), "Please choose a group", new Guid("1a82c06a-4986-4ed3-b1dd-05271b4931d8"), "Ishaa" }
                });

            migrationBuilder.UpdateData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("4a113557-d989-4243-af30-4d6906ce02de"),
                column: "Name",
                value: "Salat Fajr");

            migrationBuilder.UpdateData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("cf35efea-96a1-4f3a-943d-ae8389fb7337"),
                column: "Name",
                value: "Salat Dohr");

            migrationBuilder.UpdateData(
                table: "Mosque",
                keyColumn: "Id",
                keyValue: new Guid("1a82c06a-4986-4ed3-b1dd-05271b4931d8"),
                columns: new[] { "Address", "Email", "Name" },
                values: new object[] { "Neue Str. 3, 89077 Ulm", "AlSalam@gmail.com", "Al-Salam Moschee" });

            migrationBuilder.UpdateData(
                table: "TemporaryAuthenticators",
                keyColumn: "Id",
                keyValue: 1,
                column: "Token",
                value: new Guid("13b47836-12f0-4a17-a4d9-b9239e9ed64a"));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("802e14d4-7c79-4740-aefc-6bf5b412129c"),
                columns: new[] { "Date", "Description", "EventTypeId" },
                values: new object[] { new DateTime(2021, 4, 15, 0, 31, 9, 294, DateTimeKind.Local).AddTicks(162), "", new Guid("d5d109a9-ac86-40ef-a783-b4c0b8fefaa1") });

            migrationBuilder.InsertData(
                table: "Event",
                columns: new[] { "Id", "Date", "Description", "EventTypeId" },
                values: new object[,]
                {
                    { new Guid("513a6d9e-b4ee-4299-a945-241428be5114"), new DateTime(2021, 4, 15, 0, 31, 9, 294, DateTimeKind.Local).AddTicks(180), "", new Guid("d5d109a9-ac86-40ef-a783-b5c0b8fefaa1") },
                    { new Guid("4ae8d4f8-7444-4aa5-9a80-af1c89f46805"), new DateTime(2021, 4, 15, 0, 31, 9, 294, DateTimeKind.Local).AddTicks(185), "", new Guid("d5d109a9-ac86-40ef-a783-b6c0b8fefaa1") },
                    { new Guid("c23ed31c-5ddc-4993-8b39-7665f43b7fd9"), new DateTime(2021, 4, 15, 0, 31, 9, 294, DateTimeKind.Local).AddTicks(189), "", new Guid("d5d109a9-ac86-40ef-a783-b7c0b8fefaa1") }
                });

            migrationBuilder.InsertData(
                table: "Group",
                columns: new[] { "Id", "EventId", "MaxPlaces", "Name" },
                values: new object[,]
                {
                    { new Guid("2740bdfd-d621-4f42-9ae5-34e24ddc4e85"), new Guid("513a6d9e-b4ee-4299-a945-241428be5114"), 10, "Salat Asr" },
                    { new Guid("a482283f-291a-43bd-8b88-6a4838e96998"), new Guid("4ae8d4f8-7444-4aa5-9a80-af1c89f46805"), 10, "Salat Maghreb" },
                    { new Guid("b5d9b806-d791-440a-b773-8380b7d237bd"), new Guid("c23ed31c-5ddc-4993-8b39-7665f43b7fd9"), 10, "Salat Ishaa" },
                    { new Guid("3be97c6d-7a78-44df-b1a7-2f7a035600c6"), new Guid("c23ed31c-5ddc-4993-8b39-7665f43b7fd9"), 10, "Tarawih group 1" },
                    { new Guid("b450b7fa-7104-4cc1-9b4e-a15c639ca61e"), new Guid("c23ed31c-5ddc-4993-8b39-7665f43b7fd9"), 10, "Tarawih group 2" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EventType",
                keyColumn: "Id",
                keyValue: new Guid("d5d109a9-ac86-40ef-a783-b4c0b8fefaa1"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("2740bdfd-d621-4f42-9ae5-34e24ddc4e85"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("3be97c6d-7a78-44df-b1a7-2f7a035600c6"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("a482283f-291a-43bd-8b88-6a4838e96998"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("b450b7fa-7104-4cc1-9b4e-a15c639ca61e"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("b5d9b806-d791-440a-b773-8380b7d237bd"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("4ae8d4f8-7444-4aa5-9a80-af1c89f46805"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("513a6d9e-b4ee-4299-a945-241428be5114"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("c23ed31c-5ddc-4993-8b39-7665f43b7fd9"));

            migrationBuilder.DeleteData(
                table: "EventType",
                keyColumn: "Id",
                keyValue: new Guid("d5d109a9-ac86-40ef-a783-b5c0b8fefaa1"));

            migrationBuilder.DeleteData(
                table: "EventType",
                keyColumn: "Id",
                keyValue: new Guid("d5d109a9-ac86-40ef-a783-b6c0b8fefaa1"));

            migrationBuilder.DeleteData(
                table: "EventType",
                keyColumn: "Id",
                keyValue: new Guid("d5d109a9-ac86-40ef-a783-b7c0b8fefaa1"));

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("802e14d4-7c79-4740-aefc-6bf5b412129c"),
                columns: new[] { "Date", "Description", "EventTypeId" },
                values: new object[] { new DateTime(2021, 4, 19, 22, 20, 46, 243, DateTimeKind.Local).AddTicks(6933), "tarawih 7", new Guid("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1") });

            migrationBuilder.UpdateData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("ee48fa11-be9a-4885-a244-98a0aedfbea5"),
                columns: new[] { "Date", "Description" },
                values: new object[] { new DateTime(2021, 4, 15, 22, 20, 46, 241, DateTimeKind.Local).AddTicks(5628), "tarawih 1" });

            migrationBuilder.UpdateData(
                table: "EventType",
                keyColumn: "Id",
                keyValue: new Guid("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1"),
                columns: new[] { "Description", "MosqueId", "Name" },
                values: new object[] { "Allaho akbar", null, "Salat tarawih" });

            migrationBuilder.UpdateData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("4a113557-d989-4243-af30-4d6906ce02de"),
                column: "Name",
                value: "Falouja");

            migrationBuilder.UpdateData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("cf35efea-96a1-4f3a-943d-ae8389fb7337"),
                column: "Name",
                value: "Samadi");

            migrationBuilder.UpdateData(
                table: "Mosque",
                keyColumn: "Id",
                keyValue: new Guid("1a82c06a-4986-4ed3-b1dd-05271b4931d8"),
                columns: new[] { "Address", "Email", "Name" },
                values: new object[] { "Jamila 07 RUE 900", "JamaaSouna@gmail.com", "Jamaa Souna" });

            migrationBuilder.UpdateData(
                table: "TemporaryAuthenticators",
                keyColumn: "Id",
                keyValue: 1,
                column: "Token",
                value: new Guid("fca6c19c-7b03-4557-b5c4-327ef8771f05"));
        }
    }
}
