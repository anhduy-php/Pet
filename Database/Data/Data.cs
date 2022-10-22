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
            string newPc_Id1 = Guid.NewGuid().ToString();
            string newPc_Id2 = Guid.NewGuid().ToString();
            string newPc_Id3 = Guid.NewGuid().ToString();
            string newPc_Id4 = Guid.NewGuid().ToString();
            string newPc_Id5 = Guid.NewGuid().ToString();

            // Table Pet Categories
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
            builder.Entity<Pets>().HasData(
                        new Pets()
                        {
                            pet_Id = Guid.NewGuid().ToString(),
                            pet_Name = "Name",
                            pet_Description = "Description",
                            pet_Price = 1,
                            pet_OrtherName = "OrtherName",
                            pet_Origin = "Origin",
                            pet_CategoryId = "CategoryId",
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
                    isDelete = false
                }
                );


            // Table Users
            string newUser_Id1 = Guid.NewGuid().ToString();

            builder.Entity<Users>().HasData(
                new Users()
                {
                    Id = newUser_Id1,
                    UserName = "Admin",
                    PasswordHash = "123456",
                    FirstName = "FirstName",
                    LastName = "LastName",
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




        }
    }
}