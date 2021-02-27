using SovaProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SovaProject.ViewModels
{
    public class TarufsListViewModel
    {
        public IEnumerable<Taruf> allTarufs { get; set; }
        public string currCategory { get; set; }
    }
}
