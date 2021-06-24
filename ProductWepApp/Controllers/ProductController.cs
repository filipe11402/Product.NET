using Microsoft.AspNetCore.Mvc;
using ProductWepApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductWepApp.Controllers
{
    public class ProductController : Controller
    {

        public IActionResult Index()
        {
            List<Product> prodList = new List<Product>()
            {
                new Product {Id=1, amount=10, productName="teste" },
                new Product {Id=2, amount=23, productName="arroz" },
            };
            

            return View(prodList);
        }
    }
}
