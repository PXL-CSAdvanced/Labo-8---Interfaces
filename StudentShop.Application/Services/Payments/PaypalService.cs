using StudentShop.Application.Services.Payments.Interfaces;
using System.Diagnostics;

namespace StudentShop.Application.Services.Payments
{
    public class PaypalService : IPaymentMethod
    {
        public void ProcessPayment(decimal amount)
        {
            Debug.WriteLine("Paypal payment processed succesfully.");
        }
    }
}
