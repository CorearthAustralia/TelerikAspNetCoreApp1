using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace TelerikAspNetCoreApp1.Controllers
{
    public class OnlinePayment : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult CheckoutPayment()
        {
            return View();
        }



        public IActionResult APIPayment()
        {
            return View();
        }



    }
}
