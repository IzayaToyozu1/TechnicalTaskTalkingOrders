using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using TechnicalTaskTalkingOrders.Models;

namespace TechnicalTaskTalkingOrders.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationContext db;

        public HomeController(ApplicationContext context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddOrder(Order order)
        {
            db.Orders.Add(order);
            db.SaveChanges();
            return RedirectToAction(nameof(ListOrder));
        }

        public IActionResult ListOrder()
        {
            return View(db.Orders.ToList());
        }

        protected void BtClick(object sender, EventArgs e)
        {
            
        }
    }
}