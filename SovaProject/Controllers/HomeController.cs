using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SovaProject.Data.interfeces;
using SovaProject.Models;
using SovaProject.ViewModels;

namespace SovaProject.Controllers
{
    public class HomeController : Controller
    {
        private IAllTarufs _tarufRep;

        public HomeController(IAllTarufs tarufPep)
        {
            _tarufRep = tarufPep;
        }

        public ViewResult index()
        {
            var homeTarufs = new HomeViewModel {
                favTarufs=_tarufRep.getFavTarufs
            };

            return View(homeTarufs);
        }
    }
}
