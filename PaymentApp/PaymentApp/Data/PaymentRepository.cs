using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PaymentApp.Models;

namespace PaymentApp.Data
{
    public class PaymentRepository : IPaymentRepository
    {
        private readonly ApplicationDbContext _context;

        public PaymentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Payment> GetAll()
        {
            return _context.Payments.ToList();
        }

    

        public void Add(Payment entity)
        {
            _context.Payments.Add(entity);
        }

      

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public IEnumerable<Payment> GetRecentPayments(int count)
        {
            return _context.Payments
                .OrderByDescending(p => p.PaymentDate)
                .Take(count)
                .ToList();
        }
    }
}