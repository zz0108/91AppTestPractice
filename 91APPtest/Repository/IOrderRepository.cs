﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _91APPtest.Repository
{
    public interface IOrderRepository<T> where T : class
    {
        T GetOrderProducts();
    }
}
