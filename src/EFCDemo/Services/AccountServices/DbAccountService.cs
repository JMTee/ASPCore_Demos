using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCDemo.ViewModels;
using EFCDemo.Models;

namespace EFCDemo.Services
{
    public class DbAccountService : IAccountService
    {
        private DemoContext _demoContext;
        public DbAccountService(DemoContext dc)
        {
            _demoContext = dc;
        }
      
        public int authenticateLogin(LoginViewModel lv)
        {
            int userCount = _demoContext.Accounts.Where(x => x.email == lv.Email && x.password == lv.Password).Count();
            return userCount;
        }
    }
}
