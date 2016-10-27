using System.Collections.Generic;

namespace EFCDemo.Models
{
    public class Account
    {
        public Account(string _email, string _password)
        {
            email = _email;
            password = _password;
        }
        public int AccountId { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public ICollection<Purchase> Purchases{ get; set; }
    }
}