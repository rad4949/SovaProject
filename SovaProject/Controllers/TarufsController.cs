using Microsoft.AspNetCore.Mvc;
using SovaProject.Data.interfeces;
using SovaProject.Data.Models;
using SovaProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SovaProject.Controllers
{
    public class TarufsController : Controller
    {
        private readonly IAllTarufs _allTarufs;
        private readonly ITarufsCategory _allCategories;

        public TarufsController(IAllTarufs iAllTarufs, ITarufsCategory iTarufsCat)
        {
            _allTarufs = iAllTarufs;
            _allCategories = iTarufsCat;
        }

        [Route("Tarufs/List")]
        [Route("Tarufs/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Taruf> tarufs = null;
            string currCategory = "";
            if (string.IsNullOrEmpty(category))
            {
                tarufs = _allTarufs.Tarufs.OrderBy(i => i.Id);
            }
            else
            {
                if (string.Equals("Sarny", category, StringComparison.OrdinalIgnoreCase))
                {
                    tarufs = _allTarufs.Tarufs.Where(i => i.Category.CategoryName.Equals("Сарни")).OrderBy(i => i.Id);
                    currCategory = "Сарни";
                }
                if (string.Equals("Klesiv", category, StringComparison.OrdinalIgnoreCase))
                {
                    tarufs = _allTarufs.Tarufs.Where(i => i.Category.CategoryName.Equals("Клесів")).OrderBy(i => i.Id);
                    currCategory = "Клесів";
                }
                if (string.Equals("ExperimentalStation", category, StringComparison.OrdinalIgnoreCase))
                {
                    tarufs = _allTarufs.Tarufs.Where(i => i.Category.CategoryName.Equals("Дослідна станція")).OrderBy(i => i.Id);
                    currCategory = "Дослідна станція";
                }
                if (string.Equals("Karpylivka", category, StringComparison.OrdinalIgnoreCase))
                {
                    tarufs = _allTarufs.Tarufs.Where(i => i.Category.CategoryName.Equals("Карпилівка")).OrderBy(i => i.Id);
                    currCategory = "Карпилівка";
                }
            }
            var tarufObj = new TarufsListViewModel
            {
                allTarufs = tarufs,
                currCategory = currCategory
            };

            ViewBag.Title = "Сторінка з тарифами";
            return View(tarufObj);
        }
    }
}
