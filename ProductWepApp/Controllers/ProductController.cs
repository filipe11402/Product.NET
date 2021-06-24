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
                new Product(id=1, amount=10, prodName="teste"),
                new Product(100, "feijao"),
            };
            

            return View(prodList);
        }
    }
}
