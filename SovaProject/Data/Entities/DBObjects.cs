using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using SovaProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SovaProject.Data.Entities
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            if (!content.Category.Any())
            {
                content.Category.AddRange(Categories.Select(c => c.Value));
            }
            List<Taruf> tarufList = new List<Taruf> { new Taruf
                    {
                        Name = "Максі+",
                        ShortDesc = "Для багатоповерхових будинків",
                        LongDesc = "Швидкість інтернету 50 Мбіт/с через локальні оптичні мережі",
                        Img = "https://detector.media/doc/images/news/archive/2016/133767/ArticleImage_133767.jpg",
                        Price = 150,
                        IsFavorite = true,
                        Available = true,
                        Category = Categories["Сарни"]
                    },
                    new Taruf
                    {
                        Name = "Ультра+",
                        ShortDesc = "Для багатоповерхових будинків",
                        LongDesc = "Швидкість інтернету 100 Мбіт/с через локальні оптичні мережі",
                        Img = "https://detector.media/doc/images/news/archive/2016/133767/ArticleImage_133767.jpg",
                        Price = 200,
                        IsFavorite = true,
                        Available = true,
                        Category = Categories["Сарни"]
                    },
                    new Taruf
                    {
                        Name = "ГігаПорт 150",
                        ShortDesc = "Для багатоповерхових будинків",
                        LongDesc = "Швидкість інтернету 150 Мбіт/с через локальні оптичні мережі",
                        Img = "https://detector.media/doc/images/news/archive/2016/133767/ArticleImage_133767.jpg",
                        Price = 250,
                        IsFavorite = true,
                        Available = true,
                        Category = Categories["Сарни"]
                    },
                    new Taruf
                    {
                        Name = "ГігаПорт 200",
                        ShortDesc = "Для багатоповерхових будинків",
                        LongDesc = "Швидкість інтернету 200 Мбіт/с через локальні оптичні мережі",
                        Img = "https://detector.media/doc/images/news/archive/2016/133767/ArticleImage_133767.jpg",
                        Price = 300,
                        IsFavorite = true,
                        Available = true,
                        Category = Categories["Сарни"]
                    },
                    new Taruf
                    {
                        Name = "Ультра+",
                        ShortDesc = "Для приватних секторів",
                        LongDesc = "Швидкість інтернету 100 Мбіт/с через локальні оптичні мережі",
                        Img = "https://detector.media/doc/images/news/archive/2016/133767/ArticleImage_133767.jpg",
                        Price = 200,
                        IsFavorite = true,
                        Available = true,
                        Category = Categories["Сарни"]
                    },
                    new Taruf
                    {
                        Name = "ГігаПорт 150",
                        ShortDesc = "Для приватних секторів",
                        LongDesc = "Швидкість інтернету 150 Мбіт/с через локальні оптичні мережі",
                        Img = "https://detector.media/doc/images/news/archive/2016/133767/ArticleImage_133767.jpg",
                        Price = 250,
                        IsFavorite = true,
                        Available = true,
                        Category = Categories["Сарни"]
                    },
                    new Taruf
                    {
                        Name = "ГігаПорт 200",
                        ShortDesc = "Для приватних секторів",
                        LongDesc = "Швидкість інтернету 200 Мбіт/с через локальні оптичні мережі",
                        Img = "https://detector.media/doc/images/news/archive/2016/133767/ArticleImage_133767.jpg",
                        Price = 300,
                        IsFavorite = true,
                        Available = true,
                        Category = Categories["Сарни"]
                    },
                    new Taruf
                    {
                        Name = "Професійний",
                        ShortDesc = "Для всіх видів житла",
                        LongDesc = "Швидкість інтернету 3 Мбіт/с по радіо",
                        Img = "https://detector.media/doc/images/news/archive/2016/133767/ArticleImage_133767.jpg",
                        Price = 150,
                        IsFavorite = true,
                        Available = true,
                        Category = Categories["Сарни"]
                    },
                    new Taruf
                    {
                        Name = "Максимальний",
                        ShortDesc = "Для всіх видів житла",
                        LongDesc = "Швидкість інтернету 10 Мбіт/с по радіо",
                        Img = "https://detector.media/doc/images/news/archive/2016/133767/ArticleImage_133767.jpg",
                        Price = 200,
                        IsFavorite = true,
                        Available = true,
                        Category = Categories["Сарни"]
                    },
                    new Taruf
                    {
                        Name = "Ультра",
                        ShortDesc = "Для всіх видів житла",
                        LongDesc = "Швидкість інтернету 20 Мбіт/с по радіо",
                        Img = "https://detector.media/doc/images/news/archive/2016/133767/ArticleImage_133767.jpg",
                        Price = 250,
                        IsFavorite = true,
                        Available = true,
                        Category = Categories["Сарни"]
                    },
                    new Taruf
                    {
                        Name = "Офіс 10",
                        ShortDesc = "Для бізнесу",
                        LongDesc = "Швидкість інтернету 10 Мбіт/с по радіо",
                        Img = "https://detector.media/doc/images/news/archive/2016/133767/ArticleImage_133767.jpg",
                        Price = 300,
                        IsFavorite = true,
                        Available = true,
                        Category = Categories["Сарни"]
                    },
                    new Taruf
                    {
                        Name = "Офіс 20",
                        ShortDesc = "Для бізнесу",
                        LongDesc = "Швидкість інтернету 20 Мбіт/с по радіо",
                        Img = "https://detector.media/doc/images/news/archive/2016/133767/ArticleImage_133767.jpg",
                        Price = 500,
                        IsFavorite = true,
                        Available = true,
                        Category = Categories["Сарни"]
                    },
                    new Taruf
                    {
                        Name = "Офіс 50",
                        ShortDesc = "Для бізнесу",
                        LongDesc = "Швидкість інтернету 50 Мбіт/с по радіо",
                        Img = "https://detector.media/doc/images/news/archive/2016/133767/ArticleImage_133767.jpg",
                        Price = 800,
                        IsFavorite = true,
                        Available = true,
                        Category = Categories["Сарни"]
                    },
                    new Taruf
                    {
                        Name = "Офіс 5",
                        ShortDesc = "Для всіх видів житла",
                        LongDesc = "Для бізнесу",
                        Img = "https://detector.media/doc/images/news/archive/2016/133767/ArticleImage_133767.jpg",
                        Price = 300,
                        IsFavorite = true,
                        Available = true,
                        Category = Categories["Сарни"]
                    },
                    new Taruf
                    {
                        Name = "Офіс 10",
                        ShortDesc = "Для бізнесу",
                        LongDesc = "Швидкість інтернету 10 Мбіт/с по радіо",
                        Img = "https://detector.media/doc/images/news/archive/2016/133767/ArticleImage_133767.jpg",
                        Price = 500,
                        IsFavorite = true,
                        Available = true,
                        Category = Categories["Сарни"]
                    },
                    new Taruf
                    {
                        Name = "Офіс 20",
                        ShortDesc = "Для бізнесу",
                        LongDesc = "Швидкість інтернету 20 Мбіт/с по радіо",
                        Img = "https://detector.media/doc/images/news/archive/2016/133767/ArticleImage_133767.jpg",
                        Price = 800,
                        IsFavorite = true,
                        Available = true,
                        Category = Categories["Сарни"]
                    },
                    new Taruf
                    {
                        Name = "HOME-10",
                        ShortDesc = "Для всіх видів житла",
                        LongDesc = "Швидкість інтернету 10 Мбіт/с через локальні оптичні мережі",
                        Img = "https://detector.media/doc/images/news/archive/2016/133767/ArticleImage_133767.jpg",
                        Price = 150,
                        IsFavorite = true,
                        Available = true,
                        Category = Categories["Дослідна станція"]
                    },
                    new Taruf
                    {
                        Name = "HOME-20",
                        ShortDesc = "Для всіх видів житла",
                        LongDesc = "Швидкість інтернету 20 Мбіт/с через локальні оптичні мережі",
                        Img = "https://detector.media/doc/images/news/archive/2016/133767/ArticleImage_133767.jpg",
                        Price = 200,
                        IsFavorite = true,
                        Available = true,
                        Category = Categories["Дослідна станція"]
                    },
                    new Taruf
                    {
                        Name = "HOME-50",
                        ShortDesc = "Для всіх видів житла",
                        LongDesc = "Швидкість інтернету 50 Мбіт/с через локальні оптичні мережі",
                        Img = "https://detector.media/doc/images/news/archive/2016/133767/ArticleImage_133767.jpg",
                        Price = 250,
                        IsFavorite = true,
                        Available = true,
                        Category = Categories["Дослідна станція"]
                    },
                    new Taruf
                    {
                        Name = "HOME-100",
                        ShortDesc = "Для всіх видів житла",
                        LongDesc = "Швидкість інтернету 100 Мбіт/с через локальні оптичні мережі",
                        Img = "https://detector.media/doc/images/news/archive/2016/133767/ArticleImage_133767.jpg",
                        Price = 300,
                        IsFavorite = true,
                        Available = true,
                        Category = Categories["Дослідна станція"]
                    },
                    new Taruf
                    {
                        Name = "HOME-10",
                        ShortDesc = "Для всіх видів житла",
                        LongDesc = "Швидкість інтернету 10 Мбіт/с через локальні оптичні мережі",
                        Img = "https://detector.media/doc/images/news/archive/2016/133767/ArticleImage_133767.jpg",
                        Price = 150,
                        IsFavorite = true,
                        Available = true,
                        Category = Categories["Клесів"]
                    },
                    new Taruf
                    {
                        Name = "HOME-20",
                        ShortDesc = "Для всіх видів житла",
                        LongDesc = "Швидкість інтернету 20 Мбіт/с через локальні оптичні мережі",
                        Img = "https://detector.media/doc/images/news/archive/2016/133767/ArticleImage_133767.jpg",
                        Price = 200,
                        IsFavorite = true,
                        Available = true,
                        Category = Categories["Клесів"]
                    },
                    new Taruf
                    {
                        Name = "HOME-50",
                        ShortDesc = "Для всіх видів житла",
                        LongDesc = "Швидкість інтернету 50 Мбіт/с через локальні оптичні мережі",
                        Img = "https://detector.media/doc/images/news/archive/2016/133767/ArticleImage_133767.jpg",
                        Price = 250,
                        IsFavorite = true,
                        Available = true,
                        Category = Categories["Клесів"]
                    },
                    new Taruf
                    {
                        Name = "HOME-100",
                        ShortDesc = "Для всіх видів житла",
                        LongDesc = "Швидкість інтернету 100 Мбіт/с через локальні оптичні мережі",
                        Img = "https://detector.media/doc/images/news/archive/2016/133767/ArticleImage_133767.jpg",
                        Price = 300,
                        IsFavorite = true,
                        Available = true,
                        Category = Categories["Клесів"]
                    },
                    new Taruf
                    {
                        Name = "Професійний",
                        ShortDesc = "Для всіх видів житла",
                        LongDesc = "Швидкість інтернету 3 Мбіт/с по радіо",
                        Img = "https://detector.media/doc/images/news/archive/2016/133767/ArticleImage_133767.jpg",
                        Price = 150,
                        IsFavorite = true,
                        Available = true,
                        Category = Categories["Клесів"]
                    },
                    new Taruf
                    {
                        Name = "Максимальний",
                        ShortDesc = "Для всіх видів житла",
                        LongDesc = "Швидкість інтернету 10 Мбіт/с по радіо",
                        Img = "https://detector.media/doc/images/news/archive/2016/133767/ArticleImage_133767.jpg",
                        Price = 200,
                        IsFavorite = true,
                        Available = true,
                        Category = Categories["Клесів"]
                    },
                    new Taruf
                    {
                        Name = "Ультра",
                        ShortDesc = "Для всіх видів житла",
                        LongDesc = "Швидкість інтернету 20 Мбіт/с по радіо",
                        Img = "https://detector.media/doc/images/news/archive/2016/133767/ArticleImage_133767.jpg",
                        Price = 250,
                        IsFavorite = true,
                        Available = true,
                        Category = Categories["Клесів"]
                    },
                    new Taruf
                    {
                        Name = "Офіс 5",
                        ShortDesc = "Для бізнесу",
                        LongDesc = "Швидкість інтернету 5 Мбіт/с через локальні оптичні мережі",
                        Img = "https://detector.media/doc/images/news/archive/2016/133767/ArticleImage_133767.jpg",
                        Price = 300,
                        IsFavorite = true,
                        Available = true,
                        Category = Categories["Клесів"]
                    },
                    new Taruf
                    {
                        Name = "Офіс 10",
                        ShortDesc = "Для бізнесу",
                        LongDesc = "Швидкість інтернету 10 Мбіт/с через локальні оптичні мережі",
                        Img = "https://detector.media/doc/images/news/archive/2016/133767/ArticleImage_133767.jpg",
                        Price = 500,
                        IsFavorite = true,
                        Available = true,
                        Category = Categories["Клесів"]
                    },
                    new Taruf
                    {
                        Name = "Офіс 20",
                        ShortDesc = "Для бізнесу",
                        LongDesc = "Швидкість інтернету 20 Мбіт/с через локальні оптичні мережі",
                        Img = "https://detector.media/doc/images/news/archive/2016/133767/ArticleImage_133767.jpg",
                        Price = 800,
                        IsFavorite = true,
                        Available = true,
                        Category = Categories["Клесів"]
                    },
                    new Taruf
                    {
                        Name = "Офіс 5",
                        ShortDesc = "Для бізнесу",
                        LongDesc = "Швидкість інтернету 5 Мбіт/с по радіо",
                        Img = "https://detector.media/doc/images/news/archive/2016/133767/ArticleImage_133767.jpg",
                        Price = 300,
                        IsFavorite = true,
                        Available = true,
                        Category = Categories["Клесів"]
                    },
                    new Taruf
                    {
                        Name = "Офіс 10",
                        ShortDesc = "Для бізнесу",
                        LongDesc = "Швидкість інтернету 10 Мбіт/с по радіо",
                        Img = "https://detector.media/doc/images/news/archive/2016/133767/ArticleImage_133767.jpg",
                        Price = 500,
                        IsFavorite = true,
                        Available = true,
                        Category = Categories["Клесів"]
                    },
                    new Taruf
                    {
                        Name = "Офіс 20",
                        ShortDesc = "Для бізнесу",
                        LongDesc = "Швидкість інтернету 20 Мбіт/с по радіо",
                        Img = "https://detector.media/doc/images/news/archive/2016/133767/ArticleImage_133767.jpg",
                        Price = 800,
                        IsFavorite = true,
                        Available = true,
                        Category = Categories["Клесів"]
                    },
                    new Taruf
                    {
                        Name = "HOME-10",
                        ShortDesc = "Для всіх видів житла",
                        LongDesc = "Швидкість інтернету 10 Мбіт/с через локальні оптичні мережі",
                        Img = "https://detector.media/doc/images/news/archive/2016/133767/ArticleImage_133767.jpg",
                        Price = 150,
                        IsFavorite = true,
                        Available = true,
                        Category = Categories["Карпилівка"]
                    },
                    new Taruf
                    {
                        Name = "HOME-20",
                        ShortDesc = "Для всіх видів житла",
                        LongDesc = "Швидкість інтернету 20 Мбіт/с через локальні оптичні мережі",
                        Img = "https://detector.media/doc/images/news/archive/2016/133767/ArticleImage_133767.jpg",
                        Price = 200,
                        IsFavorite = true,
                        Available = true,
                        Category = Categories["Карпилівка"]
                    },
                    new Taruf
                    {
                        Name = "HOME-50",
                        ShortDesc = "Для всіх видів житла",
                        LongDesc = "Швидкість інтернету 50 Мбіт/с через локальні оптичні мережі",
                        Img = "https://detector.media/doc/images/news/archive/2016/133767/ArticleImage_133767.jpg",
                        Price = 250,
                        IsFavorite = true,
                        Available = true,
                        Category = Categories["Карпилівка"]
                    },
                    new Taruf
                    {
                        Name = "HOME-100",
                        ShortDesc = "Для всіх видів житла",
                        LongDesc = "Швидкість інтернету 100 Мбіт/с через локальні оптичні мережі",
                        Img = "https://detector.media/doc/images/news/archive/2016/133767/ArticleImage_133767.jpg",
                        Price = 300,
                        IsFavorite = true,
                        Available = true,
                        Category = Categories["Карпилівка"]
                    }
            };
            if (!content.Taruf.Any())
            {
                content.AddRange(tarufList);
            }
            content.SaveChanges();

            DateTime data = new DateTime(2021, 1, 1);

            List<Order> orderList = new List<Order> {
                   new Order
                   {
                       Name = "Ігор",
                       Surname = "Радчук",
                       Adress = "Квіткова 1",
                       Phone = "0674934949",
                       OrderTime = data,
                       IsActive = false
                   },
                   new Order
                   {
                       Name = "Ігор",
                       Surname = "Радчук",
                       Adress = "Квіткова 1",
                       Phone = "0674934949",
                       OrderTime = data.AddMonths(1),
                       IsActive = false
                   },
                   new Order
                   {
                       Name = "Ігор",
                       Surname = "Радчук",
                       Adress = "Квіткова 1",
                       Phone = "0674934949",
                       OrderTime = data.AddMonths(2),
                       IsActive = false
                   },
                   new Order
                   {
                       Name = "Ігор",
                       Surname = "Радчук",
                       Adress = "Квіткова 1",
                       Phone = "0674934949",
                       OrderTime = data.AddMonths(3),
                       IsActive = false
                   },
                   new Order
                   {
                       Name = "Ігор",
                       Surname = "Радчук",
                       Adress = "Квіткова 1",
                       Phone = "0674934949",
                       OrderTime = data.AddMonths(4),
                       IsActive = false
                   },
                   new Order
                   {
                       Name = "Ігор",
                       Surname = "Радчук",
                       Adress = "Квіткова 1",
                       Phone = "0674934949",
                       OrderTime = data.AddMonths(5),
                       IsActive = false
                   },
                   new Order
                   {
                       Name = "Ігор",
                       Surname = "Радчук",
                       Adress = "Квіткова 1",
                       Phone = "0674934949",
                       OrderTime = data.AddMonths(6),
                       IsActive = false
                   },
                   new Order
                   {
                       Name = "Ігор",
                       Surname = "Радчук",
                       Adress = "Квіткова 1",
                       Phone = "0674934949",
                       OrderTime = data.AddMonths(7),
                       IsActive = false
                   },
                   new Order
                   {
                       Name = "Ігор",
                       Surname = "Радчук",
                       Adress = "Квіткова 1",
                       Phone = "0674934949",
                       OrderTime = data.AddMonths(8),
                       IsActive = false
                   },
                   new Order
                   {
                       Name = "Ігор",
                       Surname = "Радчук",
                       Adress = "Квіткова 1",
                       Phone = "0674934949",
                       OrderTime = data.AddMonths(9),
                       IsActive = false
                   },
                   new Order
                   {
                       Name = "Ігор",
                       Surname = "Радчук",
                       Adress = "Квіткова 1",
                       Phone = "0674934949",
                       OrderTime = data.AddMonths(10),
                       IsActive = false
                   },
                   new Order
                   {
                       Name = "Ігор",
                       Surname = "Радчук",
                       Adress = "Квіткова 1",
                       Phone = "0674934949",
                       OrderTime = data.AddMonths(11),
                       IsActive = false
                   },
                   new Order
                   {
                       Name = "Ігор",
                       Surname = "Радчук",
                       Adress = "Квіткова 1",
                       Phone = "0674934949",
                       OrderTime = data.AddMonths(1),
                       IsActive = false
                   }
            };

            if (!content.Order.Any())
            {
                content.AddRange(orderList);
                content.SaveChanges();
            }

            if (!content.OrderDetail.Any())
            {
                content.OrderDetail.AddRange(
                   new OrderDetail
                   {
                       OrderID = orderList.ElementAt(1).Id,
                       TarufID = tarufList.ElementAt(1).Id,
                       Price = tarufList.ElementAt(1).Price
                   },
                   new OrderDetail
                   {
                       OrderID = orderList.ElementAt(2).Id,
                       TarufID = tarufList.ElementAt(2).Id,
                       Price = tarufList.ElementAt(2).Price
                   },
                   new OrderDetail
                   {
                       OrderID = orderList.ElementAt(3).Id,
                       TarufID = tarufList.ElementAt(3).Id,
                       Price = tarufList.ElementAt(3).Price
                   },
                   new OrderDetail
                   {
                       OrderID = orderList.ElementAt(4).Id,
                       TarufID = tarufList.ElementAt(4).Id,
                       Price = tarufList.ElementAt(4).Price
                   },
                   new OrderDetail
                   {
                       OrderID = orderList.ElementAt(5).Id,
                       TarufID = tarufList.ElementAt(5).Id,
                       Price = tarufList.ElementAt(5).Price
                   },
                   new OrderDetail
                   {
                       OrderID = orderList.ElementAt(6).Id,
                       TarufID = tarufList.ElementAt(6).Id,
                       Price = tarufList.ElementAt(6).Price
                   },
                   new OrderDetail
                   {
                       OrderID = orderList.ElementAt(7).Id,
                       TarufID = tarufList.ElementAt(7).Id,
                       Price = tarufList.ElementAt(7).Price
                   },
                   new OrderDetail
                   {
                       OrderID = orderList.ElementAt(8).Id,
                       TarufID = tarufList.ElementAt(8).Id,
                       Price = tarufList.ElementAt(8).Price
                   },
                   new OrderDetail
                   {
                       OrderID = orderList.ElementAt(9).Id,
                       TarufID = tarufList.ElementAt(9).Id,
                       Price = tarufList.ElementAt(9).Price
                   },
                   new OrderDetail
                   {
                       OrderID = orderList.ElementAt(10).Id,
                       TarufID = tarufList.ElementAt(10).Id,
                       Price = tarufList.ElementAt(10).Price
                   },
                   new OrderDetail
                   {
                       OrderID = orderList.ElementAt(11).Id,
                       TarufID = tarufList.ElementAt(11).Id,
                       Price = tarufList.ElementAt(11).Price
                   },
                   new OrderDetail
                   {
                       OrderID = orderList.ElementAt(12).Id,
                       TarufID = tarufList.ElementAt(12).Id,
                       Price = tarufList.ElementAt(12).Price
                   },
                   new OrderDetail
                   {
                       OrderID = orderList.Last().Id,
                       TarufID = tarufList.ElementAt(13).Id,
                       Price = tarufList.ElementAt(13).Price
                   });
                content.SaveChanges();
            }
        }


        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {
                     new Category{ CategoryName="Сарни", Desc=""},
                    new Category{ CategoryName="Дослідна станція", Desc=""},
                    new Category{ CategoryName="Клесів", Desc=""},
                    new Category{ CategoryName="Карпилівка", Desc=""}
                    };
                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                    {
                        category.Add(el.CategoryName, el);
                    }
                }
                return category;
            }
        }
    }
}


