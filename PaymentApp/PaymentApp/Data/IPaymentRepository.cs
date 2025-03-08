using PaymentApp.Models;
using System.Collections.Generic;

namespace PaymentApp.Data
{
    public interface IPaymentRepository : IRepository<Payment>
    {
        IEnumerable<Payment> GetRecentPayments(int count);
    }
}