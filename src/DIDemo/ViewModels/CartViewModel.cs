using DIDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIDemo.ViewModels
{
    public class CartViewModel
    {
        public CartViewModel()
        {

        }


        public ICollection<Purchase> ProductPurchases { get; set; }
    }
}
