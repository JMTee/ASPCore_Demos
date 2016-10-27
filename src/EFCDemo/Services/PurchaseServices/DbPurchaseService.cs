using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCDemo.Models;

namespace EFCDemo.Services
{
    public class DbPurchaseService : IPurchaseService
    {
        private DemoContext _demoContext;
        public DbPurchaseService(DemoContext dc)
        {
            _demoContext = dc;
        }
        public ICollection<Purchase> getAllPurchases()
        {
            return _demoContext.Purchases.ToList();
        }

        public ICollection<Purchase> getMyPurchases(Account Ac)
        {
            throw new NotImplementedException();
        }
    }
}
