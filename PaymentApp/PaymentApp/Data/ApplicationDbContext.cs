using Microsoft.EntityFrameworkCore;
using PaymentApp.Models;
using System.Collections.Generic;

namespace PaymentApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Payment> Payments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-JKVPU8D\\SQLEXPRESS;Initial Catalog=payment;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
    }
}