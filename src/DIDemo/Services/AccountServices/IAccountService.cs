using DIDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIDemo.Services
{
   public interface IAccountService
    {
        int authenticateLogin(LoginViewModel lv);
    }
}
