using System.ComponentModel.DataAnnotations;

namespace Design.Models.Dto
{
    public class BillsDto
    {
        public string bill_Id { get; set; }
        public string bill_UserId { get; set; }

        [Display(Name = "User Name")]
        public string bill_UserName { get; set; }

        [Display(Name = "Status Payment")]
        public bool bill_StatusPayment { get; set; }

        [Display(Name = "Status Revice Order")]
        public bool bill_StatusReviceOrder { get; set; }

        [Display(Name = "Total")]
        public double bill_Total { get; set; }

        [Display(Name = "Start Date Time")]
        public DateTime bill_StartDateTime { get; set; }

        [Display(Name = "Cancel")]
        public bool bill_Cancel { get; set; }
    }
}
