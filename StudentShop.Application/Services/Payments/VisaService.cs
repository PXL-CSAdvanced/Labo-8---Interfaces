using StudentShop.Application.Services.Payments.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentShop.Application.Services.Payments
{
    public class VisaService : IPaymentMethod
    {
        public void ProcessPayment(decimal amount)
        {
            Debug.WriteLine("Visa payment processed succesfully.");
        }
    }
}
