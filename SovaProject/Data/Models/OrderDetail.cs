﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SovaProject.Data.Models
{
    public class OrderDetail
    {
        public int id { get; set; }
        public int orderID { get; set; }
        public int TarufID { get; set; }
        public uint price { get; set; }
        public virtual Taruf taruf { get; set; }
        public virtual Order order { get; set; }
    }
}
