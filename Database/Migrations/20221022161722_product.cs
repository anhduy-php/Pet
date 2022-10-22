using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Database.Migrations
{
    public partial class product : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PettInBill",
                keyColumns: new[] { "pib_BillId", "pib_PetId" },
                keyValues: new object[] { "bc8eee77-d226-4dbc-9c3c-575e45b4757e", "36360661-1c4b-474c-bcbf-66c16b42b357" });

            migrationBuilder.DeleteData(
                table: "ProductInBill",
                keyColumns: new[] { "proib_BillId", "proib_ProductId" },
                keyValues: new object[] { "bc8eee77-d226-4dbc-9c3c-575e45b4757e", "63886122-64fe-4633-990c-b55ed47f7f57" });

            migrationBuilder.DeleteData(
                table: "UserContact",
                keyColumn: "uc_Id",
                keyValue: "828bee48-2436-4574-ae27-cf75b61ccf8b");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ddc955b7-6138-47b1-aa53-bc7f25d26af6", "dc9c6d40-ada5-4b54-bf17-e7955fbe204b" });

            migrationBuilder.DeleteData(
                table: "Bills",
                keyColumn: "bill_Id",
                keyValue: "bc8eee77-d226-4dbc-9c3c-575e45b4757e");

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "pet_Id",
                keyValue: "36360661-1c4b-474c-bcbf-66c16b42b357");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_Id",
                keyValue: "63886122-64fe-4633-990c-b55ed47f7f57");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "ddc955b7-6138-47b1-aa53-bc7f25d26af6");

            migrationBuilder.DeleteData(
                table: "PetCategories",
                keyColumn: "pc_Id",
                keyValue: "0beac127-fe68-4eb4-8536-d03663de191f");

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "proc_Id",
                keyValue: "256df248-d68c-4bfe-beef-3530f7d0b65c");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "dc9c6d40-ada5-4b54-bf17-e7955fbe204b");

            migrationBuilder.AddColumn<string>(
                name: "product_Image1",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "product_Image2",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "product_Image3",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "product_Image4",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "product_Image5",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "pet_Image1",
                table: "Pets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "pet_Image2",
                table: "Pets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "pet_Image3",
                table: "Pets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "pet_Image4",
                table: "Pets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "pet_Image5",
                table: "Pets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "PetCategories",
                columns: new[] { "pc_Id", "pc_Description", "pc_IsDelete", "pc_Name" },
                values: new object[,]
                {
                    { "0edd9af8-634d-4dfe-8f68-3f6a4f649f8a", "Pho Deer", false, "Pho Deer" },
                    { "101f2f0b-7634-43ce-b9cf-01b06bae6b86", "Alaska", false, "Alaska" },
                    { "183b7352-ad15-4fa7-967c-c2639e1adcb3", "Husky", false, "Husky" },
                    { "18905cfe-2b9e-43ce-8f6b-b5714e7b5803", "Vitespitz", false, "Vitespitz" },
                    { "25dafb34-a58e-4757-a3e9-35b9ab226a88", "Golden Retriever", false, "Golden Retriever" },
                    { "2c76ff0f-f000-4ccd-903a-dd81b8386391", "Shiba Inu", false, "Shiba Inu" },
                    { "3596fe4a-998f-417d-878d-6b82073fe30c", "Pug", false, "Pug" },
                    { "38822d47-f05e-484f-9af4-5d1334ddb01e", "H'Mong Coc", false, "H'Mong Coc" },
                    { "4750bd6e-3013-439d-9147-458fb635a26c", "Phu Quoc", false, "Phu Quoc" },
                    { "4b7c3ed1-1560-41a3-99b6-43ce7cd5a136", "Samoyed", false, "Samoyed" },
                    { "5fac894a-a012-4abc-941b-c097ee7a2fe1", "Ikita Inu", false, "Ikita Inu" },
                    { "6432edba-2d75-4485-884f-c19e221cbbac", "Dalmatian", false, "Dalmatian" },
                    { "77e950ee-45de-45b4-b415-6a83b1c28500", "Cocker Spaniel", false, "Cocker Spaniel" },
                    { "7a859a9b-8ef6-4519-a36e-4d5c008c3380", "Phoc Soc", false, "Phoc Soc" },
                    { "7a8a923e-26d5-40ee-aaab-1f1755f5ed0a", "Sausage", false, "Sausage" },
                    { "8637cef8-dd50-4fcc-ab09-902d8db07f44", "Labrador", false, "Labrador" },
                    { "8daf3fdf-f65a-4221-ace2-d117f2db8508", "Border collie", false, "Border collie" },
                    { "8fb6624f-b9e6-4cd1-8e19-bbacbc8ffc9a", "Bulldog", false, "Bulldog" },
                    { "9e97181b-b251-409f-bbaa-6fcb797ef03c", "Dobermann", false, "Dobermann" },
                    { "b506f21e-e608-417b-90b5-012c3ca93db1", "Tibetan Clams", false, "Tibetan Clams" },
                    { "bb6b5a90-b5e1-452d-b39a-c90f46184515", "Rottweiler", false, "Rottweiler" },
                    { "bea8fcc8-3ed8-4f23-8f9d-e8b9ad5be0e5", "Becgie Germany", false, "Becgie Germany" },
                    { "c0deabcd-59e4-4655-acc8-8a4fca01b723", "Pekingese", false, "Pekingese" },
                    { "cc70426a-f0f6-4e37-9672-9a1f5e999fde", "Pitbull", false, "Pitbull" },
                    { "d14c67d5-4a42-4221-ab15-268a0de34613", "Chihuahua", false, "Chihuahua" },
                    { "d283ff48-dfa0-41ff-8cc2-2997596fbc7e", "Malinois", false, "Malinois" },
                    { "d7f0e948-5917-4c6b-ba0b-07d579270c7f", "Great Dane", false, "Great Dane" },
                    { "dadba9e0-ee05-457a-9462-12a038b2dc9f", "Poodle", false, "Poodle" },
                    { "ddaee95e-695b-4a68-bd4a-e9d020305e71", "Chow Chow", false, "Chow Chow" },
                    { "ddfc77ba-a221-49ed-8e7c-d4efcd7f0a61", "Bully American", false, "Bully American" },
                    { "eccf607d-6302-41ee-b4e6-a36ff75f0a82", "Corgi", false, "Corgi" },
                    { "efe4cbd8-52e4-4099-a410-d5d696517fdf", "Japan Dog", false, "Japan Dog" }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "proc_Id", "proc_Description", "proc_IsDelete", "proc_Name" },
                values: new object[,]
                {
                    { "25796aad-8886-4baa-89ea-ab60e9622e32", "Pet Cage", false, "Pet Cage" },
                    { "31aee0ec-e0c5-4bed-8e70-b71befb70b25", "Pet Toys", false, "Pet Toys" },
                    { "37ff9faf-1464-4589-ac20-139f829060ef", "Nutritional Food", false, "Nutritional Food" },
                    { "73a8b868-f082-4802-a298-559c72e707e9", "Beauty Accessories", false, "Beauty Accessories" },
                    { "7530f132-1e23-4e07-b3b9-0f1a8f559c8b", "Pet Clothes", false, "Pet Clothes" },
                    { "87c52723-537d-4378-80c3-556e24822d8f", "Medicines & Functional Products", false, "Medicines & Functional Products" },
                    { "977d57c9-4b90-42bd-9c26-1ccf6aaf4005", "Pet Supplies", false, "Pet Supplies" },
                    { "d58b3306-4e7a-494a-a8c8-9fc37834a393", "Pet Food", false, "Pet Food" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Discriminator", "Name", "NormalizedName", "isDelete" },
                values: new object[] { "89543239-37ca-49b0-b35f-d78a35a5a06f", "88daf35f-b3f2-4280-b4fd-51af026a242c", "admin", "Roles", "ADMIN", "Admin", false });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "DoB", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "isDelete" },
                values: new object[] { "5db2ec3d-8bcf-4bf9-81de-4730297b2f20", 0, "c75b26b2-2526-4ea2-b068-43b77c58d8fc", "Users", new DateTime(2022, 10, 22, 23, 17, 22, 26, DateTimeKind.Local).AddTicks(8907), "admin@gmail.com", true, "FirstName", "LastName", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAECDNtWNOXpMoh2XQUcdBeC6cNOC41Is/uVJleEtg8+GcF5rDEUT2upAQLWPG6+klrw==", null, false, "e9cb5b3d-8fe6-4de0-8805-c681f63870b1", false, "Admin", false });

            migrationBuilder.InsertData(
                table: "Bills",
                columns: new[] { "bill_Id", "bill_Cancel", "bill_StartDateTime", "bill_StatusPayment", "bill_StatusReviceOrder", "bill_Total", "bill_UserId" },
                values: new object[] { "2f412223-c9f4-48eb-9924-8b216f31ee85", false, new DateTime(2022, 10, 22, 23, 17, 22, 26, DateTimeKind.Local).AddTicks(9361), true, false, 1.0, "5db2ec3d-8bcf-4bf9-81de-4730297b2f20" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "product_Id", "product_CategoryId", "product_Description", "product_Image1", "product_Image2", "product_Image3", "product_Image4", "product_Image5", "product_IsDelete", "product_Name", "product_Price", "product_Rate", "product_ReProducePrice" },
                values: new object[,]
                {
                    { "03cf6cc9-12e7-45d1-a101-4cfef8d2525a", "977d57c9-4b90-42bd-9c26-1ccf6aaf4005", "Coat + Strap", "image/phukien/phukien-ao_giaythat.png", "image/phukien/phukien-ao_giaythat.png", "image/phukien/phukien-ao_giaythat.png", "image/phukien/phukien-ao_giaythat.png", "image/phukien/phukien-ao_giaythat.png", false, "Coat + Strap", 100000.0, 5.0, 0.0 },
                    { "098c911d-1a68-4bba-9c59-896452427333", "977d57c9-4b90-42bd-9c26-1ccf6aaf4005", "Bio Milk Powder For Dogs and Cats", "image/phukien/phukien-suabotchomeo.png", "image/phukien/phukien-suabotchomeo.png", "image/phukien/phukien-suabotchomeo.png", "image/phukien/phukien-suabotchomeo.png", "image/phukien/phukien-suabotchomeo.png", false, "Bio Milk Powder For Dogs and Cats", 100000.0, 5.0, 0.0 },
                    { "1130512f-9f4d-48b6-87e3-ddb4d58d7ce2", "977d57c9-4b90-42bd-9c26-1ccf6aaf4005", "Toys", "image/phukien/phukien-dochoi.png", "image/phukien/phukien-dochoi.png", "image/phukien/phukien-dochoi.png", "image/phukien/phukien-dochoi.png", "image/phukien/phukien-dochoi.png", false, "Toys", 100000.0, 5.0, 0.0 },
                    { "134426be-d66d-45f8-8b7d-0a419d5a3f2b", "977d57c9-4b90-42bd-9c26-1ccf6aaf4005", "Lamb Sticks", "image/phukien/phukien-thitcuuque.png", "image/phukien/phukien-thitcuuque.png", "image/phukien/phukien-thitcuuque.png", "image/phukien/phukien-thitcuuque.png", "image/phukien/phukien-thitcuuque.png", false, "Lamb Sticks", 100000.0, 5.0, 0.0 },
                    { "1e36caa4-8c07-4be5-9691-c700fa2f0195", "977d57c9-4b90-42bd-9c26-1ccf6aaf4005", "Balloon Toys", "image/phukien/phukien-bongbongdochoi.png", "image/phukien/phukien-bongbongdochoi.png", "image/phukien/phukien-bongbongdochoi.png", "image/phukien/phukien-bongbongdochoi.png", "image/phukien/phukien-bongbongdochoi.png", false, "Balloon Toys", 100000.0, 5.0, 0.0 },
                    { "211cd7e7-da5c-443b-8dcc-f8486cda1b00", "977d57c9-4b90-42bd-9c26-1ccf6aaf4005", "Food Toys", "image/phukien/phukien-dochoithucan.png", "image/phukien/phukien-dochoithucan.png", "image/phukien/phukien-dochoithucan.png", "image/phukien/phukien-dochoithucan.png", "image/phukien/phukien-dochoithucan.png", false, "Food Toys", 100000.0, 5.0, 0.0 },
                    { "2227bc02-2ef9-4844-9919-c8023a486e26", "977d57c9-4b90-42bd-9c26-1ccf6aaf4005", "Feather Brush", "image/phukien/phukien-banchaylong.png", "image/phukien/phukien-banchaylong.png", "image/phukien/phukien-banchaylong.png", "image/phukien/phukien-banchaylong.png", "image/phukien/phukien-banchaylong.png", false, "Feather Brush", 100000.0, 5.0, 0.0 },
                    { "293cd544-4b5b-493d-8af2-9a5871dca7e0", "977d57c9-4b90-42bd-9c26-1ccf6aaf4005", "Royal Canin For Adult Dogs", "image/phukien/phukien-royal_truongthanh.png", "image/phukien/phukien-royal_truongthanh.png", "image/phukien/phukien-royal_truongthanh.png", "image/phukien/phukien-royal_truongthanh.png", "image/phukien/phukien-royal_truongthanh.png", false, "Royal Canin For Adult Dogs", 100000.0, 5.0, 0.0 },
                    { "37fb2a40-9bcd-4c36-991d-ac8c7d0ce75a", "977d57c9-4b90-42bd-9c26-1ccf6aaf4005", "Transparent Backpack For Dogs and Cats", "image/phukien/phukien-balotrongsuot.png", "image/phukien/phukien-balotrongsuot.png", "image/phukien/phukien-balotrongsuot.png", "image/phukien/phukien-balotrongsuot.png", "image/phukien/phukien-balotrongsuot.png", false, "Transparent Backpack For Dogs and Cats", 100000.0, 5.0, 0.0 },
                    { "3e8390be-0c86-4442-bba2-bcca42285af8", "977d57c9-4b90-42bd-9c26-1ccf6aaf4005", "SmartHeart For Small Dogs", "image/phukien/phukien-SmartHeart.png", "image/phukien/phukien-SmartHeart.png", "image/phukien/phukien-SmartHeart.png", "image/phukien/phukien-SmartHeart.png", "image/phukien/phukien-SmartHeart.png", false, "SmartHeart For Small Dogs", 100000.0, 5.0, 0.0 },
                    { "427176bd-a0f8-42b3-9bc2-278e2aee0d7f", "977d57c9-4b90-42bd-9c26-1ccf6aaf4005", "Nutri-Nutrition Gel", "image/phukien/phukien-gelddNutri.png", "image/phukien/phukien-gelddNutri.png", "image/phukien/phukien-gelddNutri.png", "image/phukien/phukien-gelddNutri.png", "image/phukien/phukien-gelddNutri.png", false, "Nutri-Nutrition Gel", 100000.0, 5.0, 0.0 },
                    { "43d98c4d-59c6-4d5d-a04e-d37d9e6e592f", "977d57c9-4b90-42bd-9c26-1ccf6aaf4005", "SmartHeart For Adult Dogs", "image/phukien/phukien-Smartheart_truongthanh.png", "image/phukien/phukien-Smartheart_truongthanh.png", "image/phukien/phukien-Smartheart_truongthanh.png", "image/phukien/phukien-Smartheart_truongthanh.png", "image/phukien/phukien-Smartheart_truongthanh.png", false, "SmartHeart For Adult Dogs", 1000000.0, 5.0, 0.0 },
                    { "4b231fba-8a16-488a-80bf-f52e275924f5", "977d57c9-4b90-42bd-9c26-1ccf6aaf4005", "Pair of Bows", "image/phukien/phukien-capno.png", "image/phukien/phukien-capno.png", "image/phukien/phukien-capno.png", "image/phukien/phukien-capno.png", "image/phukien/phukien-capno.png", false, "Pair of Bows", 100000.0, 5.0, 0.0 },
                    { "4c9c99eb-50f6-4bfb-81e6-7502d6d8a20b", "977d57c9-4b90-42bd-9c26-1ccf6aaf4005", "Drugs of Calcium", "image/phukien/phukien-thuoccanxi.png", "image/phukien/phukien-thuoccanxi.png", "image/phukien/phukien-thuoccanxi.png", "image/phukien/phukien-thuoccanxi.png", "image/phukien/phukien-thuoccanxi.png", false, "Drugs of Calcium", 100000.0, 5.0, 0.0 },
                    { "575168f7-2b60-4000-b55c-644cd16d233a", "977d57c9-4b90-42bd-9c26-1ccf6aaf4005", "Throwing dish", "image/phukien/phukien-dianem.png", "image/phukien/phukien-dianem.png", "image/phukien/phukien-dianem.png", "image/phukien/phukien-dianem.png", "image/phukien/phukien-dianem.png", false, "Throwing dish", 100000.0, 5.0, 0.0 },
                    { "6b24aa63-9988-46e6-9fb9-62d4ba873dc5", "977d57c9-4b90-42bd-9c26-1ccf6aaf4005", "Oliver Shower Gel", "image/phukien/phukien-suatamoliver.png", "image/phukien/phukien-suatamoliver.png", "image/phukien/phukien-suatamoliver.png", "image/phukien/phukien-suatamoliver.png", "image/phukien/phukien-suatamoliver.png", false, "Oliver Shower Gel", 100000.0, 5.0, 0.0 },
                    { "71184630-c981-412c-b3e4-99970ae5fe15", "977d57c9-4b90-42bd-9c26-1ccf6aaf4005", "Food Gun", "image/phukien/phukien-sungbanthucan.png", "image/phukien/phukien-sungbanthucan.png", "image/phukien/phukien-sungbanthucan.png", "image/phukien/phukien-sungbanthucan.png", "image/phukien/phukien-sungbanthucan.png", false, "Food Gun", 100000.0, 5.0, 0.0 },
                    { "74a279ee-6f70-41fe-801b-940ba3700fd3", "977d57c9-4b90-42bd-9c26-1ccf6aaf4005", "Dog Fence", "image/phukien/phukien-raoquaycho.png", "image/phukien/phukien-raoquaycho.png", "image/phukien/phukien-raoquaycho.png", "image/phukien/phukien-raoquaycho.png", "image/phukien/phukien-raoquaycho.png", false, "Dog Fence", 100000.0, 5.0, 0.0 },
                    { "7cc95b97-cf65-4216-98ed-b104e951b7b4", "977d57c9-4b90-42bd-9c26-1ccf6aaf4005", "Shipping Bag", "image/phukien/phukien-tuivanchuyen.png", "image/phukien/phukien-tuivanchuyen.png", "image/phukien/phukien-tuivanchuyen.png", "image/phukien/phukien-tuivanchuyen.png", "image/phukien/phukien-tuivanchuyen.png", false, "Shipping Bag", 100000.0, 5.0, 0.0 },
                    { "82d4e33c-453f-4041-af0d-350fe2929aba", "977d57c9-4b90-42bd-9c26-1ccf6aaf4005", "Bow Bow Bra", "image/phukien/phukien-aongucnochuong.png", "image/phukien/phukien-aongucnochuong.png", "image/phukien/phukien-aongucnochuong.png", "image/phukien/phukien-aongucnochuong.png", "image/phukien/phukien-aongucnochuong.png", false, "Bow Bow Bra", 100000.0, 5.0, 0.0 },
                    { "83c5f46d-18d1-48c0-9257-9eb81b2f7ce1", "977d57c9-4b90-42bd-9c26-1ccf6aaf4005", "BLOOM SEXY Fragrance Bath Oil", "image/phukien/phukien-dautamnuochoabloomsexy.png", "image/phukien/phukien-dautamnuochoabloomsexy.png", "image/phukien/phukien-dautamnuochoabloomsexy.png", "image/phukien/phukien-dautamnuochoabloomsexy.png", "image/phukien/phukien-dautamnuochoabloomsexy.png", false, "BLOOM SEXY Fragrance Bath Oil", 100000.0, 5.0, 0.0 },
                    { "8b6bc4ab-8a38-4220-9608-095f81421976", "977d57c9-4b90-42bd-9c26-1ccf6aaf4005", "Royal Canin For Small Dogs", "image/phukien/phukien-roya_chonho.png", "image/phukien/phukien-roya_chonho.png", "image/phukien/phukien-roya_chonho.png", "image/phukien/phukien-roya_chonho.png", "image/phukien/phukien-roya_chonho.png", false, "Royal Canin For Small Dogs", 100000.0, 5.0, 0.0 },
                    { "8bded664-26ed-403e-9465-8bbbbf010228", "977d57c9-4b90-42bd-9c26-1ccf6aaf4005", "FAY Dry Bath Powder", "image/phukien/phukien-phantamkhoFay.png", "image/phukien/phukien-phantamkhoFay.png", "image/phukien/phukien-phantamkhoFay.png", "image/phukien/phukien-phantamkhoFay.png", "image/phukien/phukien-phantamkhoFay.png", false, "FAY Dry Bath Powder", 100000.0, 5.0, 0.0 },
                    { "a46ebd81-bdbf-4ee6-a43b-1026131d25fb", "977d57c9-4b90-42bd-9c26-1ccf6aaf4005", "Bonus Cake Tablet", "image/phukien/phukien-banhthuong.png", "image/phukien/phukien-banhthuong.png", "image/phukien/phukien-banhthuong.png", "image/phukien/phukien-banhthuong.png", "image/phukien/phukien-banhthuong.png", false, "Bonus Cake Tablet", 100000.0, 5.0, 0.0 },
                    { "a54d60f8-45b7-48c1-aa33-39d53ddb2f69", "977d57c9-4b90-42bd-9c26-1ccf6aaf4005", "Orb of Thorns", "image/phukien/phukien-quacaugai.png", "image/phukien/phukien-quacaugai.png", "image/phukien/phukien-quacaugai.png", "image/phukien/phukien-quacaugai.png", "image/phukien/phukien-quacaugai.png", false, "Orb of Thorns", 100000.0, 5.0, 0.0 },
                    { "afcc65a4-bf1a-421e-8d10-5984b5bc7a6a", "977d57c9-4b90-42bd-9c26-1ccf6aaf4005", "Training Whistle", "image/phukien/phukien-coihuanluyen.png", "image/phukien/phukien-coihuanluyen.png", "image/phukien/phukien-coihuanluyen.png", "image/phukien/phukien-coihuanluyen.png", "image/phukien/phukien-coihuanluyen.png", false, "Training Whistle", 100000.0, 5.0, 0.0 },
                    { "b6b5bb11-f7c9-4403-806c-95fc26d50120", "977d57c9-4b90-42bd-9c26-1ccf6aaf4005", "Sleeky Multivitamin", "image/phukien/phukien-vitamintonghop.png", "image/phukien/phukien-vitamintonghop.png", "image/phukien/phukien-vitamintonghop.png", "image/phukien/phukien-vitamintonghop.png", "image/phukien/phukien-vitamintonghop.png", false, "Sleeky Multivitamin", 100000.0, 5.0, 0.0 },
                    { "b93d7d75-4d7c-4056-b780-f4c57a5ad014", "977d57c9-4b90-42bd-9c26-1ccf6aaf4005", "Princess Lace Scarf", "image/phukien/phukien-khanren.png", "image/phukien/phukien-khanren.png", "image/phukien/phukien-khanren.png", "image/phukien/phukien-khanren.png", "image/phukien/phukien-khanren.png", false, "Princess Lace Scarf", 100000.0, 5.0, 0.0 },
                    { "c3ca3f49-f3d6-46d4-ab26-c6e3c654c9bc", "977d57c9-4b90-42bd-9c26-1ccf6aaf4005", "Skin Bones", "image/phukien/phukien-xuongda.png", "image/phukien/phukien-xuongda.png", "image/phukien/phukien-xuongda.png", "image/phukien/phukien-xuongda.png", "image/phukien/phukien-xuongda.png", false, "Skin Bones", 100000.0, 5.0, 0.0 },
                    { "cc92954b-a5d9-49d7-b79f-78f60443e618", "977d57c9-4b90-42bd-9c26-1ccf6aaf4005", "Rooster Toys", "image/phukien/phukien-dochoi_gatrong.png", "image/phukien/phukien-dochoi_gatrong.png", "image/phukien/phukien-dochoi_gatrong.png", "image/phukien/phukien-dochoi_gatrong.png", "image/phukien/phukien-dochoi_gatrong.png", false, "Rooster Toys", 100000.0, 5.0, 0.0 },
                    { "d24f98f6-428c-4b63-b954-5d018a4e3573", "977d57c9-4b90-42bd-9c26-1ccf6aaf4005", "BLOOM SEXY Fragrance Bath Oil", "image/phukien/phukien-dautamFay.png", "image/phukien/phukien-dautamFay.png", "image/phukien/phukien-dautamFay.png", "image/phukien/phukien-dautamFay.png", "image/phukien/phukien-dautamFay.png", false, "BLOOM SEXY Fragrance Bath Oil", 100000.0, 5.0, 0.0 },
                    { "e87f1c9b-3bc8-4f2f-be30-dfb3b8fced96", "977d57c9-4b90-42bd-9c26-1ccf6aaf4005", "Lice Treatment Ring", "image/phukien/phukien-vongtriveran.png", "image/phukien/phukien-vongtriveran.png", "image/phukien/phukien-vongtriveran.png", "image/phukien/phukien-vongtriveran.png", "image/phukien/phukien-vongtriveran.png", false, "Lice Treatment Ring", 100000.0, 5.0, 0.0 },
                    { "f45796b9-c616-4a89-bb17-250b891d6cf2", "977d57c9-4b90-42bd-9c26-1ccf6aaf4005", "Canxi Nano", "image/phukien/phukien-canxinano.png", "image/phukien/phukien-canxinano.png", "image/phukien/phukien-canxinano.png", "image/phukien/phukien-canxinano.png", "image/phukien/phukien-canxinano.png", false, "Canxi Nano", 100000.0, 5.0, 0.0 },
                    { "f539e402-932b-41d0-9868-c583e16f4e71", "977d57c9-4b90-42bd-9c26-1ccf6aaf4005", "Anti-Tear Syrup", "image/phukien/phukien-sirochongchaynuocmat.png", "image/phukien/phukien-sirochongchaynuocmat.png", "image/phukien/phukien-sirochongchaynuocmat.png", "image/phukien/phukien-sirochongchaynuocmat.png", "image/phukien/phukien-sirochongchaynuocmat.png", false, "Anti-Tear Syrup", 100000.0, 5.0, 0.0 },
                    { "fbb79555-a0c5-4feb-aefd-e4bd91307288", "977d57c9-4b90-42bd-9c26-1ccf6aaf4005", "HANTOC Lice Spray", "image/phukien/phukien-xitveranHANTOC.png", "image/phukien/phukien-xitveranHANTOC.png", "image/phukien/phukien-xitveranHANTOC.png", "image/phukien/phukien-xitveranHANTOC.png", "image/phukien/phukien-xitveranHANTOC.png", false, "HANTOC Lice Spray", 100000.0, 5.0, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "UserContact",
                columns: new[] { "uc_Id", "uc_Content", "uc_Email", "uc_IsDelete", "uc_Name", "uc_Phone", "uc_UserCreate" },
                values: new object[] { "0a30a7dd-e6fc-4e4b-b99e-598e8c00d836", "Content", "Email", false, "Name", "Phone", "5db2ec3d-8bcf-4bf9-81de-4730297b2f20" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "89543239-37ca-49b0-b35f-d78a35a5a06f", "5db2ec3d-8bcf-4bf9-81de-4730297b2f20" });

            migrationBuilder.InsertData(
                table: "PettInBill",
                columns: new[] { "pib_BillId", "pib_PetId", "pib_IsDelete", "pib_Price", "pib_Quantity" },
                values: new object[] { "2f412223-c9f4-48eb-9924-8b216f31ee85", "0d601915-9c63-4ae7-b227-544669f84e54", false, 12.0, 1.0 });

            migrationBuilder.InsertData(
                table: "ProductInBill",
                columns: new[] { "proib_BillId", "proib_ProductId", "proib_IsDelete", "proib_Price", "proib_Quantity" },
                values: new object[] { "2f412223-c9f4-48eb-9924-8b216f31ee85", "37fb2a40-9bcd-4c36-991d-ac8c7d0ce75a", false, 12.0, 1.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PetCategories",
                keyColumn: "pc_Id",
                keyValue: "0edd9af8-634d-4dfe-8f68-3f6a4f649f8a");

            migrationBuilder.DeleteData(
                table: "PetCategories",
                keyColumn: "pc_Id",
                keyValue: "101f2f0b-7634-43ce-b9cf-01b06bae6b86");

            migrationBuilder.DeleteData(
                table: "PetCategories",
                keyColumn: "pc_Id",
                keyValue: "183b7352-ad15-4fa7-967c-c2639e1adcb3");

            migrationBuilder.DeleteData(
                table: "PetCategories",
                keyColumn: "pc_Id",
                keyValue: "18905cfe-2b9e-43ce-8f6b-b5714e7b5803");

            migrationBuilder.DeleteData(
                table: "PetCategories",
                keyColumn: "pc_Id",
                keyValue: "25dafb34-a58e-4757-a3e9-35b9ab226a88");

            migrationBuilder.DeleteData(
                table: "PetCategories",
                keyColumn: "pc_Id",
                keyValue: "2c76ff0f-f000-4ccd-903a-dd81b8386391");

            migrationBuilder.DeleteData(
                table: "PetCategories",
                keyColumn: "pc_Id",
                keyValue: "3596fe4a-998f-417d-878d-6b82073fe30c");

            migrationBuilder.DeleteData(
                table: "PetCategories",
                keyColumn: "pc_Id",
                keyValue: "38822d47-f05e-484f-9af4-5d1334ddb01e");

            migrationBuilder.DeleteData(
                table: "PetCategories",
                keyColumn: "pc_Id",
                keyValue: "4750bd6e-3013-439d-9147-458fb635a26c");

            migrationBuilder.DeleteData(
                table: "PetCategories",
                keyColumn: "pc_Id",
                keyValue: "4b7c3ed1-1560-41a3-99b6-43ce7cd5a136");

            migrationBuilder.DeleteData(
                table: "PetCategories",
                keyColumn: "pc_Id",
                keyValue: "5fac894a-a012-4abc-941b-c097ee7a2fe1");

            migrationBuilder.DeleteData(
                table: "PetCategories",
                keyColumn: "pc_Id",
                keyValue: "6432edba-2d75-4485-884f-c19e221cbbac");

            migrationBuilder.DeleteData(
                table: "PetCategories",
                keyColumn: "pc_Id",
                keyValue: "77e950ee-45de-45b4-b415-6a83b1c28500");

            migrationBuilder.DeleteData(
                table: "PetCategories",
                keyColumn: "pc_Id",
                keyValue: "7a859a9b-8ef6-4519-a36e-4d5c008c3380");

            migrationBuilder.DeleteData(
                table: "PetCategories",
                keyColumn: "pc_Id",
                keyValue: "7a8a923e-26d5-40ee-aaab-1f1755f5ed0a");

            migrationBuilder.DeleteData(
                table: "PetCategories",
                keyColumn: "pc_Id",
                keyValue: "8637cef8-dd50-4fcc-ab09-902d8db07f44");

            migrationBuilder.DeleteData(
                table: "PetCategories",
                keyColumn: "pc_Id",
                keyValue: "8daf3fdf-f65a-4221-ace2-d117f2db8508");

            migrationBuilder.DeleteData(
                table: "PetCategories",
                keyColumn: "pc_Id",
                keyValue: "8fb6624f-b9e6-4cd1-8e19-bbacbc8ffc9a");

            migrationBuilder.DeleteData(
                table: "PetCategories",
                keyColumn: "pc_Id",
                keyValue: "9e97181b-b251-409f-bbaa-6fcb797ef03c");

            migrationBuilder.DeleteData(
                table: "PetCategories",
                keyColumn: "pc_Id",
                keyValue: "b506f21e-e608-417b-90b5-012c3ca93db1");

            migrationBuilder.DeleteData(
                table: "PetCategories",
                keyColumn: "pc_Id",
                keyValue: "bb6b5a90-b5e1-452d-b39a-c90f46184515");

            migrationBuilder.DeleteData(
                table: "PetCategories",
                keyColumn: "pc_Id",
                keyValue: "bea8fcc8-3ed8-4f23-8f9d-e8b9ad5be0e5");

            migrationBuilder.DeleteData(
                table: "PetCategories",
                keyColumn: "pc_Id",
                keyValue: "c0deabcd-59e4-4655-acc8-8a4fca01b723");

            migrationBuilder.DeleteData(
                table: "PetCategories",
                keyColumn: "pc_Id",
                keyValue: "cc70426a-f0f6-4e37-9672-9a1f5e999fde");

            migrationBuilder.DeleteData(
                table: "PetCategories",
                keyColumn: "pc_Id",
                keyValue: "d14c67d5-4a42-4221-ab15-268a0de34613");

            migrationBuilder.DeleteData(
                table: "PetCategories",
                keyColumn: "pc_Id",
                keyValue: "d283ff48-dfa0-41ff-8cc2-2997596fbc7e");

            migrationBuilder.DeleteData(
                table: "PetCategories",
                keyColumn: "pc_Id",
                keyValue: "d7f0e948-5917-4c6b-ba0b-07d579270c7f");

            migrationBuilder.DeleteData(
                table: "PetCategories",
                keyColumn: "pc_Id",
                keyValue: "dadba9e0-ee05-457a-9462-12a038b2dc9f");

            migrationBuilder.DeleteData(
                table: "PetCategories",
                keyColumn: "pc_Id",
                keyValue: "ddaee95e-695b-4a68-bd4a-e9d020305e71");

            migrationBuilder.DeleteData(
                table: "PetCategories",
                keyColumn: "pc_Id",
                keyValue: "ddfc77ba-a221-49ed-8e7c-d4efcd7f0a61");

            migrationBuilder.DeleteData(
                table: "PetCategories",
                keyColumn: "pc_Id",
                keyValue: "eccf607d-6302-41ee-b4e6-a36ff75f0a82");

            migrationBuilder.DeleteData(
                table: "PetCategories",
                keyColumn: "pc_Id",
                keyValue: "efe4cbd8-52e4-4099-a410-d5d696517fdf");

            migrationBuilder.DeleteData(
                table: "PettInBill",
                keyColumns: new[] { "pib_BillId", "pib_PetId" },
                keyValues: new object[] { "2f412223-c9f4-48eb-9924-8b216f31ee85", "0d601915-9c63-4ae7-b227-544669f84e54" });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "proc_Id",
                keyValue: "25796aad-8886-4baa-89ea-ab60e9622e32");

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "proc_Id",
                keyValue: "31aee0ec-e0c5-4bed-8e70-b71befb70b25");

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "proc_Id",
                keyValue: "37ff9faf-1464-4589-ac20-139f829060ef");

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "proc_Id",
                keyValue: "73a8b868-f082-4802-a298-559c72e707e9");

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "proc_Id",
                keyValue: "7530f132-1e23-4e07-b3b9-0f1a8f559c8b");

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "proc_Id",
                keyValue: "87c52723-537d-4378-80c3-556e24822d8f");

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "proc_Id",
                keyValue: "d58b3306-4e7a-494a-a8c8-9fc37834a393");

            migrationBuilder.DeleteData(
                table: "ProductInBill",
                keyColumns: new[] { "proib_BillId", "proib_ProductId" },
                keyValues: new object[] { "2f412223-c9f4-48eb-9924-8b216f31ee85", "37fb2a40-9bcd-4c36-991d-ac8c7d0ce75a" });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_Id",
                keyValue: "03cf6cc9-12e7-45d1-a101-4cfef8d2525a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_Id",
                keyValue: "098c911d-1a68-4bba-9c59-896452427333");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_Id",
                keyValue: "1130512f-9f4d-48b6-87e3-ddb4d58d7ce2");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_Id",
                keyValue: "134426be-d66d-45f8-8b7d-0a419d5a3f2b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_Id",
                keyValue: "1e36caa4-8c07-4be5-9691-c700fa2f0195");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_Id",
                keyValue: "211cd7e7-da5c-443b-8dcc-f8486cda1b00");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_Id",
                keyValue: "2227bc02-2ef9-4844-9919-c8023a486e26");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_Id",
                keyValue: "293cd544-4b5b-493d-8af2-9a5871dca7e0");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_Id",
                keyValue: "3e8390be-0c86-4442-bba2-bcca42285af8");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_Id",
                keyValue: "427176bd-a0f8-42b3-9bc2-278e2aee0d7f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_Id",
                keyValue: "43d98c4d-59c6-4d5d-a04e-d37d9e6e592f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_Id",
                keyValue: "4b231fba-8a16-488a-80bf-f52e275924f5");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_Id",
                keyValue: "4c9c99eb-50f6-4bfb-81e6-7502d6d8a20b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_Id",
                keyValue: "575168f7-2b60-4000-b55c-644cd16d233a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_Id",
                keyValue: "6b24aa63-9988-46e6-9fb9-62d4ba873dc5");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_Id",
                keyValue: "71184630-c981-412c-b3e4-99970ae5fe15");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_Id",
                keyValue: "74a279ee-6f70-41fe-801b-940ba3700fd3");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_Id",
                keyValue: "7cc95b97-cf65-4216-98ed-b104e951b7b4");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_Id",
                keyValue: "82d4e33c-453f-4041-af0d-350fe2929aba");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_Id",
                keyValue: "83c5f46d-18d1-48c0-9257-9eb81b2f7ce1");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_Id",
                keyValue: "8b6bc4ab-8a38-4220-9608-095f81421976");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_Id",
                keyValue: "8bded664-26ed-403e-9465-8bbbbf010228");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_Id",
                keyValue: "a46ebd81-bdbf-4ee6-a43b-1026131d25fb");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_Id",
                keyValue: "a54d60f8-45b7-48c1-aa33-39d53ddb2f69");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_Id",
                keyValue: "afcc65a4-bf1a-421e-8d10-5984b5bc7a6a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_Id",
                keyValue: "b6b5bb11-f7c9-4403-806c-95fc26d50120");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_Id",
                keyValue: "b93d7d75-4d7c-4056-b780-f4c57a5ad014");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_Id",
                keyValue: "c3ca3f49-f3d6-46d4-ab26-c6e3c654c9bc");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_Id",
                keyValue: "cc92954b-a5d9-49d7-b79f-78f60443e618");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_Id",
                keyValue: "d24f98f6-428c-4b63-b954-5d018a4e3573");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_Id",
                keyValue: "e87f1c9b-3bc8-4f2f-be30-dfb3b8fced96");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_Id",
                keyValue: "f45796b9-c616-4a89-bb17-250b891d6cf2");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_Id",
                keyValue: "f539e402-932b-41d0-9868-c583e16f4e71");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_Id",
                keyValue: "fbb79555-a0c5-4feb-aefd-e4bd91307288");

            migrationBuilder.DeleteData(
                table: "UserContact",
                keyColumn: "uc_Id",
                keyValue: "0a30a7dd-e6fc-4e4b-b99e-598e8c00d836");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "89543239-37ca-49b0-b35f-d78a35a5a06f", "5db2ec3d-8bcf-4bf9-81de-4730297b2f20" });

            migrationBuilder.DeleteData(
                table: "Bills",
                keyColumn: "bill_Id",
                keyValue: "2f412223-c9f4-48eb-9924-8b216f31ee85");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_Id",
                keyValue: "37fb2a40-9bcd-4c36-991d-ac8c7d0ce75a");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "89543239-37ca-49b0-b35f-d78a35a5a06f");

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "proc_Id",
                keyValue: "977d57c9-4b90-42bd-9c26-1ccf6aaf4005");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "5db2ec3d-8bcf-4bf9-81de-4730297b2f20");

            migrationBuilder.DropColumn(
                name: "product_Image1",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "product_Image2",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "product_Image3",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "product_Image4",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "product_Image5",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "pet_Image1",
                table: "Pets");

            migrationBuilder.DropColumn(
                name: "pet_Image2",
                table: "Pets");

            migrationBuilder.DropColumn(
                name: "pet_Image3",
                table: "Pets");

            migrationBuilder.DropColumn(
                name: "pet_Image4",
                table: "Pets");

            migrationBuilder.DropColumn(
                name: "pet_Image5",
                table: "Pets");

            migrationBuilder.InsertData(
                table: "PetCategories",
                columns: new[] { "pc_Id", "pc_Description", "pc_IsDelete", "pc_Name" },
                values: new object[] { "0beac127-fe68-4eb4-8536-d03663de191f", "Description", false, "Name" });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "proc_Id", "proc_Description", "proc_IsDelete", "proc_Name" },
                values: new object[] { "256df248-d68c-4bfe-beef-3530f7d0b65c", "Description", false, "Name" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Discriminator", "Name", "NormalizedName", "isDelete" },
                values: new object[] { "ddc955b7-6138-47b1-aa53-bc7f25d26af6", "84bb4977-b2ee-46cd-9913-0d972bef3091", "admin", "Roles", "ADMIN", "admin", false });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "DoB", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "isDelete" },
                values: new object[] { "dc9c6d40-ada5-4b54-bf17-e7955fbe204b", 0, "719393ce-a2eb-42c1-aafa-47a03abef9ee", "Users", new DateTime(2022, 10, 22, 13, 45, 50, 649, DateTimeKind.Local).AddTicks(9050), "staff@gmail.com", true, "FirstName", "LastName", false, null, "STAFF@GMAIL.COM", "STAFF@GMAIL.COM", "AQAAAAEAACcQAAAAEI7EghdDpLC/NM2YZfGxLbCjb95sUI68/xlFLCWabTJjTavfqUufKkXMJTtzATo5WA==", null, false, "1132e8b5-2cb7-452d-a4d2-0ba8e912ce8e", false, "Admin", false });

            migrationBuilder.InsertData(
                table: "Bills",
                columns: new[] { "bill_Id", "bill_Cancel", "bill_StartDateTime", "bill_StatusPayment", "bill_StatusReviceOrder", "bill_Total", "bill_UserId" },
                values: new object[] { "bc8eee77-d226-4dbc-9c3c-575e45b4757e", false, new DateTime(2022, 10, 22, 13, 45, 50, 649, DateTimeKind.Local).AddTicks(9348), true, false, 1.0, "dc9c6d40-ada5-4b54-bf17-e7955fbe204b" });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "pet_Id", "pet_CategoryId", "pet_Description", "pet_IsDelete", "pet_Lifespan", "pet_Name", "pet_Origin", "pet_OrtherName", "pet_Price", "pet_Weight" },
                values: new object[] { "36360661-1c4b-474c-bcbf-66c16b42b357", "0beac127-fe68-4eb4-8536-d03663de191f", "Description", false, 1.0, "Name", "Origin", "OrtherName", 1.0, 3.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "product_Id", "product_CategoryId", "product_Description", "product_IsDelete", "product_Name", "product_Price", "product_Rate", "product_ReProducePrice" },
                values: new object[] { "63886122-64fe-4633-990c-b55ed47f7f57", "256df248-d68c-4bfe-beef-3530f7d0b65c", "Description", false, "Name", 1.0, 5.0, 0.0 });

            migrationBuilder.InsertData(
                table: "UserContact",
                columns: new[] { "uc_Id", "uc_Content", "uc_Email", "uc_IsDelete", "uc_Name", "uc_Phone", "uc_UserCreate" },
                values: new object[] { "828bee48-2436-4574-ae27-cf75b61ccf8b", "Content", "Email", false, "Name", "Phone", "dc9c6d40-ada5-4b54-bf17-e7955fbe204b" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ddc955b7-6138-47b1-aa53-bc7f25d26af6", "dc9c6d40-ada5-4b54-bf17-e7955fbe204b" });

            migrationBuilder.InsertData(
                table: "PettInBill",
                columns: new[] { "pib_BillId", "pib_PetId", "pib_IsDelete", "pib_Price", "pib_Quantity" },
                values: new object[] { "bc8eee77-d226-4dbc-9c3c-575e45b4757e", "36360661-1c4b-474c-bcbf-66c16b42b357", false, 12.0, 1.0 });

            migrationBuilder.InsertData(
                table: "ProductInBill",
                columns: new[] { "proib_BillId", "proib_ProductId", "proib_IsDelete", "proib_Price", "proib_Quantity" },
                values: new object[] { "bc8eee77-d226-4dbc-9c3c-575e45b4757e", "63886122-64fe-4633-990c-b55ed47f7f57", false, 12.0, 1.0 });
        }
    }
}
