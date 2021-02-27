using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SovaProject.ViewModels
{
    public class Graph2ViewModel
    {        public string Title { get; set; }
        public List<ElementMoney> listElementMoney { get; set; }
    }
    public class ElementMoney
    {
        public string value { get; set; }
        public string label { get; set; }
    }
}
