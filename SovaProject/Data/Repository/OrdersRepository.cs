using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.EntityFrameworkCore;
using MimeKit;
using SendGrid;
using SendGrid.Helpers.Mail;
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
            //var message = new MimeMessage();
            //message.From.Add(new MailboxAddress(/*"Mrs. Chanandler Bong", */"itstudentyre@gmail.com"));
            //message.To.Add(new MailboxAddress(/*"Mrs. Chanandler Bong", */"igor12radchuk@gmail.com"));
            //message.Subject = "Нове повідомлення";

            //message.Body = new TextPart("plain")
            //{
            //    Text = html/*@"Hey Chandler,I just wanted to let you know that Monica and I were going to go play some paintball, you in?-- Joey"*/
            //};

            //using (var client = new SmtpClient())
            //{
            //    client.ServerCertificateValidationCallback = (s, c, h, e) => true;
            //    client.Connect("smtp.gmail.com", 465, true);
            //    client.Authenticate("itstudentyre@gmail.com", "thuoji5Ne+");
            //    client.Send(message);
            //    client.Disconnect(true);
            //}

            var apiKey = Environment.GetEnvironmentVariable("NAME_OF_THE_ENVIRONMENT_VARIABLE_FOR_YOUR_SENDGRID_KEY");
            var client = new SendGridClient("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");
            var from = new EmailAddress("igor12radchuk@gmail.com");
            var subject = "Sending with SendGrid is Fun";
            var to = new EmailAddress("sova.project.adm1n@gmail.com");//, "Example User"
            var plainTextContent = html;//"and easy to do anywhere, even with C#";
            var htmlContent = html;//"<strong>and easy to do anywhere, even with C#</strong>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = client.SendEmailAsync(msg);

        }
    }
}
