﻿using SovaProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SovaProject.Data.interfeces
{
    public interface IAllOrders
    {
        void createOrder(Order order);
    }
}
