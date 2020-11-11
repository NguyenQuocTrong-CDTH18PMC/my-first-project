using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using ProjectCodeFirst.Data;
using ProjectCodeFirst.Models;

namespace ProjectCodeFirst.Controllers
{
    public class CartController : Controller
    {
        private ISession session;
        private readonly ShopgiayDBContext _context;
        private const string CartSession = "CartSession";

        public CartController(ShopgiayDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

     
        public IActionResult AddProduct([FromRoute]int ProductID)
        {
            var product = _context.Products.FirstOrDefault(i => i.ID == ProductID);

          

            
           

            
           
            return RedirectToAction("Index", "Cart");

        }
    }
}
