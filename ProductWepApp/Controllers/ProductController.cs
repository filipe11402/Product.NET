using Microsoft.AspNetCore.Mvc;
using ProductWepApp.Data;
using ProductWepApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductWepApp.Controllers
{
    public class ProductController : Controller
    {

        private readonly ApplicationDbContext _db;

        public ProductController(ApplicationDbContext db) 
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Product> prodList = _db.Products;
            return View(prodList);
        }
    }
}
