using DIDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIDemo.Services
{
    public interface IPurchaseService
    {
        ICollection<Purchase> getAllPurchases();
        ICollection<Purchase> getMyPurchases(Account Ac);
    }
}
