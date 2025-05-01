using StudentShop.Domain.Base;
using StudentShop.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentShop.Domain
{
    public class ProductLine : OrderLine, ICanPrint, IHasPrice
    {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice => Quantity * UnitPrice;

        internal ProductLine(string productName, decimal unitPrice, int quantity)
        {
            this.ProductName = productName;
            this.UnitPrice = unitPrice;
            this.Quantity = quantity;
        }

        public override string Print()
        {
            return this.ProductName.PadRight(22) + this.TotalPrice.ToString("C").PadLeft(7);
        }
    }
}
