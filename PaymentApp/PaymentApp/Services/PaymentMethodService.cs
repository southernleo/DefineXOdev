using System.Collections.Generic;
using System.Linq;

namespace PaymentApp.Services
{
    public class PaymentMethodService : IPaymentMethodService
    {
        private readonly List<string> _paymentMethods;

        public PaymentMethodService()
        {
            _paymentMethods = new List<string>
            {
                 "Kredi Kartı", "Banka Kartı", "Havale/EFT",
                 "PayPal", "Bitcoin", "Ethereum",
                 "Apple Pay", "Papara", "Ininal"
            };
        }

        public IEnumerable<string> GetAvailablePaymentMethods()
        {
            return _paymentMethods;
        }

        public bool AddPaymentMethod(string method)
        {
            if (string.IsNullOrWhiteSpace(method) || _paymentMethods.Contains(method))
            {
                return false;
            }

            _paymentMethods.Add(method);
            return true;
        }
    }
}