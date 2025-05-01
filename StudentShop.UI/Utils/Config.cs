using StudentShop.Application.Services.Payments;
using StudentShop.Application.Services.Payments.Interfaces;
using StudentShop.Infrastructure.Logging;
using StudentShop.Infrastructure.Logging.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentShop.UI.Utils
{
    internal static class Config
    {
        internal static ILogger DefaultLogger => new DebugLogger();
    }
}
