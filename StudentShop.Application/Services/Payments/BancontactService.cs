using StudentShop.Application.Services.Payments.Interfaces;
using System.Diagnostics;

namespace StudentShop.Application.Services.Payments
{
    public class BancontactService : IPaymentMethod
    {
        public void ProcessPayment(decimal amount)
        {
            Debug.WriteLine("Process payment processed succesfully.");
        }
    }
}
