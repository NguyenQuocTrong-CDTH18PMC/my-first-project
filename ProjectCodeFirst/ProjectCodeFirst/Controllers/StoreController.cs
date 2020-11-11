using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Session;
using Microsoft.EntityFrameworkCore;
using ProjectCodeFirst.Data;
using ProjectCodeFirst.Models;

namespace ProjectCodeFirst.Controllers
{
    public class StoreController : Controller
    {
        private readonly ShopgiayDBContext _context;

        public StoreController(ShopgiayDBContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            return View(_context.Products.ToList());
        }

        public IActionResult ProductAdidas()
        {
            return View(_context.Products.ToList());
        }

        public IActionResult ProductNike()
        {
            return View(_context.Products.ToList());
        }

        public IActionResult ProductBitis()
        {
            return View(_context.Products.ToList());
        }

    
    }
}
