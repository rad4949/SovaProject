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

            if (!content.Taruf.Any())
            {
                content.AddRange(
                    new Taruf
                    {
                        name = "Максі+",
                        shortDesc = "Для багатоповерхових будинків",
                        longDesc = "Швидкість інтернету 50 Мбіт/с через локальні оптичні мережі",
                        img = "https://detector.media/doc/images/news/archive/2016/133767/ArticleImage_133767.jpg",
                        price = 150,
                        isFavorite = true,
                        available = true,
                        Category = Categories["Сарни"]
                    },
                    new Taruf
                    {
                        name = "Ультра+",
                        shortDesc = "Для багатоповерхових будинків",
                        longDesc = "Швидкість інтернету 100 Мбіт/с через локальні оптичні мережі",
                        img = "https://detector.media/doc/images/news/archive/2016/133767/ArticleImage_133767.jpg",
                        price = 200,
                        isFavorite = true,
                        available = true,
                        Category = Categories["Сарни"]
                    },
                    new Taruf
                    {
                        name = "ГігаПорт 150",
                        shortDesc = "Для багатоповерхових будинків",
                        longDesc = "Швидкість інтернету 150 Мбіт/с через локальні оптичні мережі",
                        img = "https://detector.media/doc/images/news/archive/2016/133767/ArticleImage_133767.jpg",
                        price = 250,
                        isFavorite = true,
                        available = true,
                        Category = Categories["Сарни"]
                    },
                    new Taruf
                    {
                        name = "ГігаПорт 200",
                        shortDesc = "Для багатоповерхових будинків",
                        longDesc = "Швидкість інтернету 200 Мбіт/с через локальні оптичні мережі",
                        img = "https://detector.media/doc/images/news/archive/2016/133767/ArticleImage_133767.jpg",
                        price = 300,
                        isFavorite = true,
                        available = true,
                        Category = Categories["Сарни"]
                    },
                    new Taruf
                    {
                        name = "Ультра+",
                        shortDesc = "Для приватних секторів",
                        longDesc = "Швидкість інтернету 100 Мбіт/с через локальні оптичні мережі",
                        img = "https://detector.media/doc/images/news/archive/2016/133767/ArticleImage_133767.jpg",
                        price = 200,
                        isFavorite = true,
                        available = true,
                        Category = Categories["Сарни"]
                    },
                    new Taruf
                    {
                        name = "ГігаПорт 150",
                        shortDesc = "Для приватних секторів",
                        longDesc = "Швидкість інтернету 150 Мбіт/с через локальні оптичні мережі",
                        img = "https://detector.media/doc/images/news/archive/2016/133767/ArticleImage_133767.jpg",
                        price = 250,
                        isFavorite = true,
                        available = true,
                        Category = Categories["Сарни"]
                    },
                    new Taruf
                    {
                        name = "ГігаПорт 200",
                        shortDesc = "Для приватних секторів",
                        longDesc = "Швидкість інтернету 200 Мбіт/с через локальні оптичні мережі",
                        img = "https://detector.media/doc/images/news/archive/2016/133767/ArticleImage_133767.jpg",
                        price = 300,
                        isFavorite = true,
                        available = true,
                        Category = Categories["Сарни"]
                    },
                    new Taruf
                    {
                        name = "Професійний",
                        shortDesc = "Для всіх видів житла",
                        longDesc = "Швидкість інтернету 3 Мбіт/с по радіо",
                        img = "https://detector.media/doc/images/news/archive/2016/133767/ArticleImage_133767.jpg",
                        price = 150,
                        isFavorite = true,
                        available = true,
                        Category = Categories["Сарни"]
                    },
                    new Taruf
                    {
                        name = "Максимальний",
                        shortDesc = "Для всіх видів житла",
                        longDesc = "Швидкість інтернету 10 Мбіт/с по радіо",
                        img = "https://detector.media/doc/images/news/archive/2016/133767/ArticleImage_133767.jpg",
                        price = 200,
                        isFavorite = true,
                        available = true,
                        Category = Categories["Сарни"]
                    },
                    new Taruf
                    {
                        name = "Ультра",
                        shortDesc = "Для всіх видів житла",
                        longDesc = "Швидкість інтернету 20 Мбіт/с по радіо",
                        img = "https://detector.media/doc/images/news/archive/2016/133767/ArticleImage_133767.jpg",
                        price = 250,
                        isFavorite = true,
                        available = true,
                        Category = Categories["Сарни"]
                    },
                    new Taruf
                    {
                        name = "Офіс 10",
                        shortDesc = "Для бізнесу",
                        longDesc = "Швидкість інтернету 10 Мбіт/с по радіо",
                        img = "https://detector.media/doc/images/news/archive/2016/133767/ArticleImage_133767.jpg",
                        price = 300,
                        isFavorite = true,
                        available = true,
                        Category = Categories["Сарни"]
                    },
                    new Taruf
                    {
                        name = "Офіс 20",
                        shortDesc = "Для бізнесу",
                        longDesc = "Швидкість інтернету 20 Мбіт/с по радіо",
                        img = "https://detector.media/doc/images/news/archive/2016/133767/ArticleImage_133767.jpg",
                        price = 500,
                        isFavorite = true,
                        available = true,
                        Category = Categories["Сарни"]
                    },
                    new Taruf
                    {
                        name = "Офіс 50",
                        shortDesc = "Для бізнесу",
                        longDesc = "Швидкість інтернету 50 Мбіт/с по радіо",
                        img = "https://detector.media/doc/images/news/archive/2016/133767/ArticleImage_133767.jpg",
                        price = 800,
                        isFavorite = true,
                        available = true,
                        Category = Categories["Сарни"]
                    },
                    new Taruf
                    {
                        name = "Офіс 5",
                        shortDesc = "Для всіх видів житла",
                        longDesc = "Для бізнесу",
                        img = "https://detector.media/doc/images/news/archive/2016/133767/ArticleImage_133767.jpg",
                        price = 300,
                        isFavorite = true,
                        available = true,
                        Category = Categories["Сарни"]
                    },
                    new Taruf
                    {
                        name = "Офіс 10",
                        shortDesc = "Для бізнесу",
                        longDesc = "Швидкість інтернету 10 Мбіт/с по радіо",
                        img = "https://detector.media/doc/images/news/archive/2016/133767/ArticleImage_133767.jpg",
                        price = 500,
                        isFavorite = true,
                        available = true,
                        Category = Categories["Сарни"]
                    },
                    new Taruf
                    {
                        name = "Офіс 20",
                        shortDesc = "Для бізнесу",
                        longDesc = "Швидкість інтернету 20 Мбіт/с по радіо",
                        img = "https://detector.media/doc/images/news/archive/2016/133767/ArticleImage_133767.jpg",
                        price = 800,
                        isFavorite = true,
                        available = true,
                        Category = Categories["Сарни"]
                    },
                    new Taruf
                    {
                        name = "HOME-10",
                        shortDesc = "Для всіх видів житла",
                        longDesc = "Швидкість інтернету 10 Мбіт/с через локальні оптичні мережі",
                        img = "https://detector.media/doc/images/news/archive/2016/133767/ArticleImage_133767.jpg",
                        price = 150,
                        isFavorite = true,
                        available = true,
                        Category = Categories["Дослідна станція"]
                    },
                    new Taruf
                    {
                        name = "HOME-20",
                        shortDesc = "Для всіх видів житла",
                        longDesc = "Швидкість інтернету 20 Мбіт/с через локальні оптичні мережі",
                        img = "https://detector.media/doc/images/news/archive/2016/133767/ArticleImage_133767.jpg",
                        price = 200,
                        isFavorite = true,
                        available = true,
                        Category = Categories["Дослідна станція"]
                    },
                    new Taruf
                    {
                        name = "HOME-50",
                        shortDesc = "Для всіх видів житла",
                        longDesc = "Швидкість інтернету 50 Мбіт/с через локальні оптичні мережі",
                        img = "https://detector.media/doc/images/news/archive/2016/133767/ArticleImage_133767.jpg",
                        price = 250,
                        isFavorite = true,
                        available = true,
                        Category = Categories["Дослідна станція"]
                    },
                    new Taruf
                    {
                        name = "HOME-100",
                        shortDesc = "Для всіх видів житла",
                        longDesc = "Швидкість інтернету 100 Мбіт/с через локальні оптичні мережі",
                        img = "https://detector.media/doc/images/news/archive/2016/133767/ArticleImage_133767.jpg",
                        price = 300,
                        isFavorite = true,
                        available = true,
                        Category = Categories["Дослідна станція"]
                    },
                    new Taruf
                    {
                        name = "HOME-10",
                        shortDesc = "Для всіх видів житла",
                        longDesc = "Швидкість інтернету 10 Мбіт/с через локальні оптичні мережі",
                        img = "https://detector.media/doc/images/news/archive/2016/133767/ArticleImage_133767.jpg",
                        price = 150,
                        isFavorite = true,
                        available = true,
                        Category = Categories["Клесів"]
                    },
                    new Taruf
                    {
                        name = "HOME-20",
                        shortDesc = "Для всіх видів житла",
                        longDesc = "Швидкість інтернету 20 Мбіт/с через локальні оптичні мережі",
                        img = "https://detector.media/doc/images/news/archive/2016/133767/ArticleImage_133767.jpg",
                        price = 200,
                        isFavorite = true,
                        available = true,
                        Category = Categories["Клесів"]
                    },
                    new Taruf
                    {
                        name = "HOME-50",
                        shortDesc = "Для всіх видів житла",
                        longDesc = "Швидкість інтернету 50 Мбіт/с через локальні оптичні мережі",
                        img = "https://detector.media/doc/images/news/archive/2016/133767/ArticleImage_133767.jpg",
                        price = 250,
                        isFavorite = true,
                        available = true,
                        Category = Categories["Клесів"]
                    },
                    new Taruf
                    {
                        name = "HOME-100",
                        shortDesc = "Для всіх видів житла",
                        longDesc = "Швидкість інтернету 100 Мбіт/с через локальні оптичні мережі",
                        img = "https://detector.media/doc/images/news/archive/2016/133767/ArticleImage_133767.jpg",
                        price = 300,
                        isFavorite = true,
                        available = true,
                        Category = Categories["Клесів"]
                    },
                    new Taruf
                    {
                        name = "Професійний",
                        shortDesc = "Для всіх видів житла",
                        longDesc = "Швидкість інтернету 3 Мбіт/с по радіо",
                        img = "https://detector.media/doc/images/news/archive/2016/133767/ArticleImage_133767.jpg",
                        price = 150,
                        isFavorite = true,
                        available = true,
                        Category = Categories["Клесів"]
                    },
                    new Taruf
                    {
                        name = "Максимальний",
                        shortDesc = "Для всіх видів житла",
                        longDesc = "Швидкість інтернету 10 Мбіт/с по радіо",
                        img = "https://detector.media/doc/images/news/archive/2016/133767/ArticleImage_133767.jpg",
                        price = 200,
                        isFavorite = true,
                        available = true,
                        Category = Categories["Клесів"]
                    },
                    new Taruf
                    {
                        name = "Ультра",
                        shortDesc = "Для всіх видів житла",
                        longDesc = "Швидкість інтернету 20 Мбіт/с по радіо",
                        img = "https://detector.media/doc/images/news/archive/2016/133767/ArticleImage_133767.jpg",
                        price = 250,
                        isFavorite = true,
                        available = true,
                        Category = Categories["Клесів"]
                    },
                    new Taruf
                    {
                        name = "Офіс 5",
                        shortDesc = "Для бізнесу",
                        longDesc = "Швидкість інтернету 5 Мбіт/с через локальні оптичні мережі",
                        img = "https://detector.media/doc/images/news/archive/2016/133767/ArticleImage_133767.jpg",
                        price = 300,
                        isFavorite = true,
                        available = true,
                        Category = Categories["Клесів"]
                    },
                    new Taruf
                    {
                        name = "Офіс 10",
                        shortDesc = "Для бізнесу",
                        longDesc = "Швидкість інтернету 10 Мбіт/с через локальні оптичні мережі",
                        img = "https://detector.media/doc/images/news/archive/2016/133767/ArticleImage_133767.jpg",
                        price = 500,
                        isFavorite = true,
                        available = true,
                        Category = Categories["Клесів"]
                    },
                    new Taruf
                    {
                        name = "Офіс 20",
                        shortDesc = "Для бізнесу",
                        longDesc = "Швидкість інтернету 20 Мбіт/с через локальні оптичні мережі",
                        img = "https://detector.media/doc/images/news/archive/2016/133767/ArticleImage_133767.jpg",
                        price = 800,
                        isFavorite = true,
                        available = true,
                        Category = Categories["Клесів"]
                    },
                    new Taruf
                    {
                        name = "Офіс 5",
                        shortDesc = "Для бізнесу",
                        longDesc = "Швидкість інтернету 5 Мбіт/с по радіо",
                        img = "https://detector.media/doc/images/news/archive/2016/133767/ArticleImage_133767.jpg",
                        price = 300,
                        isFavorite = true,
                        available = true,
                        Category = Categories["Клесів"]
                    },
                    new Taruf
                    {
                        name = "Офіс 10",
                        shortDesc = "Для бізнесу",
                        longDesc = "Швидкість інтернету 10 Мбіт/с по радіо",
                        img = "https://detector.media/doc/images/news/archive/2016/133767/ArticleImage_133767.jpg",
                        price = 500,
                        isFavorite = true,
                        available = true,
                        Category = Categories["Клесів"]
                    },
                    new Taruf
                    {
                        name = "Офіс 20",
                        shortDesc = "Для бізнесу",
                        longDesc = "Швидкість інтернету 20 Мбіт/с по радіо",
                        img = "https://detector.media/doc/images/news/archive/2016/133767/ArticleImage_133767.jpg",
                        price = 800,
                        isFavorite = true,
                        available = true,
                        Category = Categories["Клесів"]
                    },
                    new Taruf
                    {
                        name = "HOME-10",
                        shortDesc = "Для всіх видів житла",
                        longDesc = "Швидкість інтернету 10 Мбіт/с через локальні оптичні мережі",
                        img = "https://detector.media/doc/images/news/archive/2016/133767/ArticleImage_133767.jpg",
                        price = 150,
                        isFavorite = true,
                        available = true,
                        Category = Categories["Карпилівка"]
                    },
                    new Taruf
                    {
                        name = "HOME-20",
                        shortDesc = "Для всіх видів житла",
                        longDesc = "Швидкість інтернету 20 Мбіт/с через локальні оптичні мережі",
                        img = "https://detector.media/doc/images/news/archive/2016/133767/ArticleImage_133767.jpg",
                        price = 200,
                        isFavorite = true,
                        available = true,
                        Category = Categories["Карпилівка"]
                    },
                    new Taruf
                    {
                        name = "HOME-50",
                        shortDesc = "Для всіх видів житла",
                        longDesc = "Швидкість інтернету 50 Мбіт/с через локальні оптичні мережі",
                        img = "https://detector.media/doc/images/news/archive/2016/133767/ArticleImage_133767.jpg",
                        price = 250,
                        isFavorite = true,
                        available = true,
                        Category = Categories["Карпилівка"]
                    },
                    new Taruf
                    {
                        name = "HOME-100",
                        shortDesc = "Для всіх видів житла",
                        longDesc = "Швидкість інтернету 100 Мбіт/с через локальні оптичні мережі",
                        img = "https://detector.media/doc/images/news/archive/2016/133767/ArticleImage_133767.jpg",
                        price = 300,
                        isFavorite = true,
                        available = true,
                        Category = Categories["Карпилівка"]
                    }
                    );
            }
            content.SaveChanges();
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
                     new Category{ categoryName="Сарни", desc=""},
                    new Category{ categoryName="Дослідна станція", desc=""},
                    new Category{ categoryName="Клесів", desc=""},
                    new Category{ categoryName="Карпилівка", desc=""}
                    };
                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                    {
                        category.Add(el.categoryName, el);
                    }
                }
                return category;
            }
        }
    }
}


