using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SovaProject.Data.Entities;
using SovaProject.Data.Models;
using SovaProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SovaProject.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly AppDBContent _appDBContent;
        public AdminController(AppDBContent appDBContent)
        {
            _appDBContent = appDBContent;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Graph1()
        {
            Graph1ViewModel model = new Graph1ViewModel();
            model.Title = "";
            List<Order> listOrder = _appDBContent.Order.ToList();
            model.listElement = new List<Element>
            {
                new Element
                {
                    value = listOrder.Where(p=>p.OrderTime.Month==1).Count().ToString(),
                    label = "Січень"
                },
                new Element
                {
                    value = listOrder.Where(p=>p.OrderTime.Month==2).Count().ToString(),
                    label = "Лютий"
                },
                new Element
                {
                    value = listOrder.Where(p=>p.OrderTime.Month==3).Count().ToString(),
                    label = "Березень"
                },
                new Element
                {
                    value = listOrder.Where(p=>p.OrderTime.Month==4).Count().ToString(),
                    label = "Квітень"
                },new Element
                {
                    value = listOrder.Where(p=>p.OrderTime.Month==5).Count().ToString(),
                    label = "Травень"
                },new Element
                {
                    value = listOrder.Where(p=>p.OrderTime.Month==6).Count().ToString(),
                    label = "Червень"
                },new Element
                {
                    value = listOrder.Where(p=>p.OrderTime.Month==7).Count().ToString(),
                    label = "Липень"
                },new Element
                {
                    value = listOrder.Where(p=>p.OrderTime.Month==8).Count().ToString(),
                    label = "Серпень"
                },new Element
                {
                    value = listOrder.Where(p=>p.OrderTime.Month==9).Count().ToString(),
                    label = "Вересень"
                },new Element
                {
                    value = listOrder.Where(p=>p.OrderTime.Month==10).Count().ToString(),
                    label = "Жовтень"
                },new Element
                {
                    value = listOrder.Where(p=>p.OrderTime.Month==11).Count().ToString(),
                    label = "Листопад"
                },new Element
                {
                    value = listOrder.Where(p=>p.OrderTime.Month==12).Count().ToString(),
                    label = "Грудень"
                },
            };
            return View(model);
        }
        public IActionResult Tables()
        {
            TableViewModel model = new TableViewModel();
            model.Title = "Статистика";
            model.listElementClient = _appDBContent.Order.ToList();

            return View(model);
        }
        public IActionResult TablesActive(Filter filter, int page = 1)
        {
            TableActiveViewModel model = new TableActiveViewModel();
            var query = _appDBContent.Order.AsQueryable();
            if(!string.IsNullOrEmpty(filter.Name))
            {
                query = query.Where(x => x.Name.ToLower().Contains(filter.Name.ToLower()) ||
                            x.Surname.ToLower().Contains(filter.Name.ToLower()));
            }
            int pageSize = 10;

            int pageNo = page - 1;
            model.ListActiveElement = query.OrderBy(x => x.Id)
                .Skip(pageNo * pageSize)
                .Take(pageSize)
                .ToList();

            int allCount = query.Count();

            model.Page = page;
            model.MaxPage = (int)Math.Ceiling((double)allCount / pageSize);
            model.Filter = filter;

            return View(model);
        }
        public IActionResult Graph2()
        {
            Graph2ViewModel model = new Graph2ViewModel();
            model.Title = "Статистика коштів";
            List<Order> listOrders = _appDBContent.Order.ToList();
            List<Order> listOrdersTemp = new List<Order>();
            List<OrderDetail> orderDetails = _appDBContent.OrderDetail.ToList();
            List<OrderDetail> orderDetailsTemp = new List<OrderDetail>();
            decimal[] arrMoney = new decimal[12] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            for (int i = 1; i <= 12; i++)
            {
                listOrdersTemp = listOrders.Where(c => c.OrderTime.Month == i).ToList();
                foreach (var item in listOrdersTemp)
                {
                    orderDetailsTemp = orderDetails.Where(p => p.OrderID == item.Id).ToList();
                    foreach (var item2 in orderDetailsTemp)
                    {
                        arrMoney[i - 1] += (decimal)item2.Price;
                    }
                }

            }
            model.listElementMoney = new List<ElementMoney>
            {
                new ElementMoney
                {
                    value =  arrMoney[0].ToString(),
                    label = "Січень"
                },
                new ElementMoney
                {
                    value =  arrMoney[1].ToString(),
                    label = "Лютий"
                },
                new ElementMoney
                {
                    value =  arrMoney[2].ToString(),
                    label = "Березень"
                },
                new ElementMoney
                {
                    value =  arrMoney[3].ToString(),
                    label = "Квітень"
                },new ElementMoney
                {
                    value =  arrMoney[4].ToString(),
                    label = "Травень"
                },new ElementMoney
                {
                    value =  arrMoney[5].ToString(),
                    label = "Червень"
                },new ElementMoney
                {
                    value =  arrMoney[6].ToString(),
                    label = "Липень"
                },new ElementMoney
                {
                    value =  arrMoney[7].ToString(),
                    label = "Серпень"
                },new ElementMoney
                {
                    value =  arrMoney[8].ToString(),
                    label = "Вересень"
                },new ElementMoney
                {
                    value =  arrMoney[9].ToString(),
                    label = "Жовтень"
                },new ElementMoney
                {
                    value =  arrMoney[10].ToString(),
                    label = "Листопад"
                },new ElementMoney
                {
                    value =  arrMoney[11].ToString(),
                    label = "Грудень"
                },
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult SetActive(int id)
        {
            //var element =_appDBContent.UserIsActives.Where(s => s.orderId == id).FirstOrDefault();
            var element =_appDBContent.Order.Where(s => s.Id == id).FirstOrDefault();
            element.IsActive = true;
            _appDBContent.SaveChanges();
            return RedirectToAction("TablesActive");
        }
    }
}
