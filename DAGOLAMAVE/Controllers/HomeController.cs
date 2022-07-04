using System.Diagnostics;
using DAGOLAMAVE.Models;
using Microsoft.AspNetCore.Mvc;

namespace DAGOLAMAVE.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
            // Order Variant 1
            OrderSimulator.Order(
                OrderSimulator.NewCustomer1(),
                OrderSimulator.NewMenuItemsSet1()
            );

            // Order Variant 2
            //OrderSimulator.Order(
            //    OrderSimulator.NewCustomer2(),
            //    OrderSimulator.NewMenuItemsSet2()
            //);
        }

        public IActionResult Index()
        {
            ViewBag.Order = OrderSimulator.CurrentOrder;
            ViewBag.Vendor = OrderSimulator.Vendor;
            ViewBag.Rider = OrderSimulator.Rider;
            return View();
        }

        public IActionResult VendorReport()
        {
            ViewBag.Vendor = OrderSimulator.Vendor;
            return View();
        }

        public IActionResult RiderReport()
        {
            ViewBag.Rider = OrderSimulator.Rider;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}