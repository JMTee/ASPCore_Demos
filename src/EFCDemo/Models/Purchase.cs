using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCDemo.Models
{
    public class Purchase
    {
        public Purchase()
        {
        }
        public int PurchaseId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public DateTime DatePurchased { get; set; }

        public int accountIdFK { get; set; }

        [ForeignKey("accountIdFK")]
        public Account account { get; set; }

    }
}