using HTML_CSS_JS_Demo.Services;
using HTML_CSS_JS_Demo.Models;
using HTML_CSS_JS_Demo.ViewModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HTML_CSS_JS_Demo.Services
{
    public class TempAccountService:IAccountService
    {
        private List<Account> MockAccount;
        public TempAccountService()
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
