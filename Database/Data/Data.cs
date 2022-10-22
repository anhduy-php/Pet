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
            string newPc_Id6 = Guid.NewGuid().ToString();
            string newPc_Id7 = Guid.NewGuid().ToString();
            string newPc_Id8 = Guid.NewGuid().ToString();
            string newPc_Id9 = Guid.NewGuid().ToString();
            string newPc_Id10 = Guid.NewGuid().ToString();
            string newPc_Id11 = Guid.NewGuid().ToString();
            string newPc_Id12 = Guid.NewGuid().ToString();
            string newPc_Id13 = Guid.NewGuid().ToString();
            string newPc_Id14 = Guid.NewGuid().ToString();
            string newPc_Id15 = Guid.NewGuid().ToString();
            string newPc_Id16 = Guid.NewGuid().ToString();
            string newPc_Id17 = Guid.NewGuid().ToString();
            string newPc_Id18 = Guid.NewGuid().ToString();
            string newPc_Id19 = Guid.NewGuid().ToString();
            string newPc_Id20 = Guid.NewGuid().ToString();
            string newPc_Id21 = Guid.NewGuid().ToString();
            string newPc_Id22 = Guid.NewGuid().ToString();
            string newPc_Id23 = Guid.NewGuid().ToString();
            string newPc_Id24 = Guid.NewGuid().ToString();
            string newPc_Id25 = Guid.NewGuid().ToString();
            string newPc_Id26 = Guid.NewGuid().ToString();
            string newPc_Id27 = Guid.NewGuid().ToString();
            string newPc_Id28 = Guid.NewGuid().ToString();
            string newPc_Id29 = Guid.NewGuid().ToString();
            string newPc_Id30 = Guid.NewGuid().ToString();
            string newPc_Id31 = Guid.NewGuid().ToString();
            string newPc_Id32 = Guid.NewGuid().ToString();

            builder.Entity<PetCategories>().HasData(
                new PetCategories()
                {
                    pc_Id = newPc_Id1,
                    pc_Name = "Ikita Inu",
                    pc_Description = "Ikita Inu",
                    pc_IsDelete = false
                },
                new PetCategories()
                {
                    pc_Id = newPc_Id2,
                    pc_Name = "Alaska",
                    pc_Description = "Alaska",
                    pc_IsDelete = false
                },
                new PetCategories()
                {
                    pc_Id = newPc_Id3,
                    pc_Name = "Vitespitz",
                    pc_Description = "Vitespitz",
                    pc_IsDelete = false
                },
                new PetCategories()
                {
                    pc_Id = newPc_Id4,
                    pc_Name = "Pekingese",
                    pc_Description = "Pekingese",
                    pc_IsDelete = false
                },
                new PetCategories()
                {
                    pc_Id = newPc_Id5,
                    pc_Name = "Becgie Germany",
                    pc_Description = "Becgie Germany",
                    pc_IsDelete = false
                },
                new PetCategories()
                {
                    pc_Id = newPc_Id6,
                    pc_Name = "Border collie",
                    pc_Description = "Border collie",
                    pc_IsDelete = false
                },
                new PetCategories()
                {
                    pc_Id = newPc_Id7,
                    pc_Name = "Bulldog",
                    pc_Description = "Bulldog",
                    pc_IsDelete = false
                },
                new PetCategories()
                {
                    pc_Id = newPc_Id8,
                    pc_Name = "Bully American",
                    pc_Description = "Bully American",
                    pc_IsDelete = false
                },
                new PetCategories()
                {
                    pc_Id = newPc_Id9,
                    pc_Name = "Chihuahua",
                    pc_Description = "Chihuahua",
                    pc_IsDelete = false
                },
                new PetCategories()
                {
                    pc_Id = newPc_Id10,
                    pc_Name = "Dalmatian",
                    pc_Description = "Dalmatian",
                    pc_IsDelete = false
                },
                new PetCategories()
                {
                    pc_Id = newPc_Id11,
                    pc_Name = "Japan Dog",
                    pc_Description = "Japan Dog",
                    pc_IsDelete = false
                },
                new PetCategories()
                {
                    pc_Id = newPc_Id12,
                    pc_Name = "Chow Chow",
                    pc_Description = "Chow Chow",
                    pc_IsDelete = false
                },
                new PetCategories()
                {
                    pc_Id = newPc_Id13,
                    pc_Name = "Cocker Spaniel",
                    pc_Description = "Cocker Spaniel",
                    pc_IsDelete = false
                },
                new PetCategories()
                {
                    pc_Id = newPc_Id14,
                    pc_Name = "Corgi",
                    pc_Description = "Corgi",
                    pc_IsDelete = false
                },
                new PetCategories()
                {
                    pc_Id = newPc_Id15,
                    pc_Name = "Dobermann",
                    pc_Description = "Dobermann",
                    pc_IsDelete = false
                },
                new PetCategories()
                {
                    pc_Id = newPc_Id16,
                    pc_Name = "Golden Retriever",
                    pc_Description = "Golden Retriever",
                    pc_IsDelete = false
                },
                new PetCategories()
                {
                    pc_Id = newPc_Id17,
                    pc_Name = "Great Dane",
                    pc_Description = "Great Dane",
                    pc_IsDelete = false
                },
                new PetCategories()
                {
                    pc_Id = newPc_Id18,
                    pc_Name = "H'Mong Coc",
                    pc_Description = "H'Mong Coc",
                    pc_IsDelete = false
                },
                new PetCategories()
                {
                    pc_Id = newPc_Id19,
                    pc_Name = "Husky",
                    pc_Description = "Husky",
                    pc_IsDelete = false
                },
                new PetCategories()
                {
                    pc_Id = newPc_Id20,
                    pc_Name = "Labrador",
                    pc_Description = "Labrador",
                    pc_IsDelete = false
                },
                new PetCategories()
                {
                    pc_Id = newPc_Id21,
                    pc_Name = "Sausage",
                    pc_Description = "Sausage",
                    pc_IsDelete = false
                },
                new PetCategories()
                {
                    pc_Id = newPc_Id22,
                    pc_Name = "Malinois",
                    pc_Description = "Malinois",
                    pc_IsDelete = false
                },
                new PetCategories()
                {
                    pc_Id = newPc_Id23,
                    pc_Name = "Tibetan Clams",
                    pc_Description = "Tibetan Clams",
                    pc_IsDelete = false
                },
                new PetCategories()
                {
                    pc_Id = newPc_Id24,
                    pc_Name = "Pho Deer",
                    pc_Description = "Pho Deer",
                    pc_IsDelete = false
                },
                new PetCategories()
                {
                    pc_Id = newPc_Id25,
                    pc_Name = "Phoc Soc",
                    pc_Description = "Phoc Soc",
                    pc_IsDelete = false
                },
                new PetCategories()
                {
                    pc_Id = newPc_Id26,
                    pc_Name = "Phu Quoc",
                    pc_Description = "Phu Quoc",
                    pc_IsDelete = false
                },
                new PetCategories()
                {
                    pc_Id = newPc_Id27,
                    pc_Name = "Pitbull",
                    pc_Description = "Pitbull",
                    pc_IsDelete = false
                },
                new PetCategories()
                {
                    pc_Id = newPc_Id28,
                    pc_Name = "Poodle",
                    pc_Description = "Poodle",
                    pc_IsDelete = false
                },
                new PetCategories()
                {
                    pc_Id = newPc_Id29,
                    pc_Name = "Pug",
                    pc_Description = "Pug",
                    pc_IsDelete = false
                },
                new PetCategories()
                {
                    pc_Id = newPc_Id30,
                    pc_Name = "Rottweiler",
                    pc_Description = "Rottweiler",
                    pc_IsDelete = false
                },
                new PetCategories()
                {
                    pc_Id = newPc_Id31,
                    pc_Name = "Samoyed",
                    pc_Description = "Samoyed",
                    pc_IsDelete = false
                },
                new PetCategories()
                {
                    pc_Id = newPc_Id32,
                    pc_Name = "Shiba Inu",
                    pc_Description = "Shiba Inu",
                    pc_IsDelete = false
                }
                );



            ////Table Pets
            ///
            string newPet_Id1 = Guid.NewGuid().ToString();
            string newPet_Id2 = Guid.NewGuid().ToString();
            string newPet_Id3 = Guid.NewGuid().ToString();
            string newPet_Id4 = Guid.NewGuid().ToString();
            string newPet_Id5 = Guid.NewGuid().ToString();
            string newPet_Id6 = Guid.NewGuid().ToString();
            string newPet_Id7 = Guid.NewGuid().ToString();
            string newPet_Id8 = Guid.NewGuid().ToString();
            string newPet_Id9 = Guid.NewGuid().ToString();
            string newPet_Id10 = Guid.NewGuid().ToString();
            string newPet_Id11 = Guid.NewGuid().ToString();
            string newPet_Id12 = Guid.NewGuid().ToString();
            string newPet_Id13 = Guid.NewGuid().ToString();
            string newPet_Id14 = Guid.NewGuid().ToString();
            string newPet_Id15 = Guid.NewGuid().ToString();
            string newPet_Id16 = Guid.NewGuid().ToString();
            string newPet_Id17 = Guid.NewGuid().ToString();
            string newPet_Id18 = Guid.NewGuid().ToString();
            string newPet_Id19 = Guid.NewGuid().ToString();
            string newPet_Id20 = Guid.NewGuid().ToString();
            string newPet_Id21 = Guid.NewGuid().ToString();
            string newPet_Id22 = Guid.NewGuid().ToString();
            string newPet_Id23 = Guid.NewGuid().ToString();
            string newPet_Id24 = Guid.NewGuid().ToString();
            string newPet_Id25 = Guid.NewGuid().ToString();
            string newPet_Id26 = Guid.NewGuid().ToString();
            string newPet_Id27 = Guid.NewGuid().ToString();
            string newPet_Id28 = Guid.NewGuid().ToString();
            string newPet_Id29 = Guid.NewGuid().ToString();
            string newPet_Id30 = Guid.NewGuid().ToString();
            string newPet_Id31 = Guid.NewGuid().ToString();
            string newPet_Id32 = Guid.NewGuid().ToString();
            string newPet_Id33 = Guid.NewGuid().ToString();
            string newPet_Id34 = Guid.NewGuid().ToString();
            string newPet_Id35 = Guid.NewGuid().ToString();

            builder.Entity<Pets>().HasData(
                        new Pets()
                        {
                            pet_Id = newPet_Id1,
                            pet_Name = "AKITA INU",
                            pet_Description = "AKITA INU",
                            pet_Image1 = "image/giongcho/akita-inu.jpg",
                            pet_Image2 = "image/giongcho/akita-inu.jpg",
                            pet_Image3 = "image/giongcho/akita-inu.jpg",
                            pet_Image4 = "image/giongcho/akita-inu.jpg",
                            pet_Image5 = "image/giongcho/akita-inu.jpg",
                            pet_Price = 1,
                            pet_OrtherName = "OrtherName",
                            pet_Origin = "Origin",
                            pet_CategoryId = newPc_Id1,
                            pet_Weight = 3,
                            pet_Lifespan = 1,
                            pet_IsDelete = false
                        },
                        new Pets()
                        {
                            pet_Id = newPet_Id2,
                            pet_Name = "ALASKA",
                            pet_Description = "ALASKA",
                            pet_Image1 = "image/giongcho/alaska.jpg",
                            pet_Image2 = "image/giongcho/alaska.jpg",
                            pet_Image3 = "image/giongcho/alaska.jpg",
                            pet_Image4 = "image/giongcho/alaska.jpg",
                            pet_Image5 = "image/giongcho/alaska.jpg",
                            pet_Price = 1,
                            pet_OrtherName = "OrtherName",
                            pet_Origin = "Origin",
                            pet_CategoryId = newPc_Id1,
                            pet_Weight = 3,
                            pet_Lifespan = 1,
                            pet_IsDelete = false
                        }, 
                        new Pets()
                        {
                            pet_Id = newPet_Id3,
                            pet_Name = "Vitespitz",
                            pet_Description = "Vitespitz",
                            pet_Image1 = "image/giongcho/chobacha.png",
                            pet_Image2 = "image/giongcho/chobacha.png",
                            pet_Image3 = "image/giongcho/chobacha.png",
                            pet_Image4 = "image/giongcho/chobacha.png",
                            pet_Image5 = "image/giongcho/chobacha.png",
                            pet_Price = 1,
                            pet_OrtherName = "OrtherName",
                            pet_Origin = "Origin",
                            pet_CategoryId = newPc_Id1,
                            pet_Weight = 3,
                            pet_Lifespan = 1,
                            pet_IsDelete = false
                        }, 
                        new Pets()
                        {
                            pet_Id = newPet_Id4,
                            pet_Name = "BECGIE Germany",
                            pet_Description = "BECGIE Germany",
                            pet_Image1 = "image/giongcho/becgie-duc.jpg",
                            pet_Image2 = "image/giongcho/becgie-duc.jpg",
                            pet_Image3 = "image/giongcho/becgie-duc.jpg",
                            pet_Image4 = "image/giongcho/becgie-duc.jpg",
                            pet_Image5 = "image/giongcho/becgie-duc.jpg",
                            pet_Price = 1,
                            pet_OrtherName = "OrtherName",
                            pet_Origin = "Origin",
                            pet_CategoryId = newPc_Id1,
                            pet_Weight = 3,
                            pet_Lifespan = 1,
                            pet_IsDelete = false
                        }, 
                        new Pets()
                        {
                            pet_Id = newPet_Id5,
                            pet_Name = "BORDER COLLIE",
                            pet_Description = "BORDER COLLIE",
                            pet_Image1 = "image/giongcho/BORDER-COLLIE.jpg",
                            pet_Image2 = "image/giongcho/BORDER-COLLIE.jpg",
                            pet_Image3 = "image/giongcho/BORDER-COLLIE.jpg",
                            pet_Image4 = "image/giongcho/BORDER-COLLIE.jpg",
                            pet_Image5 = "image/giongcho/BORDER-COLLIE.jpg",
                            pet_Price = 1,
                            pet_OrtherName = "OrtherName",
                            pet_Origin = "Origin",
                            pet_CategoryId = newPc_Id1,
                            pet_Weight = 3,
                            pet_Lifespan = 1,
                            pet_IsDelete = false
                        }, 
                        new Pets()
                        {
                            pet_Id = newPet_Id6,
                            pet_Name = "BULLDOG",
                            pet_Description = "BULLDOG",
                            pet_Image1 = "image/giongcho/bulldog.jpg",
                            pet_Image2 = "image/giongcho/bulldog.jpg",
                            pet_Image3 = "image/giongcho/bulldog.jpg",
                            pet_Image4 = "image/giongcho/bulldog.jpg",
                            pet_Image5 = "image/giongcho/bulldog.jpg",
                            pet_Price = 1,
                            pet_OrtherName = "OrtherName",
                            pet_Origin = "Origin",
                            pet_CategoryId = newPc_Id1,
                            pet_Weight = 3,
                            pet_Lifespan = 1,
                            pet_IsDelete = false
                        }, 
                        new Pets()
                        {
                            pet_Id = newPet_Id7,
                            pet_Name = "BULLY AMERICAN",
                            pet_Description = "BULLY AMERICAN",
                            pet_Image1 = "image/giongcho/bully-american.jpg",
                            pet_Image2 = "image/giongcho/bully-american.jpg",
                            pet_Image3 = "image/giongcho/bully-american.jpg",
                            pet_Image4 = "image/giongcho/bully-american.jpg",
                            pet_Image5 = "image/giongcho/bully-american.jpg",
                            pet_Price = 1,
                            pet_OrtherName = "OrtherName",
                            pet_Origin = "Origin",
                            pet_CategoryId = newPc_Id1,
                            pet_Weight = 3,
                            pet_Lifespan = 1,
                            pet_IsDelete = false
                        }, 
                        new Pets()
                        {
                            pet_Id = newPet_Id8,
                            pet_Name = "CHIHUAHUA",
                            pet_Description = "CHIHUAHUA",
                            pet_Image1 = "image/giongcho/chihuahua.jpg",
                            pet_Image2 = "image/giongcho/chihuahua.jpg",
                            pet_Image3 = "image/giongcho/chihuahua.jpg",
                            pet_Image4 = "image/giongcho/chihuahua.jpg",
                            pet_Image5 = "image/giongcho/chihuahua.jpg",
                            pet_Price = 1,
                            pet_OrtherName = "OrtherName",
                            pet_Origin = "Origin",
                            pet_CategoryId = newPc_Id1,
                            pet_Weight = 3,
                            pet_Lifespan = 1,
                            pet_IsDelete = false
                        }, 
                        new Pets()
                        {
                            pet_Id = newPet_Id9,
                            pet_Name = "Dalmatian",
                            pet_Description = "Dalmatian",
                            pet_Image1 = "image/giongcho/cho-dom.jpg",
                            pet_Image2 = "image/giongcho/cho-dom.jpg",
                            pet_Image3 = "image/giongcho/cho-dom.jpg",
                            pet_Image4 = "image/giongcho/cho-dom.jpg",
                            pet_Image5 = "image/giongcho/cho-dom.jpg",
                            pet_Price = 1,
                            pet_OrtherName = "OrtherName",
                            pet_Origin = "Origin",
                            pet_CategoryId = newPc_Id1,
                            pet_Weight = 3,
                            pet_Lifespan = 1,
                            pet_IsDelete = false
                        }, 
                        new Pets()
                        {
                            pet_Id = newPet_Id10,
                            pet_Name = "Japan Dog",
                            pet_Description = "Japan Dog",
                            pet_Image1 = "image/giongcho/chonhatban.png",
                            pet_Image2 = "image/giongcho/chonhatban.png",
                            pet_Image3 = "image/giongcho/chonhatban.png",
                            pet_Image4 = "image/giongcho/chonhatban.png",
                            pet_Image5 = "image/giongcho/chonhatban.png",
                            pet_Price = 1,
                            pet_OrtherName = "OrtherName",
                            pet_Origin = "Origin",
                            pet_CategoryId = newPc_Id1,
                            pet_Weight = 3,
                            pet_Lifespan = 1,
                            pet_IsDelete = false
                        }, 
                        new Pets()
                        {
                            pet_Id = newPet_Id11,
                            pet_Name = "CHOW CHOW",
                            pet_Description = "CHOW CHOW",
                            pet_Image1 = "image/giongcho/chow-chow.jpg",
                            pet_Image2 = "image/giongcho/chow-chow.jpg",
                            pet_Image3 = "image/giongcho/chow-chow.jpg",
                            pet_Image4 = "image/giongcho/chow-chow.jpg",
                            pet_Image5 = "image/giongcho/chow-chow.jpg",
                            pet_Price = 1,
                            pet_OrtherName = "OrtherName",
                            pet_Origin = "Origin",
                            pet_CategoryId = newPc_Id1,
                            pet_Weight = 3,
                            pet_Lifespan = 1,
                            pet_IsDelete = false
                        }, 
                        new Pets()
                        {
                            pet_Id = newPet_Id12,
                            pet_Name = "COCKER SPANIEL",
                            pet_Description = "COCKER SPANIEL",
                            pet_Image1 = "image/giongcho/cocker.png",
                            pet_Image2 = "image/giongcho/cocker.png",
                            pet_Image3 = "image/giongcho/cocker.png",
                            pet_Image4 = "image/giongcho/cocker.png",
                            pet_Image5 = "image/giongcho/cocker.png",
                            pet_Price = 1,
                            pet_OrtherName = "OrtherName",
                            pet_Origin = "Origin",
                            pet_CategoryId = newPc_Id1,
                            pet_Weight = 3,
                            pet_Lifespan = 1,
                            pet_IsDelete = false
                        }, 
                        new Pets()
                        {
                            pet_Id = newPet_Id13,
                            pet_Name = "CORGI",
                            pet_Description = "CORGI",
                            pet_Image1 = "image/giongcho/corgy.jpg",
                            pet_Image2 = "image/giongcho/corgy.jpg",
                            pet_Image3 = "image/giongcho/corgy.jpg",
                            pet_Image4 = "image/giongcho/corgy.jpg",
                            pet_Image5 = "image/giongcho/corgy.jpg",
                            pet_Price = 1,
                            pet_OrtherName = "OrtherName",
                            pet_Origin = "Origin",
                            pet_CategoryId = newPc_Id1,
                            pet_Weight = 3,
                            pet_Lifespan = 1,
                            pet_IsDelete = false
                        }, 
                        new Pets()
                        {
                            pet_Id = newPet_Id14,
                            pet_Name = "DOBERMANN",
                            pet_Description = "DOBERMANN",
                            pet_Image1 = "image/giongcho/dobermann.jp",
                            pet_Image2 = "image/giongcho/dobermann.jp",
                            pet_Image3 = "image/giongcho/dobermann.jp",
                            pet_Image4 = "image/giongcho/dobermann.jp",
                            pet_Image5 = "image/giongcho/dobermann.jp",
                            pet_Price = 1,
                            pet_OrtherName = "OrtherName",
                            pet_Origin = "Origin",
                            pet_CategoryId = newPc_Id1,
                            pet_Weight = 3,
                            pet_Lifespan = 1,
                            pet_IsDelete = false
                        }, 
                        new Pets()
                        {
                            pet_Id = newPet_Id15,
                            pet_Name = "GOLDEN RETRIEVER",
                            pet_Description = "GOLDEN RETRIEVER",
                            pet_Image1 = "image/giongcho/dobermann.jpg",
                            pet_Image2 = "image/giongcho/dobermann.jpg",
                            pet_Image3 = "image/giongcho/dobermann.jpg",
                            pet_Image4 = "image/giongcho/dobermann.jpg",
                            pet_Image5 = "image/giongcho/dobermann.jpg",
                            pet_Price = 1,
                            pet_OrtherName = "GOLDEN RETRIEVER",
                            pet_Origin = "GOLDEN RETRIEVER",
                            pet_CategoryId = newPc_Id1,
                            pet_Weight = 3,
                            pet_Lifespan = 1,
                            pet_IsDelete = false
                        }, 
                        new Pets()
                        {
                            pet_Id = newPet_Id16,
                            pet_Name = "GOLDEN RETRIEVE",
                            pet_Description = "GOLDEN RETRIEVE",
                            pet_Image1 = "image/giongcho/golden-retriever.jpg",
                            pet_Image2 = "image/giongcho/golden-retriever.jpg",
                            pet_Image3 = "image/giongcho/golden-retriever.jpg",
                            pet_Image4 = "image/giongcho/golden-retriever.jpg",
                            pet_Image5 = "image/giongcho/golden-retriever.jpg",
                            pet_Price = 1,
                            pet_OrtherName = "GOLDEN RETRIEVE",
                            pet_Origin = "GOLDEN RETRIEVE",
                            pet_CategoryId = newPc_Id1,
                            pet_Weight = 3,
                            pet_Lifespan = 1,
                            pet_IsDelete = false
                        }, 
                        new Pets()
                        {
                            pet_Id = newPet_Id17,
                            pet_Name = "GREAT DANE",
                            pet_Description = "GREAT DANE",
                            pet_Image1 = "image/giongcho/golden-retriever.jpg",
                            pet_Image2 = "image/giongcho/golden-retriever.jpg",
                            pet_Image3 = "image/giongcho/golden-retriever.jpg",
                            pet_Image4 = "image/giongcho/golden-retriever.jpg",
                            pet_Image5 = "image/giongcho/golden-retriever.jpg",
                            pet_Price = 1,
                            pet_OrtherName = "GREAT DANE",
                            pet_Origin = "GREAT DANE",
                            pet_CategoryId = newPc_Id1,
                            pet_Weight = 3,
                            pet_Lifespan = 1,
                            pet_IsDelete = false
                        }, 
                        new Pets()
                        {
                            pet_Id = newPet_Id18,
                            pet_Name = "GREAT DANE",
                            pet_Description = "GREAT DANE",
                            pet_Image1 = "image/giongcho/great-dane.jpg",
                            pet_Image2 = "image/giongcho/great-dane.jpg",
                            pet_Image3 = "image/giongcho/great-dane.jpg",
                            pet_Image4 = "image/giongcho/great-dane.jpg",
                            pet_Image5 = "image/giongcho/great-dane.jpg",
                            pet_Price = 1,
                            pet_OrtherName = "GREAT DANE",
                            pet_Origin = "GREAT DANE",
                            pet_CategoryId = newPc_Id1,
                            pet_Weight = 3,
                            pet_Lifespan = 1,
                            pet_IsDelete = false
                        },
                        new Pets()
                        {
                            pet_Id = newPet_Id19,
                            pet_Name = "H'Mong Coc",
                            pet_Description = "H'Mong Coc",
                            pet_Image1 = "image/giongcho/mong-coc.jpg",
                            pet_Image2 = "image/giongcho/mong-coc.jpg",
                            pet_Image3 = "image/giongcho/mong-coc.jpg",
                            pet_Image4 = "image/giongcho/mong-coc.jpg",
                            pet_Image5 = "image/giongcho/mong-coc.jpg",
                            pet_Price = 1,
                            pet_OrtherName = "H'Mong Coc",
                            pet_Origin = "H'Mong Coc",
                            pet_CategoryId = newPc_Id1,
                            pet_Weight = 3,
                            pet_Lifespan = 1,
                            pet_IsDelete = false
                        }, 
                        new Pets()
                        {
                            pet_Id = newPet_Id20,
                            pet_Name = "HUSKY",
                            pet_Description = "HUSKY",
                            pet_Image1 = "image/giongcho/husky.jpg",
                            pet_Image2 = "image/giongcho/husky.jpg",
                            pet_Image3 = "image/giongcho/husky.jpg",
                            pet_Image4 = "image/giongcho/husky.jpg",
                            pet_Image5 = "image/giongcho/husky.jpg",
                            pet_Price = 1,
                            pet_OrtherName = "HUSKY",
                            pet_Origin = "HUSKY",
                            pet_CategoryId = newPc_Id1,
                            pet_Weight = 3,
                            pet_Lifespan = 1,
                            pet_IsDelete = false
                        }, 
                        new Pets()
                        {
                            pet_Id = newPet_Id21,
                            pet_Name = "BLABRADOR",
                            pet_Description = "BLABRADOR",
                            pet_Image1 = "image/giongcho/labrador.png",
                            pet_Image2 = "image/giongcho/labrador.png",
                            pet_Image3 = "image/giongcho/labrador.png",
                            pet_Image4 = "image/giongcho/labrador.png",
                            pet_Image5 = "image/giongcho/labrador.png",
                            pet_Price = 1,
                            pet_OrtherName = "BLABRADOR",
                            pet_Origin = "BLABRADOR",
                            pet_CategoryId = newPc_Id1,
                            pet_Weight = 3,
                            pet_Lifespan = 1,
                            pet_IsDelete = false
                        }, 
                        new Pets()
                        {
                            pet_Id = newPet_Id22,
                            pet_Name = "Sausage",
                            pet_Description = "Sausage",
                            pet_Image1 = "image/giongcho/lap-xuong.jpg",
                            pet_Image2 = "image/giongcho/lap-xuong.jpg",
                            pet_Image3 = "image/giongcho/lap-xuong.jpg",
                            pet_Image4 = "image/giongcho/lap-xuong.jpg",
                            pet_Image5 = "image/giongcho/lap-xuong.jpg",
                            pet_Price = 1,
                            pet_OrtherName = "Sausage",
                            pet_Origin = "Sausage",
                            pet_CategoryId = newPc_Id1,
                            pet_Weight = 3,
                            pet_Lifespan = 1,
                            pet_IsDelete = false
                        }, 
                        new Pets()
                        {
                            pet_Id = newPet_Id23,
                            pet_Name = "MALINOIS",
                            pet_Description = "MALINOIS",
                            pet_Image1 = "image/giongcho/choMalinois.png",
                            pet_Image2 = "image/giongcho/choMalinois.png",
                            pet_Image3 = "image/giongcho/choMalinois.png",
                            pet_Image4 = "image/giongcho/choMalinois.png",
                            pet_Image5 = "image/giongcho/choMalinois.png",
                            pet_Price = 1,
                            pet_OrtherName = "MALINOIS",
                            pet_Origin = "MALINOIS",
                            pet_CategoryId = newPc_Id1,
                            pet_Weight = 3,
                            pet_Lifespan = 1,
                            pet_IsDelete = false
                        }, 
                        new Pets()
                        {
                            pet_Id = newPet_Id24,
                            pet_Name = "Tibetan Clams",
                            pet_Description = "Tibetan Clams",
                            pet_Image1 = "image/giongcho/ngaottang.jpg",
                            pet_Image2 = "image/giongcho/ngaottang.jpg",
                            pet_Image3 = "image/giongcho/ngaottang.jpg",
                            pet_Image4 = "image/giongcho/ngaottang.jpg",
                            pet_Image5 = "image/giongcho/ngaottang.jpg",
                            pet_Price = 1,
                            pet_OrtherName = "Tibetan Clams",
                            pet_Origin = "Tibetan Clams",
                            pet_CategoryId = newPc_Id1,
                            pet_Weight = 3,
                            pet_Lifespan = 1,
                            pet_IsDelete = false
                        }, 
                        new Pets()
                        {
                            pet_Id = newPet_Id25,
                            pet_Name = "Deer Pug dog",
                            pet_Description = "Deer Pug dog",
                            pet_Image1 = "image/giongcho/phoc-huou.jpg",
                            pet_Image2 = "image/giongcho/phoc-huou.jpg",
                            pet_Image3 = "image/giongcho/phoc-huou.jpg",
                            pet_Image4 = "image/giongcho/phoc-huou.jpg",
                            pet_Image5 = "image/giongcho/phoc-huou.jpg",
                            pet_Price = 1,
                            pet_OrtherName = "Deer Pug dog",
                            pet_Origin = "Deer Pug dog",
                            pet_CategoryId = newPc_Id1,
                            pet_Weight = 3,
                            pet_Lifespan = 1,
                            pet_IsDelete = false
                        }, 
                        new Pets()
                        {
                            pet_Id = newPet_Id26,
                            pet_Name = "Phoc squirrel dog",
                            pet_Description = "Phoc squirrel dog",
                            pet_Image1 = "image/giongcho/phoc-soc.jpg",
                            pet_Image2 = "image/giongcho/phoc-soc.jpg",
                            pet_Image3 = "image/giongcho/phoc-soc.jpg",
                            pet_Image4 = "image/giongcho/phoc-soc.jpg",
                            pet_Image5 = "image/giongcho/phoc-soc.jpg",
                            pet_Price = 1,
                            pet_OrtherName = "Phoc squirrel dog",
                            pet_Origin = "Phoc squirrel dog",
                            pet_CategoryId = newPc_Id1,
                            pet_Weight = 3,
                            pet_Lifespan = 1,
                            pet_IsDelete = false
                        }, 
                        new Pets()
                        {
                            pet_Id = newPet_Id27,
                            pet_Name = "Phu Quoc dogs",
                            pet_Description = "Phu Quoc dogs",
                            pet_Image1 = "image/giongcho/phu-quoc.jpg",
                            pet_Image2 = "image/giongcho/phu-quoc.jpg",
                            pet_Image3 = "image/giongcho/phu-quoc.jpg",
                            pet_Image4 = "image/giongcho/phu-quoc.jpg",
                            pet_Image5 = "image/giongcho/phu-quoc.jpg",
                            pet_Price = 1,
                            pet_OrtherName = "Phu Quoc dogs",
                            pet_Origin = "Phu Quoc dogs",
                            pet_CategoryId = newPc_Id1,
                            pet_Weight = 3,
                            pet_Lifespan = 1,
                            pet_IsDelete = false
                        }, 
                        new Pets()
                        {
                            pet_Id = newPet_Id28,
                            pet_Name = "PITBULL",
                            pet_Description = "PITBULL",
                            pet_Image1 = "image/giongcho/pitbull.jpg",
                            pet_Image2 = "image/giongcho/pitbull.jpg",
                            pet_Image3 = "image/giongcho/pitbull.jpg",
                            pet_Image4 = "image/giongcho/pitbull.jpg",
                            pet_Image5 = "image/giongcho/pitbull.jpg",
                            pet_Price = 1,
                            pet_OrtherName = "PITBULL",
                            pet_Origin = "PITBULL",
                            pet_CategoryId = newPc_Id1,
                            pet_Weight = 3,
                            pet_Lifespan = 1,
                            pet_IsDelete = false
                        }, new Pets()
                        {
                            pet_Id = newPet_Id29,
                            pet_Name = "POODLE",
                            pet_Description = "POODLE",
                            pet_Image1 = "image/giongcho/poodle.jpg",
                            pet_Image2 = "image/giongcho/poodle.jpg",
                            pet_Image3 = "image/giongcho/poodle.jpg",
                            pet_Image4 = "image/giongcho/poodle.jpg",
                            pet_Image5 = "image/giongcho/poodle.jpg",
                            pet_Price = 1,
                            pet_OrtherName = "POODLE",
                            pet_Origin = "POODLE",
                            pet_CategoryId = newPc_Id1,
                            pet_Weight = 3,
                            pet_Lifespan = 1,
                            pet_IsDelete = false
                        }, new Pets()
                        {
                            pet_Id = newPet_Id30,
                            pet_Name = "PUG",
                            pet_Description = "PUG",
                            pet_Image1 = "image/giongcho/pub.jpg",
                            pet_Image2 = "image/giongcho/pub.jpg",
                            pet_Image3 = "image/giongcho/pub.jpg",
                            pet_Image4 = "image/giongcho/pub.jpg",
                            pet_Image5 = "image/giongcho/pub.jpg",
                            pet_Price = 1,
                            pet_OrtherName = "PUG",
                            pet_Origin = "PUG",
                            pet_CategoryId = newPc_Id1,
                            pet_Weight = 3,
                            pet_Lifespan = 1,
                            pet_IsDelete = false
                        }, new Pets()
                        {
                            pet_Id = newPet_Id31,
                            pet_Name = "ROTTWEILER",
                            pet_Description = "ROTTWEILER",
                            pet_Image1 = "image/giongcho/rottweiler.jpg",
                            pet_Image2 = "image/giongcho/rottweiler.jpg",
                            pet_Image3 = "image/giongcho/rottweiler.jpg",
                            pet_Image4 = "image/giongcho/rottweiler.jpg",
                            pet_Image5 = "image/giongcho/rottweiler.jpg",
                            pet_Price = 1,
                            pet_OrtherName = "ROTTWEILER",
                            pet_Origin = "ROTTWEILER",
                            pet_CategoryId = newPc_Id1,
                            pet_Weight = 3,
                            pet_Lifespan = 1,
                            pet_IsDelete = false
                        }, new Pets()
                        {
                            pet_Id = newPet_Id32,
                            pet_Name = "ROTTWEILER",
                            pet_Description = "ROTTWEILER",
                            pet_Image1 = "image/giongcho/rottweiler.jpg",
                            pet_Image2 = "image/giongcho/rottweiler.jpg",
                            pet_Image3 = "image/giongcho/rottweiler.jpg",
                            pet_Image4 = "image/giongcho/rottweiler.jpg",
                            pet_Image5 = "image/giongcho/rottweiler.jpg",
                            pet_Price = 1,
                            pet_OrtherName = "ROTTWEILER",
                            pet_Origin = "ROTTWEILER",
                            pet_CategoryId = newPc_Id1,
                            pet_Weight = 3,
                            pet_Lifespan = 1,
                            pet_IsDelete = false
                        }, new Pets()
                        {
                            pet_Id = newPet_Id33,
                            pet_Name = "SAMOYED",
                            pet_Description = "SAMOYED",
                            pet_Image1 = "image/giongcho/samoyed.jpg",
                            pet_Image2 = "image/giongcho/samoyed.jpg",
                            pet_Image3 = "image/giongcho/samoyed.jpg",
                            pet_Image4 = "image/giongcho/samoyed.jpg",
                            pet_Image5 = "image/giongcho/samoyed.jpg",
                            pet_Price = 1,
                            pet_OrtherName = "SAMOYED",
                            pet_Origin = "SAMOYED",
                            pet_CategoryId = newPc_Id1,
                            pet_Weight = 3,
                            pet_Lifespan = 1,
                            pet_IsDelete = false
                        }, new Pets()
                        {
                            pet_Id = newPet_Id34,
                            pet_Name = "SHIBA INU",
                            pet_Description = "SHIBA INU",
                            pet_Image1 = "image/giongcho/shiba.jpg",
                            pet_Image2 = "image/giongcho/shiba.jpg",
                            pet_Image3 = "image/giongcho/shiba.jpg",
                            pet_Image4 = "image/giongcho/shiba.jpg",
                            pet_Image5 = "image/giongcho/shiba.jpg",
                            pet_Price = 1,
                            pet_OrtherName = "SHIBA INU",
                            pet_Origin = "SHIBA INU",
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
                    NormalizedName = "Admin",
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
                    NormalizedUserName = "ADMIN@GMAIL.COM",
                    NormalizedEmail = "ADMIN@GMAIL.COM",
                    Email = "admin@gmail.com",
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
            var newProc_Id4 = Guid.NewGuid().ToString();
            var newProc_Id5 = Guid.NewGuid().ToString();
            var newProc_Id6 = Guid.NewGuid().ToString();
            var newProc_Id7 = Guid.NewGuid().ToString();
            var newProc_Id8 = Guid.NewGuid().ToString();

            builder.Entity<ProductCategories>().HasData(
                new ProductCategories()
                {
                    proc_Id = newProc_Id1,
                    proc_Name = "Pet Supplies",
                    proc_Description = "Pet Supplies",
                    proc_IsDelete = false
                },
                new ProductCategories()
                {
                    proc_Id = newProc_Id2,
                    proc_Name = "Pet Food",
                    proc_Description = "Pet Food",
                    proc_IsDelete = false
                },
                new ProductCategories()
                {
                    proc_Id = newProc_Id3,
                    proc_Name = "Pet Cage",
                    proc_Description = "Pet Cage",
                    proc_IsDelete = false
                },
                new ProductCategories()
                {
                    proc_Id = newProc_Id4,
                    proc_Name = "Pet Toys",
                    proc_Description = "Pet Toys",
                    proc_IsDelete = false
                },
                new ProductCategories()
                {
                    proc_Id = newProc_Id5,
                    proc_Name = "Beauty Accessories",
                    proc_Description = "Beauty Accessories",
                    proc_IsDelete = false
                },
                new ProductCategories()
                {
                    proc_Id = newProc_Id6,
                    proc_Name = "Pet Clothes",
                    proc_Description = "Pet Clothes",
                    proc_IsDelete = false
                },
                new ProductCategories()
                {
                    proc_Id = newProc_Id7,
                    proc_Name = "Nutritional Food",
                    proc_Description = "Nutritional Food",
                    proc_IsDelete = false
                },
                new ProductCategories()
                {
                    proc_Id = newProc_Id8,
                    proc_Name = "Medicines & Functional Products",
                    proc_Description = "Medicines & Functional Products",
                    proc_IsDelete = false
                }
                );

            // Table Product
            var newProduct_Id1 = Guid.NewGuid().ToString();
            var newProduct_Id2 = Guid.NewGuid().ToString();
            var newProduct_Id3 = Guid.NewGuid().ToString();
            var newProduct_Id4 = Guid.NewGuid().ToString();
            var newProduct_Id5 = Guid.NewGuid().ToString();
            var newProduct_Id6 = Guid.NewGuid().ToString();
            var newProduct_Id7 = Guid.NewGuid().ToString();
            var newProduct_Id8 = Guid.NewGuid().ToString();
            var newProduct_Id9 = Guid.NewGuid().ToString();
            var newProduct_Id10 = Guid.NewGuid().ToString();
            var newProduct_Id11 = Guid.NewGuid().ToString();
            var newProduct_Id12 = Guid.NewGuid().ToString();
            var newProduct_Id13 = Guid.NewGuid().ToString();
            var newProduct_Id14 = Guid.NewGuid().ToString();
            var newProduct_Id15 = Guid.NewGuid().ToString();
            var newProduct_Id16 = Guid.NewGuid().ToString();
            var newProduct_Id17 = Guid.NewGuid().ToString();
            var newProduct_Id18 = Guid.NewGuid().ToString();
            var newProduct_Id19 = Guid.NewGuid().ToString();
            var newProduct_Id20 = Guid.NewGuid().ToString();
            var newProduct_Id21 = Guid.NewGuid().ToString();
            var newProduct_Id22 = Guid.NewGuid().ToString();
            var newProduct_Id23 = Guid.NewGuid().ToString();
            var newProduct_Id24 = Guid.NewGuid().ToString();
            var newProduct_Id25 = Guid.NewGuid().ToString();
            var newProduct_Id26 = Guid.NewGuid().ToString();
            var newProduct_Id27 = Guid.NewGuid().ToString();
            var newProduct_Id28 = Guid.NewGuid().ToString();
            var newProduct_Id29 = Guid.NewGuid().ToString();
            var newProduct_Id30 = Guid.NewGuid().ToString();
            var newProduct_Id31 = Guid.NewGuid().ToString();
            var newProduct_Id32 = Guid.NewGuid().ToString();
            var newProduct_Id33 = Guid.NewGuid().ToString();
            var newProduct_Id34 = Guid.NewGuid().ToString();
            var newProduct_Id35 = Guid.NewGuid().ToString();


            builder.Entity<Products>().HasData(
                     new Products()
                     {
                         product_Id = newProduct_Id1,
                         product_Name = "Transparent Backpack For Dogs and Cats",
                         product_Description = "Transparent Backpack For Dogs and Cats",
                         product_Image1 = "image/phukien/phukien-balotrongsuot.png",
                         product_Image2 = "image/phukien/phukien-balotrongsuot.png",
                         product_Image3 = "image/phukien/phukien-balotrongsuot.png",
                         product_Image4 = "image/phukien/phukien-balotrongsuot.png",
                         product_Image5 = "image/phukien/phukien-balotrongsuot.png",
                         product_Price = 100000,
                         product_Rate = 5,
                         product_ReProducePrice = 0,
                         product_CategoryId = newProc_Id1,
                         product_IsDelete = false
                     }, new Products()
                     {
                         product_Id = newProduct_Id2,
                         product_Name = "Training Whistle",
                         product_Description = "Training Whistle",
                         product_Image1 = "image/phukien/phukien-coihuanluyen.png",
                         product_Image2 = "image/phukien/phukien-coihuanluyen.png",
                         product_Image3 = "image/phukien/phukien-coihuanluyen.png",
                         product_Image4 = "image/phukien/phukien-coihuanluyen.png",
                         product_Image5 = "image/phukien/phukien-coihuanluyen.png",
                         product_Price = 100000,
                         product_Rate = 5,
                         product_ReProducePrice = 0,
                         product_CategoryId = newProc_Id1,
                         product_IsDelete = false
                     }, new Products()
                     {
                         product_Id = newProduct_Id3,
                         product_Name = "Lamb Sticks",
                         product_Description = "Lamb Sticks",
                         product_Image1 = "image/phukien/phukien-thitcuuque.png",
                         product_Image2 = "image/phukien/phukien-thitcuuque.png",
                         product_Image3 = "image/phukien/phukien-thitcuuque.png",
                         product_Image4 = "image/phukien/phukien-thitcuuque.png",
                         product_Image5 = "image/phukien/phukien-thitcuuque.png",
                         product_Price = 100000,
                         product_Rate = 5,
                         product_ReProducePrice = 0,
                         product_CategoryId = newProc_Id1,
                         product_IsDelete = false
                     }, new Products()
                     {
                         product_Id = newProduct_Id4,
                         product_Name = "SmartHeart For Small Dogs",
                         product_Description = "SmartHeart For Small Dogs",
                         product_Image1 = "image/phukien/phukien-SmartHeart.png",
                         product_Image2 = "image/phukien/phukien-SmartHeart.png",
                         product_Image3 = "image/phukien/phukien-SmartHeart.png",
                         product_Image4 = "image/phukien/phukien-SmartHeart.png",
                         product_Image5 = "image/phukien/phukien-SmartHeart.png",
                         product_Price = 100000,
                         product_Rate = 5,
                         product_ReProducePrice = 0,
                         product_CategoryId = newProc_Id1,
                         product_IsDelete = false
                     }, new Products()
                     {
                         product_Id = newProduct_Id5,
                         product_Name = "Bonus Cake Tablet",
                         product_Description = "Bonus Cake Tablet",
                         product_Image1 = "image/phukien/phukien-banhthuong.png",
                         product_Image2 = "image/phukien/phukien-banhthuong.png",
                         product_Image3 = "image/phukien/phukien-banhthuong.png",
                         product_Image4 = "image/phukien/phukien-banhthuong.png",
                         product_Image5 = "image/phukien/phukien-banhthuong.png",
                         product_Price = 100000,
                         product_Rate = 5,
                         product_ReProducePrice = 0,
                         product_CategoryId = newProc_Id1,
                         product_IsDelete = false
                     }, new Products()
                     {
                         product_Id = newProduct_Id6,
                         product_Name = "Royal Canin For Adult Dogs",
                         product_Description = "Royal Canin For Adult Dogs",
                         product_Image1 = "image/phukien/phukien-royal_truongthanh.png",
                         product_Image2 = "image/phukien/phukien-royal_truongthanh.png",
                         product_Image3 = "image/phukien/phukien-royal_truongthanh.png",
                         product_Image4 = "image/phukien/phukien-royal_truongthanh.png",
                         product_Image5 = "image/phukien/phukien-royal_truongthanh.png",
                         product_Price = 100000,
                         product_Rate = 5,
                         product_ReProducePrice = 0,
                         product_CategoryId = newProc_Id1,
                         product_IsDelete = false
                     }, new Products()
                     {
                         product_Id = newProduct_Id7,
                         product_Name = "Pair of Bows",
                         product_Description = "Pair of Bows",
                         product_Image1 = "image/phukien/phukien-capno.png",
                         product_Image2 = "image/phukien/phukien-capno.png",
                         product_Image3 = "image/phukien/phukien-capno.png",
                         product_Image4 = "image/phukien/phukien-capno.png",
                         product_Image5 = "image/phukien/phukien-capno.png",
                         product_Price = 100000,
                         product_Rate = 5,
                         product_ReProducePrice = 0,
                         product_CategoryId = newProc_Id1,
                         product_IsDelete = false
                     }, new Products()
                     {
                         product_Id = newProduct_Id8,
                         product_Name = "Princess Lace Scarf",
                         product_Description = "Princess Lace Scarf",
                         product_Image1 = "image/phukien/phukien-khanren.png",
                         product_Image2 = "image/phukien/phukien-khanren.png",
                         product_Image3 = "image/phukien/phukien-khanren.png",
                         product_Image4 = "image/phukien/phukien-khanren.png",
                         product_Image5 = "image/phukien/phukien-khanren.png",
                         product_Price = 100000,
                         product_Rate = 5,
                         product_ReProducePrice = 0,
                         product_CategoryId = newProc_Id1,
                         product_IsDelete = false
                     }, new Products()
                     {
                         product_Id = newProduct_Id9,
                         product_Name = "Drugs of Calcium",
                         product_Description = "Drugs of Calcium",
                         product_Image1 = "image/phukien/phukien-thuoccanxi.png",
                         product_Image2 = "image/phukien/phukien-thuoccanxi.png",
                         product_Image3 = "image/phukien/phukien-thuoccanxi.png",
                         product_Image4 = "image/phukien/phukien-thuoccanxi.png",
                         product_Image5 = "image/phukien/phukien-thuoccanxi.png",
                         product_Price = 100000,
                         product_Rate = 5,
                         product_ReProducePrice = 0,
                         product_CategoryId = newProc_Id1,
                         product_IsDelete = false
                     }, new Products()
                     {
                         product_Id = newProduct_Id10,
                         product_Name = "Bow Bow Bra",
                         product_Description = "Bow Bow Bra",
                         product_Image1 = "image/phukien/phukien-aongucnochuong.png",
                         product_Image2 = "image/phukien/phukien-aongucnochuong.png",
                         product_Image3 = "image/phukien/phukien-aongucnochuong.png",
                         product_Image4 = "image/phukien/phukien-aongucnochuong.png",
                         product_Image5 = "image/phukien/phukien-aongucnochuong.png",
                         product_Price = 100000,
                         product_Rate = 5,
                         product_ReProducePrice = 0,
                         product_CategoryId = newProc_Id1,
                         product_IsDelete = false
                     }, new Products()
                     {
                         product_Id = newProduct_Id11,
                         product_Name = "Balloon Toys",
                         product_Description = "Balloon Toys",
                         product_Image1 = "image/phukien/phukien-bongbongdochoi.png",
                         product_Image2 = "image/phukien/phukien-bongbongdochoi.png",
                         product_Image3 = "image/phukien/phukien-bongbongdochoi.png",
                         product_Image4 = "image/phukien/phukien-bongbongdochoi.png",
                         product_Image5 = "image/phukien/phukien-bongbongdochoi.png",
                         product_Price = 100000,
                         product_Rate = 5,
                         product_ReProducePrice = 0,
                         product_CategoryId = newProc_Id1,
                         product_IsDelete = false
                     }, new Products()
                     {
                         product_Id = newProduct_Id12,
                         product_Name = "Dog Fence",
                         product_Description = "Dog Fence",
                         product_Image1 = "image/phukien/phukien-raoquaycho.png",
                         product_Image2 = "image/phukien/phukien-raoquaycho.png",
                         product_Image3 = "image/phukien/phukien-raoquaycho.png",
                         product_Image4 = "image/phukien/phukien-raoquaycho.png",
                         product_Image5 = "image/phukien/phukien-raoquaycho.png",
                         product_Price = 100000,
                         product_Rate = 5,
                         product_ReProducePrice = 0,
                         product_CategoryId = newProc_Id1,
                         product_IsDelete = false
                     }, new Products()
                     {
                         product_Id = newProduct_Id13,
                         product_Name = "BLOOM SEXY Fragrance Bath Oil",
                         product_Description = "BLOOM SEXY Fragrance Bath Oil",
                         product_Image1 = "image/phukien/phukien-dautamnuochoabloomsexy.png",
                         product_Image2 = "image/phukien/phukien-dautamnuochoabloomsexy.png",
                         product_Image3 = "image/phukien/phukien-dautamnuochoabloomsexy.png",
                         product_Image4 = "image/phukien/phukien-dautamnuochoabloomsexy.png",
                         product_Image5 = "image/phukien/phukien-dautamnuochoabloomsexy.png",
                         product_Price = 100000,
                         product_Rate = 5,
                         product_ReProducePrice = 0,
                         product_CategoryId = newProc_Id1,
                         product_IsDelete = false
                     }, new Products()
                     {
                         product_Id = newProduct_Id14,
                         product_Name = "Toys",
                         product_Description = "Toys",
                         product_Image1 = "image/phukien/phukien-dochoi.png",
                         product_Image2 = "image/phukien/phukien-dochoi.png",
                         product_Image3 = "image/phukien/phukien-dochoi.png",
                         product_Image4 = "image/phukien/phukien-dochoi.png",
                         product_Image5 = "image/phukien/phukien-dochoi.png",
                         product_Price = 100000,
                         product_Rate = 5,
                         product_ReProducePrice = 0,
                         product_CategoryId = newProc_Id1,
                         product_IsDelete = false
                     }, new Products()
                     {
                         product_Id = newProduct_Id15,
                         product_Name = "BLOOM SEXY Fragrance Bath Oil",
                         product_Description = "BLOOM SEXY Fragrance Bath Oil",
                         product_Image1 = "image/phukien/phukien-dautamFay.png",
                         product_Image2 = "image/phukien/phukien-dautamFay.png",
                         product_Image3 = "image/phukien/phukien-dautamFay.png",
                         product_Image4 = "image/phukien/phukien-dautamFay.png",
                         product_Image5 = "image/phukien/phukien-dautamFay.png",
                         product_Price = 100000,
                         product_Rate = 5,
                         product_ReProducePrice = 0,
                         product_CategoryId = newProc_Id1,
                         product_IsDelete = false
                     }, new Products()
                     {
                         product_Id = newProduct_Id16,
                         product_Name = "Anti-Tear Syrup",
                         product_Description = "Anti-Tear Syrup",
                         product_Image1 = "image/phukien/phukien-sirochongchaynuocmat.png",
                         product_Image2 = "image/phukien/phukien-sirochongchaynuocmat.png",
                         product_Image3 = "image/phukien/phukien-sirochongchaynuocmat.png",
                         product_Image4 = "image/phukien/phukien-sirochongchaynuocmat.png",
                         product_Image5 = "image/phukien/phukien-sirochongchaynuocmat.png",
                         product_Price = 100000,
                         product_Rate = 5,
                         product_ReProducePrice = 0,
                         product_CategoryId = newProc_Id1,
                         product_IsDelete = false
                     }, new Products()
                     {
                         product_Id = newProduct_Id17,
                         product_Name = "Lice Treatment Ring",
                         product_Description = "Lice Treatment Ring",
                         product_Image1 = "image/phukien/phukien-vongtriveran.png",
                         product_Image2 = "image/phukien/phukien-vongtriveran.png",
                         product_Image3 = "image/phukien/phukien-vongtriveran.png",
                         product_Image4 = "image/phukien/phukien-vongtriveran.png",
                         product_Image5 = "image/phukien/phukien-vongtriveran.png",
                         product_Price = 100000,
                         product_Rate = 5,
                         product_ReProducePrice = 0,
                         product_CategoryId = newProc_Id1,
                         product_IsDelete = false
                     }, new Products()
                     {
                         product_Id = newProduct_Id18,
                         product_Name = "HANTOC Lice Spray",
                         product_Description = "HANTOC Lice Spray",
                         product_Image1 = "image/phukien/phukien-xitveranHANTOC.png",
                         product_Image2 = "image/phukien/phukien-xitveranHANTOC.png",
                         product_Image3 = "image/phukien/phukien-xitveranHANTOC.png",
                         product_Image4 = "image/phukien/phukien-xitveranHANTOC.png",
                         product_Image5 = "image/phukien/phukien-xitveranHANTOC.png",
                         product_Price = 100000,
                         product_Rate = 5,
                         product_ReProducePrice = 0,
                         product_CategoryId = newProc_Id1,
                         product_IsDelete = false
                     }, new Products()
                     {
                         product_Id = newProduct_Id19,
                         product_Name = "Nutri-Nutrition Gel",
                         product_Description = "Nutri-Nutrition Gel",
                         product_Image1 = "image/phukien/phukien-gelddNutri.png",
                         product_Image2 = "image/phukien/phukien-gelddNutri.png",
                         product_Image3 = "image/phukien/phukien-gelddNutri.png",
                         product_Image4 = "image/phukien/phukien-gelddNutri.png",
                         product_Image5 = "image/phukien/phukien-gelddNutri.png",
                         product_Price = 100000,
                         product_Rate = 5,
                         product_ReProducePrice = 0,
                         product_CategoryId = newProc_Id1,
                         product_IsDelete = false
                     }, new Products()
                     {
                         product_Id = newProduct_Id20,
                         product_Name = "Bio Milk Powder For Dogs and Cats",
                         product_Description = "Bio Milk Powder For Dogs and Cats",
                         product_Image1 = "image/phukien/phukien-suabotchomeo.png",
                         product_Image2 = "image/phukien/phukien-suabotchomeo.png",
                         product_Image3 = "image/phukien/phukien-suabotchomeo.png",
                         product_Image4 = "image/phukien/phukien-suabotchomeo.png",
                         product_Image5 = "image/phukien/phukien-suabotchomeo.png",
                         product_Price = 100000,
                         product_Rate = 5,
                         product_ReProducePrice = 0,
                         product_CategoryId = newProc_Id1,
                         product_IsDelete = false
                     }, new Products()
                     {
                         product_Id = newProduct_Id21,
                         product_Name = "Sleeky Multivitamin",
                         product_Description = "Sleeky Multivitamin",
                         product_Image1 = "image/phukien/phukien-vitamintonghop.png",
                         product_Image2 = "image/phukien/phukien-vitamintonghop.png",
                         product_Image3 = "image/phukien/phukien-vitamintonghop.png",
                         product_Image4 = "image/phukien/phukien-vitamintonghop.png",
                         product_Image5 = "image/phukien/phukien-vitamintonghop.png",
                         product_Price = 100000,
                         product_Rate = 5,
                         product_ReProducePrice = 0,
                         product_CategoryId = newProc_Id1,
                         product_IsDelete = false
                     }, new Products()
                     {
                         product_Id = newProduct_Id22,
                         product_Name = "Canxi Nano",
                         product_Description = "Canxi Nano",
                         product_Image1 = "image/phukien/phukien-canxinano.png",
                         product_Image2 = "image/phukien/phukien-canxinano.png",
                         product_Image3 = "image/phukien/phukien-canxinano.png",
                         product_Image4 = "image/phukien/phukien-canxinano.png",
                         product_Image5 = "image/phukien/phukien-canxinano.png",
                         product_Price = 100000,
                         product_Rate = 5,
                         product_ReProducePrice = 0,
                         product_CategoryId = newProc_Id1,
                         product_IsDelete = false
                     }, new Products()
                     {
                         product_Id = newProduct_Id23,
                         product_Name = "Shipping Bag",
                         product_Description = "Shipping Bag",
                         product_Image1 = "image/phukien/phukien-tuivanchuyen.png",
                         product_Image2 = "image/phukien/phukien-tuivanchuyen.png",
                         product_Image3 = "image/phukien/phukien-tuivanchuyen.png",
                         product_Image4 = "image/phukien/phukien-tuivanchuyen.png",
                         product_Image5 = "image/phukien/phukien-tuivanchuyen.png",
                         product_Price = 100000,
                         product_Rate = 5,
                         product_ReProducePrice = 0,
                         product_CategoryId = newProc_Id1,
                         product_IsDelete = false
                     }, new Products()
                     {
                         product_Id = newProduct_Id24,
                         product_Name = "Food Toys",
                         product_Description = "Food Toys",
                         product_Image1 = "image/phukien/phukien-dochoithucan.png",
                         product_Image2 = "image/phukien/phukien-dochoithucan.png",
                         product_Image3 = "image/phukien/phukien-dochoithucan.png",
                         product_Image4 = "image/phukien/phukien-dochoithucan.png",
                         product_Image5 = "image/phukien/phukien-dochoithucan.png",
                         product_Price = 100000,
                         product_Rate = 5,
                         product_ReProducePrice = 0,
                         product_CategoryId = newProc_Id1,
                         product_IsDelete = false
                     }, new Products()
                     {
                         product_Id = newProduct_Id25,
                         product_Name = "Coat + Strap",
                         product_Description = "Coat + Strap",
                         product_Image1 = "image/phukien/phukien-ao_giaythat.png",
                         product_Image2 = "image/phukien/phukien-ao_giaythat.png",
                         product_Image3 = "image/phukien/phukien-ao_giaythat.png",
                         product_Image4 = "image/phukien/phukien-ao_giaythat.png",
                         product_Image5 = "image/phukien/phukien-ao_giaythat.png",
                         product_Price = 100000,
                         product_Rate = 5,
                         product_ReProducePrice = 0,
                         product_CategoryId = newProc_Id1,
                         product_IsDelete = false
                     }, new Products()
                     {
                         product_Id = newProduct_Id26,
                         product_Name = "Throwing dish",
                         product_Description = "Throwing dish",
                         product_Image1 = "image/phukien/phukien-dianem.png",
                         product_Image2 = "image/phukien/phukien-dianem.png",
                         product_Image3 = "image/phukien/phukien-dianem.png",
                         product_Image4 = "image/phukien/phukien-dianem.png",
                         product_Image5 = "image/phukien/phukien-dianem.png",
                         product_Price = 100000,
                         product_Rate = 5,
                         product_ReProducePrice = 0,
                         product_CategoryId = newProc_Id1,
                         product_IsDelete = false
                     }, new Products()
                     {
                         product_Id = newProduct_Id27,
                         product_Name = "Orb of Thorns",
                         product_Description = "Orb of Thorns",
                         product_Image1 = "image/phukien/phukien-quacaugai.png",
                         product_Image2 = "image/phukien/phukien-quacaugai.png",
                         product_Image3 = "image/phukien/phukien-quacaugai.png",
                         product_Image4 = "image/phukien/phukien-quacaugai.png",
                         product_Image5 = "image/phukien/phukien-quacaugai.png",
                         product_Price = 100000,
                         product_Rate = 5,
                         product_ReProducePrice = 0,
                         product_CategoryId = newProc_Id1,
                         product_IsDelete = false
                     }, new Products()
                     {
                         product_Id = newProduct_Id28,
                         product_Name = "Food Gun",
                         product_Description = "Food Gun",
                         product_Image1 = "image/phukien/phukien-sungbanthucan.png",
                         product_Image2 = "image/phukien/phukien-sungbanthucan.png",
                         product_Image3 = "image/phukien/phukien-sungbanthucan.png",
                         product_Image4 = "image/phukien/phukien-sungbanthucan.png",
                         product_Image5 = "image/phukien/phukien-sungbanthucan.png",
                         product_Price = 100000,
                         product_Rate = 5,
                         product_ReProducePrice = 0,
                         product_CategoryId = newProc_Id1,
                         product_IsDelete = false
                     }, new Products()
                     {
                         product_Id = newProduct_Id29,
                         product_Name = "Feather Brush",
                         product_Description = "Feather Brush",
                         product_Image1 = "image/phukien/phukien-banchaylong.png",
                         product_Image2 = "image/phukien/phukien-banchaylong.png",
                         product_Image3 = "image/phukien/phukien-banchaylong.png",
                         product_Image4 = "image/phukien/phukien-banchaylong.png",
                         product_Image5 = "image/phukien/phukien-banchaylong.png",
                         product_Price = 100000,
                         product_Rate = 5,
                         product_ReProducePrice = 0,
                         product_CategoryId = newProc_Id1,
                         product_IsDelete = false
                     }, new Products()
                     {
                         product_Id = newProduct_Id30,
                         product_Name = "Rooster Toys",
                         product_Description = "Rooster Toys",
                         product_Image1 = "image/phukien/phukien-dochoi_gatrong.png",
                         product_Image2 = "image/phukien/phukien-dochoi_gatrong.png",
                         product_Image3 = "image/phukien/phukien-dochoi_gatrong.png",
                         product_Image4 = "image/phukien/phukien-dochoi_gatrong.png",
                         product_Image5 = "image/phukien/phukien-dochoi_gatrong.png",
                         product_Price = 100000,
                         product_Rate = 5,
                         product_ReProducePrice = 0,
                         product_CategoryId = newProc_Id1,
                         product_IsDelete = false
                     }, new Products()
                     {
                         product_Id = newProduct_Id31,
                         product_Name = "Skin Bones",
                         product_Description = "Skin Bones",
                         product_Image1 = "image/phukien/phukien-xuongda.png",
                         product_Image2 = "image/phukien/phukien-xuongda.png",
                         product_Image3 = "image/phukien/phukien-xuongda.png",
                         product_Image4 = "image/phukien/phukien-xuongda.png",
                         product_Image5 = "image/phukien/phukien-xuongda.png",
                         product_Price = 100000,
                         product_Rate = 5,
                         product_ReProducePrice = 0,
                         product_CategoryId = newProc_Id1,
                         product_IsDelete = false
                     }, new Products()
                     {
                         product_Id = newProduct_Id32,
                         product_Name = "SmartHeart For Adult Dogs",
                         product_Description = "SmartHeart For Adult Dogs",
                         product_Image1 = "image/phukien/phukien-Smartheart_truongthanh.png",
                         product_Image2 = "image/phukien/phukien-Smartheart_truongthanh.png",
                         product_Image3 = "image/phukien/phukien-Smartheart_truongthanh.png",
                         product_Image4 = "image/phukien/phukien-Smartheart_truongthanh.png",
                         product_Image5 = "image/phukien/phukien-Smartheart_truongthanh.png",
                         product_Price = 1000000,
                         product_Rate = 5,
                         product_ReProducePrice = 0,
                         product_CategoryId = newProc_Id1,
                         product_IsDelete = false
                     }, new Products()
                     {
                         product_Id = newProduct_Id33,
                         product_Name = "Royal Canin For Small Dogs",
                         product_Description = "Royal Canin For Small Dogs",
                         product_Image1 = "image/phukien/phukien-roya_chonho.png",
                         product_Image2 = "image/phukien/phukien-roya_chonho.png",
                         product_Image3 = "image/phukien/phukien-roya_chonho.png",
                         product_Image4 = "image/phukien/phukien-roya_chonho.png",
                         product_Image5 = "image/phukien/phukien-roya_chonho.png",
                         product_Price = 100000,
                         product_Rate = 5,
                         product_ReProducePrice = 0,
                         product_CategoryId = newProc_Id1,
                         product_IsDelete = false
                     }, new Products()
                     {
                         product_Id = newProduct_Id34,
                         product_Name = "FAY Dry Bath Powder",
                         product_Description = "FAY Dry Bath Powder",
                         product_Image1 = "image/phukien/phukien-phantamkhoFay.png",
                         product_Image2 = "image/phukien/phukien-phantamkhoFay.png",
                         product_Image3 = "image/phukien/phukien-phantamkhoFay.png",
                         product_Image4 = "image/phukien/phukien-phantamkhoFay.png",
                         product_Image5 = "image/phukien/phukien-phantamkhoFay.png",
                         product_Price = 100000,
                         product_Rate = 5,
                         product_ReProducePrice = 0,
                         product_CategoryId = newProc_Id1,
                         product_IsDelete = false
                     }, new Products()
                     {
                         product_Id = newProduct_Id35,
                         product_Name = "Oliver Shower Gel",
                         product_Description = "Oliver Shower Gel",
                         product_Image1 = "image/phukien/phukien-suatamoliver.png",
                         product_Image2 = "image/phukien/phukien-suatamoliver.png",
                         product_Image3 = "image/phukien/phukien-suatamoliver.png",
                         product_Image4 = "image/phukien/phukien-suatamoliver.png",
                         product_Image5 = "image/phukien/phukien-suatamoliver.png",
                         product_Price = 100000,
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
                    bill_Total = 1000000,
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


            // Table Introduce Page
            builder.Entity<IntroducePage>().HasData(
                new IntroducePage()
                {
                    introduce_Id = "defaultPage",
                    introduce_Zalo = "0812888858",
                    introduce_Phone = "0812888858",
                    introduce_Email = "petshop.cuahangthucung@gmail.com",
                    introduce_Address1 = "180 Bui Van Ba, District 7, Ho Chi Minh City.",
                    introduce_Address2 = "464 Cong Hoa, Tan Binh District, Ho Chi Minh City.",
                    introduce_Address3 = "157/13 Luong The Vinh Street, Ward 1, Ca Mau City.",
                    introduce_Map1 = "180 Bui Van Ba, District 7, Ho Chi Minh City .",
                    introduce_Map2 = "464 Cong Hoa, Ward 13, Tan Binh District, City Ho Chi Minh.",
                    introduce_Map3 = "157/13 Luong The Vinh Street, Ward 1, City Ca Mau.",
                    introduce_UserCreate = newUser_Id1
                }
                );

        }
    }
}