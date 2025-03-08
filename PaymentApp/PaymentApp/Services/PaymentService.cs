using PaymentApp.Data;
using PaymentApp.Models;
using System;
using System.Collections.Generic;

namespace PaymentApp.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly IPaymentRepository _paymentRepository;

        public PaymentService(IPaymentRepository paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }

        public IEnumerable<Payment> GetAllPayments()
        {
            return _paymentRepository.GetAll();
        }

        public bool ProcessPayment(string paymentMethod, decimal amount)
        {
            if (string.IsNullOrWhiteSpace(paymentMethod) || amount <= 0)
            {
                return false;
            }

            var payment = new Payment
            {
                PaymentMethod = paymentMethod,
                Amount = amount,
                PaymentDate = DateTime.Now
            };

            _paymentRepository.Add(payment);
            _paymentRepository.SaveChanges();

            return true;
        }
    }
}