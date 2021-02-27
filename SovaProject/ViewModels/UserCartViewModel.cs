using SovaProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SovaProject.ViewModels
{
    public class UserCartViewModel
    {
        public List<UserCart1ViewModel> userCart { get; set; }
    }
    public class NewUserCartViewModel
    {
        public UserCart userCart { get; set; }
    }

    public class UserCart1ViewModel
    {
        public string name { get; set; }
        public uint price { get; set; }
    }
}
