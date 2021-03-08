using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SovaProject.Data.Entities;
using SovaProject.Data.interfeces;
using SovaProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SovaProject.Controllers
{
    public class OrderController : Controller
    {
        private readonly IAllOrders allOrders;
        private readonly UserCart userCart;
        //private readonly AppDBContent _appDBContent;

        public OrderController(IAllOrders allOrders, UserCart userCart/*, AppDBContent appDBContent*/)
        {
            this.allOrders = allOrders;
            this.userCart = userCart;
            //_appDBContent = appDBContent;

        }
        [HttpGet]
        public IActionResult Checkout()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            //var listShopCart = _appDBContent.UserCartItem.Include(x => x.Taruf).AsQueryable();
            userCart.listUserItems = userCart.getUserItems();

            //if (listShopCart == null)
            //{
            //    ModelState.AddModelError("", "У вас мають бути вибрані товари");
            //}
            if (userCart.listUserItems.Count == 0)
            {
                ModelState.AddModelError("", "У вас мають бути вибрані товари");
            }
            if (ModelState.IsValid)
            {
                allOrders.createOrder(order);
                return RedirectToAction("Complete");
            }

            return View(order);
        }
        public IActionResult Complete()
        {
            ViewBag.Message = "Замовлення успішно виконано";
            return View();
        }
    }
}
