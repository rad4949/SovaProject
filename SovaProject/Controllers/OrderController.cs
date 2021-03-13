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

        public OrderController(IAllOrders allOrders, UserCart userCart)
        {
            this.allOrders = allOrders;
            this.userCart = userCart;
        }
        [HttpGet]
        public IActionResult Checkout()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            userCart.UserItems = userCart.getUserItems();

            if (userCart.UserItems.Price == 0)
            {
                ModelState.AddModelError("", "У вас мають бути вибрані товари");
            }
            else
            {
                if (ModelState.IsValid)
                {
                    allOrders.createOrder(order);
                    return RedirectToAction("Complete");
                }
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
