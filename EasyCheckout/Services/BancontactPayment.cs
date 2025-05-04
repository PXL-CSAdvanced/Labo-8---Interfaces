using EasyCheckout.Interfaces;

namespace EasyCheckout.Services
{
    internal class BancontactPayment : IPaymentMethod
    {
        public string Name => "Bancontact";

        public string ProcessPayment(decimal amount)
        {
            return $"{amount:c} betaald met Bancontact. Verwerking succesvol.";
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
