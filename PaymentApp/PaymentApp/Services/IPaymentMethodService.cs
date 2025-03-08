using System.Collections.Generic;

namespace PaymentApp.Services
{
    public interface IPaymentMethodService
    {
        IEnumerable<string> GetAvailablePaymentMethods();
        bool AddPaymentMethod(string method);
    }
}