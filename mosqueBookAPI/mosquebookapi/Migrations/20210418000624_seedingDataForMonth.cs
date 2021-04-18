using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace mosquebookapi.Migrations
{
    public partial class seedingDataForMonth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                keyValue: new Guid("4a113557-d989-4243-af30-4d6906ce02de"));

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
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("cf35efea-96a1-4f3a-943d-ae8389fb7337"));

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
                keyValue: new Guid("802e14d4-7c79-4740-aefc-6bf5b412129c"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("c23ed31c-5ddc-4993-8b39-7665f43b7fd9"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("ee48fa11-be9a-4885-a244-98a0aedfbea5"));

            migrationBuilder.InsertData(
                table: "Event",
                columns: new[] { "Id", "Date", "Description", "EventTypeId" },
                values: new object[,]
                {
                    { new Guid("c5975b5a-02bd-49e2-acbc-80ab2220f621"), new DateTime(2021, 4, 19, 0, 6, 23, 621, DateTimeKind.Local).AddTicks(230), "", new Guid("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1") },
                    { new Guid("df43fd65-0fe1-4830-a90a-12e981b4881d"), new DateTime(2021, 5, 8, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(632), "", new Guid("d5d109a9-ac86-40ef-a783-b4c0b8fefaa1") },
                    { new Guid("b8f6e4d5-ba83-453d-b0e2-e1e2f7e335cc"), new DateTime(2021, 5, 8, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(633), "", new Guid("d5d109a9-ac86-40ef-a783-b5c0b8fefaa1") },
                    { new Guid("1c05bba3-ed58-4f2c-b41c-03872fe2db86"), new DateTime(2021, 5, 8, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(635), "", new Guid("d5d109a9-ac86-40ef-a783-b6c0b8fefaa1") },
                    { new Guid("ae775912-0927-4e4d-83fe-a2497c775873"), new DateTime(2021, 5, 8, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(638), "", new Guid("d5d109a9-ac86-40ef-a783-b7c0b8fefaa1") },
                    { new Guid("3500cf7a-e76c-437d-8ec7-f094a94c5e0f"), new DateTime(2021, 5, 9, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(679), "", new Guid("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1") },
                    { new Guid("23ff0cbc-891b-4faf-a8f2-e93ee119cb91"), new DateTime(2021, 5, 9, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(681), "", new Guid("d5d109a9-ac86-40ef-a783-b4c0b8fefaa1") },
                    { new Guid("1a649a43-bc16-4721-b291-4347df54aa49"), new DateTime(2021, 5, 9, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(682), "", new Guid("d5d109a9-ac86-40ef-a783-b5c0b8fefaa1") },
                    { new Guid("d10ec7be-0456-4ff2-97d3-37a02793d2b1"), new DateTime(2021, 5, 9, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(684), "", new Guid("d5d109a9-ac86-40ef-a783-b6c0b8fefaa1") },
                    { new Guid("fbbd0bd8-584e-4660-a47f-f8d90719fe7f"), new DateTime(2021, 5, 9, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(685), "", new Guid("d5d109a9-ac86-40ef-a783-b7c0b8fefaa1") },
                    { new Guid("34092974-73a3-4fc9-b1b4-2cf7e2ef5408"), new DateTime(2021, 5, 10, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(724), "", new Guid("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1") },
                    { new Guid("f208cfa2-7185-44a0-b6d0-dbfb15ad3075"), new DateTime(2021, 5, 10, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(726), "", new Guid("d5d109a9-ac86-40ef-a783-b4c0b8fefaa1") },
                    { new Guid("0cb52daf-1e53-429c-b010-aa22f45e389d"), new DateTime(2021, 5, 10, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(728), "", new Guid("d5d109a9-ac86-40ef-a783-b5c0b8fefaa1") },
                    { new Guid("96b0db43-1cd1-4980-9038-0adf1fce8df9"), new DateTime(2021, 5, 10, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(729), "", new Guid("d5d109a9-ac86-40ef-a783-b6c0b8fefaa1") },
                    { new Guid("4bafd0b1-3022-48e3-bfd8-f3c629215cf6"), new DateTime(2021, 5, 10, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(732), "", new Guid("d5d109a9-ac86-40ef-a783-b7c0b8fefaa1") },
                    { new Guid("3c0619bf-7500-4e5f-bf4c-138e00f19674"), new DateTime(2021, 5, 11, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(771), "", new Guid("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1") },
                    { new Guid("d959ea3a-33c5-49f0-814f-221a55014606"), new DateTime(2021, 5, 8, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(630), "", new Guid("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1") },
                    { new Guid("3786db35-4b3a-4be8-8a1d-109b7337c609"), new DateTime(2021, 5, 11, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(773), "", new Guid("d5d109a9-ac86-40ef-a783-b4c0b8fefaa1") },
                    { new Guid("e0d2d220-5b0b-4428-8d3b-cdf4e6e8a050"), new DateTime(2021, 5, 7, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(566), "", new Guid("d5d109a9-ac86-40ef-a783-b7c0b8fefaa1") },
                    { new Guid("1f77ddb3-2341-4dc5-aecd-4780c3961b6f"), new DateTime(2021, 5, 7, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(563), "", new Guid("d5d109a9-ac86-40ef-a783-b5c0b8fefaa1") },
                    { new Guid("a7f0cfab-f1e2-4c06-ae4c-69d326a9e7b7"), new DateTime(2021, 5, 4, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(401), "", new Guid("d5d109a9-ac86-40ef-a783-b5c0b8fefaa1") },
                    { new Guid("51491cac-e7c8-4926-9c24-a90bd1b74cff"), new DateTime(2021, 5, 4, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(402), "", new Guid("d5d109a9-ac86-40ef-a783-b6c0b8fefaa1") },
                    { new Guid("4ed32862-e448-4d01-bc4c-976957059aef"), new DateTime(2021, 5, 4, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(405), "", new Guid("d5d109a9-ac86-40ef-a783-b7c0b8fefaa1") },
                    { new Guid("90f36610-46fc-4eb1-8060-55e743d7330d"), new DateTime(2021, 5, 5, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(468), "", new Guid("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1") },
                    { new Guid("4091b872-9ffc-4589-8420-376fdf303d93"), new DateTime(2021, 5, 5, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(470), "", new Guid("d5d109a9-ac86-40ef-a783-b4c0b8fefaa1") },
                    { new Guid("f02831fb-ab03-459e-89d7-b48aa245eeb9"), new DateTime(2021, 5, 5, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(472), "", new Guid("d5d109a9-ac86-40ef-a783-b5c0b8fefaa1") },
                    { new Guid("1916b7ad-e782-469d-aacf-ec0678000da3"), new DateTime(2021, 5, 5, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(473), "", new Guid("d5d109a9-ac86-40ef-a783-b6c0b8fefaa1") },
                    { new Guid("b667a254-17d0-4cba-ae64-d80dbf66e823"), new DateTime(2021, 5, 5, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(474), "", new Guid("d5d109a9-ac86-40ef-a783-b7c0b8fefaa1") },
                    { new Guid("de6381e6-2a31-48b0-8dce-fbc1aa4de0ad"), new DateTime(2021, 5, 6, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(514), "", new Guid("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1") },
                    { new Guid("e6fcf2bf-2ad0-48d9-af8a-7955e9591aee"), new DateTime(2021, 5, 6, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(515), "", new Guid("d5d109a9-ac86-40ef-a783-b4c0b8fefaa1") },
                    { new Guid("ef8b6c51-e6d1-49d8-87c8-969f66b37eda"), new DateTime(2021, 5, 6, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(517), "", new Guid("d5d109a9-ac86-40ef-a783-b5c0b8fefaa1") },
                    { new Guid("d7c13f36-a59a-4877-a809-5bbe20f164b1"), new DateTime(2021, 5, 6, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(518), "", new Guid("d5d109a9-ac86-40ef-a783-b6c0b8fefaa1") },
                    { new Guid("78d16281-195a-4b84-bb3d-1ea15b01321e"), new DateTime(2021, 5, 6, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(521), "", new Guid("d5d109a9-ac86-40ef-a783-b7c0b8fefaa1") },
                    { new Guid("29938e42-2c4e-4c00-8e8a-16aa01fe7c88"), new DateTime(2021, 5, 7, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(560), "", new Guid("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1") },
                    { new Guid("959a3ecd-3834-40bb-8936-b94da0852314"), new DateTime(2021, 5, 7, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(562), "", new Guid("d5d109a9-ac86-40ef-a783-b4c0b8fefaa1") },
                    { new Guid("2bc8bc63-209c-421b-81d5-535e2c0d19cf"), new DateTime(2021, 5, 7, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(565), "", new Guid("d5d109a9-ac86-40ef-a783-b6c0b8fefaa1") },
                    { new Guid("cb99a928-41e3-436d-8d85-e2fa1bda08fa"), new DateTime(2021, 5, 4, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(400), "", new Guid("d5d109a9-ac86-40ef-a783-b4c0b8fefaa1") },
                    { new Guid("588e0f53-f5d9-4116-a80d-f28099731e3f"), new DateTime(2021, 5, 11, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(775), "", new Guid("d5d109a9-ac86-40ef-a783-b5c0b8fefaa1") },
                    { new Guid("6e28b4eb-5ff6-490d-9511-c133b2f8a5e9"), new DateTime(2021, 5, 11, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(777), "", new Guid("d5d109a9-ac86-40ef-a783-b7c0b8fefaa1") },
                    { new Guid("4e05d1f5-ee71-4e6d-b36e-d769a0cbd182"), new DateTime(2021, 5, 15, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(985), "", new Guid("d5d109a9-ac86-40ef-a783-b7c0b8fefaa1") },
                    { new Guid("c3ea650f-afe6-4090-bd1a-508a35e502e2"), new DateTime(2021, 5, 16, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(1050), "", new Guid("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1") },
                    { new Guid("098989db-0143-4462-b703-302602ae7da5"), new DateTime(2021, 5, 16, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(1052), "", new Guid("d5d109a9-ac86-40ef-a783-b4c0b8fefaa1") },
                    { new Guid("6ec7d47b-bf47-4229-a0f6-2547207d860c"), new DateTime(2021, 5, 16, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(1053), "", new Guid("d5d109a9-ac86-40ef-a783-b5c0b8fefaa1") },
                    { new Guid("1c02e3b9-efe2-4d99-a177-826fddff50bf"), new DateTime(2021, 5, 16, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(1055), "", new Guid("d5d109a9-ac86-40ef-a783-b6c0b8fefaa1") },
                    { new Guid("e5208ae9-8c72-4a46-a8fb-ae91be93eb96"), new DateTime(2021, 5, 16, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(1058), "", new Guid("d5d109a9-ac86-40ef-a783-b7c0b8fefaa1") },
                    { new Guid("94569c07-1269-448b-ac8a-9d19bd75cbf4"), new DateTime(2021, 5, 17, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(1096), "", new Guid("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1") },
                    { new Guid("7d576624-a377-490d-8cf1-4fe59a195032"), new DateTime(2021, 5, 17, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(1098), "", new Guid("d5d109a9-ac86-40ef-a783-b4c0b8fefaa1") },
                    { new Guid("a7ff7211-1621-4a32-9cc0-4c23804f2e4e"), new DateTime(2021, 5, 17, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(1100), "", new Guid("d5d109a9-ac86-40ef-a783-b5c0b8fefaa1") },
                    { new Guid("51009bcb-d7fb-46db-9bc3-161efc2a5936"), new DateTime(2021, 5, 17, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(1101), "", new Guid("d5d109a9-ac86-40ef-a783-b6c0b8fefaa1") },
                    { new Guid("dd694a91-75ec-46a3-acb4-d78a199616d2"), new DateTime(2021, 5, 17, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(1102), "", new Guid("d5d109a9-ac86-40ef-a783-b7c0b8fefaa1") },
                    { new Guid("5b12bc99-b9c3-4541-b0f9-7b32c066f083"), new DateTime(2021, 5, 18, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(1142), "", new Guid("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1") },
                    { new Guid("9af75da3-eede-49c2-b5d9-ca7482c82db7"), new DateTime(2021, 5, 18, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(1144), "", new Guid("d5d109a9-ac86-40ef-a783-b4c0b8fefaa1") },
                    { new Guid("e3a94711-1c11-4b85-b75a-524552b69a8c"), new DateTime(2021, 5, 18, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(1145), "", new Guid("d5d109a9-ac86-40ef-a783-b5c0b8fefaa1") },
                    { new Guid("15e9ae17-d948-4c79-b8d1-e353545296e0"), new DateTime(2021, 5, 18, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(1147), "", new Guid("d5d109a9-ac86-40ef-a783-b6c0b8fefaa1") },
                    { new Guid("fd590dab-81a6-45fe-b317-ac207db51809"), new DateTime(2021, 5, 15, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(984), "", new Guid("d5d109a9-ac86-40ef-a783-b6c0b8fefaa1") },
                    { new Guid("2b25c08a-0de7-4ac0-88b1-41a22f91d245"), new DateTime(2021, 5, 11, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(776), "", new Guid("d5d109a9-ac86-40ef-a783-b6c0b8fefaa1") },
                    { new Guid("7df25dad-8737-492c-b371-72ff1c140ee2"), new DateTime(2021, 5, 15, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(983), "", new Guid("d5d109a9-ac86-40ef-a783-b5c0b8fefaa1") },
                    { new Guid("8db45cdd-210f-4e91-a578-068938cf3f9a"), new DateTime(2021, 5, 15, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(979), "", new Guid("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1") },
                    { new Guid("77c41813-5fc8-4b12-9e3f-df5ea6e1c2b6"), new DateTime(2021, 5, 12, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(837), "", new Guid("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1") },
                    { new Guid("fc686a00-6617-4018-bdb0-de06d622dd68"), new DateTime(2021, 5, 12, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(839), "", new Guid("d5d109a9-ac86-40ef-a783-b4c0b8fefaa1") },
                    { new Guid("d6d8a190-0aea-4c1b-b707-1645708796ee"), new DateTime(2021, 5, 12, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(841), "", new Guid("d5d109a9-ac86-40ef-a783-b5c0b8fefaa1") },
                    { new Guid("093dae4a-a6d4-4099-b8c3-52788ede324d"), new DateTime(2021, 5, 12, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(842), "", new Guid("d5d109a9-ac86-40ef-a783-b6c0b8fefaa1") },
                    { new Guid("5b874499-d7fa-4a1a-bd36-49751b120f87"), new DateTime(2021, 5, 12, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(845), "", new Guid("d5d109a9-ac86-40ef-a783-b7c0b8fefaa1") },
                    { new Guid("d0d2f413-5277-421e-8f0a-1ed1fc160f9e"), new DateTime(2021, 5, 13, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(887), "", new Guid("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1") },
                    { new Guid("6285c45a-a15c-456e-908b-6b05f497ea61"), new DateTime(2021, 5, 13, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(888), "", new Guid("d5d109a9-ac86-40ef-a783-b4c0b8fefaa1") },
                    { new Guid("e1b45a68-0175-42b7-a933-c7ea2ce83006"), new DateTime(2021, 5, 13, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(890), "", new Guid("d5d109a9-ac86-40ef-a783-b5c0b8fefaa1") },
                    { new Guid("ce297c6e-ec4e-490f-9a2e-628628729288"), new DateTime(2021, 5, 13, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(891), "", new Guid("d5d109a9-ac86-40ef-a783-b6c0b8fefaa1") },
                    { new Guid("61599e99-ac04-4f4d-a977-12ca37169cac"), new DateTime(2021, 5, 13, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(892), "", new Guid("d5d109a9-ac86-40ef-a783-b7c0b8fefaa1") },
                    { new Guid("fce6209d-e52b-4fab-a9f7-14e79b2e891b"), new DateTime(2021, 5, 14, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(932), "", new Guid("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1") },
                    { new Guid("d129e310-fd48-4e52-b95c-e78f9c8cde98"), new DateTime(2021, 5, 14, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(933), "", new Guid("d5d109a9-ac86-40ef-a783-b4c0b8fefaa1") },
                    { new Guid("0b9b14e7-7ef2-4986-9bb2-134f4517cda7"), new DateTime(2021, 5, 14, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(935), "", new Guid("d5d109a9-ac86-40ef-a783-b5c0b8fefaa1") },
                    { new Guid("a87f9044-8fca-422e-b998-9d86bd6855aa"), new DateTime(2021, 5, 14, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(936), "", new Guid("d5d109a9-ac86-40ef-a783-b6c0b8fefaa1") },
                    { new Guid("25c4d172-1f3d-4fa2-9290-9d26c6e2cb68"), new DateTime(2021, 5, 14, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(939), "", new Guid("d5d109a9-ac86-40ef-a783-b7c0b8fefaa1") },
                    { new Guid("98fbcdb2-83bf-43e3-95f7-676bb9ff1c8d"), new DateTime(2021, 5, 15, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(981), "", new Guid("d5d109a9-ac86-40ef-a783-b4c0b8fefaa1") },
                    { new Guid("9d0e7061-5b81-4ff5-aebc-58c07a52ca14"), new DateTime(2021, 5, 18, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(1150), "", new Guid("d5d109a9-ac86-40ef-a783-b7c0b8fefaa1") },
                    { new Guid("7210fd84-7fb1-42b7-8b13-3fbf65677080"), new DateTime(2021, 5, 4, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(398), "", new Guid("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1") },
                    { new Guid("3452b941-5a4c-46fe-b195-329db0c4ce68"), new DateTime(2021, 5, 3, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(357), "", new Guid("d5d109a9-ac86-40ef-a783-b6c0b8fefaa1") },
                    { new Guid("d0c36ad4-5c38-4037-bfe0-5fd20669387d"), new DateTime(2021, 4, 23, 0, 6, 23, 621, DateTimeKind.Local).AddTicks(9834), "", new Guid("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1") },
                    { new Guid("70c0fd74-4688-407b-a583-3aa993814e3a"), new DateTime(2021, 4, 23, 0, 6, 23, 621, DateTimeKind.Local).AddTicks(9835), "", new Guid("d5d109a9-ac86-40ef-a783-b4c0b8fefaa1") },
                    { new Guid("307fc466-e5a3-4fd7-959e-f4493183f7b8"), new DateTime(2021, 4, 23, 0, 6, 23, 621, DateTimeKind.Local).AddTicks(9837), "", new Guid("d5d109a9-ac86-40ef-a783-b5c0b8fefaa1") },
                    { new Guid("4e82f8cb-95d7-4584-9d8e-6d362937774e"), new DateTime(2021, 4, 23, 0, 6, 23, 621, DateTimeKind.Local).AddTicks(9838), "", new Guid("d5d109a9-ac86-40ef-a783-b6c0b8fefaa1") },
                    { new Guid("116fc02a-e323-4ae4-97eb-b199a5228d83"), new DateTime(2021, 4, 23, 0, 6, 23, 621, DateTimeKind.Local).AddTicks(9840), "", new Guid("d5d109a9-ac86-40ef-a783-b7c0b8fefaa1") },
                    { new Guid("10502b56-a649-41d5-89ce-56933bc09708"), new DateTime(2021, 4, 24, 0, 6, 23, 621, DateTimeKind.Local).AddTicks(9882), "", new Guid("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1") },
                    { new Guid("2a8569af-1ee4-4719-b3de-0585a2142e73"), new DateTime(2021, 4, 24, 0, 6, 23, 621, DateTimeKind.Local).AddTicks(9883), "", new Guid("d5d109a9-ac86-40ef-a783-b4c0b8fefaa1") },
                    { new Guid("5a9e3cec-9d4b-441b-8776-e7c353372da0"), new DateTime(2021, 4, 24, 0, 6, 23, 621, DateTimeKind.Local).AddTicks(9885), "", new Guid("d5d109a9-ac86-40ef-a783-b5c0b8fefaa1") },
                    { new Guid("91d50930-716f-49b9-921a-a72a35533634"), new DateTime(2021, 4, 24, 0, 6, 23, 621, DateTimeKind.Local).AddTicks(9886), "", new Guid("d5d109a9-ac86-40ef-a783-b6c0b8fefaa1") },
                    { new Guid("6cb5dc33-1c10-4584-9b90-3b9361691a5d"), new DateTime(2021, 4, 24, 0, 6, 23, 621, DateTimeKind.Local).AddTicks(9889), "", new Guid("d5d109a9-ac86-40ef-a783-b7c0b8fefaa1") },
                    { new Guid("2f51f61b-4b7c-48f1-a8fb-7d36e5b4d678"), new DateTime(2021, 4, 25, 0, 6, 23, 621, DateTimeKind.Local).AddTicks(9929), "", new Guid("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1") },
                    { new Guid("bf570802-e8fe-4ee2-b68e-4a16ff98229a"), new DateTime(2021, 4, 25, 0, 6, 23, 621, DateTimeKind.Local).AddTicks(9931), "", new Guid("d5d109a9-ac86-40ef-a783-b4c0b8fefaa1") },
                    { new Guid("34a9e559-49b6-4d8b-b8f2-cdc9d32bc614"), new DateTime(2021, 4, 25, 0, 6, 23, 621, DateTimeKind.Local).AddTicks(9932), "", new Guid("d5d109a9-ac86-40ef-a783-b5c0b8fefaa1") },
                    { new Guid("aaa9f2af-78db-40d0-afc2-6865245b4071"), new DateTime(2021, 4, 25, 0, 6, 23, 621, DateTimeKind.Local).AddTicks(9934), "", new Guid("d5d109a9-ac86-40ef-a783-b6c0b8fefaa1") },
                    { new Guid("3077c554-bab4-494e-999a-382acfab24e7"), new DateTime(2021, 4, 25, 0, 6, 23, 621, DateTimeKind.Local).AddTicks(9935), "", new Guid("d5d109a9-ac86-40ef-a783-b7c0b8fefaa1") },
                    { new Guid("f0f78c5d-c0ec-46be-a57f-6f76b9a6a62a"), new DateTime(2021, 4, 22, 0, 6, 23, 621, DateTimeKind.Local).AddTicks(9756), "", new Guid("d5d109a9-ac86-40ef-a783-b7c0b8fefaa1") },
                    { new Guid("eb42bdaa-f8c0-4a67-aa25-7b573480bb90"), new DateTime(2021, 4, 26, 0, 6, 23, 621, DateTimeKind.Local).AddTicks(9976), "", new Guid("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1") },
                    { new Guid("c7cd424a-fd43-4f58-a8bb-2f053e5b457b"), new DateTime(2021, 4, 22, 0, 6, 23, 621, DateTimeKind.Local).AddTicks(9753), "", new Guid("d5d109a9-ac86-40ef-a783-b6c0b8fefaa1") },
                    { new Guid("2b137fcc-acbf-4eb3-b06c-89656be85582"), new DateTime(2021, 4, 22, 0, 6, 23, 621, DateTimeKind.Local).AddTicks(9750), "", new Guid("d5d109a9-ac86-40ef-a783-b4c0b8fefaa1") },
                    { new Guid("f9305dd6-ac77-437e-bbf5-f47a4dadbdf7"), new DateTime(2021, 4, 19, 0, 6, 23, 621, DateTimeKind.Local).AddTicks(7648), "", new Guid("d5d109a9-ac86-40ef-a783-b4c0b8fefaa1") },
                    { new Guid("7cbd0120-f5d3-4314-97b7-700e3cd5d5a4"), new DateTime(2021, 4, 19, 0, 6, 23, 621, DateTimeKind.Local).AddTicks(7674), "", new Guid("d5d109a9-ac86-40ef-a783-b5c0b8fefaa1") },
                    { new Guid("45816a3a-eeaa-482f-b4ff-a62ede8c86d8"), new DateTime(2021, 4, 19, 0, 6, 23, 621, DateTimeKind.Local).AddTicks(7677), "", new Guid("d5d109a9-ac86-40ef-a783-b6c0b8fefaa1") },
                    { new Guid("a6bcca0e-65af-42ee-9889-1c3b0acd84e7"), new DateTime(2021, 4, 19, 0, 6, 23, 621, DateTimeKind.Local).AddTicks(7678), "", new Guid("d5d109a9-ac86-40ef-a783-b7c0b8fefaa1") },
                    { new Guid("97ed2667-2ae4-434e-a29a-d85c063ad5b8"), new DateTime(2021, 4, 20, 0, 6, 23, 621, DateTimeKind.Local).AddTicks(9627), "", new Guid("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1") },
                    { new Guid("d90eb6ed-388e-41fa-82b6-404ef2de4e8e"), new DateTime(2021, 4, 20, 0, 6, 23, 621, DateTimeKind.Local).AddTicks(9634), "", new Guid("d5d109a9-ac86-40ef-a783-b4c0b8fefaa1") },
                    { new Guid("95207cb5-c3cf-4943-bceb-00ca1380581d"), new DateTime(2021, 4, 20, 0, 6, 23, 621, DateTimeKind.Local).AddTicks(9636), "", new Guid("d5d109a9-ac86-40ef-a783-b5c0b8fefaa1") },
                    { new Guid("be9f7bd4-a492-4ac3-bc9a-82792d24a024"), new DateTime(2021, 4, 20, 0, 6, 23, 621, DateTimeKind.Local).AddTicks(9637), "", new Guid("d5d109a9-ac86-40ef-a783-b6c0b8fefaa1") },
                    { new Guid("3b35ebcd-d5b9-40af-b1c1-4f2eb41a484a"), new DateTime(2021, 4, 20, 0, 6, 23, 621, DateTimeKind.Local).AddTicks(9642), "", new Guid("d5d109a9-ac86-40ef-a783-b7c0b8fefaa1") },
                    { new Guid("81d76017-fd1b-49ce-bfd3-ecfa7076e6eb"), new DateTime(2021, 4, 21, 0, 6, 23, 621, DateTimeKind.Local).AddTicks(9699), "", new Guid("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1") },
                    { new Guid("8923c352-6c7b-44a4-ba98-d8391cb0f982"), new DateTime(2021, 4, 21, 0, 6, 23, 621, DateTimeKind.Local).AddTicks(9701), "", new Guid("d5d109a9-ac86-40ef-a783-b4c0b8fefaa1") },
                    { new Guid("dfbf35c7-8cf0-4023-9048-a7b647cba0c2"), new DateTime(2021, 4, 21, 0, 6, 23, 621, DateTimeKind.Local).AddTicks(9702), "", new Guid("d5d109a9-ac86-40ef-a783-b5c0b8fefaa1") },
                    { new Guid("b2dac0e9-d57c-4794-832b-d323e08e09e7"), new DateTime(2021, 4, 21, 0, 6, 23, 621, DateTimeKind.Local).AddTicks(9704), "", new Guid("d5d109a9-ac86-40ef-a783-b6c0b8fefaa1") },
                    { new Guid("4c19ee3c-a35c-4e5e-88ad-a43995c37e54"), new DateTime(2021, 4, 21, 0, 6, 23, 621, DateTimeKind.Local).AddTicks(9705), "", new Guid("d5d109a9-ac86-40ef-a783-b7c0b8fefaa1") },
                    { new Guid("aa25cda7-e938-4697-a0f6-9a818687ecba"), new DateTime(2021, 4, 22, 0, 6, 23, 621, DateTimeKind.Local).AddTicks(9748), "", new Guid("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1") },
                    { new Guid("7c788bab-b5ca-4666-8b74-6e6219444c8a"), new DateTime(2021, 4, 22, 0, 6, 23, 621, DateTimeKind.Local).AddTicks(9751), "", new Guid("d5d109a9-ac86-40ef-a783-b5c0b8fefaa1") },
                    { new Guid("07b09c0a-05a3-4e93-90f9-896d11c7a2f9"), new DateTime(2021, 5, 3, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(359), "", new Guid("d5d109a9-ac86-40ef-a783-b7c0b8fefaa1") },
                    { new Guid("4b707a26-f417-43f6-abbf-f6ced0ea031a"), new DateTime(2021, 4, 26, 0, 6, 23, 621, DateTimeKind.Local).AddTicks(9978), "", new Guid("d5d109a9-ac86-40ef-a783-b4c0b8fefaa1") },
                    { new Guid("eb36c7eb-95b4-44aa-9e29-53394fb0c962"), new DateTime(2021, 4, 26, 0, 6, 23, 621, DateTimeKind.Local).AddTicks(9981), "", new Guid("d5d109a9-ac86-40ef-a783-b6c0b8fefaa1") },
                    { new Guid("6cbbfff3-ddc6-433d-87a5-4afdf2336ed7"), new DateTime(2021, 4, 30, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(194), "", new Guid("d5d109a9-ac86-40ef-a783-b6c0b8fefaa1") },
                    { new Guid("235b4a3e-93af-45ee-b2d4-b3d9423afc47"), new DateTime(2021, 4, 30, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(197), "", new Guid("d5d109a9-ac86-40ef-a783-b7c0b8fefaa1") },
                    { new Guid("614cb404-ad58-4d99-bf3b-7feccd3f2763"), new DateTime(2021, 5, 1, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(259), "", new Guid("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1") },
                    { new Guid("3dfd1e3d-8391-4184-9d26-1ee85591e65b"), new DateTime(2021, 5, 1, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(261), "", new Guid("d5d109a9-ac86-40ef-a783-b4c0b8fefaa1") },
                    { new Guid("eb13ae68-4c2b-4fdf-a464-1d7e8b05176a"), new DateTime(2021, 5, 1, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(263), "", new Guid("d5d109a9-ac86-40ef-a783-b5c0b8fefaa1") },
                    { new Guid("25045b91-1951-4501-bd8b-217b1bc7cadf"), new DateTime(2021, 5, 1, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(264), "", new Guid("d5d109a9-ac86-40ef-a783-b6c0b8fefaa1") },
                    { new Guid("0b73769a-9eb2-463f-9bab-e9ef485e8ec9"), new DateTime(2021, 5, 1, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(265), "", new Guid("d5d109a9-ac86-40ef-a783-b7c0b8fefaa1") },
                    { new Guid("01290684-5b48-4cb4-a90f-33355163752f"), new DateTime(2021, 5, 2, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(306), "", new Guid("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1") },
                    { new Guid("11dad89d-2355-439a-91e8-9b21ba5a099f"), new DateTime(2021, 5, 2, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(308), "", new Guid("d5d109a9-ac86-40ef-a783-b4c0b8fefaa1") },
                    { new Guid("d972d3e2-564c-4475-a479-189c7553a6de"), new DateTime(2021, 5, 2, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(309), "", new Guid("d5d109a9-ac86-40ef-a783-b5c0b8fefaa1") },
                    { new Guid("63d9d029-cc11-47b8-acae-2aaa95e84213"), new DateTime(2021, 5, 2, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(311), "", new Guid("d5d109a9-ac86-40ef-a783-b6c0b8fefaa1") },
                    { new Guid("1c035dd9-197e-437a-abe0-17c3ea17185e"), new DateTime(2021, 5, 2, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(314), "", new Guid("d5d109a9-ac86-40ef-a783-b7c0b8fefaa1") },
                    { new Guid("881033c1-28c4-4ab0-9466-eb64047204ae"), new DateTime(2021, 5, 3, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(353), "", new Guid("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1") },
                    { new Guid("5fc3bf28-0dce-47b4-9d46-d6dae4ddd491"), new DateTime(2021, 5, 3, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(354), "", new Guid("d5d109a9-ac86-40ef-a783-b4c0b8fefaa1") },
                    { new Guid("18886b3b-eeda-4fe5-9274-f23cc36921bd"), new DateTime(2021, 5, 3, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(356), "", new Guid("d5d109a9-ac86-40ef-a783-b5c0b8fefaa1") },
                    { new Guid("c643c1ee-e5a1-4980-abf8-ef538deeaff4"), new DateTime(2021, 4, 30, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(192), "", new Guid("d5d109a9-ac86-40ef-a783-b5c0b8fefaa1") },
                    { new Guid("67b7998f-f1aa-43e3-97f0-320bdbf46ece"), new DateTime(2021, 4, 26, 0, 6, 23, 621, DateTimeKind.Local).AddTicks(9979), "", new Guid("d5d109a9-ac86-40ef-a783-b5c0b8fefaa1") },
                    { new Guid("230f778e-27c7-4680-811b-e368cab6d669"), new DateTime(2021, 4, 30, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(191), "", new Guid("d5d109a9-ac86-40ef-a783-b4c0b8fefaa1") },
                    { new Guid("ac262776-2e2f-4f40-bfd1-726bdefa884e"), new DateTime(2021, 4, 29, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(149), "", new Guid("d5d109a9-ac86-40ef-a783-b7c0b8fefaa1") },
                    { new Guid("cb50d2e5-64a2-4ccc-94bb-363e3ca7ca86"), new DateTime(2021, 4, 26, 0, 6, 23, 621, DateTimeKind.Local).AddTicks(9983), "", new Guid("d5d109a9-ac86-40ef-a783-b7c0b8fefaa1") },
                    { new Guid("9f714ef6-8d3c-4a2b-a7d1-b5c9adeb931a"), new DateTime(2021, 4, 27, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(48), "", new Guid("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1") },
                    { new Guid("74bdcf3e-4fed-46a5-8d32-d7ff2f243a36"), new DateTime(2021, 4, 27, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(50), "", new Guid("d5d109a9-ac86-40ef-a783-b4c0b8fefaa1") },
                    { new Guid("c3dbb1a1-8aa5-4e58-a3ee-9dc7f491603e"), new DateTime(2021, 4, 27, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(51), "", new Guid("d5d109a9-ac86-40ef-a783-b5c0b8fefaa1") },
                    { new Guid("41d4194e-51f5-4b1d-835a-253bf6ad1581"), new DateTime(2021, 4, 27, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(52), "", new Guid("d5d109a9-ac86-40ef-a783-b6c0b8fefaa1") },
                    { new Guid("6612df5b-3452-4807-96c3-f99edaed4fa9"), new DateTime(2021, 4, 27, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(54), "", new Guid("d5d109a9-ac86-40ef-a783-b7c0b8fefaa1") },
                    { new Guid("dae32fe3-bfeb-4cdc-ae76-e11271073ecf"), new DateTime(2021, 4, 28, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(95), "", new Guid("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1") },
                    { new Guid("7844bd6e-926e-4199-bd4f-8673705abc2f"), new DateTime(2021, 4, 28, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(96), "", new Guid("d5d109a9-ac86-40ef-a783-b4c0b8fefaa1") },
                    { new Guid("59f08faa-cbae-479f-b68e-3a6764b130e6"), new DateTime(2021, 4, 28, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(98), "", new Guid("d5d109a9-ac86-40ef-a783-b5c0b8fefaa1") },
                    { new Guid("f1849e3a-110d-4323-bb0e-d2a925685a8f"), new DateTime(2021, 4, 28, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(99), "", new Guid("d5d109a9-ac86-40ef-a783-b6c0b8fefaa1") },
                    { new Guid("18946922-7a98-4921-b9f7-9365963383a5"), new DateTime(2021, 4, 28, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(102), "", new Guid("d5d109a9-ac86-40ef-a783-b7c0b8fefaa1") },
                    { new Guid("7883e627-cf0a-46f6-868a-2c83c0a57f52"), new DateTime(2021, 4, 29, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(144), "", new Guid("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1") },
                    { new Guid("12a2de14-ee7b-4d05-831a-81b0727f7cc7"), new DateTime(2021, 4, 29, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(145), "", new Guid("d5d109a9-ac86-40ef-a783-b4c0b8fefaa1") },
                    { new Guid("60764ff0-e205-41d7-af62-2856143ec0e5"), new DateTime(2021, 4, 29, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(147), "", new Guid("d5d109a9-ac86-40ef-a783-b5c0b8fefaa1") },
                    { new Guid("88aa2d8e-1b72-4dd4-83cc-a7f18e331191"), new DateTime(2021, 4, 29, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(148), "", new Guid("d5d109a9-ac86-40ef-a783-b6c0b8fefaa1") },
                    { new Guid("fa6b0e30-6a13-48a0-9120-23002bc6ab8e"), new DateTime(2021, 4, 30, 0, 6, 23, 622, DateTimeKind.Local).AddTicks(189), "", new Guid("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1") }
                });

            migrationBuilder.UpdateData(
                table: "TemporaryAuthenticators",
                keyColumn: "Id",
                keyValue: 1,
                column: "Token",
                value: new Guid("9f6cc9e7-f048-4f14-8d0f-253132a84a45"));

            migrationBuilder.InsertData(
                table: "Group",
                columns: new[] { "Id", "EventId", "MaxPlaces", "Name" },
                values: new object[,]
                {
                    { new Guid("3aa2044f-bbd4-4024-ac0e-164960751182"), new Guid("c5975b5a-02bd-49e2-acbc-80ab2220f621"), 300, "Salat Fajr" },
                    { new Guid("ee63da46-683b-459d-9578-da703882663e"), new Guid("d959ea3a-33c5-49f0-814f-221a55014606"), 300, "Salat Fajr" },
                    { new Guid("c53f1b8b-a406-4228-9cc6-845929a8a691"), new Guid("df43fd65-0fe1-4830-a90a-12e981b4881d"), 300, "Salat Dohr" },
                    { new Guid("88556579-965e-432c-a2dd-0abcfb5f8e5e"), new Guid("b8f6e4d5-ba83-453d-b0e2-e1e2f7e335cc"), 300, "Salat Asr" },
                    { new Guid("f2886c50-af66-495e-9a23-3e20fdff6037"), new Guid("1c05bba3-ed58-4f2c-b41c-03872fe2db86"), 300, "Salat Maghreb" },
                    { new Guid("4a7716af-d82f-467e-8f30-e99eda8c31ac"), new Guid("ae775912-0927-4e4d-83fe-a2497c775873"), 300, "Salat Ishaa" },
                    { new Guid("e5a32997-f062-4b04-bbee-67be17db81ff"), new Guid("ae775912-0927-4e4d-83fe-a2497c775873"), 150, "Tarawih group 1" },
                    { new Guid("5cbe5abb-3c42-474c-950c-b480e833ddc5"), new Guid("ae775912-0927-4e4d-83fe-a2497c775873"), 150, "Tarawih group 2" },
                    { new Guid("5654b3f2-feb4-45e9-97a2-68dbde52ff7b"), new Guid("3500cf7a-e76c-437d-8ec7-f094a94c5e0f"), 300, "Salat Fajr" },
                    { new Guid("1e85a463-7751-4657-8283-6bdae6f668cd"), new Guid("23ff0cbc-891b-4faf-a8f2-e93ee119cb91"), 300, "Salat Dohr" },
                    { new Guid("7de6f8df-79ff-402e-aba7-b61b3f5c1de2"), new Guid("1a649a43-bc16-4721-b291-4347df54aa49"), 300, "Salat Asr" },
                    { new Guid("84e7a015-15fb-43ba-b84d-60fba375d534"), new Guid("e0d2d220-5b0b-4428-8d3b-cdf4e6e8a050"), 150, "Tarawih group 2" },
                    { new Guid("7e2355c0-f10b-4001-be66-7dc297bf32cc"), new Guid("d10ec7be-0456-4ff2-97d3-37a02793d2b1"), 300, "Salat Maghreb" },
                    { new Guid("2960b982-c8a0-4672-93cb-79d343988334"), new Guid("fbbd0bd8-584e-4660-a47f-f8d90719fe7f"), 150, "Tarawih group 1" },
                    { new Guid("bb5e0f19-8137-4d13-a72e-de904ffb205f"), new Guid("fbbd0bd8-584e-4660-a47f-f8d90719fe7f"), 150, "Tarawih group 2" },
                    { new Guid("3f536583-c118-4247-b603-5441ad62533a"), new Guid("34092974-73a3-4fc9-b1b4-2cf7e2ef5408"), 300, "Salat Fajr" },
                    { new Guid("40a87b4c-c54e-40b6-b053-875a5d324eea"), new Guid("f208cfa2-7185-44a0-b6d0-dbfb15ad3075"), 300, "Salat Dohr" },
                    { new Guid("085b6f5e-c678-4392-99c3-f6ea8dc2611e"), new Guid("0cb52daf-1e53-429c-b010-aa22f45e389d"), 300, "Salat Asr" },
                    { new Guid("d7f9a59d-6695-4cda-82b4-a53d6012ebc1"), new Guid("96b0db43-1cd1-4980-9038-0adf1fce8df9"), 300, "Salat Maghreb" },
                    { new Guid("bfcd1c55-8853-48a5-b627-aae3cdc97c04"), new Guid("4bafd0b1-3022-48e3-bfd8-f3c629215cf6"), 300, "Salat Ishaa" },
                    { new Guid("63846194-f825-48bc-bcd6-8315b4ee744d"), new Guid("4bafd0b1-3022-48e3-bfd8-f3c629215cf6"), 150, "Tarawih group 1" },
                    { new Guid("715b26f7-6409-4370-993b-72ac178d2f99"), new Guid("4bafd0b1-3022-48e3-bfd8-f3c629215cf6"), 150, "Tarawih group 2" },
                    { new Guid("be3cbad7-050a-43eb-b54f-41c2de6b89c1"), new Guid("3c0619bf-7500-4e5f-bf4c-138e00f19674"), 300, "Salat Fajr" },
                    { new Guid("858ec4c1-55db-4e43-a6da-40c8c2efd74f"), new Guid("fbbd0bd8-584e-4660-a47f-f8d90719fe7f"), 300, "Salat Ishaa" },
                    { new Guid("618b9407-36bb-4a6c-a767-02340389cec1"), new Guid("3786db35-4b3a-4be8-8a1d-109b7337c609"), 300, "Salat Dohr" },
                    { new Guid("b5aac432-780c-44ef-8fba-7888106523b8"), new Guid("e0d2d220-5b0b-4428-8d3b-cdf4e6e8a050"), 150, "Tarawih group 1" },
                    { new Guid("be776f90-520b-4ab2-a7eb-52fce1091072"), new Guid("2bc8bc63-209c-421b-81d5-535e2c0d19cf"), 300, "Salat Maghreb" },
                    { new Guid("52a10189-e61d-4253-ba6e-b400f0c79cd4"), new Guid("a7f0cfab-f1e2-4c06-ae4c-69d326a9e7b7"), 300, "Salat Asr" },
                    { new Guid("5d8aca73-1264-4c72-bbd5-62221d131766"), new Guid("51491cac-e7c8-4926-9c24-a90bd1b74cff"), 300, "Salat Maghreb" },
                    { new Guid("fb925bb9-f9e9-4028-aebb-e346fbc910c3"), new Guid("4ed32862-e448-4d01-bc4c-976957059aef"), 300, "Salat Ishaa" },
                    { new Guid("373a8caf-acdf-4759-ab0c-b92358958c1b"), new Guid("4ed32862-e448-4d01-bc4c-976957059aef"), 150, "Tarawih group 1" },
                    { new Guid("f5b77341-8d51-457a-96e0-e8f4bab39306"), new Guid("4ed32862-e448-4d01-bc4c-976957059aef"), 150, "Tarawih group 2" },
                    { new Guid("2d89f093-5c41-4aec-a2bb-e008d5f1842c"), new Guid("90f36610-46fc-4eb1-8060-55e743d7330d"), 300, "Salat Fajr" },
                    { new Guid("5445a828-d2ee-4de1-a53c-3c9315936136"), new Guid("4091b872-9ffc-4589-8420-376fdf303d93"), 300, "Salat Dohr" },
                    { new Guid("78b6c27d-6894-406a-840c-4a5a85e42b22"), new Guid("f02831fb-ab03-459e-89d7-b48aa245eeb9"), 300, "Salat Asr" },
                    { new Guid("9b1ac8b5-6d7f-4cbd-8f20-c9663f2e053a"), new Guid("1916b7ad-e782-469d-aacf-ec0678000da3"), 300, "Salat Maghreb" },
                    { new Guid("68e2a409-3ad1-4cec-9c83-8a5858a8cda2"), new Guid("b667a254-17d0-4cba-ae64-d80dbf66e823"), 300, "Salat Ishaa" },
                    { new Guid("f2f895af-5e1c-4302-b225-13d5a235374b"), new Guid("e0d2d220-5b0b-4428-8d3b-cdf4e6e8a050"), 300, "Salat Ishaa" },
                    { new Guid("82031797-f168-4121-b3e9-bc8345d021b7"), new Guid("b667a254-17d0-4cba-ae64-d80dbf66e823"), 150, "Tarawih group 1" },
                    { new Guid("e64e7d90-a416-48d0-bd8e-7441390e0132"), new Guid("de6381e6-2a31-48b0-8dce-fbc1aa4de0ad"), 300, "Salat Fajr" },
                    { new Guid("a96231a2-c532-49fa-9b6b-19c19e52e293"), new Guid("e6fcf2bf-2ad0-48d9-af8a-7955e9591aee"), 300, "Salat Dohr" },
                    { new Guid("97b6d0f1-554c-4e8e-aa76-eed014f4889e"), new Guid("ef8b6c51-e6d1-49d8-87c8-969f66b37eda"), 300, "Salat Asr" },
                    { new Guid("60e9b54c-812b-40fe-8285-31148241097e"), new Guid("d7c13f36-a59a-4877-a809-5bbe20f164b1"), 300, "Salat Maghreb" },
                    { new Guid("c1a4104b-d5d3-4ce8-ab96-c2586bb07492"), new Guid("78d16281-195a-4b84-bb3d-1ea15b01321e"), 300, "Salat Ishaa" },
                    { new Guid("f8be926d-d3af-4343-9fbb-c9d2c3f8a5c7"), new Guid("78d16281-195a-4b84-bb3d-1ea15b01321e"), 150, "Tarawih group 1" },
                    { new Guid("2949f2d9-6e4f-4ad6-9fed-9837a6544789"), new Guid("78d16281-195a-4b84-bb3d-1ea15b01321e"), 150, "Tarawih group 2" },
                    { new Guid("3ff13791-f424-408d-bf62-6dc39eae907e"), new Guid("29938e42-2c4e-4c00-8e8a-16aa01fe7c88"), 300, "Salat Fajr" },
                    { new Guid("a812e848-96b9-4df1-9d29-be08886e3ecb"), new Guid("959a3ecd-3834-40bb-8936-b94da0852314"), 300, "Salat Dohr" },
                    { new Guid("85a690f1-b77f-42a4-9f3e-bd0fe77e4373"), new Guid("1f77ddb3-2341-4dc5-aecd-4780c3961b6f"), 300, "Salat Asr" },
                    { new Guid("e0a4b34e-5215-42b1-a0f5-6eeda341e885"), new Guid("b667a254-17d0-4cba-ae64-d80dbf66e823"), 150, "Tarawih group 2" },
                    { new Guid("7fc24f9c-9ffc-4079-8670-d5f4994304a0"), new Guid("588e0f53-f5d9-4116-a80d-f28099731e3f"), 300, "Salat Asr" },
                    { new Guid("2be181b4-5cce-43cf-822c-9b4731a60c35"), new Guid("2b25c08a-0de7-4ac0-88b1-41a22f91d245"), 300, "Salat Maghreb" },
                    { new Guid("73633641-a4a7-42dc-ac36-bc413435bd11"), new Guid("6e28b4eb-5ff6-490d-9511-c133b2f8a5e9"), 300, "Salat Ishaa" },
                    { new Guid("f4a74977-6fa6-4066-9465-0ce6a12d398e"), new Guid("4e05d1f5-ee71-4e6d-b36e-d769a0cbd182"), 300, "Salat Ishaa" },
                    { new Guid("b4899844-aa7b-4dd7-92d4-6add40134edd"), new Guid("4e05d1f5-ee71-4e6d-b36e-d769a0cbd182"), 150, "Tarawih group 1" },
                    { new Guid("21305f4f-37eb-444e-bfd9-8ae65b7bf62f"), new Guid("4e05d1f5-ee71-4e6d-b36e-d769a0cbd182"), 150, "Tarawih group 2" },
                    { new Guid("37cff3ce-7180-4589-9bfb-6620aaf33375"), new Guid("c3ea650f-afe6-4090-bd1a-508a35e502e2"), 300, "Salat Fajr" },
                    { new Guid("fcca1dbf-8310-4f75-82aa-cec747679713"), new Guid("098989db-0143-4462-b703-302602ae7da5"), 300, "Salat Dohr" },
                    { new Guid("af0a7fba-a6bd-488a-80ee-fb22e4df12b3"), new Guid("6ec7d47b-bf47-4229-a0f6-2547207d860c"), 300, "Salat Asr" },
                    { new Guid("fccb795c-0639-49aa-9840-b83f8f383bbc"), new Guid("1c02e3b9-efe2-4d99-a177-826fddff50bf"), 300, "Salat Maghreb" },
                    { new Guid("258cebaf-3f95-494a-af95-3f4b3d6764eb"), new Guid("e5208ae9-8c72-4a46-a8fb-ae91be93eb96"), 300, "Salat Ishaa" },
                    { new Guid("836f5ebe-810f-48e4-9256-9d9ef63fcfa4"), new Guid("e5208ae9-8c72-4a46-a8fb-ae91be93eb96"), 150, "Tarawih group 1" },
                    { new Guid("a6537c89-ceb0-4fee-9e7c-c867e788d7c1"), new Guid("e5208ae9-8c72-4a46-a8fb-ae91be93eb96"), 150, "Tarawih group 2" },
                    { new Guid("0cef54ac-95e2-48c1-9ce5-45c908f89bf4"), new Guid("fd590dab-81a6-45fe-b317-ac207db51809"), 300, "Salat Maghreb" },
                    { new Guid("04c34437-c36e-44bf-815b-a890297a1ac9"), new Guid("94569c07-1269-448b-ac8a-9d19bd75cbf4"), 300, "Salat Fajr" },
                    { new Guid("d8dfc91d-e85a-466b-88ec-5fe88da22b8c"), new Guid("a7ff7211-1621-4a32-9cc0-4c23804f2e4e"), 300, "Salat Asr" },
                    { new Guid("602122f3-af1c-4101-9c0a-38339c62a966"), new Guid("51009bcb-d7fb-46db-9bc3-161efc2a5936"), 300, "Salat Maghreb" },
                    { new Guid("d59fae55-bcd5-4f6a-8b66-33a095e12dfa"), new Guid("dd694a91-75ec-46a3-acb4-d78a199616d2"), 300, "Salat Ishaa" },
                    { new Guid("dc553756-775a-4b7b-be3f-d74acf79e151"), new Guid("dd694a91-75ec-46a3-acb4-d78a199616d2"), 150, "Tarawih group 1" },
                    { new Guid("9b4789c3-b03d-4397-9cba-e025cf337ff0"), new Guid("dd694a91-75ec-46a3-acb4-d78a199616d2"), 150, "Tarawih group 2" },
                    { new Guid("730eed76-b34c-4b9a-bf9f-6d6fe120b974"), new Guid("5b12bc99-b9c3-4541-b0f9-7b32c066f083"), 300, "Salat Fajr" },
                    { new Guid("6774f3bc-3f70-4ccb-aa85-df3e92fe45ad"), new Guid("9af75da3-eede-49c2-b5d9-ca7482c82db7"), 300, "Salat Dohr" },
                    { new Guid("f94975a4-e9cb-4254-a694-9ae538b62da7"), new Guid("e3a94711-1c11-4b85-b75a-524552b69a8c"), 300, "Salat Asr" },
                    { new Guid("64d02d05-5663-436a-a8d6-d36ccfe79c64"), new Guid("15e9ae17-d948-4c79-b8d1-e353545296e0"), 300, "Salat Maghreb" },
                    { new Guid("527a9557-e76b-4b57-b979-c170d25d874c"), new Guid("9d0e7061-5b81-4ff5-aebc-58c07a52ca14"), 300, "Salat Ishaa" },
                    { new Guid("5f62d69e-16d6-41b8-a52e-96464f6617a3"), new Guid("7d576624-a377-490d-8cf1-4fe59a195032"), 300, "Salat Dohr" },
                    { new Guid("2667d472-ee9d-445d-84c8-b5f1e29c1846"), new Guid("7df25dad-8737-492c-b371-72ff1c140ee2"), 300, "Salat Asr" },
                    { new Guid("b7951cf6-5f10-41b9-a543-26582ccde5cf"), new Guid("98fbcdb2-83bf-43e3-95f7-676bb9ff1c8d"), 300, "Salat Dohr" },
                    { new Guid("fa4d7234-afff-4b69-9520-efb62651eff4"), new Guid("8db45cdd-210f-4e91-a578-068938cf3f9a"), 300, "Salat Fajr" },
                    { new Guid("ffddb558-aab2-4e28-a17a-a53fe962869c"), new Guid("6e28b4eb-5ff6-490d-9511-c133b2f8a5e9"), 150, "Tarawih group 1" },
                    { new Guid("213ce565-0400-4f38-b1c0-c3f09d3a3550"), new Guid("6e28b4eb-5ff6-490d-9511-c133b2f8a5e9"), 150, "Tarawih group 2" },
                    { new Guid("247319e9-f0b2-4362-a4e4-35c8b3328e98"), new Guid("77c41813-5fc8-4b12-9e3f-df5ea6e1c2b6"), 300, "Salat Fajr" },
                    { new Guid("470e9812-7134-4dc3-abe9-88319c7a5b7a"), new Guid("fc686a00-6617-4018-bdb0-de06d622dd68"), 300, "Salat Dohr" },
                    { new Guid("f163dc4b-8184-4699-bec0-f80adc44f6f3"), new Guid("d6d8a190-0aea-4c1b-b707-1645708796ee"), 300, "Salat Asr" },
                    { new Guid("f129631e-0bc7-4996-bf77-ea473c02688e"), new Guid("093dae4a-a6d4-4099-b8c3-52788ede324d"), 300, "Salat Maghreb" },
                    { new Guid("9721c808-fb8b-4e86-aaa7-640fa31aaf6f"), new Guid("5b874499-d7fa-4a1a-bd36-49751b120f87"), 300, "Salat Ishaa" },
                    { new Guid("b995ea99-8994-461b-b146-cbc669bfb16f"), new Guid("5b874499-d7fa-4a1a-bd36-49751b120f87"), 150, "Tarawih group 1" },
                    { new Guid("f5679cf6-ff25-4555-8476-c34326ce8a3d"), new Guid("5b874499-d7fa-4a1a-bd36-49751b120f87"), 150, "Tarawih group 2" },
                    { new Guid("5c6be910-3fff-484e-a3ca-4381383be29b"), new Guid("d0d2f413-5277-421e-8f0a-1ed1fc160f9e"), 300, "Salat Fajr" },
                    { new Guid("2e71b4e4-bcf5-466a-9c8e-f54e5ed49985"), new Guid("6285c45a-a15c-456e-908b-6b05f497ea61"), 300, "Salat Dohr" },
                    { new Guid("bd69e10e-8b28-4000-b259-2c9d8f4057b7"), new Guid("e1b45a68-0175-42b7-a933-c7ea2ce83006"), 300, "Salat Asr" },
                    { new Guid("a111ccad-44d4-4bda-80bb-3ecfa56a9096"), new Guid("ce297c6e-ec4e-490f-9a2e-628628729288"), 300, "Salat Maghreb" },
                    { new Guid("673f8937-ed78-45f2-afbb-ff25db77d0df"), new Guid("61599e99-ac04-4f4d-a977-12ca37169cac"), 300, "Salat Ishaa" },
                    { new Guid("61bb932b-fa86-44dd-b482-0c8172df6ebe"), new Guid("61599e99-ac04-4f4d-a977-12ca37169cac"), 150, "Tarawih group 1" },
                    { new Guid("5d92c5df-850e-4571-bbc3-34ba4a530bb8"), new Guid("61599e99-ac04-4f4d-a977-12ca37169cac"), 150, "Tarawih group 2" },
                    { new Guid("18ec2397-ffe7-4b2a-91d8-f5d3f78d861e"), new Guid("fce6209d-e52b-4fab-a9f7-14e79b2e891b"), 300, "Salat Fajr" },
                    { new Guid("d6cc9b95-b70a-4b7a-97fa-4be3d19fdf47"), new Guid("d129e310-fd48-4e52-b95c-e78f9c8cde98"), 300, "Salat Dohr" },
                    { new Guid("bf0b0deb-21ef-4cf3-a0de-c0c712a68262"), new Guid("0b9b14e7-7ef2-4986-9bb2-134f4517cda7"), 300, "Salat Asr" },
                    { new Guid("de7bf3b2-63b7-4fc2-8dcb-960c7c2a79aa"), new Guid("a87f9044-8fca-422e-b998-9d86bd6855aa"), 300, "Salat Maghreb" },
                    { new Guid("2c59936c-1cd0-4f19-903a-98f08f698584"), new Guid("25c4d172-1f3d-4fa2-9290-9d26c6e2cb68"), 300, "Salat Ishaa" },
                    { new Guid("6868e57d-4c8b-4f8d-a5b6-594e0faadbf7"), new Guid("25c4d172-1f3d-4fa2-9290-9d26c6e2cb68"), 150, "Tarawih group 1" },
                    { new Guid("9a54d142-905a-4597-b7b8-435bc99254f0"), new Guid("25c4d172-1f3d-4fa2-9290-9d26c6e2cb68"), 150, "Tarawih group 2" },
                    { new Guid("eb008ca2-1e9e-4b85-a4c6-4130d80f99be"), new Guid("cb99a928-41e3-436d-8d85-e2fa1bda08fa"), 300, "Salat Dohr" },
                    { new Guid("0f176893-92d3-46b3-82c8-565fe0553209"), new Guid("7210fd84-7fb1-42b7-8b13-3fbf65677080"), 300, "Salat Fajr" },
                    { new Guid("66ef5809-1cd3-4a46-a2cf-ccf0fc696786"), new Guid("07b09c0a-05a3-4e93-90f9-896d11c7a2f9"), 150, "Tarawih group 2" },
                    { new Guid("59e54654-9fd7-4d1a-8e9e-d1cc0284881c"), new Guid("07b09c0a-05a3-4e93-90f9-896d11c7a2f9"), 150, "Tarawih group 1" },
                    { new Guid("4c92b7a3-c645-4f17-8ad9-04b21095428e"), new Guid("d0c36ad4-5c38-4037-bfe0-5fd20669387d"), 300, "Salat Fajr" },
                    { new Guid("5a1ab1d1-83e1-4dd3-b988-e02488267858"), new Guid("70c0fd74-4688-407b-a583-3aa993814e3a"), 300, "Salat Dohr" },
                    { new Guid("9e89cbdc-746e-4b56-9963-5809043dbd54"), new Guid("307fc466-e5a3-4fd7-959e-f4493183f7b8"), 300, "Salat Asr" },
                    { new Guid("b6add5ec-5c57-444d-899e-f21b7a25c681"), new Guid("4e82f8cb-95d7-4584-9d8e-6d362937774e"), 300, "Salat Maghreb" },
                    { new Guid("4a68ba54-c1ea-4969-8221-dc8969d11f78"), new Guid("116fc02a-e323-4ae4-97eb-b199a5228d83"), 300, "Salat Ishaa" },
                    { new Guid("ece2300e-dab5-42df-bc5a-2e0640cb5dec"), new Guid("116fc02a-e323-4ae4-97eb-b199a5228d83"), 150, "Tarawih group 1" },
                    { new Guid("7c77e53e-5993-47f5-a867-8689ad6c820b"), new Guid("116fc02a-e323-4ae4-97eb-b199a5228d83"), 150, "Tarawih group 2" },
                    { new Guid("a3bf84d4-a581-456d-b94b-3efc22976b5b"), new Guid("10502b56-a649-41d5-89ce-56933bc09708"), 300, "Salat Fajr" },
                    { new Guid("ff7a8d1a-e741-4e28-ba04-aa718f950405"), new Guid("2a8569af-1ee4-4719-b3de-0585a2142e73"), 300, "Salat Dohr" },
                    { new Guid("93908ffe-45d8-4b99-8b2f-6f4c9be8a3f1"), new Guid("5a9e3cec-9d4b-441b-8776-e7c353372da0"), 300, "Salat Asr" },
                    { new Guid("acbba305-14cf-4a98-86d4-9173a8a3e3ee"), new Guid("f0f78c5d-c0ec-46be-a57f-6f76b9a6a62a"), 150, "Tarawih group 2" },
                    { new Guid("fab995a2-b87d-434f-9034-6064cca8d741"), new Guid("91d50930-716f-49b9-921a-a72a35533634"), 300, "Salat Maghreb" },
                    { new Guid("8480dfa4-0163-45be-91f4-e3f758b73bdd"), new Guid("6cb5dc33-1c10-4584-9b90-3b9361691a5d"), 150, "Tarawih group 1" },
                    { new Guid("925fa033-4173-4d9f-9ae3-1805b78c55ee"), new Guid("6cb5dc33-1c10-4584-9b90-3b9361691a5d"), 150, "Tarawih group 2" },
                    { new Guid("e6957c6f-7fa7-4391-988b-b009e160c9bc"), new Guid("2f51f61b-4b7c-48f1-a8fb-7d36e5b4d678"), 300, "Salat Fajr" },
                    { new Guid("9e5f0a21-0abb-4f1f-a95a-e2e886360f31"), new Guid("bf570802-e8fe-4ee2-b68e-4a16ff98229a"), 300, "Salat Dohr" },
                    { new Guid("84e478bd-ef18-4f88-9804-0bea413549d2"), new Guid("34a9e559-49b6-4d8b-b8f2-cdc9d32bc614"), 300, "Salat Asr" },
                    { new Guid("88279aae-4404-4919-9a1a-a631c98fd995"), new Guid("aaa9f2af-78db-40d0-afc2-6865245b4071"), 300, "Salat Maghreb" },
                    { new Guid("e31f41e3-b273-4114-8151-20ffa4c5fbad"), new Guid("3077c554-bab4-494e-999a-382acfab24e7"), 300, "Salat Ishaa" },
                    { new Guid("ebf12e67-fe24-4ad0-9fe7-dfb890c37482"), new Guid("3077c554-bab4-494e-999a-382acfab24e7"), 150, "Tarawih group 1" },
                    { new Guid("482c762f-52cd-41c7-b9ea-0387e7b0297e"), new Guid("3077c554-bab4-494e-999a-382acfab24e7"), 150, "Tarawih group 2" },
                    { new Guid("06d9ffc1-e25b-4576-aa18-314409246767"), new Guid("eb42bdaa-f8c0-4a67-aa25-7b573480bb90"), 300, "Salat Fajr" },
                    { new Guid("b70df634-6260-4e2b-9697-4c1c19386b32"), new Guid("6cb5dc33-1c10-4584-9b90-3b9361691a5d"), 300, "Salat Ishaa" },
                    { new Guid("3cc46219-8844-4255-a670-bc8bed6b9c2f"), new Guid("f0f78c5d-c0ec-46be-a57f-6f76b9a6a62a"), 150, "Tarawih group 1" },
                    { new Guid("e9917b99-88af-40b5-a0a4-c490f54eca37"), new Guid("f0f78c5d-c0ec-46be-a57f-6f76b9a6a62a"), 300, "Salat Ishaa" },
                    { new Guid("928426f0-42d5-4f23-865a-5db893b90dd8"), new Guid("c7cd424a-fd43-4f58-a8bb-2f053e5b457b"), 300, "Salat Maghreb" },
                    { new Guid("852e157b-593f-481f-bc86-522157e7b358"), new Guid("f9305dd6-ac77-437e-bbf5-f47a4dadbdf7"), 300, "Salat Dohr" },
                    { new Guid("25a669b6-7b26-46fe-b6e3-17b0b276eadd"), new Guid("7cbd0120-f5d3-4314-97b7-700e3cd5d5a4"), 300, "Salat Asr" },
                    { new Guid("39a0192a-7f4d-4108-8594-9065a76e3023"), new Guid("45816a3a-eeaa-482f-b4ff-a62ede8c86d8"), 300, "Salat Maghreb" },
                    { new Guid("5b020fb9-3f5e-4e2a-8838-c743476fe720"), new Guid("a6bcca0e-65af-42ee-9889-1c3b0acd84e7"), 300, "Salat Ishaa" },
                    { new Guid("1122c09a-8abe-4cf8-a7fd-8ec671b6631e"), new Guid("a6bcca0e-65af-42ee-9889-1c3b0acd84e7"), 150, "Tarawih group 1" },
                    { new Guid("116e9f9d-5ab9-45e2-83c7-ee9ebaab4947"), new Guid("a6bcca0e-65af-42ee-9889-1c3b0acd84e7"), 150, "Tarawih group 2" },
                    { new Guid("51d82f3f-c674-4808-8f80-345495705ec1"), new Guid("97ed2667-2ae4-434e-a29a-d85c063ad5b8"), 300, "Salat Fajr" },
                    { new Guid("291ecedc-097a-4475-860c-4497c55a3ad4"), new Guid("d90eb6ed-388e-41fa-82b6-404ef2de4e8e"), 300, "Salat Dohr" },
                    { new Guid("f85bde45-4159-4cee-9cdf-57d38a67c2b8"), new Guid("95207cb5-c3cf-4943-bceb-00ca1380581d"), 300, "Salat Asr" },
                    { new Guid("b31cacf9-5b26-429d-b7e1-e449dc5ea458"), new Guid("be9f7bd4-a492-4ac3-bc9a-82792d24a024"), 300, "Salat Maghreb" },
                    { new Guid("d067ad61-6210-426e-bf58-33ca1eb3013f"), new Guid("3b35ebcd-d5b9-40af-b1c1-4f2eb41a484a"), 300, "Salat Ishaa" },
                    { new Guid("af596d38-30f0-43be-8a8b-08a8e66b3714"), new Guid("3b35ebcd-d5b9-40af-b1c1-4f2eb41a484a"), 150, "Tarawih group 1" },
                    { new Guid("8daa86e0-308d-4808-8ffe-c3e139779e0b"), new Guid("3b35ebcd-d5b9-40af-b1c1-4f2eb41a484a"), 150, "Tarawih group 2" },
                    { new Guid("a32c772d-6cd4-4ad7-845b-27218767c594"), new Guid("81d76017-fd1b-49ce-bfd3-ecfa7076e6eb"), 300, "Salat Fajr" },
                    { new Guid("794fa24f-bf4d-4a26-b9c2-ec58bab43292"), new Guid("8923c352-6c7b-44a4-ba98-d8391cb0f982"), 300, "Salat Dohr" },
                    { new Guid("ac0271a5-6045-48af-8b1d-2b0c1a4263fe"), new Guid("dfbf35c7-8cf0-4023-9048-a7b647cba0c2"), 300, "Salat Asr" },
                    { new Guid("c094bf15-7e99-4674-b4d1-ebcfa2e3f17f"), new Guid("b2dac0e9-d57c-4794-832b-d323e08e09e7"), 300, "Salat Maghreb" },
                    { new Guid("bd569634-190e-46b4-82c5-dd3fa672d4fe"), new Guid("4c19ee3c-a35c-4e5e-88ad-a43995c37e54"), 300, "Salat Ishaa" },
                    { new Guid("593182f3-d46a-46e1-ae2a-0ad5da4f5216"), new Guid("4c19ee3c-a35c-4e5e-88ad-a43995c37e54"), 150, "Tarawih group 1" },
                    { new Guid("2945b9a5-6f20-4e5a-904e-037eb33ff0a7"), new Guid("4c19ee3c-a35c-4e5e-88ad-a43995c37e54"), 150, "Tarawih group 2" },
                    { new Guid("8ddacfd7-3365-46c3-83c7-5497a5ef0abd"), new Guid("aa25cda7-e938-4697-a0f6-9a818687ecba"), 300, "Salat Fajr" },
                    { new Guid("edd4bf84-6145-4c79-90ca-9b66a89f3efe"), new Guid("2b137fcc-acbf-4eb3-b06c-89656be85582"), 300, "Salat Dohr" },
                    { new Guid("5942da53-49b5-4ef6-b17a-a7b8dcfe8f0b"), new Guid("7c788bab-b5ca-4666-8b74-6e6219444c8a"), 300, "Salat Asr" },
                    { new Guid("299753fa-fc3b-4fa1-bc32-15e03420eb96"), new Guid("4b707a26-f417-43f6-abbf-f6ced0ea031a"), 300, "Salat Dohr" },
                    { new Guid("8249fc65-5f27-4499-a989-08bea9625b15"), new Guid("9d0e7061-5b81-4ff5-aebc-58c07a52ca14"), 150, "Tarawih group 1" },
                    { new Guid("ca712a5c-b916-4afd-8770-c77ca6b9b570"), new Guid("67b7998f-f1aa-43e3-97f0-320bdbf46ece"), 300, "Salat Asr" },
                    { new Guid("3455889e-3842-471e-91e9-356f58590d8a"), new Guid("cb50d2e5-64a2-4ccc-94bb-363e3ca7ca86"), 300, "Salat Ishaa" },
                    { new Guid("2776fc5d-1f47-4b74-9d40-6d3bc204ac86"), new Guid("235b4a3e-93af-45ee-b2d4-b3d9423afc47"), 300, "Salat Ishaa" },
                    { new Guid("25d990a2-85ab-4f2a-93cd-4866abb50825"), new Guid("235b4a3e-93af-45ee-b2d4-b3d9423afc47"), 150, "Tarawih group 1" },
                    { new Guid("e647e19d-9d6d-4b84-8f28-b671ca555a7a"), new Guid("235b4a3e-93af-45ee-b2d4-b3d9423afc47"), 150, "Tarawih group 2" },
                    { new Guid("1e1cb49f-b018-4ed0-a812-4abf5acd71a2"), new Guid("614cb404-ad58-4d99-bf3b-7feccd3f2763"), 300, "Salat Fajr" },
                    { new Guid("9fb28029-9caa-41c3-b3bc-5cdc814cc1ed"), new Guid("3dfd1e3d-8391-4184-9d26-1ee85591e65b"), 300, "Salat Dohr" },
                    { new Guid("b0046bef-b4a6-4c1e-8c69-2e0495f25114"), new Guid("eb13ae68-4c2b-4fdf-a464-1d7e8b05176a"), 300, "Salat Asr" },
                    { new Guid("baa74226-077c-4312-9bae-037393d58327"), new Guid("25045b91-1951-4501-bd8b-217b1bc7cadf"), 300, "Salat Maghreb" },
                    { new Guid("3bb095ef-d8be-492b-8a7c-862079bb590c"), new Guid("0b73769a-9eb2-463f-9bab-e9ef485e8ec9"), 300, "Salat Ishaa" },
                    { new Guid("693c99c6-b086-4962-bf04-dc7f2262543a"), new Guid("0b73769a-9eb2-463f-9bab-e9ef485e8ec9"), 150, "Tarawih group 1" },
                    { new Guid("e01303f2-ea09-4297-9553-0f45279c7ae1"), new Guid("0b73769a-9eb2-463f-9bab-e9ef485e8ec9"), 150, "Tarawih group 2" },
                    { new Guid("c30302f1-7d1e-422c-b11e-096d64dff405"), new Guid("6cbbfff3-ddc6-433d-87a5-4afdf2336ed7"), 300, "Salat Maghreb" },
                    { new Guid("18bf2f78-31fd-4bd9-a4b5-a47f94d4e623"), new Guid("01290684-5b48-4cb4-a90f-33355163752f"), 300, "Salat Fajr" },
                    { new Guid("e3f236be-7500-47d1-9c6d-6b4df49cc68b"), new Guid("d972d3e2-564c-4475-a479-189c7553a6de"), 300, "Salat Asr" },
                    { new Guid("b3f902f0-dae4-48e1-b73f-18d312aca216"), new Guid("63d9d029-cc11-47b8-acae-2aaa95e84213"), 300, "Salat Maghreb" },
                    { new Guid("48d72f9c-6adc-477a-8331-1653236f4339"), new Guid("1c035dd9-197e-437a-abe0-17c3ea17185e"), 300, "Salat Ishaa" },
                    { new Guid("c14630b3-9ee5-43e5-93ce-6fe81ae7621d"), new Guid("1c035dd9-197e-437a-abe0-17c3ea17185e"), 150, "Tarawih group 1" },
                    { new Guid("55ede5c6-ceab-4647-a0fd-d3241a43b765"), new Guid("1c035dd9-197e-437a-abe0-17c3ea17185e"), 150, "Tarawih group 2" },
                    { new Guid("f727d745-eb51-4fa6-ac80-055f82926c33"), new Guid("881033c1-28c4-4ab0-9466-eb64047204ae"), 300, "Salat Fajr" },
                    { new Guid("a5d5a035-36fe-45ba-b083-78c37cfc03d5"), new Guid("5fc3bf28-0dce-47b4-9d46-d6dae4ddd491"), 300, "Salat Dohr" },
                    { new Guid("6cf30e45-83bf-4624-9ec0-4feb7593ca42"), new Guid("18886b3b-eeda-4fe5-9274-f23cc36921bd"), 300, "Salat Asr" },
                    { new Guid("c07d4baa-88f6-449f-985d-d2a5fd627107"), new Guid("3452b941-5a4c-46fe-b195-329db0c4ce68"), 300, "Salat Maghreb" },
                    { new Guid("228ca227-c0b7-4e52-8906-f7ccae55a67e"), new Guid("07b09c0a-05a3-4e93-90f9-896d11c7a2f9"), 300, "Salat Ishaa" },
                    { new Guid("28990a45-b5f2-4f88-8750-49d841349d38"), new Guid("11dad89d-2355-439a-91e8-9b21ba5a099f"), 300, "Salat Dohr" },
                    { new Guid("f3c640d4-466d-47f9-af51-89778cf4dcb9"), new Guid("c643c1ee-e5a1-4980-abf8-ef538deeaff4"), 300, "Salat Asr" },
                    { new Guid("dc7cf64e-7b6e-4d2e-bc38-8996a5f14e02"), new Guid("230f778e-27c7-4680-811b-e368cab6d669"), 300, "Salat Dohr" },
                    { new Guid("27eb9d5d-d2ec-4613-9308-8c24f3009853"), new Guid("fa6b0e30-6a13-48a0-9120-23002bc6ab8e"), 300, "Salat Fajr" },
                    { new Guid("b0790174-c063-4be8-9f48-3d21b934b3c3"), new Guid("cb50d2e5-64a2-4ccc-94bb-363e3ca7ca86"), 150, "Tarawih group 1" },
                    { new Guid("42b76547-ac3d-4ef0-b09c-4e383df8cc8f"), new Guid("cb50d2e5-64a2-4ccc-94bb-363e3ca7ca86"), 150, "Tarawih group 2" },
                    { new Guid("04345c8a-8ba0-4c38-87d8-1a4feb87792f"), new Guid("9f714ef6-8d3c-4a2b-a7d1-b5c9adeb931a"), 300, "Salat Fajr" },
                    { new Guid("654d8021-09c4-4c55-9777-76e434ec12cf"), new Guid("74bdcf3e-4fed-46a5-8d32-d7ff2f243a36"), 300, "Salat Dohr" },
                    { new Guid("80dfb537-cfd6-440b-9fa7-7fcd1bc0945b"), new Guid("c3dbb1a1-8aa5-4e58-a3ee-9dc7f491603e"), 300, "Salat Asr" },
                    { new Guid("8fd9e3c7-1b1b-411e-8a70-b513cfff5697"), new Guid("41d4194e-51f5-4b1d-835a-253bf6ad1581"), 300, "Salat Maghreb" },
                    { new Guid("408df049-238e-485f-8209-b16bcfa3d8b4"), new Guid("6612df5b-3452-4807-96c3-f99edaed4fa9"), 300, "Salat Ishaa" },
                    { new Guid("9b872501-bf3b-4bea-b992-b3a01848802e"), new Guid("6612df5b-3452-4807-96c3-f99edaed4fa9"), 150, "Tarawih group 1" },
                    { new Guid("c2d5171d-29bf-4fea-a528-e3fbf50aba9c"), new Guid("6612df5b-3452-4807-96c3-f99edaed4fa9"), 150, "Tarawih group 2" },
                    { new Guid("c8f812c0-4089-4dce-9185-1b2b02eb35ee"), new Guid("dae32fe3-bfeb-4cdc-ae76-e11271073ecf"), 300, "Salat Fajr" },
                    { new Guid("f279800d-7edc-453e-a435-8d081b8a3f38"), new Guid("7844bd6e-926e-4199-bd4f-8673705abc2f"), 300, "Salat Dohr" },
                    { new Guid("e104699a-45af-4a01-93ae-2aabeef54ea1"), new Guid("59f08faa-cbae-479f-b68e-3a6764b130e6"), 300, "Salat Asr" },
                    { new Guid("df7e8c6c-151b-4660-89c8-0d9f8bad34e9"), new Guid("f1849e3a-110d-4323-bb0e-d2a925685a8f"), 300, "Salat Maghreb" },
                    { new Guid("5aa0e614-050a-4b99-a995-4d8db2760824"), new Guid("18946922-7a98-4921-b9f7-9365963383a5"), 300, "Salat Ishaa" },
                    { new Guid("88aa6f5a-21d2-4aed-98e5-1ce7fb0210e9"), new Guid("18946922-7a98-4921-b9f7-9365963383a5"), 150, "Tarawih group 1" },
                    { new Guid("d4fc122c-bcf9-4d44-90cf-525f39a967ae"), new Guid("18946922-7a98-4921-b9f7-9365963383a5"), 150, "Tarawih group 2" },
                    { new Guid("b6648c7d-8c45-46b4-a9fb-bd83ebdff53c"), new Guid("7883e627-cf0a-46f6-868a-2c83c0a57f52"), 300, "Salat Fajr" },
                    { new Guid("09573467-28ab-4458-b0ac-c9678047e4ad"), new Guid("12a2de14-ee7b-4d05-831a-81b0727f7cc7"), 300, "Salat Dohr" },
                    { new Guid("292b8310-f525-4fd8-9ea8-413e64fdf1e4"), new Guid("60764ff0-e205-41d7-af62-2856143ec0e5"), 300, "Salat Asr" },
                    { new Guid("e1b15713-b77a-4dfa-bbf3-2802e0384ca1"), new Guid("88aa2d8e-1b72-4dd4-83cc-a7f18e331191"), 300, "Salat Maghreb" },
                    { new Guid("380be8dd-bbb9-478f-9b2c-d4c92b64f15a"), new Guid("ac262776-2e2f-4f40-bfd1-726bdefa884e"), 300, "Salat Ishaa" },
                    { new Guid("0887148d-b85f-4ab0-8597-1f04831632bb"), new Guid("ac262776-2e2f-4f40-bfd1-726bdefa884e"), 150, "Tarawih group 1" },
                    { new Guid("493f2b0c-5143-43a3-b52a-81156a8e199f"), new Guid("ac262776-2e2f-4f40-bfd1-726bdefa884e"), 150, "Tarawih group 2" },
                    { new Guid("f2da7b7b-9e9e-46cb-885b-ed9dca522b12"), new Guid("eb36c7eb-95b4-44aa-9e29-53394fb0c962"), 300, "Salat Maghreb" },
                    { new Guid("dbfba2ee-53fa-4abb-9f7a-c5e312d9643c"), new Guid("9d0e7061-5b81-4ff5-aebc-58c07a52ca14"), 150, "Tarawih group 2" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("04345c8a-8ba0-4c38-87d8-1a4feb87792f"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("04c34437-c36e-44bf-815b-a890297a1ac9"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("06d9ffc1-e25b-4576-aa18-314409246767"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("085b6f5e-c678-4392-99c3-f6ea8dc2611e"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("0887148d-b85f-4ab0-8597-1f04831632bb"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("09573467-28ab-4458-b0ac-c9678047e4ad"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("0cef54ac-95e2-48c1-9ce5-45c908f89bf4"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("0f176893-92d3-46b3-82c8-565fe0553209"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("1122c09a-8abe-4cf8-a7fd-8ec671b6631e"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("116e9f9d-5ab9-45e2-83c7-ee9ebaab4947"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("18bf2f78-31fd-4bd9-a4b5-a47f94d4e623"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("18ec2397-ffe7-4b2a-91d8-f5d3f78d861e"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("1e1cb49f-b018-4ed0-a812-4abf5acd71a2"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("1e85a463-7751-4657-8283-6bdae6f668cd"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("21305f4f-37eb-444e-bfd9-8ae65b7bf62f"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("213ce565-0400-4f38-b1c0-c3f09d3a3550"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("228ca227-c0b7-4e52-8906-f7ccae55a67e"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("247319e9-f0b2-4362-a4e4-35c8b3328e98"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("258cebaf-3f95-494a-af95-3f4b3d6764eb"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("25a669b6-7b26-46fe-b6e3-17b0b276eadd"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("25d990a2-85ab-4f2a-93cd-4866abb50825"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("2667d472-ee9d-445d-84c8-b5f1e29c1846"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("2776fc5d-1f47-4b74-9d40-6d3bc204ac86"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("27eb9d5d-d2ec-4613-9308-8c24f3009853"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("28990a45-b5f2-4f88-8750-49d841349d38"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("291ecedc-097a-4475-860c-4497c55a3ad4"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("292b8310-f525-4fd8-9ea8-413e64fdf1e4"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("2945b9a5-6f20-4e5a-904e-037eb33ff0a7"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("2949f2d9-6e4f-4ad6-9fed-9837a6544789"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("2960b982-c8a0-4672-93cb-79d343988334"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("299753fa-fc3b-4fa1-bc32-15e03420eb96"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("2be181b4-5cce-43cf-822c-9b4731a60c35"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("2c59936c-1cd0-4f19-903a-98f08f698584"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("2d89f093-5c41-4aec-a2bb-e008d5f1842c"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("2e71b4e4-bcf5-466a-9c8e-f54e5ed49985"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("3455889e-3842-471e-91e9-356f58590d8a"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("373a8caf-acdf-4759-ab0c-b92358958c1b"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("37cff3ce-7180-4589-9bfb-6620aaf33375"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("380be8dd-bbb9-478f-9b2c-d4c92b64f15a"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("39a0192a-7f4d-4108-8594-9065a76e3023"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("3aa2044f-bbd4-4024-ac0e-164960751182"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("3bb095ef-d8be-492b-8a7c-862079bb590c"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("3cc46219-8844-4255-a670-bc8bed6b9c2f"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("3f536583-c118-4247-b603-5441ad62533a"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("3ff13791-f424-408d-bf62-6dc39eae907e"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("408df049-238e-485f-8209-b16bcfa3d8b4"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("40a87b4c-c54e-40b6-b053-875a5d324eea"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("42b76547-ac3d-4ef0-b09c-4e383df8cc8f"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("470e9812-7134-4dc3-abe9-88319c7a5b7a"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("482c762f-52cd-41c7-b9ea-0387e7b0297e"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("48d72f9c-6adc-477a-8331-1653236f4339"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("493f2b0c-5143-43a3-b52a-81156a8e199f"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("4a68ba54-c1ea-4969-8221-dc8969d11f78"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("4a7716af-d82f-467e-8f30-e99eda8c31ac"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("4c92b7a3-c645-4f17-8ad9-04b21095428e"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("51d82f3f-c674-4808-8f80-345495705ec1"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("527a9557-e76b-4b57-b979-c170d25d874c"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("52a10189-e61d-4253-ba6e-b400f0c79cd4"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("5445a828-d2ee-4de1-a53c-3c9315936136"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("55ede5c6-ceab-4647-a0fd-d3241a43b765"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("5654b3f2-feb4-45e9-97a2-68dbde52ff7b"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("593182f3-d46a-46e1-ae2a-0ad5da4f5216"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("5942da53-49b5-4ef6-b17a-a7b8dcfe8f0b"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("59e54654-9fd7-4d1a-8e9e-d1cc0284881c"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("5a1ab1d1-83e1-4dd3-b988-e02488267858"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("5aa0e614-050a-4b99-a995-4d8db2760824"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("5b020fb9-3f5e-4e2a-8838-c743476fe720"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("5c6be910-3fff-484e-a3ca-4381383be29b"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("5cbe5abb-3c42-474c-950c-b480e833ddc5"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("5d8aca73-1264-4c72-bbd5-62221d131766"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("5d92c5df-850e-4571-bbc3-34ba4a530bb8"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("5f62d69e-16d6-41b8-a52e-96464f6617a3"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("602122f3-af1c-4101-9c0a-38339c62a966"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("60e9b54c-812b-40fe-8285-31148241097e"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("618b9407-36bb-4a6c-a767-02340389cec1"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("61bb932b-fa86-44dd-b482-0c8172df6ebe"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("63846194-f825-48bc-bcd6-8315b4ee744d"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("64d02d05-5663-436a-a8d6-d36ccfe79c64"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("654d8021-09c4-4c55-9777-76e434ec12cf"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("66ef5809-1cd3-4a46-a2cf-ccf0fc696786"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("673f8937-ed78-45f2-afbb-ff25db77d0df"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("6774f3bc-3f70-4ccb-aa85-df3e92fe45ad"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("6868e57d-4c8b-4f8d-a5b6-594e0faadbf7"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("68e2a409-3ad1-4cec-9c83-8a5858a8cda2"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("693c99c6-b086-4962-bf04-dc7f2262543a"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("6cf30e45-83bf-4624-9ec0-4feb7593ca42"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("715b26f7-6409-4370-993b-72ac178d2f99"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("730eed76-b34c-4b9a-bf9f-6d6fe120b974"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("73633641-a4a7-42dc-ac36-bc413435bd11"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("78b6c27d-6894-406a-840c-4a5a85e42b22"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("794fa24f-bf4d-4a26-b9c2-ec58bab43292"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("7c77e53e-5993-47f5-a867-8689ad6c820b"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("7de6f8df-79ff-402e-aba7-b61b3f5c1de2"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("7e2355c0-f10b-4001-be66-7dc297bf32cc"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("7fc24f9c-9ffc-4079-8670-d5f4994304a0"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("80dfb537-cfd6-440b-9fa7-7fcd1bc0945b"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("82031797-f168-4121-b3e9-bc8345d021b7"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("8249fc65-5f27-4499-a989-08bea9625b15"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("836f5ebe-810f-48e4-9256-9d9ef63fcfa4"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("8480dfa4-0163-45be-91f4-e3f758b73bdd"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("84e478bd-ef18-4f88-9804-0bea413549d2"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("84e7a015-15fb-43ba-b84d-60fba375d534"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("852e157b-593f-481f-bc86-522157e7b358"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("858ec4c1-55db-4e43-a6da-40c8c2efd74f"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("85a690f1-b77f-42a4-9f3e-bd0fe77e4373"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("88279aae-4404-4919-9a1a-a631c98fd995"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("88556579-965e-432c-a2dd-0abcfb5f8e5e"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("88aa6f5a-21d2-4aed-98e5-1ce7fb0210e9"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("8daa86e0-308d-4808-8ffe-c3e139779e0b"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("8ddacfd7-3365-46c3-83c7-5497a5ef0abd"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("8fd9e3c7-1b1b-411e-8a70-b513cfff5697"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("925fa033-4173-4d9f-9ae3-1805b78c55ee"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("928426f0-42d5-4f23-865a-5db893b90dd8"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("93908ffe-45d8-4b99-8b2f-6f4c9be8a3f1"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("9721c808-fb8b-4e86-aaa7-640fa31aaf6f"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("97b6d0f1-554c-4e8e-aa76-eed014f4889e"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("9a54d142-905a-4597-b7b8-435bc99254f0"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("9b1ac8b5-6d7f-4cbd-8f20-c9663f2e053a"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("9b4789c3-b03d-4397-9cba-e025cf337ff0"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("9b872501-bf3b-4bea-b992-b3a01848802e"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("9e5f0a21-0abb-4f1f-a95a-e2e886360f31"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("9e89cbdc-746e-4b56-9963-5809043dbd54"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("9fb28029-9caa-41c3-b3bc-5cdc814cc1ed"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("a111ccad-44d4-4bda-80bb-3ecfa56a9096"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("a32c772d-6cd4-4ad7-845b-27218767c594"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("a3bf84d4-a581-456d-b94b-3efc22976b5b"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("a5d5a035-36fe-45ba-b083-78c37cfc03d5"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("a6537c89-ceb0-4fee-9e7c-c867e788d7c1"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("a812e848-96b9-4df1-9d29-be08886e3ecb"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("a96231a2-c532-49fa-9b6b-19c19e52e293"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("ac0271a5-6045-48af-8b1d-2b0c1a4263fe"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("acbba305-14cf-4a98-86d4-9173a8a3e3ee"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("af0a7fba-a6bd-488a-80ee-fb22e4df12b3"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("af596d38-30f0-43be-8a8b-08a8e66b3714"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("b0046bef-b4a6-4c1e-8c69-2e0495f25114"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("b0790174-c063-4be8-9f48-3d21b934b3c3"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("b31cacf9-5b26-429d-b7e1-e449dc5ea458"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("b3f902f0-dae4-48e1-b73f-18d312aca216"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("b4899844-aa7b-4dd7-92d4-6add40134edd"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("b5aac432-780c-44ef-8fba-7888106523b8"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("b6648c7d-8c45-46b4-a9fb-bd83ebdff53c"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("b6add5ec-5c57-444d-899e-f21b7a25c681"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("b70df634-6260-4e2b-9697-4c1c19386b32"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("b7951cf6-5f10-41b9-a543-26582ccde5cf"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("b995ea99-8994-461b-b146-cbc669bfb16f"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("baa74226-077c-4312-9bae-037393d58327"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("bb5e0f19-8137-4d13-a72e-de904ffb205f"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("bd569634-190e-46b4-82c5-dd3fa672d4fe"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("bd69e10e-8b28-4000-b259-2c9d8f4057b7"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("be3cbad7-050a-43eb-b54f-41c2de6b89c1"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("be776f90-520b-4ab2-a7eb-52fce1091072"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("bf0b0deb-21ef-4cf3-a0de-c0c712a68262"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("bfcd1c55-8853-48a5-b627-aae3cdc97c04"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("c07d4baa-88f6-449f-985d-d2a5fd627107"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("c094bf15-7e99-4674-b4d1-ebcfa2e3f17f"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("c14630b3-9ee5-43e5-93ce-6fe81ae7621d"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("c1a4104b-d5d3-4ce8-ab96-c2586bb07492"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("c2d5171d-29bf-4fea-a528-e3fbf50aba9c"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("c30302f1-7d1e-422c-b11e-096d64dff405"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("c53f1b8b-a406-4228-9cc6-845929a8a691"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("c8f812c0-4089-4dce-9185-1b2b02eb35ee"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("ca712a5c-b916-4afd-8770-c77ca6b9b570"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("d067ad61-6210-426e-bf58-33ca1eb3013f"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("d4fc122c-bcf9-4d44-90cf-525f39a967ae"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("d59fae55-bcd5-4f6a-8b66-33a095e12dfa"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("d6cc9b95-b70a-4b7a-97fa-4be3d19fdf47"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("d7f9a59d-6695-4cda-82b4-a53d6012ebc1"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("d8dfc91d-e85a-466b-88ec-5fe88da22b8c"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("dbfba2ee-53fa-4abb-9f7a-c5e312d9643c"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("dc553756-775a-4b7b-be3f-d74acf79e151"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("dc7cf64e-7b6e-4d2e-bc38-8996a5f14e02"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("de7bf3b2-63b7-4fc2-8dcb-960c7c2a79aa"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("df7e8c6c-151b-4660-89c8-0d9f8bad34e9"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("e01303f2-ea09-4297-9553-0f45279c7ae1"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("e0a4b34e-5215-42b1-a0f5-6eeda341e885"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("e104699a-45af-4a01-93ae-2aabeef54ea1"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("e1b15713-b77a-4dfa-bbf3-2802e0384ca1"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("e31f41e3-b273-4114-8151-20ffa4c5fbad"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("e3f236be-7500-47d1-9c6d-6b4df49cc68b"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("e5a32997-f062-4b04-bbee-67be17db81ff"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("e647e19d-9d6d-4b84-8f28-b671ca555a7a"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("e64e7d90-a416-48d0-bd8e-7441390e0132"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("e6957c6f-7fa7-4391-988b-b009e160c9bc"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("e9917b99-88af-40b5-a0a4-c490f54eca37"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("eb008ca2-1e9e-4b85-a4c6-4130d80f99be"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("ebf12e67-fe24-4ad0-9fe7-dfb890c37482"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("ece2300e-dab5-42df-bc5a-2e0640cb5dec"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("edd4bf84-6145-4c79-90ca-9b66a89f3efe"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("ee63da46-683b-459d-9578-da703882663e"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("f129631e-0bc7-4996-bf77-ea473c02688e"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("f163dc4b-8184-4699-bec0-f80adc44f6f3"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("f279800d-7edc-453e-a435-8d081b8a3f38"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("f2886c50-af66-495e-9a23-3e20fdff6037"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("f2da7b7b-9e9e-46cb-885b-ed9dca522b12"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("f2f895af-5e1c-4302-b225-13d5a235374b"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("f3c640d4-466d-47f9-af51-89778cf4dcb9"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("f4a74977-6fa6-4066-9465-0ce6a12d398e"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("f5679cf6-ff25-4555-8476-c34326ce8a3d"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("f5b77341-8d51-457a-96e0-e8f4bab39306"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("f727d745-eb51-4fa6-ac80-055f82926c33"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("f85bde45-4159-4cee-9cdf-57d38a67c2b8"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("f8be926d-d3af-4343-9fbb-c9d2c3f8a5c7"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("f94975a4-e9cb-4254-a694-9ae538b62da7"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("fa4d7234-afff-4b69-9520-efb62651eff4"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("fab995a2-b87d-434f-9034-6064cca8d741"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("fb925bb9-f9e9-4028-aebb-e346fbc910c3"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("fcca1dbf-8310-4f75-82aa-cec747679713"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("fccb795c-0639-49aa-9840-b83f8f383bbc"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("ff7a8d1a-e741-4e28-ba04-aa718f950405"));

            migrationBuilder.DeleteData(
                table: "Group",
                keyColumn: "Id",
                keyValue: new Guid("ffddb558-aab2-4e28-a17a-a53fe962869c"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("01290684-5b48-4cb4-a90f-33355163752f"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("07b09c0a-05a3-4e93-90f9-896d11c7a2f9"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("093dae4a-a6d4-4099-b8c3-52788ede324d"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("098989db-0143-4462-b703-302602ae7da5"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("0b73769a-9eb2-463f-9bab-e9ef485e8ec9"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("0b9b14e7-7ef2-4986-9bb2-134f4517cda7"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("0cb52daf-1e53-429c-b010-aa22f45e389d"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("10502b56-a649-41d5-89ce-56933bc09708"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("116fc02a-e323-4ae4-97eb-b199a5228d83"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("11dad89d-2355-439a-91e8-9b21ba5a099f"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("12a2de14-ee7b-4d05-831a-81b0727f7cc7"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("15e9ae17-d948-4c79-b8d1-e353545296e0"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("18886b3b-eeda-4fe5-9274-f23cc36921bd"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("18946922-7a98-4921-b9f7-9365963383a5"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("1916b7ad-e782-469d-aacf-ec0678000da3"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("1a649a43-bc16-4721-b291-4347df54aa49"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("1c02e3b9-efe2-4d99-a177-826fddff50bf"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("1c035dd9-197e-437a-abe0-17c3ea17185e"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("1c05bba3-ed58-4f2c-b41c-03872fe2db86"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("1f77ddb3-2341-4dc5-aecd-4780c3961b6f"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("230f778e-27c7-4680-811b-e368cab6d669"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("235b4a3e-93af-45ee-b2d4-b3d9423afc47"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("23ff0cbc-891b-4faf-a8f2-e93ee119cb91"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("25045b91-1951-4501-bd8b-217b1bc7cadf"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("25c4d172-1f3d-4fa2-9290-9d26c6e2cb68"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("29938e42-2c4e-4c00-8e8a-16aa01fe7c88"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("2a8569af-1ee4-4719-b3de-0585a2142e73"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("2b137fcc-acbf-4eb3-b06c-89656be85582"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("2b25c08a-0de7-4ac0-88b1-41a22f91d245"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("2bc8bc63-209c-421b-81d5-535e2c0d19cf"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("2f51f61b-4b7c-48f1-a8fb-7d36e5b4d678"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("3077c554-bab4-494e-999a-382acfab24e7"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("307fc466-e5a3-4fd7-959e-f4493183f7b8"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("34092974-73a3-4fc9-b1b4-2cf7e2ef5408"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("3452b941-5a4c-46fe-b195-329db0c4ce68"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("34a9e559-49b6-4d8b-b8f2-cdc9d32bc614"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("3500cf7a-e76c-437d-8ec7-f094a94c5e0f"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("3786db35-4b3a-4be8-8a1d-109b7337c609"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("3b35ebcd-d5b9-40af-b1c1-4f2eb41a484a"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("3c0619bf-7500-4e5f-bf4c-138e00f19674"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("3dfd1e3d-8391-4184-9d26-1ee85591e65b"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("4091b872-9ffc-4589-8420-376fdf303d93"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("41d4194e-51f5-4b1d-835a-253bf6ad1581"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("45816a3a-eeaa-482f-b4ff-a62ede8c86d8"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("4b707a26-f417-43f6-abbf-f6ced0ea031a"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("4bafd0b1-3022-48e3-bfd8-f3c629215cf6"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("4c19ee3c-a35c-4e5e-88ad-a43995c37e54"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("4e05d1f5-ee71-4e6d-b36e-d769a0cbd182"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("4e82f8cb-95d7-4584-9d8e-6d362937774e"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("4ed32862-e448-4d01-bc4c-976957059aef"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("51009bcb-d7fb-46db-9bc3-161efc2a5936"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("51491cac-e7c8-4926-9c24-a90bd1b74cff"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("588e0f53-f5d9-4116-a80d-f28099731e3f"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("59f08faa-cbae-479f-b68e-3a6764b130e6"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("5a9e3cec-9d4b-441b-8776-e7c353372da0"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("5b12bc99-b9c3-4541-b0f9-7b32c066f083"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("5b874499-d7fa-4a1a-bd36-49751b120f87"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("5fc3bf28-0dce-47b4-9d46-d6dae4ddd491"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("60764ff0-e205-41d7-af62-2856143ec0e5"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("614cb404-ad58-4d99-bf3b-7feccd3f2763"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("61599e99-ac04-4f4d-a977-12ca37169cac"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("6285c45a-a15c-456e-908b-6b05f497ea61"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("63d9d029-cc11-47b8-acae-2aaa95e84213"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("6612df5b-3452-4807-96c3-f99edaed4fa9"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("67b7998f-f1aa-43e3-97f0-320bdbf46ece"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("6cb5dc33-1c10-4584-9b90-3b9361691a5d"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("6cbbfff3-ddc6-433d-87a5-4afdf2336ed7"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("6e28b4eb-5ff6-490d-9511-c133b2f8a5e9"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("6ec7d47b-bf47-4229-a0f6-2547207d860c"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("70c0fd74-4688-407b-a583-3aa993814e3a"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("7210fd84-7fb1-42b7-8b13-3fbf65677080"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("74bdcf3e-4fed-46a5-8d32-d7ff2f243a36"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("77c41813-5fc8-4b12-9e3f-df5ea6e1c2b6"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("7844bd6e-926e-4199-bd4f-8673705abc2f"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("7883e627-cf0a-46f6-868a-2c83c0a57f52"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("78d16281-195a-4b84-bb3d-1ea15b01321e"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("7c788bab-b5ca-4666-8b74-6e6219444c8a"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("7cbd0120-f5d3-4314-97b7-700e3cd5d5a4"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("7d576624-a377-490d-8cf1-4fe59a195032"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("7df25dad-8737-492c-b371-72ff1c140ee2"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("81d76017-fd1b-49ce-bfd3-ecfa7076e6eb"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("881033c1-28c4-4ab0-9466-eb64047204ae"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("88aa2d8e-1b72-4dd4-83cc-a7f18e331191"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("8923c352-6c7b-44a4-ba98-d8391cb0f982"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("8db45cdd-210f-4e91-a578-068938cf3f9a"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("90f36610-46fc-4eb1-8060-55e743d7330d"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("91d50930-716f-49b9-921a-a72a35533634"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("94569c07-1269-448b-ac8a-9d19bd75cbf4"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("95207cb5-c3cf-4943-bceb-00ca1380581d"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("959a3ecd-3834-40bb-8936-b94da0852314"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("96b0db43-1cd1-4980-9038-0adf1fce8df9"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("97ed2667-2ae4-434e-a29a-d85c063ad5b8"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("98fbcdb2-83bf-43e3-95f7-676bb9ff1c8d"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("9af75da3-eede-49c2-b5d9-ca7482c82db7"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("9d0e7061-5b81-4ff5-aebc-58c07a52ca14"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("9f714ef6-8d3c-4a2b-a7d1-b5c9adeb931a"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("a6bcca0e-65af-42ee-9889-1c3b0acd84e7"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("a7f0cfab-f1e2-4c06-ae4c-69d326a9e7b7"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("a7ff7211-1621-4a32-9cc0-4c23804f2e4e"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("a87f9044-8fca-422e-b998-9d86bd6855aa"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("aa25cda7-e938-4697-a0f6-9a818687ecba"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("aaa9f2af-78db-40d0-afc2-6865245b4071"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("ac262776-2e2f-4f40-bfd1-726bdefa884e"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("ae775912-0927-4e4d-83fe-a2497c775873"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("b2dac0e9-d57c-4794-832b-d323e08e09e7"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("b667a254-17d0-4cba-ae64-d80dbf66e823"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("b8f6e4d5-ba83-453d-b0e2-e1e2f7e335cc"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("be9f7bd4-a492-4ac3-bc9a-82792d24a024"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("bf570802-e8fe-4ee2-b68e-4a16ff98229a"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("c3dbb1a1-8aa5-4e58-a3ee-9dc7f491603e"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("c3ea650f-afe6-4090-bd1a-508a35e502e2"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("c5975b5a-02bd-49e2-acbc-80ab2220f621"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("c643c1ee-e5a1-4980-abf8-ef538deeaff4"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("c7cd424a-fd43-4f58-a8bb-2f053e5b457b"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("cb50d2e5-64a2-4ccc-94bb-363e3ca7ca86"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("cb99a928-41e3-436d-8d85-e2fa1bda08fa"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("ce297c6e-ec4e-490f-9a2e-628628729288"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("d0c36ad4-5c38-4037-bfe0-5fd20669387d"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("d0d2f413-5277-421e-8f0a-1ed1fc160f9e"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("d10ec7be-0456-4ff2-97d3-37a02793d2b1"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("d129e310-fd48-4e52-b95c-e78f9c8cde98"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("d6d8a190-0aea-4c1b-b707-1645708796ee"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("d7c13f36-a59a-4877-a809-5bbe20f164b1"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("d90eb6ed-388e-41fa-82b6-404ef2de4e8e"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("d959ea3a-33c5-49f0-814f-221a55014606"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("d972d3e2-564c-4475-a479-189c7553a6de"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("dae32fe3-bfeb-4cdc-ae76-e11271073ecf"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("dd694a91-75ec-46a3-acb4-d78a199616d2"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("de6381e6-2a31-48b0-8dce-fbc1aa4de0ad"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("df43fd65-0fe1-4830-a90a-12e981b4881d"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("dfbf35c7-8cf0-4023-9048-a7b647cba0c2"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("e0d2d220-5b0b-4428-8d3b-cdf4e6e8a050"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("e1b45a68-0175-42b7-a933-c7ea2ce83006"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("e3a94711-1c11-4b85-b75a-524552b69a8c"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("e5208ae9-8c72-4a46-a8fb-ae91be93eb96"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("e6fcf2bf-2ad0-48d9-af8a-7955e9591aee"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("eb13ae68-4c2b-4fdf-a464-1d7e8b05176a"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("eb36c7eb-95b4-44aa-9e29-53394fb0c962"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("eb42bdaa-f8c0-4a67-aa25-7b573480bb90"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("ef8b6c51-e6d1-49d8-87c8-969f66b37eda"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("f02831fb-ab03-459e-89d7-b48aa245eeb9"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("f0f78c5d-c0ec-46be-a57f-6f76b9a6a62a"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("f1849e3a-110d-4323-bb0e-d2a925685a8f"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("f208cfa2-7185-44a0-b6d0-dbfb15ad3075"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("f9305dd6-ac77-437e-bbf5-f47a4dadbdf7"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("fa6b0e30-6a13-48a0-9120-23002bc6ab8e"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("fbbd0bd8-584e-4660-a47f-f8d90719fe7f"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("fc686a00-6617-4018-bdb0-de06d622dd68"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("fce6209d-e52b-4fab-a9f7-14e79b2e891b"));

            migrationBuilder.DeleteData(
                table: "Event",
                keyColumn: "Id",
                keyValue: new Guid("fd590dab-81a6-45fe-b317-ac207db51809"));

            migrationBuilder.InsertData(
                table: "Event",
                columns: new[] { "Id", "Date", "Description", "EventTypeId" },
                values: new object[,]
                {
                    { new Guid("ee48fa11-be9a-4885-a244-98a0aedfbea5"), new DateTime(2021, 4, 15, 0, 36, 25, 675, DateTimeKind.Local).AddTicks(1723), "", new Guid("d5d109a9-ac86-40ef-a783-b3c0b8fefaa1") },
                    { new Guid("802e14d4-7c79-4740-aefc-6bf5b412129c"), new DateTime(2021, 4, 15, 0, 36, 25, 675, DateTimeKind.Local).AddTicks(9009), "", new Guid("d5d109a9-ac86-40ef-a783-b4c0b8fefaa1") },
                    { new Guid("513a6d9e-b4ee-4299-a945-241428be5114"), new DateTime(2021, 4, 15, 0, 36, 25, 675, DateTimeKind.Local).AddTicks(9026), "", new Guid("d5d109a9-ac86-40ef-a783-b5c0b8fefaa1") },
                    { new Guid("4ae8d4f8-7444-4aa5-9a80-af1c89f46805"), new DateTime(2021, 4, 15, 0, 36, 25, 675, DateTimeKind.Local).AddTicks(9029), "", new Guid("d5d109a9-ac86-40ef-a783-b6c0b8fefaa1") },
                    { new Guid("c23ed31c-5ddc-4993-8b39-7665f43b7fd9"), new DateTime(2021, 4, 15, 0, 36, 25, 675, DateTimeKind.Local).AddTicks(9031), "", new Guid("d5d109a9-ac86-40ef-a783-b7c0b8fefaa1") }
                });

            migrationBuilder.UpdateData(
                table: "TemporaryAuthenticators",
                keyColumn: "Id",
                keyValue: 1,
                column: "Token",
                value: new Guid("7161863a-b4eb-4fe0-880a-0f96f384d87e"));

            migrationBuilder.InsertData(
                table: "Group",
                columns: new[] { "Id", "EventId", "MaxPlaces", "Name" },
                values: new object[,]
                {
                    { new Guid("4a113557-d989-4243-af30-4d6906ce02de"), new Guid("ee48fa11-be9a-4885-a244-98a0aedfbea5"), 300, "Salat Fajr" },
                    { new Guid("cf35efea-96a1-4f3a-943d-ae8389fb7337"), new Guid("802e14d4-7c79-4740-aefc-6bf5b412129c"), 300, "Salat Dohr" },
                    { new Guid("2740bdfd-d621-4f42-9ae5-34e24ddc4e85"), new Guid("513a6d9e-b4ee-4299-a945-241428be5114"), 300, "Salat Asr" },
                    { new Guid("a482283f-291a-43bd-8b88-6a4838e96998"), new Guid("4ae8d4f8-7444-4aa5-9a80-af1c89f46805"), 300, "Salat Maghreb" },
                    { new Guid("b5d9b806-d791-440a-b773-8380b7d237bd"), new Guid("c23ed31c-5ddc-4993-8b39-7665f43b7fd9"), 300, "Salat Ishaa" },
                    { new Guid("3be97c6d-7a78-44df-b1a7-2f7a035600c6"), new Guid("c23ed31c-5ddc-4993-8b39-7665f43b7fd9"), 150, "Tarawih group 1" },
                    { new Guid("b450b7fa-7104-4cc1-9b4e-a15c639ca61e"), new Guid("c23ed31c-5ddc-4993-8b39-7665f43b7fd9"), 150, "Tarawih group 2" }
                });
        }
    }
}
