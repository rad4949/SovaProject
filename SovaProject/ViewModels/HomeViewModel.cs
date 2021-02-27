using SovaProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SovaProject.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Taruf> favTarufs { get; set; }
    }
}
