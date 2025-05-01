using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentShop.Infrastructure.Logging.Interfaces
{
    public interface ILogger
    {
        void LogInfo(string message);
        void LogError(Exception exception);
    }
}
