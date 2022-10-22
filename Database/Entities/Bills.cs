namespace Database.Entities
{
    public class Bills
    {
        public string bill_Id { get; set; }
        public string bill_UserId { get; set; }
        public string bill_StatusPayment { get; set; }
        public string bill_StatusReviceOrder { get; set; }
        public string bill_Total { get; set; }
        public string bill_StartDateTime { get; set; }
        public string bill_Cancel { get; set; }

        public List<ProductInBill> productInBill { get; set; }
        public List<PettInBill> pettInBill { get; set; }
    }
}
