using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SovaProject.Data.Models
{
    public class UserIsActive
    {
        public int id { get; set; }
        public int orderId { get; set; }
        public bool IsActive { get; set; }
    }
}
