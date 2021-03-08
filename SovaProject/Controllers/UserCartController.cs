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
        //private readonly AppDBContent _appDBContent;

        public UserCartController(IAllTarufs tarufPep, UserCart userCart/*, AppDBContent appDBContent*/)
        {
            _tarufRep = tarufPep;
            _userCart = userCart;
            //_appDBContent = appDBContent;
        }

        public ViewResult Index()
        {
            //var list = _appDBContent.UserCartItem.Include(x => x.Taruf).AsQueryable();
            //UserCartViewModel obj = new UserCartViewModel();
            //obj.userCart = list.Select(x => new UserCart1ViewModel
            //{
            //    Name = x.Taruf.Name,
            //    Price = x.Price
            //}).ToList();

            var items = _userCart.getUserItems();
            _userCart.listUserItems = items;

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
            //_appDBContent.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
