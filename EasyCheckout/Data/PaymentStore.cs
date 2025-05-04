using EasyCheckout.Interfaces;
using EasyCheckout.Services;

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
