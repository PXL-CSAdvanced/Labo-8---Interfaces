using EasyCheckout.Interfaces;

namespace EasyCheckout.Models
{
    internal class PaypalPayment : IPaymentMethod
    {
        public string Name => "PayPal";

        public string ProcessPayment(decimal amount)
        {
            return $"{amount:c} betaald via PayPal. Bevestiging per e-mail verzonden.";
        }
    }
}
