using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentShop.Domain.Interfaces
{
    internal interface IHasPrice
    {
        decimal TotalPrice { get; }
    }
}
