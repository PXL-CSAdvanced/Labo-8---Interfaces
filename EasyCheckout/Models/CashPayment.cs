using EasyCheckout.Interfaces;

namespace EasyCheckout.Models
{
    internal class CashPayment : IPaymentMethod
    {
        public string Name => "Contant";

        public string ProcessPayment(decimal amount)
        {
            return $"{amount:c} contant betaald. Vergeet het wisselgeld niet!";
        }
    }
}
