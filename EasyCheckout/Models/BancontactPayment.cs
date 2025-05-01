using EasyCheckout.Interfaces;

namespace EasyCheckout.Models
{
    internal class BancontactPayment : IPaymentMethod
    {
        public string Name => "Bancontact";

        public string ProcessPayment(decimal amount)
        {
            return $"{amount:c} betaald met Bancontact. Verwerking succesvol.";
        }
    }
}
