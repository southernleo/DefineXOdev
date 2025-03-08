using System;

namespace PaymentApp.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public string PaymentMethod { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
    }
}