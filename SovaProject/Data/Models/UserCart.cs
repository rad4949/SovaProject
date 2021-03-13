using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SovaProject.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SovaProject.Data.Models
{
    public class UserCart
    {
        private readonly AppDBContent _appDBContent;
        public UserCart(AppDBContent appDBContent)
        {
            this._appDBContent = appDBContent;
        }
        public string UserCartId { get; set; }
        public UserCartItem UserItems { get; set; }

        public static UserCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDBContent>();
            string userCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();
            session.SetString("CartId", userCartId);
            return new UserCart(context) { UserCartId = userCartId };
        }

        public void AddToCart(Taruf taruf)
        {
            _appDBContent.UserCartItem.Add(new UserCartItem
            {
                UserCartId=UserCartId,
                Taruf=taruf,
                Price=taruf.Price
            });
            _appDBContent.SaveChanges();
        }

        public UserCartItem getUserItems()
        {
                return _appDBContent.UserCartItem.Where(c => c.UserCartId == UserCartId).Include(s => s.Taruf).ToList().LastOrDefault();
        }
    }
}
