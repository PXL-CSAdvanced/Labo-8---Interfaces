using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentShop.Domain.Base
{
    public abstract class OrderLine 
    {
        public int Id { get; set; }
        public int LineNumber { get; set; }

        public abstract string Print();
    }
}
