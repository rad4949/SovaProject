using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.EntityFrameworkCore;
using MimeKit;
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
            order.OrderTime = DateTime.Now;
            order.IsActive = false;
            _appDBContent.Order.Add(order);
            _appDBContent.SaveChanges();
            var items = userCart.UserItems;

            var orderDetail = new OrderDetail()
            {
                TarufID = items.Taruf.Id,
                OrderID = order.Id,
                Price = items.Taruf.Price
            };
            _appDBContent.OrderDetail.Add(orderDetail);
            _appDBContent.SaveChanges();

           
            string html = order.Surname + " " + order.Name + ", виконав замовлення за адресою: " + order.Adress;         
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Mrs. Chanandler Bong", "itstudentyre@gmail.com"));
            message.To.Add(new MailboxAddress("Mrs. Chanandler Bong", "igor12radchuk@gmail.com"));
            message.Subject = "How you doin'?";

            message.Body = new TextPart("plain")
            {
                Text = @"Hey Chandler,I just wanted to let you know that Monica and I were going to go play some paintball, you in?-- Joey"
            };

            using (var client = new SmtpClient())
            {
                client.ServerCertificateValidationCallback = (s, c, h, e) => true;
                client.Connect("smtp.gmail.com", 465, true);
                client.Authenticate("itstudentyre@gmail.com", "thuoji5Ne+");
                client.Send(message);
                client.Disconnect(true);
            }
            //using (var client = new MailKit.Net.Smtp.SmtpClient())
            //{
            //    client.ServerCertificateValidationCallback = (s, c, h, e) => true;

            //    client.Connect("smtp.gmail.com", 465, true);
            //    client.Authenticate("itstudentyre@gmail.com", "thuoji5Ne+");
            //    client.Send(message);
            //    client.Disconnect(true);
            //}
        }
    }
}
