using EasyCheckout.Entities;
using EasyCheckout.Interfaces;
using System.Diagnostics;
using System.IO;

namespace EasyCheckout.Logging
{
    internal class FileProductLogger : IProductLogger
    {
        private const string _filename = "productlog.csv";
        public void Write(Product product)
        {
            File.AppendAllText(_filename, $"{DateTime.Now};{product.Id};{product.Name}");
        }
    }
}
