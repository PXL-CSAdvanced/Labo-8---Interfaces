using StudentShop.Infrastructure.Logging.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentShop.Application.Services.Base
{
    public abstract class Service
    {
        protected ILogger _logger;

        protected Service(ILogger logger) 
        { 
            _logger = logger;
        }
    }
}
