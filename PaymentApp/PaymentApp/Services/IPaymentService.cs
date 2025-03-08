using PaymentApp.Models;
using System.Collections.Generic;

namespace PaymentApp.Services
{
    public interface IPaymentService
    {
        IEnumerable<Payment> GetAllPayments();
        bool ProcessPayment(string paymentMethod, decimal amount);
    }
}