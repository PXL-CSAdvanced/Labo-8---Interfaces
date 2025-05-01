using EasyCheckout.Interfaces;
using EasyCheckout.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCheckout.Data
{
    internal class PaymentStore
    {
        public IReadOnlyList<IPaymentMethod> GetAvailablePaymentMethods()
        {
            return new List<IPaymentMethod>
            {
                new BancontactPayment(),
                new CashPayment(),
                new PaypalPayment()

            };
        }
    }
}
