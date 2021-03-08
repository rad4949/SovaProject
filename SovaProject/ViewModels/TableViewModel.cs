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
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public string Surname { get; set; }
    //    public string Adress { get; set; }
    //    public string Phone { get; set; }
    //    public DateTime OrderTime { get; set; }
    //}
}
