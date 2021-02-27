using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SovaProject.ViewModels
{
    public class Graph1ViewModel
    {
        public string Title { get; set; }
        public List<Element> listElement { get; set; }
    }
    public class Element
    {
        public string value { get; set; }
        public string label { get; set; }
    }
}
