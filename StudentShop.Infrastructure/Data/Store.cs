using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentShop.Infrastructure.Data
{
    public class Store<T>
    {
        public List<T> data = new List<T>();
    }
}
