using StudentShop.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentShop.Domain
{
    public class ExpressOrder : Order
    {
        public ExpressOrder() : base() 
        { 
            base.DeliveryDate = base.OrderDate.AddDays(1);
        }
    }
}
