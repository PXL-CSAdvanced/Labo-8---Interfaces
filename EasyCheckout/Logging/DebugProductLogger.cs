using EasyCheckout.Entities;
using EasyCheckout.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCheckout.Logging
{
    internal class DebugProductLogger : IProductLogger
    {
        public void Write(Product product)
        {
            Debug.WriteLine($"{product.Name}");
        }
    }
}
