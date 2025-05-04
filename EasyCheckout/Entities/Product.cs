using EasyCheckout.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCheckout.Entities
{
    public sealed class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return this.Name.PadRight(40) + this.Price.ToString("C").PadLeft(10);
        }
    }
}
