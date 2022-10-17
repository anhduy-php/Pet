using Microsoft.EntityFrameworkCore;

namespace Database.Data
{
    public static class Data
    {
        public static void Seed(this ModelBuilder builder)
        {
            ////Table About
            //builder.Entity<About>().HasData(
            //        new About()
            //        {
            //            about_id = 1,
            //            about_Url = "https://www.youtube.com/watch?v=F1vcruph8JA",
            //            about_Title = "Footwear the leading eCommerce Store around the Globe",
            //            about_Description = "The Big Oxmox advised her not to do so, because there were thousands of bad Commas, wild Question Marks and devious Semikoli, but the Little Blind Text didn’t listen. She packed her seven versalia, put her initial into the belt and made herself on the way. \n \n When she reached the first hills of the Italic Mountains, she had a last view back on the skyline of her hometown Bookmarksgrove,the headline of Alphabet Village and the subline of her own road,the Line Lane.Pityful a rethoric question ran over her cheek,then she continued her way."
            //        });
        }
    }
}