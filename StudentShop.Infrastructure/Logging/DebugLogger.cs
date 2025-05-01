using StudentShop.Infrastructure.Logging.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentShop.Infrastructure.Logging
{
    public class DebugLogger : ILogger
    {
        public void LogError(Exception exception)
        {
            Debug.WriteLine("ERROR: " + exception.Message);
        }

        public void LogInfo(string message)
        {
            Debug.WriteLine("INFO: " + message);
        }
    }
}
