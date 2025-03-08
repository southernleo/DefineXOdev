using System.Collections.Generic;

namespace PaymentApp.Data
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        
        void Add(T entity);
      
        void SaveChanges();
    }
}