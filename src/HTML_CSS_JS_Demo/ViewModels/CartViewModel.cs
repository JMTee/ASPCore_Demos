using HTML_CSS_JS_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HTML_CSS_JS_Demo.ViewModels
{
    public class CartViewModel
    {
        public CartViewModel()
        {

        }


        public ICollection<Purchase> ProductPurchases { get; set; }
    }
}
