using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace mosquebookapi.Migrations
{
    public partial class GenerateDataModelWithData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Event_Mosque_MosqueId",
                table: "Event");

            migrationBuilder.DropIndex(
                name: "IX_Event_MosqueId",
                table: "Event");

            migrationBuilder.DropIndex(
                name: "IX_Appointment_Date",
                table: "Appointment");

            migrationBuilder.DropColumn(
                name: "MosqueId",
                table: "Event");

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
                table: "Mosque",
                columns: new[] { "Id", "Address", "Email", "Name", "PhoneNumber" },
                values: new object[] { new Guid("1a82c06a-4986-4ed3-b1dd-05271b4931d8"), "Neue Str. 3, 89077 Ulm", "AlSalam@gmail.com", "Al-Salam Moschee", null });

            migrationBuilder.InsertData(
                table: "TemporaryAuthenticators",
                columns: new[] { "Id", "Token" },
                values: new object[] { 1, new Guid("05371963-b818-4ad1-bda2-f86b4fcaf184") });

            migrationBuilder.InsertData(
                table: "EventType",
                columns: new[] { "Id", "Description", "MosqueId", "Name" },
                values: new object[,]
                {
                    { new Guid("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1"), "", new Guid("1a82c06a-4986-4ed3-b1dd-05271b4931d8"), "Fajr" },
                    { new Guid("d5d109a9-ac86-40ef-a783-b4c0b8fefaa1"), "", new Guid("1a82c06a-4986-4ed3-b1dd-05271b4931d8"), "Dohr" },
                    { new Guid("d5d109a9-ac86-40ef-a783-b5c0b8fefaa1"), "", new Guid("1a82c06a-4986-4ed3-b1dd-05271b4931d8"), "Asr" },
                    { new Guid("d5d109a9-ac86-40ef-a783-b6c0b8fefaa1"), "", new Guid("1a82c06a-4986-4ed3-b1dd-05271b4931d8"), "Maghreb" },
                    { new Guid("d5d109a9-ac86-40ef-a783-b7c0b8fefaa1"), "Please choose a group", new Guid("1a82c06a-4986-4ed3-b1dd-05271b4931d8"), "Ishaa" }
                });

            migrationBuilder.InsertData(
                table: "Event",
                columns: new[] { "Id", "Date", "Description", "EventTypeId" },
                values: new object[,]
                {
                    { new Guid("b211ea5f-052c-4c60-9dad-213825944b07"), new DateTime(2021, 4, 23, 3, 23, 13, 795, DateTimeKind.Local).AddTicks(2917), "", new Guid("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1") },
                    { new Guid("7e6139d1-58b9-4421-bf9d-6ec1738c1fee"), new DateTime(2021, 4, 29, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(6462), "", new Guid("d5d109a9-ac86-40ef-a783-b6c0b8fefaa1") },
                    { new Guid("3ae47eaa-332a-453b-bc2d-bb797e58015d"), new DateTime(2021, 4, 30, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(6574), "", new Guid("d5d109a9-ac86-40ef-a783-b6c0b8fefaa1") },
                    { new Guid("5d88104c-cb14-4b11-abf4-6625ffea28c9"), new DateTime(2021, 5, 1, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(6624), "", new Guid("d5d109a9-ac86-40ef-a783-b6c0b8fefaa1") },
                    { new Guid("ead078e7-498e-4386-a0e7-ba14ea8f1815"), new DateTime(2021, 5, 2, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(6669), "", new Guid("d5d109a9-ac86-40ef-a783-b6c0b8fefaa1") },
                    { new Guid("010f08d7-1241-4594-8310-98b03e2ef291"), new DateTime(2021, 5, 3, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(6719), "", new Guid("d5d109a9-ac86-40ef-a783-b6c0b8fefaa1") },
                    { new Guid("2e9e88d0-efa3-4167-9536-fee7a0ccad7d"), new DateTime(2021, 5, 4, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(6814), "", new Guid("d5d109a9-ac86-40ef-a783-b6c0b8fefaa1") },
                    { new Guid("6284538f-b96b-46dc-b097-c1c930baada5"), new DateTime(2021, 4, 28, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(6410), "", new Guid("d5d109a9-ac86-40ef-a783-b6c0b8fefaa1") },
                    { new Guid("cdec6270-16a3-4f37-bba2-93c3cf3b887a"), new DateTime(2021, 5, 5, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(6863), "", new Guid("d5d109a9-ac86-40ef-a783-b6c0b8fefaa1") },
                    { new Guid("d8c3f3a6-caff-4eaa-b43e-ab0562c1c6ec"), new DateTime(2021, 5, 7, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(6994), "", new Guid("d5d109a9-ac86-40ef-a783-b6c0b8fefaa1") },
                    { new Guid("0e296b65-a652-4af0-ac49-ce7015a8b363"), new DateTime(2021, 5, 8, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7045), "", new Guid("d5d109a9-ac86-40ef-a783-b6c0b8fefaa1") },
                    { new Guid("868a8e62-4911-420b-a9e2-37e04a237ba2"), new DateTime(2021, 5, 9, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7093), "", new Guid("d5d109a9-ac86-40ef-a783-b6c0b8fefaa1") },
                    { new Guid("0ba46ae3-58a8-4b26-a86a-47aa7d0a4bb4"), new DateTime(2021, 5, 10, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7139), "", new Guid("d5d109a9-ac86-40ef-a783-b6c0b8fefaa1") },
                    { new Guid("89fedf24-c865-4807-858f-9ac8197611fa"), new DateTime(2021, 5, 11, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7186), "", new Guid("d5d109a9-ac86-40ef-a783-b6c0b8fefaa1") },
                    { new Guid("46ad0090-3516-4fe5-ae19-5ae5089d29a4"), new DateTime(2021, 5, 12, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7258), "", new Guid("d5d109a9-ac86-40ef-a783-b6c0b8fefaa1") },
                    { new Guid("6e9c5aab-1d69-481d-a0d3-1e22588e5520"), new DateTime(2021, 5, 6, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(6913), "", new Guid("d5d109a9-ac86-40ef-a783-b6c0b8fefaa1") },
                    { new Guid("86800288-d18d-4dda-9dad-96031629c095"), new DateTime(2021, 4, 27, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(6329), "", new Guid("d5d109a9-ac86-40ef-a783-b6c0b8fefaa1") },
                    { new Guid("ee1dae24-22c1-4e59-9fd4-16c33a3d3b43"), new DateTime(2021, 4, 26, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(6275), "", new Guid("d5d109a9-ac86-40ef-a783-b6c0b8fefaa1") },
                    { new Guid("6885fa88-1a99-4b51-840a-a90e415e9a3f"), new DateTime(2021, 4, 25, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(6125), "", new Guid("d5d109a9-ac86-40ef-a783-b6c0b8fefaa1") },
                    { new Guid("1044c40d-2062-442a-abcf-b1313a10298e"), new DateTime(2021, 5, 10, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7136), "", new Guid("d5d109a9-ac86-40ef-a783-b5c0b8fefaa1") },
                    { new Guid("d19f3721-2ab8-4363-934d-6e1a84eccb75"), new DateTime(2021, 5, 11, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7183), "", new Guid("d5d109a9-ac86-40ef-a783-b5c0b8fefaa1") },
                    { new Guid("63ecbbf5-0b8e-4961-9af0-39f02643a00e"), new DateTime(2021, 5, 12, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7255), "", new Guid("d5d109a9-ac86-40ef-a783-b5c0b8fefaa1") },
                    { new Guid("a6b604fd-e402-48b6-be44-67b6c62cb061"), new DateTime(2021, 5, 13, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7305), "", new Guid("d5d109a9-ac86-40ef-a783-b5c0b8fefaa1") },
                    { new Guid("007a9573-c92c-4854-a6bf-e5317320fa3e"), new DateTime(2021, 5, 14, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7351), "", new Guid("d5d109a9-ac86-40ef-a783-b5c0b8fefaa1") },
                    { new Guid("23c8584b-5d4e-4707-9e1a-06a57f770029"), new DateTime(2021, 5, 15, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7422), "", new Guid("d5d109a9-ac86-40ef-a783-b5c0b8fefaa1") },
                    { new Guid("55ef304c-1d5f-4506-a026-c0166fbed941"), new DateTime(2021, 5, 16, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7470), "", new Guid("d5d109a9-ac86-40ef-a783-b5c0b8fefaa1") },
                    { new Guid("27f76d6e-644a-48e7-a72a-05d7bc8191af"), new DateTime(2021, 5, 17, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7518), "", new Guid("d5d109a9-ac86-40ef-a783-b5c0b8fefaa1") },
                    { new Guid("ac71eb4c-91fd-4f8f-8068-cec454cc394c"), new DateTime(2021, 5, 18, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7565), "", new Guid("d5d109a9-ac86-40ef-a783-b5c0b8fefaa1") },
                    { new Guid("1cd4940b-1d27-4d5e-a610-26c6348c737a"), new DateTime(2021, 5, 19, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7639), "", new Guid("d5d109a9-ac86-40ef-a783-b5c0b8fefaa1") },
                    { new Guid("4e7f697a-1fd5-49d4-a6a3-7d892cf7ca7b"), new DateTime(2021, 5, 20, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7687), "", new Guid("d5d109a9-ac86-40ef-a783-b5c0b8fefaa1") },
                    { new Guid("05515cc3-d1cd-408a-b330-4ae4c1fc3fec"), new DateTime(2021, 5, 21, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7734), "", new Guid("d5d109a9-ac86-40ef-a783-b5c0b8fefaa1") },
                    { new Guid("621030d9-7c7b-4ec0-8eae-c7e9621c3c20"), new DateTime(2021, 5, 22, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7780), "", new Guid("d5d109a9-ac86-40ef-a783-b5c0b8fefaa1") },
                    { new Guid("24aba7df-df6a-4a6c-bc8e-9fbf40693cb2"), new DateTime(2021, 4, 23, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(4021), "", new Guid("d5d109a9-ac86-40ef-a783-b6c0b8fefaa1") },
                    { new Guid("0b26c235-bf46-43eb-bc0a-10f65fd0c32f"), new DateTime(2021, 4, 24, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(6057), "", new Guid("d5d109a9-ac86-40ef-a783-b6c0b8fefaa1") },
                    { new Guid("0f6b3162-2311-4bb1-890d-b6c0ede098d3"), new DateTime(2021, 5, 13, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7307), "", new Guid("d5d109a9-ac86-40ef-a783-b6c0b8fefaa1") },
                    { new Guid("78e7fa4b-1589-4903-8af9-2a7e6133bbc8"), new DateTime(2021, 5, 14, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7354), "", new Guid("d5d109a9-ac86-40ef-a783-b6c0b8fefaa1") },
                    { new Guid("28546b44-8893-40a1-9fca-8d8a8b0a6845"), new DateTime(2021, 5, 15, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7425), "", new Guid("d5d109a9-ac86-40ef-a783-b6c0b8fefaa1") },
                    { new Guid("a4bf2c11-0670-4753-91ae-72c4f5a16331"), new DateTime(2021, 5, 16, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7473), "", new Guid("d5d109a9-ac86-40ef-a783-b6c0b8fefaa1") },
                    { new Guid("aefb8c10-9ab7-4af9-84fb-f9fa2a8ae37b"), new DateTime(2021, 5, 6, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(6917), "", new Guid("d5d109a9-ac86-40ef-a783-b7c0b8fefaa1") },
                    { new Guid("25326c78-21d4-4905-a4c6-51ae7e8f030e"), new DateTime(2021, 5, 7, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(6998), "", new Guid("d5d109a9-ac86-40ef-a783-b7c0b8fefaa1") },
                    { new Guid("692f2d41-b215-437b-a6cd-a62aab57493a"), new DateTime(2021, 5, 8, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7050), "", new Guid("d5d109a9-ac86-40ef-a783-b7c0b8fefaa1") },
                    { new Guid("05ccf9e3-a868-486f-8211-4edd84464c1d"), new DateTime(2021, 5, 9, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7095), "", new Guid("d5d109a9-ac86-40ef-a783-b7c0b8fefaa1") },
                    { new Guid("e03fb59f-0dcb-4a9c-9a65-35e35c2d94f7"), new DateTime(2021, 5, 10, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7143), "", new Guid("d5d109a9-ac86-40ef-a783-b7c0b8fefaa1") },
                    { new Guid("552c5fec-addc-4018-8fd2-c4ab0acfeb33"), new DateTime(2021, 5, 11, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7189), "", new Guid("d5d109a9-ac86-40ef-a783-b7c0b8fefaa1") },
                    { new Guid("b27365ef-db38-42fa-b3f2-39ad07089a9a"), new DateTime(2021, 5, 12, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7262), "", new Guid("d5d109a9-ac86-40ef-a783-b7c0b8fefaa1") },
                    { new Guid("19b855b8-c8b3-4707-bf99-03468c2fd6d3"), new DateTime(2021, 5, 13, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7310), "", new Guid("d5d109a9-ac86-40ef-a783-b7c0b8fefaa1") },
                    { new Guid("72654f1a-6d9e-41b3-8b88-90a1cd9e3a8e"), new DateTime(2021, 5, 14, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7358), "", new Guid("d5d109a9-ac86-40ef-a783-b7c0b8fefaa1") },
                    { new Guid("e5e8abb0-85d8-4c5f-a967-e4204be00251"), new DateTime(2021, 5, 15, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7428), "", new Guid("d5d109a9-ac86-40ef-a783-b7c0b8fefaa1") },
                    { new Guid("3742d9e3-08a8-44a0-a46d-3fc18ea357e4"), new DateTime(2021, 5, 16, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7477), "", new Guid("d5d109a9-ac86-40ef-a783-b7c0b8fefaa1") },
                    { new Guid("b9f51810-0440-4268-b864-a4d36fe4efde"), new DateTime(2021, 5, 17, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7523), "", new Guid("d5d109a9-ac86-40ef-a783-b7c0b8fefaa1") },
                    { new Guid("00d4b43a-e8f6-4680-9743-9c1c04a85672"), new DateTime(2021, 5, 18, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7572), "", new Guid("d5d109a9-ac86-40ef-a783-b7c0b8fefaa1") },
                    { new Guid("6de0a8c4-a669-48db-b6e5-cab7a1bcef2a"), new DateTime(2021, 5, 19, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7645), "", new Guid("d5d109a9-ac86-40ef-a783-b7c0b8fefaa1") },
                    { new Guid("aac9ecfa-4abd-473c-987e-2a67720754dc"), new DateTime(2021, 5, 20, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7694), "", new Guid("d5d109a9-ac86-40ef-a783-b7c0b8fefaa1") },
                    { new Guid("d72937bf-f42b-492e-affb-650c9829b33d"), new DateTime(2021, 5, 5, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(6865), "", new Guid("d5d109a9-ac86-40ef-a783-b7c0b8fefaa1") },
                    { new Guid("d2587522-fe23-4fc3-9511-18266dcdcc9e"), new DateTime(2021, 5, 9, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7090), "", new Guid("d5d109a9-ac86-40ef-a783-b5c0b8fefaa1") },
                    { new Guid("d779da88-82fc-4c7f-b9e7-1c1b8e052613"), new DateTime(2021, 5, 4, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(6819), "", new Guid("d5d109a9-ac86-40ef-a783-b7c0b8fefaa1") },
                    { new Guid("648bf85a-e7db-43ae-a41b-2176ddb3bb8a"), new DateTime(2021, 5, 2, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(6674), "", new Guid("d5d109a9-ac86-40ef-a783-b7c0b8fefaa1") },
                    { new Guid("292a7ff1-5622-43bf-b8ca-94a7607f8f79"), new DateTime(2021, 5, 17, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7520), "", new Guid("d5d109a9-ac86-40ef-a783-b6c0b8fefaa1") },
                    { new Guid("abfbba45-f3f1-452d-b3c0-2bb8d5a243d4"), new DateTime(2021, 5, 18, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7567), "", new Guid("d5d109a9-ac86-40ef-a783-b6c0b8fefaa1") },
                    { new Guid("2e55809c-3f5b-47e1-a4f5-44c467ec2b71"), new DateTime(2021, 5, 19, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7642), "", new Guid("d5d109a9-ac86-40ef-a783-b6c0b8fefaa1") },
                    { new Guid("6695e4d5-6346-46f2-8b9d-418431bf13e8"), new DateTime(2021, 5, 20, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7689), "", new Guid("d5d109a9-ac86-40ef-a783-b6c0b8fefaa1") },
                    { new Guid("4e733c47-28a7-4895-963b-fe426b4b4ac2"), new DateTime(2021, 5, 21, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7736), "", new Guid("d5d109a9-ac86-40ef-a783-b6c0b8fefaa1") },
                    { new Guid("b95f63a1-a987-4806-be96-05f95d1aa993"), new DateTime(2021, 5, 22, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7783), "", new Guid("d5d109a9-ac86-40ef-a783-b6c0b8fefaa1") },
                    { new Guid("3ac8a7b4-75f5-418a-8a31-8f1ec5497827"), new DateTime(2021, 4, 23, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(4025), "", new Guid("d5d109a9-ac86-40ef-a783-b7c0b8fefaa1") },
                    { new Guid("54d62a13-c759-44c1-ad63-a16b676250e0"), new DateTime(2021, 4, 24, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(6063), "", new Guid("d5d109a9-ac86-40ef-a783-b7c0b8fefaa1") },
                    { new Guid("5cfe4409-39f9-49b4-bee8-2b897cd359df"), new DateTime(2021, 4, 25, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(6128), "", new Guid("d5d109a9-ac86-40ef-a783-b7c0b8fefaa1") },
                    { new Guid("4d8d811b-968e-4a56-8c73-5d9c0dc556f8"), new DateTime(2021, 4, 26, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(6279), "", new Guid("d5d109a9-ac86-40ef-a783-b7c0b8fefaa1") },
                    { new Guid("6ba240fa-f2ad-490e-9841-8bfcf1b62a98"), new DateTime(2021, 4, 27, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(6332), "", new Guid("d5d109a9-ac86-40ef-a783-b7c0b8fefaa1") },
                    { new Guid("0f501328-eaf1-4860-8641-48c8fa5a6fea"), new DateTime(2021, 4, 28, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(6415), "", new Guid("d5d109a9-ac86-40ef-a783-b7c0b8fefaa1") },
                    { new Guid("0d218931-ddbd-4579-9f5b-d3dc00550654"), new DateTime(2021, 4, 29, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(6464), "", new Guid("d5d109a9-ac86-40ef-a783-b7c0b8fefaa1") },
                    { new Guid("7cfa4d8e-e530-4dfd-8c52-f8704174fb5a"), new DateTime(2021, 4, 30, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(6578), "", new Guid("d5d109a9-ac86-40ef-a783-b7c0b8fefaa1") },
                    { new Guid("2635a385-525c-4271-ae21-b6156c06d2df"), new DateTime(2021, 5, 1, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(6626), "", new Guid("d5d109a9-ac86-40ef-a783-b7c0b8fefaa1") },
                    { new Guid("ceae4395-2671-4bd0-a96b-0c432020b4d4"), new DateTime(2021, 5, 3, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(6722), "", new Guid("d5d109a9-ac86-40ef-a783-b7c0b8fefaa1") },
                    { new Guid("c1715844-de2b-4d82-b785-72772218aebe"), new DateTime(2021, 5, 8, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7043), "", new Guid("d5d109a9-ac86-40ef-a783-b5c0b8fefaa1") },
                    { new Guid("34b556a3-2844-476e-b3cc-8e7784f81a3c"), new DateTime(2021, 5, 7, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(6958), "", new Guid("d5d109a9-ac86-40ef-a783-b5c0b8fefaa1") },
                    { new Guid("7302aec8-d53e-46d9-9e9b-014234ee5e6b"), new DateTime(2021, 5, 6, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(6910), "", new Guid("d5d109a9-ac86-40ef-a783-b5c0b8fefaa1") },
                    { new Guid("9b2691dc-544f-410d-8b04-9ebda634b5ce"), new DateTime(2021, 5, 13, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7299), "", new Guid("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1") },
                    { new Guid("002ab300-622d-41f3-b3cd-82abdf6077b5"), new DateTime(2021, 5, 14, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7346), "", new Guid("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1") },
                    { new Guid("514caf56-c82e-41d5-8253-aad88b3df926"), new DateTime(2021, 5, 15, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7416), "", new Guid("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1") },
                    { new Guid("07beae5b-35d9-4838-899a-4e444935db76"), new DateTime(2021, 5, 16, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7464), "", new Guid("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1") },
                    { new Guid("37a19096-7bce-430e-8b58-15d072869e95"), new DateTime(2021, 5, 17, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7512), "", new Guid("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1") },
                    { new Guid("b12a75ef-3359-45ed-91f0-552cdbf2a10a"), new DateTime(2021, 5, 18, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7559), "", new Guid("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1") },
                    { new Guid("c3a4ee8d-22d0-4cf2-88f7-18cac590d843"), new DateTime(2021, 5, 19, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7634), "", new Guid("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1") },
                    { new Guid("39fc9bc8-ce9b-42c5-ad0e-2d9aabbd22c6"), new DateTime(2021, 5, 20, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7681), "", new Guid("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1") },
                    { new Guid("c3bc3183-c893-4fd1-b942-41ee71fec8cb"), new DateTime(2021, 5, 21, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7728), "", new Guid("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1") },
                    { new Guid("b6b91630-61d8-4d4a-8174-8c332be8a76c"), new DateTime(2021, 5, 22, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7775), "", new Guid("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1") },
                    { new Guid("1af6340c-71f3-40ab-a3e0-0b963f3a519b"), new DateTime(2021, 4, 23, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(3988), "", new Guid("d5d109a9-ac86-40ef-a783-b4c0b8fefaa1") },
                    { new Guid("700fbfa4-1ccc-4b57-8fc8-058d8f76d055"), new DateTime(2021, 4, 24, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(6051), "", new Guid("d5d109a9-ac86-40ef-a783-b4c0b8fefaa1") },
                    { new Guid("52f16339-053d-4cbf-9fb7-e1b40385fe65"), new DateTime(2021, 4, 25, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(6120), "", new Guid("d5d109a9-ac86-40ef-a783-b4c0b8fefaa1") },
                    { new Guid("8340f449-fa98-4d1a-9e3a-aaf314f458c4"), new DateTime(2021, 4, 26, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(6269), "", new Guid("d5d109a9-ac86-40ef-a783-b4c0b8fefaa1") },
                    { new Guid("0292c1ad-6fdd-4829-836b-0beae2ebc96a"), new DateTime(2021, 4, 27, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(6324), "", new Guid("d5d109a9-ac86-40ef-a783-b4c0b8fefaa1") },
                    { new Guid("a31b533b-2dba-4a33-9e9e-989bd0d6bdc3"), new DateTime(2021, 5, 12, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7249), "", new Guid("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1") },
                    { new Guid("e54c5166-8e4f-451d-916f-4d290a8ad3f2"), new DateTime(2021, 4, 28, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(6405), "", new Guid("d5d109a9-ac86-40ef-a783-b4c0b8fefaa1") },
                    { new Guid("662562aa-3014-4822-b385-3073856c22b3"), new DateTime(2021, 5, 11, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7178), "", new Guid("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1") },
                    { new Guid("f4fc1328-7d08-4ef4-8e88-7a37cdf9704a"), new DateTime(2021, 5, 9, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7084), "", new Guid("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1") },
                    { new Guid("22ccabb4-7a34-4b73-8449-209e96053614"), new DateTime(2021, 4, 24, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(6037), "", new Guid("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1") },
                    { new Guid("ee60e668-ec2a-428f-bcb2-85d122762065"), new DateTime(2021, 4, 25, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(6117), "", new Guid("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1") },
                    { new Guid("18dc0fcf-68da-40f2-bc38-884acc416bbf"), new DateTime(2021, 4, 26, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(6265), "", new Guid("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1") },
                    { new Guid("524baec8-eec8-4dbc-bc58-422a28762b31"), new DateTime(2021, 4, 27, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(6321), "", new Guid("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1") },
                    { new Guid("23858b7a-93ca-46b1-a365-d1ea99a767b0"), new DateTime(2021, 4, 28, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(6401), "", new Guid("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1") },
                    { new Guid("ff3fd64c-8868-4e58-8429-54b2dababc63"), new DateTime(2021, 4, 29, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(6453), "", new Guid("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1") },
                    { new Guid("c266cb4b-dc36-43a5-ae48-91672b4b08d1"), new DateTime(2021, 4, 30, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(6564), "", new Guid("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1") },
                    { new Guid("488c48ec-d5d9-45ba-9936-7278f3fa7495"), new DateTime(2021, 5, 1, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(6615), "", new Guid("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1") },
                    { new Guid("571c53d6-a327-44c7-a1cb-4e497da82d4e"), new DateTime(2021, 5, 2, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(6661), "", new Guid("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1") },
                    { new Guid("fa0a3139-28df-4bb6-a326-d2d87c0b4032"), new DateTime(2021, 5, 3, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(6711), "", new Guid("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1") },
                    { new Guid("c2f37762-28f4-4278-ab92-169b77b5c901"), new DateTime(2021, 5, 4, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(6805), "", new Guid("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1") },
                    { new Guid("ad81c8f4-55c8-4af6-bded-9caac4c8ab69"), new DateTime(2021, 5, 5, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(6854), "", new Guid("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1") },
                    { new Guid("6d5b647f-67f9-47b9-9b04-50c0776915f4"), new DateTime(2021, 5, 6, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(6905), "", new Guid("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1") },
                    { new Guid("f99012e7-7c57-450a-91b4-a2e1e2f96bab"), new DateTime(2021, 5, 7, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(6952), "", new Guid("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1") },
                    { new Guid("bc810f45-b253-4f01-9149-3235aee96737"), new DateTime(2021, 5, 8, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7037), "", new Guid("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1") },
                    { new Guid("815a01af-80fd-4425-9b6c-345a855bfd05"), new DateTime(2021, 5, 10, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7130), "", new Guid("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1") },
                    { new Guid("8591b9d9-bd70-46c6-93f9-b5c5e86b6814"), new DateTime(2021, 5, 21, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7739), "", new Guid("d5d109a9-ac86-40ef-a783-b7c0b8fefaa1") },
                    { new Guid("97723710-0f33-4f16-8787-72e026e62adc"), new DateTime(2021, 4, 29, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(6456), "", new Guid("d5d109a9-ac86-40ef-a783-b4c0b8fefaa1") },
                    { new Guid("f43b8708-bb10-4a23-ae74-2dc3867d550f"), new DateTime(2021, 5, 1, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(6618), "", new Guid("d5d109a9-ac86-40ef-a783-b4c0b8fefaa1") },
                    { new Guid("8bb40f58-100f-4e09-9b87-a033d830661e"), new DateTime(2021, 5, 21, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7731), "", new Guid("d5d109a9-ac86-40ef-a783-b4c0b8fefaa1") },
                    { new Guid("aabde517-0a6a-4edb-b7bc-ee9f828e3075"), new DateTime(2021, 5, 22, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7778), "", new Guid("d5d109a9-ac86-40ef-a783-b4c0b8fefaa1") },
                    { new Guid("db4f5526-61b5-4e9c-a09d-f95b36a575dc"), new DateTime(2021, 4, 23, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(4016), "", new Guid("d5d109a9-ac86-40ef-a783-b5c0b8fefaa1") },
                    { new Guid("877026c5-c4f7-434f-ad03-f1007df513b1"), new DateTime(2021, 4, 24, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(6054), "", new Guid("d5d109a9-ac86-40ef-a783-b5c0b8fefaa1") },
                    { new Guid("e5049873-2e00-4e62-a8e8-da62d8875822"), new DateTime(2021, 4, 25, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(6123), "", new Guid("d5d109a9-ac86-40ef-a783-b5c0b8fefaa1") },
                    { new Guid("a4eb0754-4dac-42a5-81da-017db7cc0092"), new DateTime(2021, 4, 26, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(6272), "", new Guid("d5d109a9-ac86-40ef-a783-b5c0b8fefaa1") },
                    { new Guid("ad8bf059-027c-435c-a5bc-7a240394d9a3"), new DateTime(2021, 4, 27, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(6327), "", new Guid("d5d109a9-ac86-40ef-a783-b5c0b8fefaa1") },
                    { new Guid("52beae30-8886-482d-aee3-cdc6612d95a9"), new DateTime(2021, 4, 28, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(6407), "", new Guid("d5d109a9-ac86-40ef-a783-b5c0b8fefaa1") },
                    { new Guid("5fc7116b-2c11-44e5-9dca-157df5d9e50c"), new DateTime(2021, 4, 29, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(6459), "", new Guid("d5d109a9-ac86-40ef-a783-b5c0b8fefaa1") },
                    { new Guid("9eb02e8f-568d-47ee-8761-498ec6325865"), new DateTime(2021, 4, 30, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(6571), "", new Guid("d5d109a9-ac86-40ef-a783-b5c0b8fefaa1") },
                    { new Guid("83f18698-cc48-476e-a3dd-b6cb34644847"), new DateTime(2021, 5, 1, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(6621), "", new Guid("d5d109a9-ac86-40ef-a783-b5c0b8fefaa1") },
                    { new Guid("112fae52-8274-4319-bbc8-5b106e73cdd8"), new DateTime(2021, 5, 2, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(6667), "", new Guid("d5d109a9-ac86-40ef-a783-b5c0b8fefaa1") },
                    { new Guid("beb89137-aad4-4a0a-9374-6ec6c4123f19"), new DateTime(2021, 5, 3, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(6716), "", new Guid("d5d109a9-ac86-40ef-a783-b5c0b8fefaa1") },
                    { new Guid("7b4fd270-170a-4156-bd94-7912e42b8d2b"), new DateTime(2021, 5, 4, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(6812), "", new Guid("d5d109a9-ac86-40ef-a783-b5c0b8fefaa1") },
                    { new Guid("d4d0c1c3-80f3-46eb-9f13-cd796baaca93"), new DateTime(2021, 5, 5, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(6860), "", new Guid("d5d109a9-ac86-40ef-a783-b5c0b8fefaa1") },
                    { new Guid("99809988-9452-47b1-99cf-e81e62485dfc"), new DateTime(2021, 5, 20, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7684), "", new Guid("d5d109a9-ac86-40ef-a783-b4c0b8fefaa1") },
                    { new Guid("a9f51d6c-1369-4f4e-888a-73f3137e8463"), new DateTime(2021, 4, 30, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(6568), "", new Guid("d5d109a9-ac86-40ef-a783-b4c0b8fefaa1") },
                    { new Guid("2e632b49-23bc-4bc1-9e40-6ec548548f77"), new DateTime(2021, 5, 19, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7637), "", new Guid("d5d109a9-ac86-40ef-a783-b4c0b8fefaa1") },
                    { new Guid("881e2d81-c550-4179-affe-1751ea7dc76d"), new DateTime(2021, 5, 17, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7515), "", new Guid("d5d109a9-ac86-40ef-a783-b4c0b8fefaa1") },
                    { new Guid("1557561f-4cb1-4b9f-af89-e65f4ee07d81"), new DateTime(2021, 5, 2, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(6664), "", new Guid("d5d109a9-ac86-40ef-a783-b4c0b8fefaa1") },
                    { new Guid("f8139ace-5061-4a98-a8ad-c4da7113cf7a"), new DateTime(2021, 5, 3, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(6714), "", new Guid("d5d109a9-ac86-40ef-a783-b4c0b8fefaa1") },
                    { new Guid("cebd365f-c3f4-4dc1-97f4-fc9f89c25628"), new DateTime(2021, 5, 4, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(6809), "", new Guid("d5d109a9-ac86-40ef-a783-b4c0b8fefaa1") },
                    { new Guid("d082b411-d7ca-4847-a2c2-dc7f2700cc4d"), new DateTime(2021, 5, 5, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(6858), "", new Guid("d5d109a9-ac86-40ef-a783-b4c0b8fefaa1") },
                    { new Guid("6b85a0ba-9a1d-4243-ba59-97b156bd6442"), new DateTime(2021, 5, 6, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(6908), "", new Guid("d5d109a9-ac86-40ef-a783-b4c0b8fefaa1") },
                    { new Guid("79203c28-238f-4da1-8f1d-2ea40bbaac12"), new DateTime(2021, 5, 7, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(6955), "", new Guid("d5d109a9-ac86-40ef-a783-b4c0b8fefaa1") },
                    { new Guid("116b933d-f180-42df-8ccf-23cb585e6ba1"), new DateTime(2021, 5, 8, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7040), "", new Guid("d5d109a9-ac86-40ef-a783-b4c0b8fefaa1") },
                    { new Guid("0ac0bb95-2dac-4eb2-84cd-971a594c1efe"), new DateTime(2021, 5, 9, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7087), "", new Guid("d5d109a9-ac86-40ef-a783-b4c0b8fefaa1") },
                    { new Guid("e75ca4e7-cb9d-4010-b10d-10ac64bbf60d"), new DateTime(2021, 5, 10, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7133), "", new Guid("d5d109a9-ac86-40ef-a783-b4c0b8fefaa1") },
                    { new Guid("ca9e04df-81f1-4a7b-8cec-15437998b3a2"), new DateTime(2021, 5, 11, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7181), "", new Guid("d5d109a9-ac86-40ef-a783-b4c0b8fefaa1") },
                    { new Guid("32db819e-f67d-44a8-9b35-81a889cb6ba0"), new DateTime(2021, 5, 12, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7253), "", new Guid("d5d109a9-ac86-40ef-a783-b4c0b8fefaa1") },
                    { new Guid("8bb9b813-d7b1-4d4d-be11-0840db4fbff6"), new DateTime(2021, 5, 13, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7302), "", new Guid("d5d109a9-ac86-40ef-a783-b4c0b8fefaa1") },
                    { new Guid("5b55cbdd-0d11-436b-aac5-99dca843785b"), new DateTime(2021, 5, 14, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7349), "", new Guid("d5d109a9-ac86-40ef-a783-b4c0b8fefaa1") },
                    { new Guid("977998ad-8881-49ce-bbab-5419cb3e5c4a"), new DateTime(2021, 5, 15, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7419), "", new Guid("d5d109a9-ac86-40ef-a783-b4c0b8fefaa1") },
                    { new Guid("90f76a9e-375a-4279-a4dc-0690c7747be8"), new DateTime(2021, 5, 16, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7467), "", new Guid("d5d109a9-ac86-40ef-a783-b4c0b8fefaa1") },
                    { new Guid("9a685895-efa5-4caf-9479-44587a739dff"), new DateTime(2021, 5, 18, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7562), "", new Guid("d5d109a9-ac86-40ef-a783-b4c0b8fefaa1") },
                    { new Guid("93ecfbab-f4b8-4911-936f-ffc448f3a278"), new DateTime(2021, 5, 22, 3, 23, 13, 797, DateTimeKind.Local).AddTicks(7787), "", new Guid("d5d109a9-ac86-40ef-a783-b7c0b8fefaa1") }
                });

            migrationBuilder.InsertData(
                table: "Group",
                columns: new[] { "Id", "EventId", "MaxPlaces", "Name" },
                values: new object[,]
                {
                    { new Guid("de0e4fa2-c27f-4794-a977-005537b5f8ca"), new Guid("b211ea5f-052c-4c60-9dad-213825944b07"), 120, "Salat Fajr" },
                    { new Guid("91fe2ecc-5c7c-49a5-86e3-ef662850a1f7"), new Guid("6ba240fa-f2ad-490e-9841-8bfcf1b62a98"), 120, "Tarawih group 1" },
                    { new Guid("a2418af7-627f-483a-955c-0e7f93a08172"), new Guid("6ba240fa-f2ad-490e-9841-8bfcf1b62a98"), 120, "Tarawih group 2" },
                    { new Guid("a6bf1e6e-c87a-4f91-9d5f-9fd07ef07254"), new Guid("0f501328-eaf1-4860-8641-48c8fa5a6fea"), 120, "Salat Ishaa" },
                    { new Guid("6a8424e7-e66c-4124-ac71-77832c08ef2d"), new Guid("0f501328-eaf1-4860-8641-48c8fa5a6fea"), 120, "Tarawih group 1" },
                    { new Guid("38f0c91d-c254-482a-af20-5d4bbd48fef2"), new Guid("0f501328-eaf1-4860-8641-48c8fa5a6fea"), 120, "Tarawih group 2" },
                    { new Guid("ef8ae034-49bd-4a5e-a50d-5544fd696e24"), new Guid("0d218931-ddbd-4579-9f5b-d3dc00550654"), 120, "Salat Ishaa" },
                    { new Guid("4c52228c-427d-48e0-a5da-41eadbf925d1"), new Guid("0d218931-ddbd-4579-9f5b-d3dc00550654"), 120, "Tarawih group 1" },
                    { new Guid("31ee8998-e7dd-4312-b76a-d62ed61a8ef8"), new Guid("0d218931-ddbd-4579-9f5b-d3dc00550654"), 120, "Tarawih group 2" },
                    { new Guid("005e3a9c-4e5c-460e-b222-6c2d1227b609"), new Guid("7cfa4d8e-e530-4dfd-8c52-f8704174fb5a"), 120, "Salat Ishaa" },
                    { new Guid("2d2c2b2e-0d72-49c7-bc06-82deccf0f633"), new Guid("7cfa4d8e-e530-4dfd-8c52-f8704174fb5a"), 120, "Tarawih group 1" },
                    { new Guid("af5396b7-8435-46b2-b9cb-fd58bc0a428c"), new Guid("6ba240fa-f2ad-490e-9841-8bfcf1b62a98"), 120, "Salat Ishaa" },
                    { new Guid("c600c418-6458-49fe-8eb9-3fe5bc8b113f"), new Guid("7cfa4d8e-e530-4dfd-8c52-f8704174fb5a"), 120, "Tarawih group 2" },
                    { new Guid("65002e89-a1a6-4f32-ade4-94361cd6b7c8"), new Guid("2635a385-525c-4271-ae21-b6156c06d2df"), 120, "Tarawih group 1" },
                    { new Guid("52028768-5357-4639-ad71-47da5efd7743"), new Guid("2635a385-525c-4271-ae21-b6156c06d2df"), 120, "Tarawih group 2" },
                    { new Guid("e41d1a2e-4d11-4a5f-9deb-76c8a48f36e2"), new Guid("648bf85a-e7db-43ae-a41b-2176ddb3bb8a"), 120, "Salat Ishaa" },
                    { new Guid("f3913127-9845-4827-a22e-38a4c1dd2963"), new Guid("648bf85a-e7db-43ae-a41b-2176ddb3bb8a"), 120, "Tarawih group 1" },
                    { new Guid("9900784a-9e57-4ab5-b3c2-c9167a757edb"), new Guid("648bf85a-e7db-43ae-a41b-2176ddb3bb8a"), 120, "Tarawih group 2" },
                    { new Guid("e6b50b44-c8f4-42f6-a2b3-e9ea9aa2dda4"), new Guid("ceae4395-2671-4bd0-a96b-0c432020b4d4"), 120, "Salat Ishaa" },
                    { new Guid("dbc378c3-cffe-41fe-b821-d4833a0a179f"), new Guid("ceae4395-2671-4bd0-a96b-0c432020b4d4"), 120, "Tarawih group 1" },
                    { new Guid("d86e3d17-afae-413b-bdac-2ecb38570fcf"), new Guid("ceae4395-2671-4bd0-a96b-0c432020b4d4"), 120, "Tarawih group 2" },
                    { new Guid("68d86aa5-be42-4973-bf07-9ace0aabf192"), new Guid("d779da88-82fc-4c7f-b9e7-1c1b8e052613"), 120, "Salat Ishaa" },
                    { new Guid("306d450e-6a18-4da1-aa8c-871031820f05"), new Guid("d779da88-82fc-4c7f-b9e7-1c1b8e052613"), 120, "Tarawih group 1" },
                    { new Guid("1bf5adbe-2d58-47a2-a15d-ac3405267f1c"), new Guid("2635a385-525c-4271-ae21-b6156c06d2df"), 120, "Salat Ishaa" },
                    { new Guid("bf4121d7-c77f-4541-b542-0fb373e33c4e"), new Guid("d779da88-82fc-4c7f-b9e7-1c1b8e052613"), 120, "Tarawih group 2" },
                    { new Guid("47b119b8-5bb9-4606-9d1c-cdf1f9337bc9"), new Guid("4d8d811b-968e-4a56-8c73-5d9c0dc556f8"), 120, "Tarawih group 2" },
                    { new Guid("ccc3a452-8c89-45df-9245-b1fb99338b06"), new Guid("4d8d811b-968e-4a56-8c73-5d9c0dc556f8"), 120, "Salat Ishaa" },
                    { new Guid("55763407-99f4-494d-b668-c38ad31c7d7d"), new Guid("0ba46ae3-58a8-4b26-a86a-47aa7d0a4bb4"), 120, "Salat Maghreb" },
                    { new Guid("afba8ffc-96f6-4416-bd35-266ba5efe13a"), new Guid("89fedf24-c865-4807-858f-9ac8197611fa"), 120, "Salat Maghreb" },
                    { new Guid("8a80ba76-8875-4237-b367-586ce58d4884"), new Guid("46ad0090-3516-4fe5-ae19-5ae5089d29a4"), 120, "Salat Maghreb" },
                    { new Guid("2a37c93b-d372-47f2-ad32-c91197833c6d"), new Guid("0f6b3162-2311-4bb1-890d-b6c0ede098d3"), 120, "Salat Maghreb" },
                    { new Guid("a3ca9745-04f5-4d2c-8810-c6d670cd6b5b"), new Guid("78e7fa4b-1589-4903-8af9-2a7e6133bbc8"), 120, "Salat Maghreb" },
                    { new Guid("1d521eba-0ac1-4035-8217-32f2b6a3e143"), new Guid("28546b44-8893-40a1-9fca-8d8a8b0a6845"), 120, "Salat Maghreb" },
                    { new Guid("fee64cd7-2141-4d3d-a84d-f627f86eb380"), new Guid("a4bf2c11-0670-4753-91ae-72c4f5a16331"), 120, "Salat Maghreb" },
                    { new Guid("003aed16-d125-4243-b566-c60e7ccb4eef"), new Guid("292a7ff1-5622-43bf-b8ca-94a7607f8f79"), 120, "Salat Maghreb" },
                    { new Guid("91679493-d5a2-4460-b4a2-124fd62aa08f"), new Guid("abfbba45-f3f1-452d-b3c0-2bb8d5a243d4"), 120, "Salat Maghreb" },
                    { new Guid("9b2e4558-1633-4af2-8320-e405bea14d4c"), new Guid("2e55809c-3f5b-47e1-a4f5-44c467ec2b71"), 120, "Salat Maghreb" },
                    { new Guid("a80131bc-cdb8-4053-bc14-d99387f48bbe"), new Guid("4d8d811b-968e-4a56-8c73-5d9c0dc556f8"), 120, "Tarawih group 1" },
                    { new Guid("86777204-5768-43bf-9599-c0fd4323188e"), new Guid("6695e4d5-6346-46f2-8b9d-418431bf13e8"), 120, "Salat Maghreb" },
                    { new Guid("5064dd4c-4f53-4422-9fbc-7456931a6336"), new Guid("b95f63a1-a987-4806-be96-05f95d1aa993"), 120, "Salat Maghreb" },
                    { new Guid("cb76a75e-2c3a-43f3-97dd-07b813f5a47a"), new Guid("3ac8a7b4-75f5-418a-8a31-8f1ec5497827"), 120, "Salat Ishaa" },
                    { new Guid("c73a3779-7ab0-4ed8-a432-4f37523f03e8"), new Guid("3ac8a7b4-75f5-418a-8a31-8f1ec5497827"), 120, "Tarawih group 1" },
                    { new Guid("ca1c45d3-9ce2-42bc-809c-626ea5c0e2f9"), new Guid("3ac8a7b4-75f5-418a-8a31-8f1ec5497827"), 120, "Tarawih group 2" },
                    { new Guid("20f5c835-3e6e-4403-b7b5-906dad03c117"), new Guid("54d62a13-c759-44c1-ad63-a16b676250e0"), 120, "Salat Ishaa" },
                    { new Guid("4a7654eb-76ea-49ce-8e70-1c1a0b8847da"), new Guid("54d62a13-c759-44c1-ad63-a16b676250e0"), 120, "Tarawih group 1" },
                    { new Guid("79e7e994-0875-4d98-a4ce-4f1cdad43c37"), new Guid("54d62a13-c759-44c1-ad63-a16b676250e0"), 120, "Tarawih group 2" },
                    { new Guid("d3b0dc7d-ef4d-4c22-bd16-e316b7e546ed"), new Guid("5cfe4409-39f9-49b4-bee8-2b897cd359df"), 120, "Salat Ishaa" },
                    { new Guid("97305b7e-321b-4420-a8fd-ee388f276e77"), new Guid("5cfe4409-39f9-49b4-bee8-2b897cd359df"), 120, "Tarawih group 1" },
                    { new Guid("115025c1-fac0-4637-883f-e51c01fe1ee5"), new Guid("5cfe4409-39f9-49b4-bee8-2b897cd359df"), 120, "Tarawih group 2" },
                    { new Guid("28eda714-c410-4c1f-86fa-225a90c17a8a"), new Guid("4e733c47-28a7-4895-963b-fe426b4b4ac2"), 120, "Salat Maghreb" },
                    { new Guid("9c24d994-8abe-47f0-ac1b-3b368d642ca7"), new Guid("d72937bf-f42b-492e-affb-650c9829b33d"), 120, "Salat Ishaa" },
                    { new Guid("d92cf7f2-4a2a-4a02-92e3-bb55d7bcda4b"), new Guid("d72937bf-f42b-492e-affb-650c9829b33d"), 120, "Tarawih group 1" },
                    { new Guid("2d71f22f-edb7-4a7b-95d3-381cf155c89e"), new Guid("d72937bf-f42b-492e-affb-650c9829b33d"), 120, "Tarawih group 2" },
                    { new Guid("8ca1c6a4-a253-4e80-91be-a41eaf68d771"), new Guid("e5e8abb0-85d8-4c5f-a967-e4204be00251"), 120, "Salat Ishaa" },
                    { new Guid("057a03c6-34b2-4064-bba5-810bbfe28af3"), new Guid("e5e8abb0-85d8-4c5f-a967-e4204be00251"), 120, "Tarawih group 1" },
                    { new Guid("4eef2b50-24e8-4b22-af53-639dd598d70b"), new Guid("e5e8abb0-85d8-4c5f-a967-e4204be00251"), 120, "Tarawih group 2" },
                    { new Guid("3961c217-5c7a-4d83-aa5f-dd5bd2b3606e"), new Guid("3742d9e3-08a8-44a0-a46d-3fc18ea357e4"), 120, "Salat Ishaa" },
                    { new Guid("c67167f2-02bc-476f-80e5-2e31e1ddff88"), new Guid("3742d9e3-08a8-44a0-a46d-3fc18ea357e4"), 120, "Tarawih group 1" },
                    { new Guid("b230619b-d759-4714-9372-3650c7514a81"), new Guid("3742d9e3-08a8-44a0-a46d-3fc18ea357e4"), 120, "Tarawih group 2" },
                    { new Guid("5f3c9d6c-5ec1-463b-a115-ef142665463c"), new Guid("b9f51810-0440-4268-b864-a4d36fe4efde"), 120, "Salat Ishaa" },
                    { new Guid("65b71ad2-8ab1-41cd-a07a-2c78e2d505e1"), new Guid("b9f51810-0440-4268-b864-a4d36fe4efde"), 120, "Tarawih group 1" },
                    { new Guid("fc2f91f7-7790-4065-822d-fcc0de03f094"), new Guid("b9f51810-0440-4268-b864-a4d36fe4efde"), 120, "Tarawih group 2" },
                    { new Guid("a45d86c8-6273-4b30-a85c-50b355f89237"), new Guid("00d4b43a-e8f6-4680-9743-9c1c04a85672"), 120, "Salat Ishaa" },
                    { new Guid("22ad5e0a-3938-4cfd-8fb0-9f51fae1e7cf"), new Guid("72654f1a-6d9e-41b3-8b88-90a1cd9e3a8e"), 120, "Tarawih group 2" },
                    { new Guid("71abacf3-84e1-4129-b134-9b9bb8821419"), new Guid("00d4b43a-e8f6-4680-9743-9c1c04a85672"), 120, "Tarawih group 1" },
                    { new Guid("7331c75c-b656-4df9-a85e-aa2c6d191d77"), new Guid("6de0a8c4-a669-48db-b6e5-cab7a1bcef2a"), 120, "Salat Ishaa" },
                    { new Guid("4be80b65-2bc2-455b-8168-b19cf58c2b4d"), new Guid("6de0a8c4-a669-48db-b6e5-cab7a1bcef2a"), 120, "Tarawih group 1" },
                    { new Guid("15302c50-bfc3-4128-afa3-999dede9855b"), new Guid("6de0a8c4-a669-48db-b6e5-cab7a1bcef2a"), 120, "Tarawih group 2" },
                    { new Guid("fe81d3ab-590e-439b-8ba8-bad2c3375e5e"), new Guid("aac9ecfa-4abd-473c-987e-2a67720754dc"), 120, "Salat Ishaa" },
                    { new Guid("bd4eea23-cbdc-46ed-8496-da9e3dd84433"), new Guid("aac9ecfa-4abd-473c-987e-2a67720754dc"), 120, "Tarawih group 1" },
                    { new Guid("323286d1-a1f7-423d-8e38-0bcbdd5744b9"), new Guid("aac9ecfa-4abd-473c-987e-2a67720754dc"), 120, "Tarawih group 2" },
                    { new Guid("fa34bae9-ce36-401d-81e4-c2bfcb6ecf8c"), new Guid("8591b9d9-bd70-46c6-93f9-b5c5e86b6814"), 120, "Salat Ishaa" },
                    { new Guid("0d5051a9-a798-420c-b9f1-d5f6816afa13"), new Guid("8591b9d9-bd70-46c6-93f9-b5c5e86b6814"), 120, "Tarawih group 1" },
                    { new Guid("4b7e19a6-8e11-4399-895c-b507637079d0"), new Guid("8591b9d9-bd70-46c6-93f9-b5c5e86b6814"), 120, "Tarawih group 2" },
                    { new Guid("849e49eb-1af7-4c16-b3ff-2e59c33304d8"), new Guid("93ecfbab-f4b8-4911-936f-ffc448f3a278"), 120, "Salat Ishaa" },
                    { new Guid("9a7609f0-fad8-488e-a170-f22e00341c20"), new Guid("00d4b43a-e8f6-4680-9743-9c1c04a85672"), 120, "Tarawih group 2" },
                    { new Guid("e6e5f43b-f8b7-4297-9a45-88232686eba9"), new Guid("72654f1a-6d9e-41b3-8b88-90a1cd9e3a8e"), 120, "Tarawih group 1" },
                    { new Guid("2d05267d-9df4-4664-ac00-45aecd9c94a2"), new Guid("72654f1a-6d9e-41b3-8b88-90a1cd9e3a8e"), 120, "Salat Ishaa" },
                    { new Guid("62b50b10-7982-4364-9c14-18106f02c02b"), new Guid("19b855b8-c8b3-4707-bf99-03468c2fd6d3"), 120, "Tarawih group 2" },
                    { new Guid("9713b446-c381-497e-9a39-3c0da02aa276"), new Guid("aefb8c10-9ab7-4af9-84fb-f9fa2a8ae37b"), 120, "Salat Ishaa" },
                    { new Guid("65873d92-64a7-4ee5-a5c1-951a88b92340"), new Guid("aefb8c10-9ab7-4af9-84fb-f9fa2a8ae37b"), 120, "Tarawih group 1" },
                    { new Guid("32ec6305-5532-4b7f-9d2e-73f6ac8018ff"), new Guid("aefb8c10-9ab7-4af9-84fb-f9fa2a8ae37b"), 120, "Tarawih group 2" },
                    { new Guid("3cfd8d49-cf95-48f4-a25a-06f591ea185b"), new Guid("25326c78-21d4-4905-a4c6-51ae7e8f030e"), 120, "Salat Ishaa" },
                    { new Guid("030a5c3a-98ae-4ecc-a160-f7f3813122d3"), new Guid("25326c78-21d4-4905-a4c6-51ae7e8f030e"), 120, "Tarawih group 1" },
                    { new Guid("173de792-0340-4073-a341-34ca6560593b"), new Guid("25326c78-21d4-4905-a4c6-51ae7e8f030e"), 120, "Tarawih group 2" },
                    { new Guid("c55b4542-62ae-4a45-8526-776d6aa20098"), new Guid("692f2d41-b215-437b-a6cd-a62aab57493a"), 120, "Salat Ishaa" },
                    { new Guid("d610feaa-e2f6-48b7-9ec6-7675fae3c2b5"), new Guid("692f2d41-b215-437b-a6cd-a62aab57493a"), 120, "Tarawih group 1" },
                    { new Guid("e1afe8a3-7b26-4538-b13c-fcbdc7e63943"), new Guid("692f2d41-b215-437b-a6cd-a62aab57493a"), 120, "Tarawih group 2" },
                    { new Guid("f0ddaa83-46e0-40b2-ae91-8a4c402a9ac1"), new Guid("05ccf9e3-a868-486f-8211-4edd84464c1d"), 120, "Salat Ishaa" },
                    { new Guid("0022421e-e0f5-4737-9bb4-51b3ed4c72e8"), new Guid("05ccf9e3-a868-486f-8211-4edd84464c1d"), 120, "Tarawih group 1" },
                    { new Guid("a3ffdf58-fe13-457f-ad85-79c8526bafd1"), new Guid("05ccf9e3-a868-486f-8211-4edd84464c1d"), 120, "Tarawih group 2" },
                    { new Guid("8f42d4d9-50a5-4ff5-984a-aeae71e9ba08"), new Guid("e03fb59f-0dcb-4a9c-9a65-35e35c2d94f7"), 120, "Salat Ishaa" },
                    { new Guid("6fd2272b-b08b-40ea-9ee6-af11d027dc54"), new Guid("e03fb59f-0dcb-4a9c-9a65-35e35c2d94f7"), 120, "Tarawih group 1" },
                    { new Guid("90f3d259-0278-4d44-8ef1-1f8201d4aab7"), new Guid("e03fb59f-0dcb-4a9c-9a65-35e35c2d94f7"), 120, "Tarawih group 2" },
                    { new Guid("1cbcac74-a6cb-454b-a958-18ba522c64ff"), new Guid("552c5fec-addc-4018-8fd2-c4ab0acfeb33"), 120, "Salat Ishaa" },
                    { new Guid("c1fe7766-058c-46ef-bcb1-f7703b23871c"), new Guid("552c5fec-addc-4018-8fd2-c4ab0acfeb33"), 120, "Tarawih group 1" },
                    { new Guid("1defe1bc-a4e9-4b89-8552-337614280d83"), new Guid("552c5fec-addc-4018-8fd2-c4ab0acfeb33"), 120, "Tarawih group 2" },
                    { new Guid("a475329b-ab0f-4312-ad62-a663ac745feb"), new Guid("b27365ef-db38-42fa-b3f2-39ad07089a9a"), 120, "Salat Ishaa" },
                    { new Guid("de940088-e5ed-40b4-877d-fe344c65d58d"), new Guid("b27365ef-db38-42fa-b3f2-39ad07089a9a"), 120, "Tarawih group 1" },
                    { new Guid("5ed287c0-a575-4846-8673-18e9239d886c"), new Guid("b27365ef-db38-42fa-b3f2-39ad07089a9a"), 120, "Tarawih group 2" },
                    { new Guid("758858be-0d9d-4cb5-9771-4fe10a89311d"), new Guid("19b855b8-c8b3-4707-bf99-03468c2fd6d3"), 120, "Salat Ishaa" },
                    { new Guid("36c90386-1507-4981-b8d5-d70985021b7a"), new Guid("19b855b8-c8b3-4707-bf99-03468c2fd6d3"), 120, "Tarawih group 1" },
                    { new Guid("d9906020-5090-4d97-b066-a65b1a3204fd"), new Guid("868a8e62-4911-420b-a9e2-37e04a237ba2"), 120, "Salat Maghreb" },
                    { new Guid("773f5bf8-27e0-4518-88cc-a2d0018a57a1"), new Guid("0e296b65-a652-4af0-ac49-ce7015a8b363"), 120, "Salat Maghreb" },
                    { new Guid("f007ff7d-530c-41a8-93c9-034bcd28cc79"), new Guid("d8c3f3a6-caff-4eaa-b43e-ab0562c1c6ec"), 120, "Salat Maghreb" },
                    { new Guid("cd7f0412-af3c-4fd2-a6c8-6cdb6b4c763d"), new Guid("6e9c5aab-1d69-481d-a0d3-1e22588e5520"), 120, "Salat Maghreb" },
                    { new Guid("4db4d75d-5afa-431b-8f71-cd7b2a1efe2e"), new Guid("c3bc3183-c893-4fd1-b942-41ee71fec8cb"), 120, "Salat Fajr" },
                    { new Guid("919deff8-670c-4636-9919-66f9332a5e48"), new Guid("b6b91630-61d8-4d4a-8174-8c332be8a76c"), 120, "Salat Fajr" },
                    { new Guid("620542bb-9cb9-425f-93a6-e2d690bb18c8"), new Guid("1af6340c-71f3-40ab-a3e0-0b963f3a519b"), 120, "Salat Dohr" },
                    { new Guid("6b7ef801-d3ea-4248-9e9c-c91476549506"), new Guid("700fbfa4-1ccc-4b57-8fc8-058d8f76d055"), 120, "Salat Dohr" },
                    { new Guid("b03a010c-996c-4725-8a07-f3339ed136bb"), new Guid("52f16339-053d-4cbf-9fb7-e1b40385fe65"), 120, "Salat Dohr" },
                    { new Guid("99241939-450d-48a0-9d88-2022cb59bb71"), new Guid("8340f449-fa98-4d1a-9e3a-aaf314f458c4"), 120, "Salat Dohr" },
                    { new Guid("f1a607d1-a9a2-42bb-8c9b-6487c08f957e"), new Guid("0292c1ad-6fdd-4829-836b-0beae2ebc96a"), 120, "Salat Dohr" },
                    { new Guid("c7fff309-c2dc-4d8b-a892-de80fecc5e85"), new Guid("e54c5166-8e4f-451d-916f-4d290a8ad3f2"), 120, "Salat Dohr" },
                    { new Guid("05a4c2cf-3291-464d-a2f3-10543ae2d8c0"), new Guid("97723710-0f33-4f16-8787-72e026e62adc"), 120, "Salat Dohr" },
                    { new Guid("0bcaa1c3-a97c-421c-93eb-6f0510fc2ffc"), new Guid("a9f51d6c-1369-4f4e-888a-73f3137e8463"), 120, "Salat Dohr" },
                    { new Guid("caf209fb-a308-4c0e-a35f-6615b6147480"), new Guid("39fc9bc8-ce9b-42c5-ad0e-2d9aabbd22c6"), 120, "Salat Fajr" },
                    { new Guid("609e5e97-37c7-4a33-9572-762b12020fca"), new Guid("f43b8708-bb10-4a23-ae74-2dc3867d550f"), 120, "Salat Dohr" },
                    { new Guid("d654fb7d-acb9-4610-9dbc-e29b365968c9"), new Guid("f8139ace-5061-4a98-a8ad-c4da7113cf7a"), 120, "Salat Dohr" },
                    { new Guid("55430995-4946-4dcb-bc44-4155c4d88599"), new Guid("cebd365f-c3f4-4dc1-97f4-fc9f89c25628"), 120, "Salat Dohr" },
                    { new Guid("eb53d9b7-0170-40f3-bd68-0f8415830d80"), new Guid("d082b411-d7ca-4847-a2c2-dc7f2700cc4d"), 120, "Salat Dohr" },
                    { new Guid("1f0eefbc-dd7d-4905-a970-fb18ae7db702"), new Guid("6b85a0ba-9a1d-4243-ba59-97b156bd6442"), 120, "Salat Dohr" },
                    { new Guid("a1eb8b8b-273e-4682-8cb0-e5227b999061"), new Guid("79203c28-238f-4da1-8f1d-2ea40bbaac12"), 120, "Salat Dohr" },
                    { new Guid("839d3fc4-141d-4dc8-a1d4-5e9e845235ad"), new Guid("116b933d-f180-42df-8ccf-23cb585e6ba1"), 120, "Salat Dohr" },
                    { new Guid("3e87386a-3f72-4ec6-af0b-f9c380f70ecf"), new Guid("0ac0bb95-2dac-4eb2-84cd-971a594c1efe"), 120, "Salat Dohr" },
                    { new Guid("7fed0946-8955-4c12-a85f-75ef24aa25f3"), new Guid("e75ca4e7-cb9d-4010-b10d-10ac64bbf60d"), 120, "Salat Dohr" },
                    { new Guid("e602bebd-b53a-4a86-b364-3ff4763b97b4"), new Guid("ca9e04df-81f1-4a7b-8cec-15437998b3a2"), 120, "Salat Dohr" },
                    { new Guid("6241bd9a-3463-418f-b4c1-1b5a4068bdc9"), new Guid("32db819e-f67d-44a8-9b35-81a889cb6ba0"), 120, "Salat Dohr" },
                    { new Guid("4676f763-b3a3-4add-ba48-45c3985ddace"), new Guid("1557561f-4cb1-4b9f-af89-e65f4ee07d81"), 120, "Salat Dohr" },
                    { new Guid("55594c16-118c-4633-a61f-ac4112251fc5"), new Guid("c3a4ee8d-22d0-4cf2-88f7-18cac590d843"), 120, "Salat Fajr" },
                    { new Guid("c3c74889-2997-4b7d-a4b0-e1b3e550f054"), new Guid("b12a75ef-3359-45ed-91f0-552cdbf2a10a"), 120, "Salat Fajr" },
                    { new Guid("a3cf46c7-34cf-48b3-9a07-b8f88263b091"), new Guid("37a19096-7bce-430e-8b58-15d072869e95"), 120, "Salat Fajr" },
                    { new Guid("78c55586-b8c0-458b-bb4a-2a6b2807c3c4"), new Guid("22ccabb4-7a34-4b73-8449-209e96053614"), 120, "Salat Fajr" },
                    { new Guid("64600d5b-7043-4375-a086-5b87d706b9d2"), new Guid("ee60e668-ec2a-428f-bcb2-85d122762065"), 120, "Salat Fajr" },
                    { new Guid("3d394fc8-6563-44cf-8498-bdbc2a7156d3"), new Guid("18dc0fcf-68da-40f2-bc38-884acc416bbf"), 120, "Salat Fajr" },
                    { new Guid("e8cd42cc-daba-4e7c-ab88-aeacb86c4571"), new Guid("524baec8-eec8-4dbc-bc58-422a28762b31"), 120, "Salat Fajr" },
                    { new Guid("a03d97cb-a2e3-4c51-93d3-191740577a8b"), new Guid("23858b7a-93ca-46b1-a365-d1ea99a767b0"), 120, "Salat Fajr" },
                    { new Guid("71951c03-0e65-4a5f-b55d-b427584321e2"), new Guid("ff3fd64c-8868-4e58-8429-54b2dababc63"), 120, "Salat Fajr" },
                    { new Guid("495c70bb-ab95-44fc-b33d-7eafdf0d8a89"), new Guid("c266cb4b-dc36-43a5-ae48-91672b4b08d1"), 120, "Salat Fajr" },
                    { new Guid("943bd11d-42fd-4a6e-a81f-c771aeaa641c"), new Guid("488c48ec-d5d9-45ba-9936-7278f3fa7495"), 120, "Salat Fajr" },
                    { new Guid("6221f834-8938-43f5-8470-14a1dd6625fc"), new Guid("571c53d6-a327-44c7-a1cb-4e497da82d4e"), 120, "Salat Fajr" },
                    { new Guid("377a7f26-6998-410a-9183-14b397cb3570"), new Guid("fa0a3139-28df-4bb6-a326-d2d87c0b4032"), 120, "Salat Fajr" },
                    { new Guid("e0950b6a-2819-4732-aeb9-cb65c122dd9d"), new Guid("c2f37762-28f4-4278-ab92-169b77b5c901"), 120, "Salat Fajr" },
                    { new Guid("1fada0b3-a7cf-4a9d-9c0a-f87f0921ce31"), new Guid("ad81c8f4-55c8-4af6-bded-9caac4c8ab69"), 120, "Salat Fajr" },
                    { new Guid("741625dc-fe87-44cf-9fc4-c99e50d035e8"), new Guid("6d5b647f-67f9-47b9-9b04-50c0776915f4"), 120, "Salat Fajr" },
                    { new Guid("b61384b1-f1ef-4191-817e-686e675bcc4a"), new Guid("f99012e7-7c57-450a-91b4-a2e1e2f96bab"), 120, "Salat Fajr" },
                    { new Guid("721adaaf-ecd8-4e8f-9283-a4e1875e9d4e"), new Guid("bc810f45-b253-4f01-9149-3235aee96737"), 120, "Salat Fajr" },
                    { new Guid("acb16f80-9a2a-4167-bc64-5b1f010a9008"), new Guid("f4fc1328-7d08-4ef4-8e88-7a37cdf9704a"), 120, "Salat Fajr" },
                    { new Guid("aa77268e-bf73-43cd-8837-5a581a0f9f45"), new Guid("815a01af-80fd-4425-9b6c-345a855bfd05"), 120, "Salat Fajr" },
                    { new Guid("083e0bb3-81aa-46d2-8f74-cb4dcc5a079b"), new Guid("662562aa-3014-4822-b385-3073856c22b3"), 120, "Salat Fajr" },
                    { new Guid("6616526b-c46e-40a4-a93e-1304204a3fd3"), new Guid("a31b533b-2dba-4a33-9e9e-989bd0d6bdc3"), 120, "Salat Fajr" },
                    { new Guid("7954d3c3-7c66-4592-a9dd-c81473a1628c"), new Guid("9b2691dc-544f-410d-8b04-9ebda634b5ce"), 120, "Salat Fajr" },
                    { new Guid("97dfc0f2-5620-4163-b7fb-cef837e618c9"), new Guid("002ab300-622d-41f3-b3cd-82abdf6077b5"), 120, "Salat Fajr" },
                    { new Guid("66e22ed0-2a56-428b-a10e-bf8f5ce7f10f"), new Guid("514caf56-c82e-41d5-8253-aad88b3df926"), 120, "Salat Fajr" },
                    { new Guid("cea5b4fb-5397-45cd-b8b4-9712c50db4e3"), new Guid("07beae5b-35d9-4838-899a-4e444935db76"), 120, "Salat Fajr" },
                    { new Guid("24af456d-5c64-42e4-885e-657c0986c32b"), new Guid("8bb9b813-d7b1-4d4d-be11-0840db4fbff6"), 120, "Salat Dohr" },
                    { new Guid("700f9593-573d-4c6c-82e0-5c1556f78d1c"), new Guid("93ecfbab-f4b8-4911-936f-ffc448f3a278"), 120, "Tarawih group 1" },
                    { new Guid("6fb9a3ca-031d-4e8a-90eb-884898fd335b"), new Guid("5b55cbdd-0d11-436b-aac5-99dca843785b"), 120, "Salat Dohr" },
                    { new Guid("bd7dd697-b4ed-4942-9249-4c4d1e8040c4"), new Guid("90f76a9e-375a-4279-a4dc-0690c7747be8"), 120, "Salat Dohr" },
                    { new Guid("c286fc99-c2ca-46ee-82ad-2fa84baac13b"), new Guid("007a9573-c92c-4854-a6bf-e5317320fa3e"), 120, "Salat Asr" },
                    { new Guid("8d174321-cdcf-41fb-8df6-5e5c4e078f7c"), new Guid("23c8584b-5d4e-4707-9e1a-06a57f770029"), 120, "Salat Asr" },
                    { new Guid("3bfd3cf9-26a9-486d-91c5-5781dcba7209"), new Guid("55ef304c-1d5f-4506-a026-c0166fbed941"), 120, "Salat Asr" },
                    { new Guid("58ce4d2c-fdea-42b5-b59a-11a898398bbf"), new Guid("27f76d6e-644a-48e7-a72a-05d7bc8191af"), 120, "Salat Asr" },
                    { new Guid("685e4aae-3776-4ffb-a654-9c937af33252"), new Guid("ac71eb4c-91fd-4f8f-8068-cec454cc394c"), 120, "Salat Asr" },
                    { new Guid("0bc3a567-b72c-4153-ad8e-5153aebb411a"), new Guid("1cd4940b-1d27-4d5e-a610-26c6348c737a"), 120, "Salat Asr" },
                    { new Guid("97a1b531-b5e3-4e6f-ab71-c320322b5491"), new Guid("4e7f697a-1fd5-49d4-a6a3-7d892cf7ca7b"), 120, "Salat Asr" },
                    { new Guid("b60b87ab-4854-4e1b-a7c4-8bf04dfe848b"), new Guid("05515cc3-d1cd-408a-b330-4ae4c1fc3fec"), 120, "Salat Asr" },
                    { new Guid("ec8ffc03-4cc5-4e78-9815-c5843ae557ee"), new Guid("621030d9-7c7b-4ec0-8eae-c7e9621c3c20"), 120, "Salat Asr" },
                    { new Guid("9c52687d-96b2-4960-91d0-0f734857fc21"), new Guid("24aba7df-df6a-4a6c-bc8e-9fbf40693cb2"), 120, "Salat Maghreb" },
                    { new Guid("d8798c4c-0709-43d0-9b54-620ba1a4a60b"), new Guid("a6b604fd-e402-48b6-be44-67b6c62cb061"), 120, "Salat Asr" },
                    { new Guid("d74444d5-26ec-4986-8b85-e5eafc49ecf0"), new Guid("0b26c235-bf46-43eb-bc0a-10f65fd0c32f"), 120, "Salat Maghreb" },
                    { new Guid("0741288d-e6d2-409f-94da-fff258085e9e"), new Guid("ee1dae24-22c1-4e59-9fd4-16c33a3d3b43"), 120, "Salat Maghreb" },
                    { new Guid("37938ab0-ca46-42d1-9642-57486fede94a"), new Guid("86800288-d18d-4dda-9dad-96031629c095"), 120, "Salat Maghreb" },
                    { new Guid("d6c2ccdf-adbc-4880-9c8d-9007f8be2866"), new Guid("6284538f-b96b-46dc-b097-c1c930baada5"), 120, "Salat Maghreb" },
                    { new Guid("0644e464-a83f-43ed-8480-f685fe2853dc"), new Guid("7e6139d1-58b9-4421-bf9d-6ec1738c1fee"), 120, "Salat Maghreb" },
                    { new Guid("c84bfc09-131d-49e4-998b-28ae36b4c6c5"), new Guid("3ae47eaa-332a-453b-bc2d-bb797e58015d"), 120, "Salat Maghreb" },
                    { new Guid("e7ea4136-086d-4439-938e-2296fa90f690"), new Guid("5d88104c-cb14-4b11-abf4-6625ffea28c9"), 120, "Salat Maghreb" },
                    { new Guid("709c5208-e499-41c8-9518-c7d6d2fa5096"), new Guid("ead078e7-498e-4386-a0e7-ba14ea8f1815"), 120, "Salat Maghreb" },
                    { new Guid("2470eab4-3c3a-4e55-ab6a-d366db4b235d"), new Guid("010f08d7-1241-4594-8310-98b03e2ef291"), 120, "Salat Maghreb" },
                    { new Guid("52948558-d259-46ed-86d5-ccb9fe1fa2f0"), new Guid("2e9e88d0-efa3-4167-9536-fee7a0ccad7d"), 120, "Salat Maghreb" },
                    { new Guid("6f120065-d4c9-4a96-9dde-1e12a536ec74"), new Guid("cdec6270-16a3-4f37-bba2-93c3cf3b887a"), 120, "Salat Maghreb" },
                    { new Guid("ff8bdfcb-3372-44a4-bbf6-8280e073df03"), new Guid("6885fa88-1a99-4b51-840a-a90e415e9a3f"), 120, "Salat Maghreb" },
                    { new Guid("dacfe56f-f744-4400-a34c-0e35bfdf2d2f"), new Guid("63ecbbf5-0b8e-4961-9af0-39f02643a00e"), 120, "Salat Asr" },
                    { new Guid("dc1a0ec9-7952-4e00-81ab-b92daae73ade"), new Guid("d19f3721-2ab8-4363-934d-6e1a84eccb75"), 120, "Salat Asr" },
                    { new Guid("dd91884f-710b-48e8-9558-a0191e1db93e"), new Guid("1044c40d-2062-442a-abcf-b1313a10298e"), 120, "Salat Asr" },
                    { new Guid("a09bd838-db83-4c61-9ff5-6f687de6e7b5"), new Guid("881e2d81-c550-4179-affe-1751ea7dc76d"), 120, "Salat Dohr" },
                    { new Guid("a1ecfc12-53c5-409b-888d-e5dba672b31a"), new Guid("9a685895-efa5-4caf-9479-44587a739dff"), 120, "Salat Dohr" },
                    { new Guid("ec41797e-8582-4fcf-9469-e147a2353180"), new Guid("2e632b49-23bc-4bc1-9e40-6ec548548f77"), 120, "Salat Dohr" },
                    { new Guid("cd99e95e-ddb1-47c8-9bbd-309da2aa01e7"), new Guid("99809988-9452-47b1-99cf-e81e62485dfc"), 120, "Salat Dohr" },
                    { new Guid("0a234ffc-8f64-48c3-9d41-d8ecdc5f7cd6"), new Guid("8bb40f58-100f-4e09-9b87-a033d830661e"), 120, "Salat Dohr" },
                    { new Guid("d3cc7c89-3b41-4257-9609-09de4d115c3a"), new Guid("aabde517-0a6a-4edb-b7bc-ee9f828e3075"), 120, "Salat Dohr" },
                    { new Guid("c9970ff3-73a1-4362-93d2-4f98d33080cf"), new Guid("db4f5526-61b5-4e9c-a09d-f95b36a575dc"), 120, "Salat Asr" },
                    { new Guid("474dce19-c42a-4d10-8d0f-84c243bb7e3c"), new Guid("877026c5-c4f7-434f-ad03-f1007df513b1"), 120, "Salat Asr" },
                    { new Guid("a55a6825-ae6f-4bca-937c-990806604a97"), new Guid("e5049873-2e00-4e62-a8e8-da62d8875822"), 120, "Salat Asr" },
                    { new Guid("120c2e5c-f46e-403e-bd38-5e64ea5f81ad"), new Guid("a4eb0754-4dac-42a5-81da-017db7cc0092"), 120, "Salat Asr" },
                    { new Guid("b36500ac-e30b-4aaf-aaf6-624110da0f08"), new Guid("ad8bf059-027c-435c-a5bc-7a240394d9a3"), 120, "Salat Asr" },
                    { new Guid("eb9ce830-3d0f-4cbd-a9df-d06b968f6bfa"), new Guid("52beae30-8886-482d-aee3-cdc6612d95a9"), 120, "Salat Asr" },
                    { new Guid("49658c56-f57a-4511-bbf1-a7cd4639e216"), new Guid("5fc7116b-2c11-44e5-9dca-157df5d9e50c"), 120, "Salat Asr" },
                    { new Guid("cca65b50-f11d-45a0-a2c5-a58af79d3c7e"), new Guid("9eb02e8f-568d-47ee-8761-498ec6325865"), 120, "Salat Asr" },
                    { new Guid("c6029573-4126-4a4f-ae74-4177f32098f4"), new Guid("83f18698-cc48-476e-a3dd-b6cb34644847"), 120, "Salat Asr" },
                    { new Guid("4f50e2af-8ce8-4c78-b530-52136388c222"), new Guid("112fae52-8274-4319-bbc8-5b106e73cdd8"), 120, "Salat Asr" },
                    { new Guid("4783635a-e338-4e03-baf8-0ce01f240ad7"), new Guid("beb89137-aad4-4a0a-9374-6ec6c4123f19"), 120, "Salat Asr" },
                    { new Guid("c700e0c6-4027-4d71-9b3c-6e7abcb1f76e"), new Guid("7b4fd270-170a-4156-bd94-7912e42b8d2b"), 120, "Salat Asr" },
                    { new Guid("355ef77a-10bd-48ec-9f42-061b515ac656"), new Guid("d4d0c1c3-80f3-46eb-9f13-cd796baaca93"), 120, "Salat Asr" },
                    { new Guid("0297528e-6941-470d-adb7-9ab2d9ee0046"), new Guid("7302aec8-d53e-46d9-9e9b-014234ee5e6b"), 120, "Salat Asr" },
                    { new Guid("12b1c75f-f54c-4bd7-95f7-1e9989262c01"), new Guid("34b556a3-2844-476e-b3cc-8e7784f81a3c"), 120, "Salat Asr" },
                    { new Guid("855190c3-721e-4e9b-9efb-b76d3169ff04"), new Guid("c1715844-de2b-4d82-b785-72772218aebe"), 120, "Salat Asr" },
                    { new Guid("921af52c-e55f-4743-bb02-dad689a017ee"), new Guid("d2587522-fe23-4fc3-9511-18266dcdcc9e"), 120, "Salat Asr" },
                    { new Guid("c694e19f-a803-4775-b657-fba9a1f23e7e"), new Guid("977998ad-8881-49ce-bbab-5419cb3e5c4a"), 120, "Salat Dohr" },
                    { new Guid("2757cae4-03af-4311-bd26-c4162b00edb8"), new Guid("93ecfbab-f4b8-4911-936f-ffc448f3a278"), 120, "Tarawih group 2" }
                });

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

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("0022421e-e0f5-4737-9bb4-51b3ed4c72e8"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("003aed16-d125-4243-b566-c60e7ccb4eef"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("005e3a9c-4e5c-460e-b222-6c2d1227b609"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("0297528e-6941-470d-adb7-9ab2d9ee0046"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("030a5c3a-98ae-4ecc-a160-f7f3813122d3"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("057a03c6-34b2-4064-bba5-810bbfe28af3"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("05a4c2cf-3291-464d-a2f3-10543ae2d8c0"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("0644e464-a83f-43ed-8480-f685fe2853dc"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("0741288d-e6d2-409f-94da-fff258085e9e"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("083e0bb3-81aa-46d2-8f74-cb4dcc5a079b"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("0a234ffc-8f64-48c3-9d41-d8ecdc5f7cd6"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("0bc3a567-b72c-4153-ad8e-5153aebb411a"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("0bcaa1c3-a97c-421c-93eb-6f0510fc2ffc"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("0d5051a9-a798-420c-b9f1-d5f6816afa13"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("115025c1-fac0-4637-883f-e51c01fe1ee5"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("120c2e5c-f46e-403e-bd38-5e64ea5f81ad"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("12b1c75f-f54c-4bd7-95f7-1e9989262c01"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("15302c50-bfc3-4128-afa3-999dede9855b"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("173de792-0340-4073-a341-34ca6560593b"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("1bf5adbe-2d58-47a2-a15d-ac3405267f1c"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("1cbcac74-a6cb-454b-a958-18ba522c64ff"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("1d521eba-0ac1-4035-8217-32f2b6a3e143"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("1defe1bc-a4e9-4b89-8552-337614280d83"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("1f0eefbc-dd7d-4905-a970-fb18ae7db702"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("1fada0b3-a7cf-4a9d-9c0a-f87f0921ce31"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("20f5c835-3e6e-4403-b7b5-906dad03c117"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("22ad5e0a-3938-4cfd-8fb0-9f51fae1e7cf"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("2470eab4-3c3a-4e55-ab6a-d366db4b235d"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("24af456d-5c64-42e4-885e-657c0986c32b"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("2757cae4-03af-4311-bd26-c4162b00edb8"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("28eda714-c410-4c1f-86fa-225a90c17a8a"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("2a37c93b-d372-47f2-ad32-c91197833c6d"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("2d05267d-9df4-4664-ac00-45aecd9c94a2"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("2d2c2b2e-0d72-49c7-bc06-82deccf0f633"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("2d71f22f-edb7-4a7b-95d3-381cf155c89e"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("306d450e-6a18-4da1-aa8c-871031820f05"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("31ee8998-e7dd-4312-b76a-d62ed61a8ef8"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("323286d1-a1f7-423d-8e38-0bcbdd5744b9"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("32ec6305-5532-4b7f-9d2e-73f6ac8018ff"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("355ef77a-10bd-48ec-9f42-061b515ac656"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("36c90386-1507-4981-b8d5-d70985021b7a"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("377a7f26-6998-410a-9183-14b397cb3570"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("37938ab0-ca46-42d1-9642-57486fede94a"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("38f0c91d-c254-482a-af20-5d4bbd48fef2"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("3961c217-5c7a-4d83-aa5f-dd5bd2b3606e"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("3bfd3cf9-26a9-486d-91c5-5781dcba7209"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("3cfd8d49-cf95-48f4-a25a-06f591ea185b"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("3d394fc8-6563-44cf-8498-bdbc2a7156d3"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("3e87386a-3f72-4ec6-af0b-f9c380f70ecf"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("4676f763-b3a3-4add-ba48-45c3985ddace"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("474dce19-c42a-4d10-8d0f-84c243bb7e3c"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("4783635a-e338-4e03-baf8-0ce01f240ad7"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("47b119b8-5bb9-4606-9d1c-cdf1f9337bc9"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("495c70bb-ab95-44fc-b33d-7eafdf0d8a89"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("49658c56-f57a-4511-bbf1-a7cd4639e216"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("4a7654eb-76ea-49ce-8e70-1c1a0b8847da"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("4b7e19a6-8e11-4399-895c-b507637079d0"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("4be80b65-2bc2-455b-8168-b19cf58c2b4d"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("4c52228c-427d-48e0-a5da-41eadbf925d1"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("4db4d75d-5afa-431b-8f71-cd7b2a1efe2e"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("4eef2b50-24e8-4b22-af53-639dd598d70b"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("4f50e2af-8ce8-4c78-b530-52136388c222"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("5064dd4c-4f53-4422-9fbc-7456931a6336"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("52028768-5357-4639-ad71-47da5efd7743"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("52948558-d259-46ed-86d5-ccb9fe1fa2f0"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("55430995-4946-4dcb-bc44-4155c4d88599"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("55594c16-118c-4633-a61f-ac4112251fc5"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("55763407-99f4-494d-b668-c38ad31c7d7d"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("58ce4d2c-fdea-42b5-b59a-11a898398bbf"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("5ed287c0-a575-4846-8673-18e9239d886c"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("5f3c9d6c-5ec1-463b-a115-ef142665463c"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("609e5e97-37c7-4a33-9572-762b12020fca"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("620542bb-9cb9-425f-93a6-e2d690bb18c8"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("6221f834-8938-43f5-8470-14a1dd6625fc"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("6241bd9a-3463-418f-b4c1-1b5a4068bdc9"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("62b50b10-7982-4364-9c14-18106f02c02b"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("64600d5b-7043-4375-a086-5b87d706b9d2"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("65002e89-a1a6-4f32-ade4-94361cd6b7c8"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("65873d92-64a7-4ee5-a5c1-951a88b92340"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("65b71ad2-8ab1-41cd-a07a-2c78e2d505e1"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("6616526b-c46e-40a4-a93e-1304204a3fd3"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("66e22ed0-2a56-428b-a10e-bf8f5ce7f10f"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("685e4aae-3776-4ffb-a654-9c937af33252"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("68d86aa5-be42-4973-bf07-9ace0aabf192"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("6a8424e7-e66c-4124-ac71-77832c08ef2d"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("6b7ef801-d3ea-4248-9e9c-c91476549506"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("6f120065-d4c9-4a96-9dde-1e12a536ec74"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("6fb9a3ca-031d-4e8a-90eb-884898fd335b"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("6fd2272b-b08b-40ea-9ee6-af11d027dc54"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("700f9593-573d-4c6c-82e0-5c1556f78d1c"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("709c5208-e499-41c8-9518-c7d6d2fa5096"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("71951c03-0e65-4a5f-b55d-b427584321e2"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("71abacf3-84e1-4129-b134-9b9bb8821419"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("721adaaf-ecd8-4e8f-9283-a4e1875e9d4e"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("7331c75c-b656-4df9-a85e-aa2c6d191d77"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("741625dc-fe87-44cf-9fc4-c99e50d035e8"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("758858be-0d9d-4cb5-9771-4fe10a89311d"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("773f5bf8-27e0-4518-88cc-a2d0018a57a1"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("78c55586-b8c0-458b-bb4a-2a6b2807c3c4"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("7954d3c3-7c66-4592-a9dd-c81473a1628c"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("79e7e994-0875-4d98-a4ce-4f1cdad43c37"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("7fed0946-8955-4c12-a85f-75ef24aa25f3"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("839d3fc4-141d-4dc8-a1d4-5e9e845235ad"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("849e49eb-1af7-4c16-b3ff-2e59c33304d8"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("855190c3-721e-4e9b-9efb-b76d3169ff04"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("86777204-5768-43bf-9599-c0fd4323188e"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("8a80ba76-8875-4237-b367-586ce58d4884"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("8ca1c6a4-a253-4e80-91be-a41eaf68d771"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("8d174321-cdcf-41fb-8df6-5e5c4e078f7c"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("8f42d4d9-50a5-4ff5-984a-aeae71e9ba08"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("90f3d259-0278-4d44-8ef1-1f8201d4aab7"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("91679493-d5a2-4460-b4a2-124fd62aa08f"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("919deff8-670c-4636-9919-66f9332a5e48"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("91fe2ecc-5c7c-49a5-86e3-ef662850a1f7"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("921af52c-e55f-4743-bb02-dad689a017ee"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("943bd11d-42fd-4a6e-a81f-c771aeaa641c"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("9713b446-c381-497e-9a39-3c0da02aa276"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("97305b7e-321b-4420-a8fd-ee388f276e77"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("97a1b531-b5e3-4e6f-ab71-c320322b5491"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("97dfc0f2-5620-4163-b7fb-cef837e618c9"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("9900784a-9e57-4ab5-b3c2-c9167a757edb"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("99241939-450d-48a0-9d88-2022cb59bb71"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("9a7609f0-fad8-488e-a170-f22e00341c20"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("9b2e4558-1633-4af2-8320-e405bea14d4c"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("9c24d994-8abe-47f0-ac1b-3b368d642ca7"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("9c52687d-96b2-4960-91d0-0f734857fc21"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("a03d97cb-a2e3-4c51-93d3-191740577a8b"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("a09bd838-db83-4c61-9ff5-6f687de6e7b5"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("a1eb8b8b-273e-4682-8cb0-e5227b999061"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("a1ecfc12-53c5-409b-888d-e5dba672b31a"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("a2418af7-627f-483a-955c-0e7f93a08172"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("a3ca9745-04f5-4d2c-8810-c6d670cd6b5b"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("a3cf46c7-34cf-48b3-9a07-b8f88263b091"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("a3ffdf58-fe13-457f-ad85-79c8526bafd1"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("a45d86c8-6273-4b30-a85c-50b355f89237"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("a475329b-ab0f-4312-ad62-a663ac745feb"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("a55a6825-ae6f-4bca-937c-990806604a97"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("a6bf1e6e-c87a-4f91-9d5f-9fd07ef07254"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("a80131bc-cdb8-4053-bc14-d99387f48bbe"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("aa77268e-bf73-43cd-8837-5a581a0f9f45"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("acb16f80-9a2a-4167-bc64-5b1f010a9008"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("af5396b7-8435-46b2-b9cb-fd58bc0a428c"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("afba8ffc-96f6-4416-bd35-266ba5efe13a"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("b03a010c-996c-4725-8a07-f3339ed136bb"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("b230619b-d759-4714-9372-3650c7514a81"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("b36500ac-e30b-4aaf-aaf6-624110da0f08"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("b60b87ab-4854-4e1b-a7c4-8bf04dfe848b"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("b61384b1-f1ef-4191-817e-686e675bcc4a"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("bd4eea23-cbdc-46ed-8496-da9e3dd84433"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("bd7dd697-b4ed-4942-9249-4c4d1e8040c4"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("bf4121d7-c77f-4541-b542-0fb373e33c4e"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("c1fe7766-058c-46ef-bcb1-f7703b23871c"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("c286fc99-c2ca-46ee-82ad-2fa84baac13b"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("c3c74889-2997-4b7d-a4b0-e1b3e550f054"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("c55b4542-62ae-4a45-8526-776d6aa20098"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("c600c418-6458-49fe-8eb9-3fe5bc8b113f"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("c6029573-4126-4a4f-ae74-4177f32098f4"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("c67167f2-02bc-476f-80e5-2e31e1ddff88"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("c694e19f-a803-4775-b657-fba9a1f23e7e"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("c700e0c6-4027-4d71-9b3c-6e7abcb1f76e"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("c73a3779-7ab0-4ed8-a432-4f37523f03e8"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("c7fff309-c2dc-4d8b-a892-de80fecc5e85"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("c84bfc09-131d-49e4-998b-28ae36b4c6c5"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("c9970ff3-73a1-4362-93d2-4f98d33080cf"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("ca1c45d3-9ce2-42bc-809c-626ea5c0e2f9"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("caf209fb-a308-4c0e-a35f-6615b6147480"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("cb76a75e-2c3a-43f3-97dd-07b813f5a47a"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("cca65b50-f11d-45a0-a2c5-a58af79d3c7e"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("ccc3a452-8c89-45df-9245-b1fb99338b06"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("cd7f0412-af3c-4fd2-a6c8-6cdb6b4c763d"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("cd99e95e-ddb1-47c8-9bbd-309da2aa01e7"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("cea5b4fb-5397-45cd-b8b4-9712c50db4e3"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("d3b0dc7d-ef4d-4c22-bd16-e316b7e546ed"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("d3cc7c89-3b41-4257-9609-09de4d115c3a"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("d610feaa-e2f6-48b7-9ec6-7675fae3c2b5"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("d654fb7d-acb9-4610-9dbc-e29b365968c9"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("d6c2ccdf-adbc-4880-9c8d-9007f8be2866"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("d74444d5-26ec-4986-8b85-e5eafc49ecf0"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("d86e3d17-afae-413b-bdac-2ecb38570fcf"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("d8798c4c-0709-43d0-9b54-620ba1a4a60b"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("d92cf7f2-4a2a-4a02-92e3-bb55d7bcda4b"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("d9906020-5090-4d97-b066-a65b1a3204fd"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("dacfe56f-f744-4400-a34c-0e35bfdf2d2f"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("dbc378c3-cffe-41fe-b821-d4833a0a179f"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("dc1a0ec9-7952-4e00-81ab-b92daae73ade"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("dd91884f-710b-48e8-9558-a0191e1db93e"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("de0e4fa2-c27f-4794-a977-005537b5f8ca"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("de940088-e5ed-40b4-877d-fe344c65d58d"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("e0950b6a-2819-4732-aeb9-cb65c122dd9d"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("e1afe8a3-7b26-4538-b13c-fcbdc7e63943"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("e41d1a2e-4d11-4a5f-9deb-76c8a48f36e2"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("e602bebd-b53a-4a86-b364-3ff4763b97b4"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("e6b50b44-c8f4-42f6-a2b3-e9ea9aa2dda4"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("e6e5f43b-f8b7-4297-9a45-88232686eba9"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("e7ea4136-086d-4439-938e-2296fa90f690"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("e8cd42cc-daba-4e7c-ab88-aeacb86c4571"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("eb53d9b7-0170-40f3-bd68-0f8415830d80"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("eb9ce830-3d0f-4cbd-a9df-d06b968f6bfa"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("ec41797e-8582-4fcf-9469-e147a2353180"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("ec8ffc03-4cc5-4e78-9815-c5843ae557ee"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("ef8ae034-49bd-4a5e-a50d-5544fd696e24"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("f007ff7d-530c-41a8-93c9-034bcd28cc79"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("f0ddaa83-46e0-40b2-ae91-8a4c402a9ac1"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("f1a607d1-a9a2-42bb-8c9b-6487c08f957e"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("f3913127-9845-4827-a22e-38a4c1dd2963"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("fa34bae9-ce36-401d-81e4-c2bfcb6ecf8c"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("fc2f91f7-7790-4065-822d-fcc0de03f094"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("fe81d3ab-590e-439b-8ba8-bad2c3375e5e"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("fee64cd7-2141-4d3d-a84d-f627f86eb380"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("ff8bdfcb-3372-44a4-bbf6-8280e073df03"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("002ab300-622d-41f3-b3cd-82abdf6077b5"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("007a9573-c92c-4854-a6bf-e5317320fa3e"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("00d4b43a-e8f6-4680-9743-9c1c04a85672"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("010f08d7-1241-4594-8310-98b03e2ef291"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("0292c1ad-6fdd-4829-836b-0beae2ebc96a"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("05515cc3-d1cd-408a-b330-4ae4c1fc3fec"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("05ccf9e3-a868-486f-8211-4edd84464c1d"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("07beae5b-35d9-4838-899a-4e444935db76"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("0ac0bb95-2dac-4eb2-84cd-971a594c1efe"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("0b26c235-bf46-43eb-bc0a-10f65fd0c32f"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("0ba46ae3-58a8-4b26-a86a-47aa7d0a4bb4"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("0d218931-ddbd-4579-9f5b-d3dc00550654"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("0e296b65-a652-4af0-ac49-ce7015a8b363"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("0f501328-eaf1-4860-8641-48c8fa5a6fea"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("0f6b3162-2311-4bb1-890d-b6c0ede098d3"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("1044c40d-2062-442a-abcf-b1313a10298e"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("112fae52-8274-4319-bbc8-5b106e73cdd8"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("116b933d-f180-42df-8ccf-23cb585e6ba1"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("1557561f-4cb1-4b9f-af89-e65f4ee07d81"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("18dc0fcf-68da-40f2-bc38-884acc416bbf"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("19b855b8-c8b3-4707-bf99-03468c2fd6d3"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("1af6340c-71f3-40ab-a3e0-0b963f3a519b"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("1cd4940b-1d27-4d5e-a610-26c6348c737a"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("22ccabb4-7a34-4b73-8449-209e96053614"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("23858b7a-93ca-46b1-a365-d1ea99a767b0"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("23c8584b-5d4e-4707-9e1a-06a57f770029"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("24aba7df-df6a-4a6c-bc8e-9fbf40693cb2"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("25326c78-21d4-4905-a4c6-51ae7e8f030e"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("2635a385-525c-4271-ae21-b6156c06d2df"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("27f76d6e-644a-48e7-a72a-05d7bc8191af"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("28546b44-8893-40a1-9fca-8d8a8b0a6845"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("292a7ff1-5622-43bf-b8ca-94a7607f8f79"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("2e55809c-3f5b-47e1-a4f5-44c467ec2b71"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("2e632b49-23bc-4bc1-9e40-6ec548548f77"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("2e9e88d0-efa3-4167-9536-fee7a0ccad7d"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("32db819e-f67d-44a8-9b35-81a889cb6ba0"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("34b556a3-2844-476e-b3cc-8e7784f81a3c"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("3742d9e3-08a8-44a0-a46d-3fc18ea357e4"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("37a19096-7bce-430e-8b58-15d072869e95"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("39fc9bc8-ce9b-42c5-ad0e-2d9aabbd22c6"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("3ac8a7b4-75f5-418a-8a31-8f1ec5497827"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("3ae47eaa-332a-453b-bc2d-bb797e58015d"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("46ad0090-3516-4fe5-ae19-5ae5089d29a4"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("488c48ec-d5d9-45ba-9936-7278f3fa7495"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("4d8d811b-968e-4a56-8c73-5d9c0dc556f8"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("4e733c47-28a7-4895-963b-fe426b4b4ac2"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("4e7f697a-1fd5-49d4-a6a3-7d892cf7ca7b"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("514caf56-c82e-41d5-8253-aad88b3df926"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("524baec8-eec8-4dbc-bc58-422a28762b31"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("52beae30-8886-482d-aee3-cdc6612d95a9"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("52f16339-053d-4cbf-9fb7-e1b40385fe65"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("54d62a13-c759-44c1-ad63-a16b676250e0"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("552c5fec-addc-4018-8fd2-c4ab0acfeb33"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("55ef304c-1d5f-4506-a026-c0166fbed941"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("571c53d6-a327-44c7-a1cb-4e497da82d4e"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("5b55cbdd-0d11-436b-aac5-99dca843785b"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("5cfe4409-39f9-49b4-bee8-2b897cd359df"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("5d88104c-cb14-4b11-abf4-6625ffea28c9"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("5fc7116b-2c11-44e5-9dca-157df5d9e50c"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("621030d9-7c7b-4ec0-8eae-c7e9621c3c20"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("6284538f-b96b-46dc-b097-c1c930baada5"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("63ecbbf5-0b8e-4961-9af0-39f02643a00e"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("648bf85a-e7db-43ae-a41b-2176ddb3bb8a"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("662562aa-3014-4822-b385-3073856c22b3"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("6695e4d5-6346-46f2-8b9d-418431bf13e8"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("6885fa88-1a99-4b51-840a-a90e415e9a3f"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("692f2d41-b215-437b-a6cd-a62aab57493a"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("6b85a0ba-9a1d-4243-ba59-97b156bd6442"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("6ba240fa-f2ad-490e-9841-8bfcf1b62a98"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("6d5b647f-67f9-47b9-9b04-50c0776915f4"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("6de0a8c4-a669-48db-b6e5-cab7a1bcef2a"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("6e9c5aab-1d69-481d-a0d3-1e22588e5520"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("700fbfa4-1ccc-4b57-8fc8-058d8f76d055"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("72654f1a-6d9e-41b3-8b88-90a1cd9e3a8e"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("7302aec8-d53e-46d9-9e9b-014234ee5e6b"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("78e7fa4b-1589-4903-8af9-2a7e6133bbc8"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("79203c28-238f-4da1-8f1d-2ea40bbaac12"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("7b4fd270-170a-4156-bd94-7912e42b8d2b"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("7cfa4d8e-e530-4dfd-8c52-f8704174fb5a"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("7e6139d1-58b9-4421-bf9d-6ec1738c1fee"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("815a01af-80fd-4425-9b6c-345a855bfd05"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("8340f449-fa98-4d1a-9e3a-aaf314f458c4"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("83f18698-cc48-476e-a3dd-b6cb34644847"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("8591b9d9-bd70-46c6-93f9-b5c5e86b6814"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("86800288-d18d-4dda-9dad-96031629c095"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("868a8e62-4911-420b-a9e2-37e04a237ba2"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("877026c5-c4f7-434f-ad03-f1007df513b1"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("881e2d81-c550-4179-affe-1751ea7dc76d"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("89fedf24-c865-4807-858f-9ac8197611fa"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("8bb40f58-100f-4e09-9b87-a033d830661e"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("8bb9b813-d7b1-4d4d-be11-0840db4fbff6"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("90f76a9e-375a-4279-a4dc-0690c7747be8"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("93ecfbab-f4b8-4911-936f-ffc448f3a278"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("97723710-0f33-4f16-8787-72e026e62adc"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("977998ad-8881-49ce-bbab-5419cb3e5c4a"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("99809988-9452-47b1-99cf-e81e62485dfc"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("9a685895-efa5-4caf-9479-44587a739dff"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("9b2691dc-544f-410d-8b04-9ebda634b5ce"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("9eb02e8f-568d-47ee-8761-498ec6325865"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("a31b533b-2dba-4a33-9e9e-989bd0d6bdc3"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("a4bf2c11-0670-4753-91ae-72c4f5a16331"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("a4eb0754-4dac-42a5-81da-017db7cc0092"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("a6b604fd-e402-48b6-be44-67b6c62cb061"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("a9f51d6c-1369-4f4e-888a-73f3137e8463"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("aabde517-0a6a-4edb-b7bc-ee9f828e3075"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("aac9ecfa-4abd-473c-987e-2a67720754dc"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("abfbba45-f3f1-452d-b3c0-2bb8d5a243d4"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("ac71eb4c-91fd-4f8f-8068-cec454cc394c"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("ad81c8f4-55c8-4af6-bded-9caac4c8ab69"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("ad8bf059-027c-435c-a5bc-7a240394d9a3"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("aefb8c10-9ab7-4af9-84fb-f9fa2a8ae37b"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("b12a75ef-3359-45ed-91f0-552cdbf2a10a"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("b211ea5f-052c-4c60-9dad-213825944b07"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("b27365ef-db38-42fa-b3f2-39ad07089a9a"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("b6b91630-61d8-4d4a-8174-8c332be8a76c"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("b95f63a1-a987-4806-be96-05f95d1aa993"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("b9f51810-0440-4268-b864-a4d36fe4efde"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("bc810f45-b253-4f01-9149-3235aee96737"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("beb89137-aad4-4a0a-9374-6ec6c4123f19"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("c1715844-de2b-4d82-b785-72772218aebe"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("c266cb4b-dc36-43a5-ae48-91672b4b08d1"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("c2f37762-28f4-4278-ab92-169b77b5c901"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("c3a4ee8d-22d0-4cf2-88f7-18cac590d843"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("c3bc3183-c893-4fd1-b942-41ee71fec8cb"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("ca9e04df-81f1-4a7b-8cec-15437998b3a2"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("cdec6270-16a3-4f37-bba2-93c3cf3b887a"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("ceae4395-2671-4bd0-a96b-0c432020b4d4"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("cebd365f-c3f4-4dc1-97f4-fc9f89c25628"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("d082b411-d7ca-4847-a2c2-dc7f2700cc4d"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("d19f3721-2ab8-4363-934d-6e1a84eccb75"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("d2587522-fe23-4fc3-9511-18266dcdcc9e"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("d4d0c1c3-80f3-46eb-9f13-cd796baaca93"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("d72937bf-f42b-492e-affb-650c9829b33d"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("d779da88-82fc-4c7f-b9e7-1c1b8e052613"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("d8c3f3a6-caff-4eaa-b43e-ab0562c1c6ec"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("db4f5526-61b5-4e9c-a09d-f95b36a575dc"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("e03fb59f-0dcb-4a9c-9a65-35e35c2d94f7"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("e5049873-2e00-4e62-a8e8-da62d8875822"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("e54c5166-8e4f-451d-916f-4d290a8ad3f2"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("e5e8abb0-85d8-4c5f-a967-e4204be00251"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("e75ca4e7-cb9d-4010-b10d-10ac64bbf60d"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("ead078e7-498e-4386-a0e7-ba14ea8f1815"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("ee1dae24-22c1-4e59-9fd4-16c33a3d3b43"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("ee60e668-ec2a-428f-bcb2-85d122762065"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("f43b8708-bb10-4a23-ae74-2dc3867d550f"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("f4fc1328-7d08-4ef4-8e88-7a37cdf9704a"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("f8139ace-5061-4a98-a8ad-c4da7113cf7a"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("f99012e7-7c57-450a-91b4-a2e1e2f96bab"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("fa0a3139-28df-4bb6-a326-d2d87c0b4032"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("ff3fd64c-8868-4e58-8429-54b2dababc63"));

            migrationBuilder.DeleteData(
                table: "EventType",
                keyColumn: "Id",
                keyValue: new Guid("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1"));

            migrationBuilder.DeleteData(
                table: "EventType",
                keyColumn: "Id",
                keyValue: new Guid("d5d109a9-ac86-40ef-a783-b4c0b8fefaa1"));

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

            migrationBuilder.DeleteData(
                table: "Mosque",
                keyColumn: "Id",
                keyValue: new Guid("1a82c06a-4986-4ed3-b1dd-05271b4931d8"));

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

            migrationBuilder.AddColumn<Guid>(
                name: "MosqueId",
                table: "Event",
                type: "char(36)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Appointment",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_Event_MosqueId",
                table: "Event",
                column: "MosqueId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointment_Date",
                table: "Appointment",
                column: "Date",
                unique: true);

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
