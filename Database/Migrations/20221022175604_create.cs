using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Database.Migrations
{
    public partial class create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PetCategories",
                columns: table => new
                {
                    pc_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    pc_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pc_Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pc_IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetCategories", x => x.pc_Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    proc_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    proc_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    proc_Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    proc_IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.proc_Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isDelete = table.Column<bool>(type: "bit", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoB = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDelete = table.Column<bool>(type: "bit", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pets",
                columns: table => new
                {
                    pet_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    pet_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pet_Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pet_Image1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pet_Image2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pet_Image3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pet_Image4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pet_Image5 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pet_Price = table.Column<double>(type: "float", nullable: false),
                    pet_OrtherName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pet_Origin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pet_CategoryId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    pet_Weight = table.Column<double>(type: "float", nullable: false),
                    pet_Lifespan = table.Column<double>(type: "float", nullable: false),
                    pet_IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pets", x => x.pet_Id);
                    table.ForeignKey(
                        name: "FK_Pets_PetCategories_pet_CategoryId",
                        column: x => x.pet_CategoryId,
                        principalTable: "PetCategories",
                        principalColumn: "pc_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    product_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    product_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    product_Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    product_Image1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    product_Image2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    product_Image3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    product_Image4 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    product_Image5 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    product_Price = table.Column<double>(type: "float", nullable: false),
                    product_Rate = table.Column<double>(type: "float", nullable: false),
                    product_ReProducePrice = table.Column<double>(type: "float", nullable: false),
                    product_CategoryId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    product_IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.product_Id);
                    table.ForeignKey(
                        name: "FK_Products_ProductCategories_product_CategoryId",
                        column: x => x.product_CategoryId,
                        principalTable: "ProductCategories",
                        principalColumn: "proc_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaims_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    bill_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    bill_UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    bill_StatusPayment = table.Column<bool>(type: "bit", nullable: false),
                    bill_StatusReviceOrder = table.Column<bool>(type: "bit", nullable: false),
                    bill_Total = table.Column<double>(type: "float", nullable: false),
                    bill_StartDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    bill_Cancel = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.bill_Id);
                    table.ForeignKey(
                        name: "FK_Bills_Users_bill_UserId",
                        column: x => x.bill_UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IntroducePage",
                columns: table => new
                {
                    introduce_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    introduce_Zalo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    introduce_Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    introduce_Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    introduce_Address1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    introduce_Address2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    introduce_Address3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    introduce_Map1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    introduce_Map2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    introduce_Map3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    introduce_UserCreate = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IntroducePage", x => x.introduce_Id);
                    table.ForeignKey(
                        name: "FK_IntroducePage_Users_introduce_UserCreate",
                        column: x => x.introduce_UserCreate,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaims_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserContact",
                columns: table => new
                {
                    uc_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    uc_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    uc_Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    uc_Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    uc_Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    uc_IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    uc_UserCreate = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserContact", x => x.uc_Id);
                    table.ForeignKey(
                        name: "FK_UserContact_Users_uc_UserCreate",
                        column: x => x.uc_UserCreate,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_UserLogins_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_UserTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PettInBill",
                columns: table => new
                {
                    pib_PetId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    pib_BillId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    pib_Quantity = table.Column<double>(type: "float", nullable: false),
                    pib_Price = table.Column<double>(type: "float", nullable: false),
                    pib_IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PettInBill", x => new { x.pib_PetId, x.pib_BillId });
                    table.ForeignKey(
                        name: "FK_PettInBill_Bills_pib_BillId",
                        column: x => x.pib_BillId,
                        principalTable: "Bills",
                        principalColumn: "bill_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PettInBill_Pets_pib_PetId",
                        column: x => x.pib_PetId,
                        principalTable: "Pets",
                        principalColumn: "pet_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductInBill",
                columns: table => new
                {
                    proib_ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    proib_BillId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    proib_Quantity = table.Column<double>(type: "float", nullable: false),
                    proib_Price = table.Column<double>(type: "float", nullable: false),
                    proib_IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductInBill", x => new { x.proib_ProductId, x.proib_BillId });
                    table.ForeignKey(
                        name: "FK_ProductInBill_Bills_proib_BillId",
                        column: x => x.proib_BillId,
                        principalTable: "Bills",
                        principalColumn: "bill_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductInBill_Products_proib_ProductId",
                        column: x => x.proib_ProductId,
                        principalTable: "Products",
                        principalColumn: "product_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "PetCategories",
                columns: new[] { "pc_Id", "pc_Description", "pc_IsDelete", "pc_Name" },
                values: new object[,]
                {
                    { "007de5e2-6ef8-4797-a530-98d901fa8c57", "Shiba Inu", false, "Shiba Inu" },
                    { "02986abe-8aaa-498c-b942-8a0fcaf16af1", "Husky", false, "Husky" },
                    { "099765d7-e234-420a-8d29-f395c112bfec", "Bully American", false, "Bully American" },
                    { "19f5639e-c952-483c-ab48-e187f4501fa0", "Becgie Germany", false, "Becgie Germany" },
                    { "23d8f287-0f82-4e71-9204-a7007306af21", "Pug", false, "Pug" },
                    { "25dff836-f046-4bbd-857d-0632bc47b03c", "Border collie", false, "Border collie" },
                    { "313cc446-898f-4476-9c7e-8b0d65a7610a", "Malinois", false, "Malinois" },
                    { "35099697-853c-4f6f-8b89-386b68f59d91", "Samoyed", false, "Samoyed" },
                    { "39e83b15-2491-4809-adfe-74ac2a47f898", "Golden Retriever", false, "Golden Retriever" },
                    { "5546cb37-d084-4afb-ba89-89bd52b192d3", "Vitespitz", false, "Vitespitz" },
                    { "5685b4c8-5828-4093-bf36-f7208e970ff9", "Cocker Spaniel", false, "Cocker Spaniel" },
                    { "56b58303-c5c4-462f-80f2-84f29696ce70", "Ikita Inu", false, "Ikita Inu" },
                    { "5d7e5f3e-00c2-46c9-9a37-9bd0100f1b53", "Sausage", false, "Sausage" },
                    { "5e4bdbbb-b1c2-437c-b781-c682b35f66bb", "Tibetan Clams", false, "Tibetan Clams" },
                    { "5f3a507a-c641-47cf-8b63-fb1777f5f10f", "Pekingese", false, "Pekingese" },
                    { "67bd9ef9-c200-4bec-89db-61a37ded4f80", "H'Mong Coc", false, "H'Mong Coc" },
                    { "6e6a85e7-ec28-47a2-bfec-6f4764bfc125", "Rottweiler", false, "Rottweiler" },
                    { "704d453c-3a33-4094-a195-ed83e70ee8b5", "Phu Quoc", false, "Phu Quoc" },
                    { "76f94dba-7cfc-4500-9da4-1df7e2026cb3", "Phoc Soc", false, "Phoc Soc" },
                    { "7e785ec4-8e30-4b7e-8fba-450e48f030ac", "Great Dane", false, "Great Dane" },
                    { "8c253cca-7e46-4102-8304-db9370ae3b60", "Labrador", false, "Labrador" },
                    { "940aface-2c15-466f-a341-25f8582c8b2f", "Poodle", false, "Poodle" },
                    { "a533a2ac-1c8a-4d7a-b15b-45485724c917", "Japan Dog", false, "Japan Dog" },
                    { "ad6a9e3b-2dc9-4ed9-a5c2-1f5649e442a7", "Chihuahua", false, "Chihuahua" },
                    { "aec76309-5516-479e-a8ee-34fcf2d90bbc", "Dobermann", false, "Dobermann" },
                    { "b02b08bf-f4f6-4e5b-99a3-6a6e23370b74", "Pitbull", false, "Pitbull" },
                    { "b38071da-10aa-4be9-b8ed-ec056cfa0866", "Pho Deer", false, "Pho Deer" },
                    { "ca49f1b8-5351-4220-af91-4765cca8cbbb", "Corgi", false, "Corgi" },
                    { "d1d05b94-ba26-4a62-b262-b3d6a383d4f1", "Dalmatian", false, "Dalmatian" },
                    { "d9b7e433-6eac-496e-aae0-e6cc52d10345", "Bulldog", false, "Bulldog" },
                    { "da2ce7a5-1f08-4215-9680-0c7dca51ae24", "Chow Chow", false, "Chow Chow" },
                    { "dc5da4e8-008d-4f6a-85f3-d1e4a24fecfd", "Alaska", false, "Alaska" }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "proc_Id", "proc_Description", "proc_IsDelete", "proc_Name" },
                values: new object[,]
                {
                    { "0ba11721-93aa-4de7-800b-4f1b07b5b2cb", "Nutritional Food", false, "Nutritional Food" },
                    { "22fbf9d7-2e58-42af-be4b-b9b3cd2c7e20", "Pet Supplies", false, "Pet Supplies" },
                    { "389cf390-06ff-4d55-b6be-25e6b4e531da", "Beauty Accessories", false, "Beauty Accessories" },
                    { "38ff1640-523b-42ba-a40e-4a5e913a14c1", "Pet Toys", false, "Pet Toys" },
                    { "5d3f1f23-d2ad-4cdf-b641-d4c6b3844c62", "Pet Food", false, "Pet Food" },
                    { "a9a81415-ad79-4e0b-a5fe-cb2cd8a52eac", "Pet Clothes", false, "Pet Clothes" },
                    { "f07da8a3-ef83-46b3-a231-6956c98c4e1c", "Medicines & Functional Products", false, "Medicines & Functional Products" },
                    { "fc9e7ba5-1376-4b67-a691-fe28227600cc", "Pet Cage", false, "Pet Cage" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Discriminator", "Name", "NormalizedName", "isDelete" },
                values: new object[] { "370047eb-dbf2-4313-9d66-ce4ce1cd2e2f", "a85e4994-7ddb-4c50-b750-26d6c1bece19", "admin", "Roles", "ADMIN", "Admin", false });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "DoB", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "isDelete" },
                values: new object[] { "8b3e6a69-6154-4a41-98c8-327dbfbf5ef8", 0, "cd7841fe-ce21-4cf3-9afb-410c75a3ff53", "Users", new DateTime(2022, 10, 23, 0, 56, 3, 900, DateTimeKind.Local).AddTicks(3365), "admin@gmail.com", true, "FirstName", "LastName", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEEKQpZiSSZVMhWKO5cwv2r7xLhkE2rS26JoNstoamC1xyGS/Gj6/oej45pcQVu2kjQ==", null, false, "16e07cf9-b330-458d-abb9-84ca11a1d132", false, "Admin", false });

            migrationBuilder.InsertData(
                table: "Bills",
                columns: new[] { "bill_Id", "bill_Cancel", "bill_StartDateTime", "bill_StatusPayment", "bill_StatusReviceOrder", "bill_Total", "bill_UserId" },
                values: new object[] { "9d0933e3-f9db-4a38-b6d4-b5a6b8935c88", false, new DateTime(2022, 10, 23, 0, 56, 3, 900, DateTimeKind.Local).AddTicks(3813), true, false, 1000000.0, "8b3e6a69-6154-4a41-98c8-327dbfbf5ef8" });

            migrationBuilder.InsertData(
                table: "IntroducePage",
                columns: new[] { "introduce_Id", "introduce_Address1", "introduce_Address2", "introduce_Address3", "introduce_Email", "introduce_Map1", "introduce_Map2", "introduce_Map3", "introduce_Phone", "introduce_UserCreate", "introduce_Zalo" },
                values: new object[] { "defaultPage", "180 Bui Van Ba, District 7, Ho Chi Minh City.", "464 Cong Hoa, Tan Binh District, Ho Chi Minh City.", "157/13 Luong The Vinh Street, Ward 1, Ca Mau City.", "petshop.cuahangthucung@gmail.com", "180 Bui Van Ba, District 7, Ho Chi Minh City .", "464 Cong Hoa, Ward 13, Tan Binh District, City Ho Chi Minh.", "157/13 Luong The Vinh Street, Ward 1, City Ca Mau.", "0812888858", "8b3e6a69-6154-4a41-98c8-327dbfbf5ef8", "0812888858" });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "pet_Id", "pet_CategoryId", "pet_Description", "pet_Image1", "pet_Image2", "pet_Image3", "pet_Image4", "pet_Image5", "pet_IsDelete", "pet_Lifespan", "pet_Name", "pet_Origin", "pet_OrtherName", "pet_Price", "pet_Weight" },
                values: new object[,]
                {
                    { "1077a922-5fcc-423b-b3fa-87d6d5d76121", "56b58303-c5c4-462f-80f2-84f29696ce70", "BORDER COLLIE", "image/giongcho/BORDER-COLLIE.jpg", "image/giongcho/BORDER-COLLIE.jpg", "image/giongcho/BORDER-COLLIE.jpg", "image/giongcho/BORDER-COLLIE.jpg", "image/giongcho/BORDER-COLLIE.jpg", false, 1.0, "BORDER COLLIE", "Origin", "OrtherName", 1.0, 3.0 },
                    { "160e44f3-705f-4a71-8f53-71f98014c0bb", "56b58303-c5c4-462f-80f2-84f29696ce70", "ROTTWEILER", "image/giongcho/rottweiler.jpg", "image/giongcho/rottweiler.jpg", "image/giongcho/rottweiler.jpg", "image/giongcho/rottweiler.jpg", "image/giongcho/rottweiler.jpg", false, 1.0, "ROTTWEILER", "ROTTWEILER", "ROTTWEILER", 1.0, 3.0 },
                    { "18fd73ba-348e-48fd-ab38-1848474ba98a", "56b58303-c5c4-462f-80f2-84f29696ce70", "GREAT DANE", "image/giongcho/golden-retriever.jpg", "image/giongcho/golden-retriever.jpg", "image/giongcho/golden-retriever.jpg", "image/giongcho/golden-retriever.jpg", "image/giongcho/golden-retriever.jpg", false, 1.0, "GREAT DANE", "GREAT DANE", "GREAT DANE", 1.0, 3.0 },
                    { "1ac399d6-9757-4d82-832b-e5a29399274d", "56b58303-c5c4-462f-80f2-84f29696ce70", "PUG", "image/giongcho/pub.jpg", "image/giongcho/pub.jpg", "image/giongcho/pub.jpg", "image/giongcho/pub.jpg", "image/giongcho/pub.jpg", false, 1.0, "PUG", "PUG", "PUG", 1.0, 3.0 },
                    { "2acdf32f-231e-4887-9d66-fd9be9ba0665", "56b58303-c5c4-462f-80f2-84f29696ce70", "GOLDEN RETRIEVE", "image/giongcho/golden-retriever.jpg", "image/giongcho/golden-retriever.jpg", "image/giongcho/golden-retriever.jpg", "image/giongcho/golden-retriever.jpg", "image/giongcho/golden-retriever.jpg", false, 1.0, "GOLDEN RETRIEVE", "GOLDEN RETRIEVE", "GOLDEN RETRIEVE", 1.0, 3.0 },
                    { "2de53e61-b28d-49f8-bf61-28d1b4e9d010", "56b58303-c5c4-462f-80f2-84f29696ce70", "PITBULL", "image/giongcho/pitbull.jpg", "image/giongcho/pitbull.jpg", "image/giongcho/pitbull.jpg", "image/giongcho/pitbull.jpg", "image/giongcho/pitbull.jpg", false, 1.0, "PITBULL", "PITBULL", "PITBULL", 1.0, 3.0 },
                    { "3e0adabf-0a9d-4727-bef5-48c9dd938d3d", "56b58303-c5c4-462f-80f2-84f29696ce70", "Japan Dog", "image/giongcho/chonhatban.png", "image/giongcho/chonhatban.png", "image/giongcho/chonhatban.png", "image/giongcho/chonhatban.png", "image/giongcho/chonhatban.png", false, 1.0, "Japan Dog", "Origin", "OrtherName", 1.0, 3.0 },
                    { "4462abd5-8b57-4cb2-b1e9-d9600814cdfe", "56b58303-c5c4-462f-80f2-84f29696ce70", "BULLY AMERICAN", "image/giongcho/bully-american.jpg", "image/giongcho/bully-american.jpg", "image/giongcho/bully-american.jpg", "image/giongcho/bully-american.jpg", "image/giongcho/bully-american.jpg", false, 1.0, "BULLY AMERICAN", "Origin", "OrtherName", 1.0, 3.0 },
                    { "4ef4b172-1baf-422e-9e92-393bfd6fea30", "56b58303-c5c4-462f-80f2-84f29696ce70", "BULLDOG", "image/giongcho/bulldog.jpg", "image/giongcho/bulldog.jpg", "image/giongcho/bulldog.jpg", "image/giongcho/bulldog.jpg", "image/giongcho/bulldog.jpg", false, 1.0, "BULLDOG", "Origin", "OrtherName", 1.0, 3.0 },
                    { "4f152631-848d-4ce8-9033-e951a2f455ff", "56b58303-c5c4-462f-80f2-84f29696ce70", "MALINOIS", "image/giongcho/choMalinois.png", "image/giongcho/choMalinois.png", "image/giongcho/choMalinois.png", "image/giongcho/choMalinois.png", "image/giongcho/choMalinois.png", false, 1.0, "MALINOIS", "MALINOIS", "MALINOIS", 1.0, 3.0 },
                    { "50740204-b161-498d-ace9-0fa591b6d8f2", "56b58303-c5c4-462f-80f2-84f29696ce70", "AKITA INU", "image/giongcho/akita-inu.jpg", "image/giongcho/akita-inu.jpg", "image/giongcho/akita-inu.jpg", "image/giongcho/akita-inu.jpg", "image/giongcho/akita-inu.jpg", false, 1.0, "AKITA INU", "Origin", "OrtherName", 1.0, 3.0 },
                    { "54af5965-e4e0-4237-a2d8-4e7a1673c0ec", "56b58303-c5c4-462f-80f2-84f29696ce70", "GOLDEN RETRIEVER", "image/giongcho/dobermann.jpg", "image/giongcho/dobermann.jpg", "image/giongcho/dobermann.jpg", "image/giongcho/dobermann.jpg", "image/giongcho/dobermann.jpg", false, 1.0, "GOLDEN RETRIEVER", "GOLDEN RETRIEVER", "GOLDEN RETRIEVER", 1.0, 3.0 },
                    { "5a4909a1-9823-4b6c-adab-07e63b69d3b1", "56b58303-c5c4-462f-80f2-84f29696ce70", "BECGIE Germany", "image/giongcho/becgie-duc.jpg", "image/giongcho/becgie-duc.jpg", "image/giongcho/becgie-duc.jpg", "image/giongcho/becgie-duc.jpg", "image/giongcho/becgie-duc.jpg", false, 1.0, "BECGIE Germany", "Origin", "OrtherName", 1.0, 3.0 },
                    { "6e22310d-e93c-402d-876d-9ef0ad62484f", "56b58303-c5c4-462f-80f2-84f29696ce70", "CHIHUAHUA", "image/giongcho/chihuahua.jpg", "image/giongcho/chihuahua.jpg", "image/giongcho/chihuahua.jpg", "image/giongcho/chihuahua.jpg", "image/giongcho/chihuahua.jpg", false, 1.0, "CHIHUAHUA", "Origin", "OrtherName", 1.0, 3.0 },
                    { "6e4e38a5-d800-40df-a5fe-c7570d73a2a3", "56b58303-c5c4-462f-80f2-84f29696ce70", "Sausage", "image/giongcho/lap-xuong.jpg", "image/giongcho/lap-xuong.jpg", "image/giongcho/lap-xuong.jpg", "image/giongcho/lap-xuong.jpg", "image/giongcho/lap-xuong.jpg", false, 1.0, "Sausage", "Sausage", "Sausage", 1.0, 3.0 },
                    { "70e57592-a2da-414a-a646-f49bd394a670", "56b58303-c5c4-462f-80f2-84f29696ce70", "BLABRADOR", "image/giongcho/labrador.png", "image/giongcho/labrador.png", "image/giongcho/labrador.png", "image/giongcho/labrador.png", "image/giongcho/labrador.png", false, 1.0, "BLABRADOR", "BLABRADOR", "BLABRADOR", 1.0, 3.0 },
                    { "7a4f15f3-257a-44ca-9583-f8b9b8edc039", "56b58303-c5c4-462f-80f2-84f29696ce70", "Phu Quoc dogs", "image/giongcho/phu-quoc.jpg", "image/giongcho/phu-quoc.jpg", "image/giongcho/phu-quoc.jpg", "image/giongcho/phu-quoc.jpg", "image/giongcho/phu-quoc.jpg", false, 1.0, "Phu Quoc dogs", "Phu Quoc dogs", "Phu Quoc dogs", 1.0, 3.0 },
                    { "7ffb76aa-7750-497f-8490-35f20d98f606", "56b58303-c5c4-462f-80f2-84f29696ce70", "SHIBA INU", "image/giongcho/shiba.jpg", "image/giongcho/shiba.jpg", "image/giongcho/shiba.jpg", "image/giongcho/shiba.jpg", "image/giongcho/shiba.jpg", false, 1.0, "SHIBA INU", "SHIBA INU", "SHIBA INU", 1.0, 3.0 },
                    { "84c2ba6a-0be3-45d5-9f11-7483bb0cc867", "56b58303-c5c4-462f-80f2-84f29696ce70", "ALASKA", "image/giongcho/alaska.jpg", "image/giongcho/alaska.jpg", "image/giongcho/alaska.jpg", "image/giongcho/alaska.jpg", "image/giongcho/alaska.jpg", false, 1.0, "ALASKA", "Origin", "OrtherName", 1.0, 3.0 },
                    { "8854a6af-905b-4eb6-b3fb-4a76fdc3409b", "56b58303-c5c4-462f-80f2-84f29696ce70", "HUSKY", "image/giongcho/husky.jpg", "image/giongcho/husky.jpg", "image/giongcho/husky.jpg", "image/giongcho/husky.jpg", "image/giongcho/husky.jpg", false, 1.0, "HUSKY", "HUSKY", "HUSKY", 1.0, 3.0 },
                    { "8d662e0e-6b2e-480e-a705-fe6c7cc27622", "56b58303-c5c4-462f-80f2-84f29696ce70", "Tibetan Clams", "image/giongcho/ngaottang.jpg", "image/giongcho/ngaottang.jpg", "image/giongcho/ngaottang.jpg", "image/giongcho/ngaottang.jpg", "image/giongcho/ngaottang.jpg", false, 1.0, "Tibetan Clams", "Tibetan Clams", "Tibetan Clams", 1.0, 3.0 },
                    { "98739036-a5ac-4a54-9b56-4e401139ae81", "56b58303-c5c4-462f-80f2-84f29696ce70", "Phoc squirrel dog", "image/giongcho/phoc-soc.jpg", "image/giongcho/phoc-soc.jpg", "image/giongcho/phoc-soc.jpg", "image/giongcho/phoc-soc.jpg", "image/giongcho/phoc-soc.jpg", false, 1.0, "Phoc squirrel dog", "Phoc squirrel dog", "Phoc squirrel dog", 1.0, 3.0 },
                    { "9d57b4c4-d624-4f97-aa53-a0b89753d5fe", "56b58303-c5c4-462f-80f2-84f29696ce70", "SAMOYED", "image/giongcho/samoyed.jpg", "image/giongcho/samoyed.jpg", "image/giongcho/samoyed.jpg", "image/giongcho/samoyed.jpg", "image/giongcho/samoyed.jpg", false, 1.0, "SAMOYED", "SAMOYED", "SAMOYED", 1.0, 3.0 },
                    { "aed45db6-b199-4325-9121-f09e0468bf2e", "56b58303-c5c4-462f-80f2-84f29696ce70", "ROTTWEILER", "image/giongcho/rottweiler.jpg", "image/giongcho/rottweiler.jpg", "image/giongcho/rottweiler.jpg", "image/giongcho/rottweiler.jpg", "image/giongcho/rottweiler.jpg", false, 1.0, "ROTTWEILER", "ROTTWEILER", "ROTTWEILER", 1.0, 3.0 },
                    { "b07208c2-0594-4ee3-ae85-166b1de1d93c", "56b58303-c5c4-462f-80f2-84f29696ce70", "Deer Pug dog", "image/giongcho/phoc-huou.jpg", "image/giongcho/phoc-huou.jpg", "image/giongcho/phoc-huou.jpg", "image/giongcho/phoc-huou.jpg", "image/giongcho/phoc-huou.jpg", false, 1.0, "Deer Pug dog", "Deer Pug dog", "Deer Pug dog", 1.0, 3.0 },
                    { "b375a8dc-8c2b-427e-b5d2-401b7ee83554", "56b58303-c5c4-462f-80f2-84f29696ce70", "Vitespitz", "image/giongcho/chobacha.png", "image/giongcho/chobacha.png", "image/giongcho/chobacha.png", "image/giongcho/chobacha.png", "image/giongcho/chobacha.png", false, 1.0, "Vitespitz", "Origin", "OrtherName", 1.0, 3.0 },
                    { "baa99523-a85c-4d95-ad4c-9312a9b7fc13", "56b58303-c5c4-462f-80f2-84f29696ce70", "CHOW CHOW", "image/giongcho/chow-chow.jpg", "image/giongcho/chow-chow.jpg", "image/giongcho/chow-chow.jpg", "image/giongcho/chow-chow.jpg", "image/giongcho/chow-chow.jpg", false, 1.0, "CHOW CHOW", "Origin", "OrtherName", 1.0, 3.0 },
                    { "dfdb25a6-f912-444a-bbdd-716ae1646cf9", "56b58303-c5c4-462f-80f2-84f29696ce70", "COCKER SPANIEL", "image/giongcho/cocker.png", "image/giongcho/cocker.png", "image/giongcho/cocker.png", "image/giongcho/cocker.png", "image/giongcho/cocker.png", false, 1.0, "COCKER SPANIEL", "Origin", "OrtherName", 1.0, 3.0 },
                    { "e2d0e537-d570-4ff1-913d-1b1c86fc62ad", "56b58303-c5c4-462f-80f2-84f29696ce70", "H'Mong Coc", "image/giongcho/mong-coc.jpg", "image/giongcho/mong-coc.jpg", "image/giongcho/mong-coc.jpg", "image/giongcho/mong-coc.jpg", "image/giongcho/mong-coc.jpg", false, 1.0, "H'Mong Coc", "H'Mong Coc", "H'Mong Coc", 1.0, 3.0 },
                    { "e6574ef9-c4f5-4249-8dd6-1e34dbe2a77b", "56b58303-c5c4-462f-80f2-84f29696ce70", "DOBERMANN", "image/giongcho/dobermann.jp", "image/giongcho/dobermann.jp", "image/giongcho/dobermann.jp", "image/giongcho/dobermann.jp", "image/giongcho/dobermann.jp", false, 1.0, "DOBERMANN", "Origin", "OrtherName", 1.0, 3.0 },
                    { "e99ca212-b3e6-4aea-8426-0a5ce7575970", "56b58303-c5c4-462f-80f2-84f29696ce70", "GREAT DANE", "image/giongcho/great-dane.jpg", "image/giongcho/great-dane.jpg", "image/giongcho/great-dane.jpg", "image/giongcho/great-dane.jpg", "image/giongcho/great-dane.jpg", false, 1.0, "GREAT DANE", "GREAT DANE", "GREAT DANE", 1.0, 3.0 },
                    { "f7b84a71-d1d5-4ae9-ac17-f3b6980f511e", "56b58303-c5c4-462f-80f2-84f29696ce70", "POODLE", "image/giongcho/poodle.jpg", "image/giongcho/poodle.jpg", "image/giongcho/poodle.jpg", "image/giongcho/poodle.jpg", "image/giongcho/poodle.jpg", false, 1.0, "POODLE", "POODLE", "POODLE", 1.0, 3.0 },
                    { "f9ef84dd-70c4-42a3-b522-cfd75641e187", "56b58303-c5c4-462f-80f2-84f29696ce70", "CORGI", "image/giongcho/corgy.jpg", "image/giongcho/corgy.jpg", "image/giongcho/corgy.jpg", "image/giongcho/corgy.jpg", "image/giongcho/corgy.jpg", false, 1.0, "CORGI", "Origin", "OrtherName", 1.0, 3.0 },
                    { "ff250da1-fe77-4795-93c4-2713d8a1a67e", "56b58303-c5c4-462f-80f2-84f29696ce70", "Dalmatian", "image/giongcho/cho-dom.jpg", "image/giongcho/cho-dom.jpg", "image/giongcho/cho-dom.jpg", "image/giongcho/cho-dom.jpg", "image/giongcho/cho-dom.jpg", false, 1.0, "Dalmatian", "Origin", "OrtherName", 1.0, 3.0 }
                });

            migrationBuilder.InsertData(
                table: "UserContact",
                columns: new[] { "uc_Id", "uc_Content", "uc_Email", "uc_IsDelete", "uc_Name", "uc_Phone", "uc_UserCreate" },
                values: new object[] { "824a996b-08a2-492f-b322-fbabecec9fe5", "Content", "Email", false, "Name", "Phone", "8b3e6a69-6154-4a41-98c8-327dbfbf5ef8" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "370047eb-dbf2-4313-9d66-ce4ce1cd2e2f", "8b3e6a69-6154-4a41-98c8-327dbfbf5ef8" });

            migrationBuilder.CreateIndex(
                name: "IX_Bills_bill_UserId",
                table: "Bills",
                column: "bill_UserId");

            migrationBuilder.CreateIndex(
                name: "IX_IntroducePage_introduce_UserCreate",
                table: "IntroducePage",
                column: "introduce_UserCreate");

            migrationBuilder.CreateIndex(
                name: "IX_Pets_pet_CategoryId",
                table: "Pets",
                column: "pet_CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PettInBill_pib_BillId",
                table: "PettInBill",
                column: "pib_BillId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductInBill_proib_BillId",
                table: "ProductInBill",
                column: "proib_BillId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_product_CategoryId",
                table: "Products",
                column: "product_CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_RoleId",
                table: "RoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Roles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserContact_uc_UserCreate",
                table: "UserContact",
                column: "uc_UserCreate");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogins_UserId",
                table: "UserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "Users",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Users",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IntroducePage");

            migrationBuilder.DropTable(
                name: "PettInBill");

            migrationBuilder.DropTable(
                name: "ProductInBill");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserContact");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "Pets");

            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "PetCategories");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "ProductCategories");
        }
    }
}
