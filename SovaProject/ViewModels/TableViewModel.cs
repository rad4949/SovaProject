using SovaProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SovaProject.ViewModels
{
    public class TableViewModel
    {
        public string Title { get; set; }
        //public List<ElementClient> listElementClient { get; set; }
        public List<Order> listElementClient { get; set; }
    }
    //public class ElementClient
    //{
    //    public int id { get; set; }
    //    public string name { get; set; }
    //    public string surname { get; set; }
    //    public string adress { get; set; }
    //    public string phone { get; set; }
    //    public DateTime orderTime { get; set; }
    //}
}
