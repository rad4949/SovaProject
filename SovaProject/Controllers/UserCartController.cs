using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SovaProject.Data.Entities;
using SovaProject.Data.interfeces;
using SovaProject.Data.Models;
using SovaProject.Data.Repository;
using SovaProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SovaProject.Controllers
{
    public class UserCartController: Controller
    {
        private IAllTarufs _tarufRep;
        private readonly UserCart _userCart;

        public UserCartController(IAllTarufs tarufPep, UserCart userCart)
        {
            _tarufRep = tarufPep;
            _userCart = userCart;
        }

        public ViewResult Index()
        {
            var items = _userCart.getUserItems();
            _userCart.UserItems = items;

            var obj = new NewUserCartViewModel
            {
                userCart = _userCart
            };

            return View(obj);
        }

        [Route("UserCart/addToCart/{Id?}")]
        public RedirectToActionResult addToCart(int id)
        {
            var item = _tarufRep.Tarufs.FirstOrDefault(i => i.Id == id);
            if (item != null)
            {
                _userCart.AddToCart(item);
            }
            return RedirectToAction("Index");
        }
    }
}
