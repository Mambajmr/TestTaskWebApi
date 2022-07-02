using System;
using System.Collections.Generic;
using System.Linq;
using TestTaskWebApi.Models;

namespace TestTaskWebApi.Data
{
    public class SqlProductRepo : IProduct
    {
        private readonly ProductContext _context;

        public SqlProductRepo(ProductContext context)
        {
            _context = context;
        }

        public void CreateProduct(Product cmd)
        {
            if (cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }

            _context.Products.Add(cmd);
        }

        public void DeleteProduct(Product cmd)
        {
            if (cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }
            _context.Products.Remove(cmd);
        }

        public IEnumerable<Product> GetAllProduct()
        {
            return _context.Products.ToList();
        }

        public Product GetProductById(int id)
        {
            return _context.Products.FirstOrDefault(p => p.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateProduct(Product cmd)
        {
            //Nothing(без реализации)
        }
    }
}
