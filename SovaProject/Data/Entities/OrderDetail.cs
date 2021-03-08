using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SovaProject.Data.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int OrderID { get; set; }
        public int TarufID { get; set; }
        public uint Price { get; set; }
        public virtual Taruf Taruf { get; set; }
        public virtual Order Order { get; set; }
    }
}
