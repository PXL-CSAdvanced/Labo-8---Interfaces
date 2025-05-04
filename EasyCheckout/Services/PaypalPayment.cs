using EasyCheckout.Interfaces;

namespace EasyCheckout.Services
{
    internal class PaypalPayment : IPaymentMethod
    {
        public string Name => "PayPal";

        public string ProcessPayment(decimal amount)
        {
            return $"{amount:c} betaald via PayPal. Bevestiging per e-mail verzonden.";
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
