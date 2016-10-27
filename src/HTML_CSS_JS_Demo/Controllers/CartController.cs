﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HTML_CSS_JS_Demo.ViewModels;
using HTML_CSS_JS_Demo.Services;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace HTML_CSS_JS_Demo.Controllers
{
    public class CartController : Controller
    {
        private IPurchaseService _purchaseService;
        public CartController(IPurchaseService purchaseService)
        {
            _purchaseService = purchaseService;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            CartViewModel cv = new CartViewModel();
            cv.ProductPurchases =_purchaseService.getAllPurchases();
            return View(cv);
        }
    }
}
