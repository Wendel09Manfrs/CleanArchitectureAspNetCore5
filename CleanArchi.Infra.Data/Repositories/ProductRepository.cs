using CleanArchi.Domain.Entities;
using CleanArchi.Domain.Interfaces;
using CleanArchi.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchi.Infra.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            return  await _context.Products.ToListAsync();
        }

        public async Task<Product> GetById(int? id)
        {
            return await _context.Products.FindAsync(id);
        }

        public void Add(Product product)
        {
            _context.Add(product);
            _context.SaveChanges();
        }

        public void Update(Product product) {
            _context.Update(product);
            _context.SaveChanges();
        }


        public void Remove(Product product)
        {
            _context.Remove(product);
            _context.SaveChanges();
        }



    }
}
