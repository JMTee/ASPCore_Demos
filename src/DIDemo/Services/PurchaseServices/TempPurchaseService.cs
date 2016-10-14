using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DIDemo.Models;

namespace DIDemo.Services
{
    public class TempPurchaseService : IPurchaseService
    {
        private ICollection<Purchase> _purchases;
        private Purchase mockData1;
        private Purchase mockData2;
        public TempPurchaseService()
        {
            _purchases = new List<Purchase>();

            // fill data
            mockData1 = new Purchase();
            mockData1.ProductName = "Vaseline";
            mockData1.ProductDescription = "This is a Shampoo";

            mockData2 = new Purchase();
            mockData2.ProductName = "Tender Juicy";
            mockData2.ProductDescription = "This is a hotdog";

            //add to list
            _purchases.Add(mockData1);
            _purchases.Add(mockData2);

        }
        public ICollection<Purchase> getAllPurchases()
        {
            return _purchases;
        }

        public ICollection<Purchase> getMyPurchases(Account Ac)
        {
            throw new NotImplementedException();
        }
    }
}
