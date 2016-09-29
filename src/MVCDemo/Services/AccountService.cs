using MVCDemo.Model;
using MVCDemo.ViewModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemo.Services
{
    public class AccountService
    {
        private List<Account> MockAccount;
        public AccountService()
        {
            MockAccount = new List<Account>();
            MockAccount.Add(new Account("admin@gmail.com","b"));
        }

        public  int authenticateLogin(LoginViewModel loginModel) {

           int userCount =  MockAccount.Where(x => x.email == loginModel.Email && x.password == loginModel.Password).Count();
            return userCount; 
        }


    }


}
