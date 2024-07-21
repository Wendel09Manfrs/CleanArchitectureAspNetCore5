using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CleanArchi.Domain.Entities;

namespace CleanArchi.Domain.Interfaces
{
    public interface IProductRepository
    {

        Task<IEnumerable<Product>> GetProducts();
        Task<Product> GetById(int? id);

        void Add(Product product);
        void Update(Product product);   
        void Remove(Product product);
    }
}
