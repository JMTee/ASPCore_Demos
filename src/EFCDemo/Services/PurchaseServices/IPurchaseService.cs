using EFCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCDemo.Services
{
    public interface IPurchaseService
    {
        ICollection<Purchase> getAllPurchases();
        ICollection<Purchase> getMyPurchases(Account Ac);
    }
}
