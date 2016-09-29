using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCDemo.ViewModels;
using MVCDemo.Services;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MVCDemo.Controllers
{
    public class AccountController : Controller
    {
        private AccountService _accountService; 
        public AccountController()
        {
            _accountService = new AccountService(); 
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        // GET: /<controller>/
        public IActionResult Login()
        {
            @ViewData["Title"] = "Login";
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginViewModel lr)
        {
            if (_accountService.authenticateLogin(lr) >  0)
            {
                return View(lr);
            }
           
            
            return View();
        }

    }
}
