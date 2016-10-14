using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemo.ViewModels
{
    public class CartViewModel
    {
        public CartViewModel()
        {
            ProductName = "Vaseline";
            ProductDescription = "It's a Freakin Shampoo";
        }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
    }
}
