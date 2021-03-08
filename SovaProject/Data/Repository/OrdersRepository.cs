using Microsoft.EntityFrameworkCore;
using SovaProject.Data.Entities;
using SovaProject.Data.interfeces;
using SovaProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SovaProject.Data.Repository
{
    public class OrdersRepository : IAllOrders
    {
        private readonly AppDBContent _appDBContent;
        private readonly UserCart userCart;

        public OrdersRepository(AppDBContent appDBContent, UserCart userCart)
        {
            _appDBContent = appDBContent;
            this.userCart = userCart;
        }
        public void createOrder(Order order)
        {
            //Order.OrderTime = DateTime.Now;
            //_appDBContent.Order.Add(Order);
            //var items = _appDBContent.UserCartItem.Include(x => x.Taruf).AsQueryable();

            //foreach (var el in items)
            //{
            //    var orderDetail = new OrderDetail()
            //    {
            //        TarufID = el.tarufId,
            //        OrderID = Order.Id,
            //        Price = el.Price 
            //    };
            //    _appDBContent.OrderDetail.Add(orderDetail);
            //}
            //_appDBContent.SaveChanges();

            /////////////////////////////////////////////////////////////////////////////
            
            order.OrderTime = DateTime.Now;
            order.IsActive = false;
            _appDBContent.Order.Add(order);
            _appDBContent.SaveChanges();
           
            var items = userCart.listUserItems;

            foreach (var el in items)
            {
                var orderDetail = new OrderDetail()
                {
                    TarufID = el.Taruf.Id,
                    OrderID = order.Id,
                    Price = el.Taruf.Price
                };
                _appDBContent.OrderDetail.Add(orderDetail);
            }
            _appDBContent.SaveChanges();
        }
    }
}
