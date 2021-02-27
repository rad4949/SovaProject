using SovaProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SovaProject.ViewModels
{
    public class TableActiveViewModel
    {
        public List<ElementActive> listActiveElement { get; set; }
    }
    public class ElementActive
    {
        public bool IsActive { get; set; }
        public Order order { get; set; }
    }
}
