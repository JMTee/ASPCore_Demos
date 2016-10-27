using HTML_CSS_JS_Demo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HTML_CSS_JS_Demo.Services
{
   public interface IAccountService
    {
        int authenticateLogin(LoginViewModel lv);
    }
}
