using StudentShop.Application.Services.Base;
using StudentShop.Infrastructure.Logging.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentShop.Application.Services
{
    public class ProductService : Service
    {
        public ProductService(ILogger logger) : base(logger)
        { 

        }
    }
}
