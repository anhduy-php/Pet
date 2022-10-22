using Database.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;

namespace Database.Data
{
    public static class Data
    {
        public static void Seed(this ModelBuilder builder)
        {


            // Table Pet Categories

            string newPc_Id1 = Guid.NewGuid().ToString();
            string newPc_Id2 = Guid.NewGuid().ToString();
            string newPc_Id3 = Guid.NewGuid().ToString();
            string newPc_Id4 = Guid.NewGuid().ToString();
            string newPc_Id5 = Guid.NewGuid().ToString();

            builder.Entity<PetCategories>().HasData(
                new PetCategories()
                {
                    pc_Id = newPc_Id1,
                    pc_Name = "Name",
                    pc_Description = "Description",
                    pc_IsDelete = false
                }
                );



            ////Table Pets
            ///
            string newPet_Id1 = Guid.NewGuid().ToString();

            builder.Entity<Pets>().HasData(
                        new Pets()
                        {
                            pet_Id = newPet_Id1,
                            pet_Name = "Name",
                            pet_Description = "Description",
                            pet_Price = 1,
                            pet_OrtherName = "OrtherName",
                            pet_Origin = "Origin",
                            pet_CategoryId = newPc_Id1,
                            pet_Weight = 3,
                            pet_Lifespan = 1,
                            pet_IsDelete = false
                        });

            // Table Roles
            string newRole_Id1 = Guid.NewGuid().ToString();

            builder.Entity<Roles>().HasData(
                new Roles()
                {
                    Id = newRole_Id1,
                    Name = "ADMIN",
                    NormalizedName = "admin",
                    Description = "admin",
                    isDelete = false
                }
                );


            // Table Users
            string newUser_Id1 = Guid.NewGuid().ToString();
            var hasher = new PasswordHasher<Users>();

            builder.Entity<Users>().HasData(
                new Users()
                {
                    Id = newUser_Id1,
                    UserName = "Admin",
                    FirstName = "FirstName",
                    LastName = "LastName",
                    NormalizedUserName = "STAFF@GMAIL.COM",
                    NormalizedEmail = "STAFF@GMAIL.COM",
                    Email = "staff@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "123456Aa@"),
                    SecurityStamp = Guid.NewGuid().ToString(),
                    DoB = DateTime.Now,
                    isDelete = false
                }
                );

            //  Table User Role
            builder.Entity<IdentityUserRole<string>>().HasData(
           new IdentityUserRole<string>
           {
               RoleId = newRole_Id1,
               UserId = newUser_Id1
           });

            //Table User Contact
            builder.Entity<UserContact>().HasData(
                new UserContact()
                {
                    uc_Id = Guid.NewGuid().ToString(),
                    uc_Name = "Name",
                    uc_Email = "Email",
                    uc_Content = "Content",
                    uc_Phone = "Phone",
                    uc_IsDelete = false,
                    uc_UserCreate = newUser_Id1
                }
                );

            //Table Product Categoires
            var newProc_Id1 = Guid.NewGuid().ToString();
            var newProc_Id2 = Guid.NewGuid().ToString();
            var newProc_Id3 = Guid.NewGuid().ToString();

            builder.Entity<ProductCategories>().HasData(
                new ProductCategories()
                {
                    proc_Id = newProc_Id1,
                    proc_Name = "Name",
                    proc_Description = "Description",
                    proc_IsDelete = false
                }
                );

            // Table Product
            var newProduct_Id1 = Guid.NewGuid().ToString();

            builder.Entity<Products>().HasData(
                    new Products()
                    {
                        product_Id = newProduct_Id1,
                        product_Name = "Name",
                        product_Description = "Description",
                        product_Price = 1,
                        product_Rate = 5,
                        product_ReProducePrice = 0,
                        product_CategoryId = newProc_Id1,
                        product_IsDelete = false
                    }
                    );

            // Table Bills

            var newBill_Id1 = Guid.NewGuid().ToString();
            builder.Entity<Bills>().HasData(
                new Bills()
                {
                    bill_Id = newBill_Id1,
                    bill_UserId = newUser_Id1,
                    bill_StatusPayment = true,
                    bill_StatusReviceOrder = false,
                    bill_Total = 1,
                    bill_StartDateTime = DateTime.Now,
                    bill_Cancel = false
                }
                );


            // Table PetInBill
            builder.Entity<PettInBill>().HasData(
                    new PettInBill()
                    {
                        pib_PetId = newPet_Id1,
                        pib_BillId = newBill_Id1,
                        pib_Quantity = 1,
                        pib_Price = 12,
                        pib_IsDelete = false
                    }
                    );

            // Table Prodcut In bill
            builder.Entity<ProductInBill>().HasData(
                new ProductInBill()
                {
                    proib_ProductId = newProduct_Id1,
                    proib_BillId = newBill_Id1,
                    proib_Quantity = 1,
                    proib_Price = 12,
                    proib_IsDelete = false
                }
                );

        }
    }
}