using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCheckout.Interfaces
{

    public interface IPaymentMethod
    {
        string Name { get; }
        string ProcessPayment(decimal amount);
    }

}
