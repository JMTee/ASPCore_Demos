using EFCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCDemo.ViewModels
{
    public class CartViewModel
    {
        public CartViewModel()
        {

        }


        public ICollection<Purchase> ProductPurchases { get; set; }
    }
}
