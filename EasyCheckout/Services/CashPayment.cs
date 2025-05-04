using EasyCheckout.Interfaces;

namespace EasyCheckout.Services
{
    internal class CashPayment : IPaymentMethod
    {
        public string Name => "Contant";

        public string ProcessPayment(decimal amount)
        {
            return $"{amount:c} contant betaald. Vergeet het wisselgeld niet!";
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
