namespace Database.Entities
{
    public class Pets
    {
        public string pet_Id { get; set; }
        public string pet_Name { get; set; }   
        public string pet_Description { get; set; }   
        public double pet_Price { get; set; }   
        public string pet_OrtherName { get; set; }   
        public string pet_Origin { get; set; }   
        public string pet_CategoryId { get; set; }   //
        public PetCategories petCategories { get; set; }
        public double pet_Weight { get; set; }   
        public double pet_Lifespan { get; set; }   
        public bool pet_IsDelete { get; set; }


        public List<PettInBill> pettInBill { get; set; }

    }
}
