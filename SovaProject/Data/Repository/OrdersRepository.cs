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
            //order.orderTime = DateTime.Now;
            //_appDBContent.Order.Add(order);
            //var items = _appDBContent.UserCartItem.Include(x => x.taruf).AsQueryable();

            //foreach (var el in items)
            //{
            //    var orderDetail = new OrderDetail()
            //    {
            //        TarufID = el.tarufId,
            //        orderID = order.id,
            //        price = el.price 
            //    };
            //    _appDBContent.OrderDetail.Add(orderDetail);
            //}
            //_appDBContent.SaveChanges();

            /////////////////////////////////////////////////////////////////////////////
            
            order.orderTime = DateTime.Now;
            _appDBContent.Order.Add(order);
            _appDBContent.SaveChanges();
            var userIsActive = new UserIsActive()
            {
                orderId = order.id,
                IsActive = false
            };
            _appDBContent.UserIsActives.Add(userIsActive);
            _appDBContent.SaveChanges();

            var items = userCart.listUserItems;

            foreach (var el in items)
            {
                var orderDetail = new OrderDetail()
                {
                    TarufID = el.taruf.id,
                    orderID = order.id,
                    price = el.taruf.price
                };
                _appDBContent.OrderDetail.Add(orderDetail);
            }
            _appDBContent.SaveChanges();
        }
    }
}
