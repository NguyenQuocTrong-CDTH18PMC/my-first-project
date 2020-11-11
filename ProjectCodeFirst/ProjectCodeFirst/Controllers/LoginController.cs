using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ProjectCodeFirst.Data;
using ProjectCodeFirst.Models;

namespace ProjectCodeFirst.Controllers
{
    public class LoginController : Controller
    {

        private readonly ShopgiayDBContext _context;

        public LoginController(ShopgiayDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Login(Account account)
        {
            //Search account in database
            var result = _context.Accounts.Where(x => x.EMAIL.Equals(account.EMAIL)).FirstOrDefault();

            //Check account 
            if (result.PASSWORD == account.PASSWORD)
            {
                //Set Account Infor into Session if login success
                HttpContext.Session.SetString("SessionEmail", account.EMAIL);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Message = "Đăng nhập thất bại";
                return View("Index");
            }
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Login");
        }

      

    }
}
