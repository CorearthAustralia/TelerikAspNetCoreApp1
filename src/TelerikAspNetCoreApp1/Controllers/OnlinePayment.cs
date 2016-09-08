using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Stripe;

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

            var stripeAPI = new StripePlanService();

            


            return View();
        }

        [HttpPost]
        public IActionResult CheckoutPayment(string StripeToken, string CustomerID, int ChargeAmount)
        {

            //var myCustomer = new StripeCustomerCreateOptions();
            //myCustomer.Email = "jonathan.tecson@corearth.com";
            //myCustomer.Description = "Jonathan Tecson";
            //myCustomer.SourceToken = StripeToken;
            ////myCustomer.TrialEnd = DateTime.UtcNow.AddMonths(1);    // when the customers trial ends (overrides the plan if applicable)
            ////myCustomer.Quantity = 1;                               // optional, defaults to 1
            //var customerService = new StripeCustomerService("sk_test_qFGjHTjY0gFwJsqkpskaiTLP");
            //StripeCustomer stripeCustomer = customerService.Create(myCustomer);

            var StripeCharge = new StripeChargeCreateOptions();
            StripeCharge.Amount = ChargeAmount;
            StripeCharge.Currency = "aud";
            StripeCharge.Description = "Jupiter Subscription";
            StripeCharge.SourceTokenOrExistingSourceId = StripeToken;
            
            StripeCharge.Capture = true;

            var StripeChargeService = new StripeChargeService("sk_test_qFGjHTjY0gFwJsqkpskaiTLP");
            StripeCharge StripeChargeTrans = StripeChargeService.Create(StripeCharge);

            return View();
        }



        public IActionResult APIPayment()
        {
            return View();
        }



    }
}
