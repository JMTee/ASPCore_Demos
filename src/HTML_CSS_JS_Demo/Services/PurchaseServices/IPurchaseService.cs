using HTML_CSS_JS_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HTML_CSS_JS_Demo.Services
{
    public interface IPurchaseService
    {
        ICollection<Purchase> getAllPurchases();
        ICollection<Purchase> getMyPurchases(Account Ac);
    }
}
