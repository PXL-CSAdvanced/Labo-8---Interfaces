using StudentShop.Application.Services.Base;
using StudentShop.Application.Services.Payments.Interfaces;
using StudentShop.Infrastructure.Logging.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentShop.Application.Services
{
    internal class OrderService : Service
    {
        private IPaymentMethod _payment;

        public OrderService(ILogger logger, IPaymentMethod payment) : base(logger)
        {
            _payment = payment;
        }
    }
}
