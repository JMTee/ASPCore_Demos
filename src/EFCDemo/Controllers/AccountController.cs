﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EFCDemo.ViewModels;
using EFCDemo.Services;


// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace EFCDemo.Controllers
{
    public class AccountController : Controller
    {
        private IAccountService _accountService; 
        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
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
            if (_accountService.authenticateLogin(lr) >  0 && ModelState.IsValid)
            {
                return View(lr);
            }
           
            
            return View();
        }

    }
}
