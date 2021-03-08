using SovaProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SovaProject.ViewModels
{
    public class TableActiveViewModel
    {
        public int Page { get; set; }
        public int MaxPage { get; set; }
        public Filter Filter { get; set; }
        public List<Order> ListActiveElement { get; set; }
    }
    public class Filter
    {
        public string Name { get; set; }
    }

   
}
