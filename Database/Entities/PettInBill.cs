namespace Database.Entities
{
    public class PettInBill
    {
        public string pib_PetId { get; set; }
        public Pets pets { get; set; }
        public string pib_BillId { get; set; }
        public Bills bills { get; set; }
        public double pib_Quantity { get; set; }
        public double pib_Price { get; set; }
        public bool pib_IsDelete { get; set; }

    }
}
