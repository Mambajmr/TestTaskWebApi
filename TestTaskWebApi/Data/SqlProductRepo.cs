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
        public IEnumerable<Product> GetAllProduct()
        {
            return _context.Products.ToList();
        }

        public Product GetProductById(int id)
        {
            return _context.Products.FirstOrDefault(p => p.Id == id);
        }
    }
}
