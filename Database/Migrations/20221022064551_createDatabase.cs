using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Database.Migrations
{
    public partial class createDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserContact_Users_uc_UserCreate",
                table: "UserContact");

            migrationBuilder.DeleteData(
                table: "PettInBill",
                keyColumns: new[] { "pib_BillId", "pib_PetId" },
                keyValues: new object[] { "1f9eec69-edb3-418b-9dc6-a9e0b9bea1ed", "d0abd105-e222-425b-8a9e-50f4e4c196fa" });

            migrationBuilder.DeleteData(
                table: "ProductInBill",
                keyColumns: new[] { "proib_BillId", "proib_ProductId" },
                keyValues: new object[] { "1f9eec69-edb3-418b-9dc6-a9e0b9bea1ed", "7192f819-44ce-41f1-89c9-9cc88646a01f" });

            migrationBuilder.DeleteData(
                table: "UserContact",
                keyColumn: "uc_Id",
                keyValue: "95f143e4-8efb-4574-9555-83be532b0052");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "77f3aa7d-f480-43a1-af7d-75d3b087fab0", "dc927da9-fca4-4608-938d-23aa23f1f553" });

            migrationBuilder.DeleteData(
                table: "Bills",
                keyColumn: "bill_Id",
                keyValue: "1f9eec69-edb3-418b-9dc6-a9e0b9bea1ed");

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "pet_Id",
                keyValue: "d0abd105-e222-425b-8a9e-50f4e4c196fa");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "product_Id",
                keyValue: "7192f819-44ce-41f1-89c9-9cc88646a01f");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "77f3aa7d-f480-43a1-af7d-75d3b087fab0");

            migrationBuilder.DeleteData(
                table: "PetCategories",
                keyColumn: "pc_Id",
                keyValue: "849c58be-b054-41f7-80aa-dec1652fe7af");

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "proc_Id",
                keyValue: "16e96752-c440-4955-b5ea-276ce35448ab");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "dc927da9-fca4-4608-938d-23aa23f1f553");

            migrationBuilder.AlterColumn<string>(
                name: "uc_UserCreate",
                table: "UserContact",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true,
                oldDefaultValue: "");

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

            migrationBuilder.AddForeignKey(
                name: "FK_UserContact_Users_uc_UserCreate",
                table: "UserContact",
                column: "uc_UserCreate",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserContact_Users_uc_UserCreate",
                table: "UserContact");

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

            migrationBuilder.AlterColumn<string>(
                name: "uc_UserCreate",
                table: "UserContact",
                type: "nvarchar(450)",
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.InsertData(
                table: "PetCategories",
                columns: new[] { "pc_Id", "pc_Description", "pc_IsDelete", "pc_Name" },
                values: new object[] { "849c58be-b054-41f7-80aa-dec1652fe7af", "Description", false, "Name" });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "proc_Id", "proc_Description", "proc_IsDelete", "proc_Name" },
                values: new object[] { "16e96752-c440-4955-b5ea-276ce35448ab", "Description", false, "Name" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Discriminator", "Name", "NormalizedName", "isDelete" },
                values: new object[] { "77f3aa7d-f480-43a1-af7d-75d3b087fab0", "73aff6e6-eede-4868-89cf-c4ac56869a67", "admin", "Roles", "ADMIN", "admin", false });

            migrationBuilder.InsertData(
                table: "UserContact",
                columns: new[] { "uc_Id", "uc_Content", "uc_Email", "uc_IsDelete", "uc_Name", "uc_Phone", "uc_UserCreate" },
                values: new object[] { "95f143e4-8efb-4574-9555-83be532b0052", "Content", "Email", false, "Name", "Phone", "" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "DoB", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "isDelete" },
                values: new object[] { "dc927da9-fca4-4608-938d-23aa23f1f553", 0, "dbf85483-51d3-4eae-a605-2f92be52ea4f", "Users", new DateTime(2022, 10, 22, 13, 43, 37, 201, DateTimeKind.Local).AddTicks(2250), "staff@gmail.com", true, "FirstName", "LastName", false, null, "STAFF@GMAIL.COM", "STAFF@GMAIL.COM", "AQAAAAEAACcQAAAAENBl/+DP+iR4Iy7mF/Xt5jMDiIlgAETbIUxv3a52aVnv+UfpQKnKWp/7KyZVNz4YIw==", null, false, "8a7b95d5-3f88-4284-ab98-f6ea092a4b52", false, "Admin", false });

            migrationBuilder.InsertData(
                table: "Bills",
                columns: new[] { "bill_Id", "bill_Cancel", "bill_StartDateTime", "bill_StatusPayment", "bill_StatusReviceOrder", "bill_Total", "bill_UserId" },
                values: new object[] { "1f9eec69-edb3-418b-9dc6-a9e0b9bea1ed", false, new DateTime(2022, 10, 22, 13, 43, 37, 201, DateTimeKind.Local).AddTicks(2600), true, false, 1.0, "dc927da9-fca4-4608-938d-23aa23f1f553" });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "pet_Id", "pet_CategoryId", "pet_Description", "pet_IsDelete", "pet_Lifespan", "pet_Name", "pet_Origin", "pet_OrtherName", "pet_Price", "pet_Weight" },
                values: new object[] { "d0abd105-e222-425b-8a9e-50f4e4c196fa", "849c58be-b054-41f7-80aa-dec1652fe7af", "Description", false, 1.0, "Name", "Origin", "OrtherName", 1.0, 3.0 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "product_Id", "product_CategoryId", "product_Description", "product_IsDelete", "product_Name", "product_Price", "product_Rate", "product_ReProducePrice" },
                values: new object[] { "7192f819-44ce-41f1-89c9-9cc88646a01f", "16e96752-c440-4955-b5ea-276ce35448ab", "Description", false, "Name", 1.0, 5.0, 0.0 });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "77f3aa7d-f480-43a1-af7d-75d3b087fab0", "dc927da9-fca4-4608-938d-23aa23f1f553" });

            migrationBuilder.InsertData(
                table: "PettInBill",
                columns: new[] { "pib_BillId", "pib_PetId", "pib_IsDelete", "pib_Price", "pib_Quantity" },
                values: new object[] { "1f9eec69-edb3-418b-9dc6-a9e0b9bea1ed", "d0abd105-e222-425b-8a9e-50f4e4c196fa", false, 12.0, 1.0 });

            migrationBuilder.InsertData(
                table: "ProductInBill",
                columns: new[] { "proib_BillId", "proib_ProductId", "proib_IsDelete", "proib_Price", "proib_Quantity" },
                values: new object[] { "1f9eec69-edb3-418b-9dc6-a9e0b9bea1ed", "7192f819-44ce-41f1-89c9-9cc88646a01f", false, 12.0, 1.0 });

            migrationBuilder.AddForeignKey(
                name: "FK_UserContact_Users_uc_UserCreate",
                table: "UserContact",
                column: "uc_UserCreate",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
