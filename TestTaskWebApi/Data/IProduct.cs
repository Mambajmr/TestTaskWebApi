using System.Collections.Generic;
using TestTaskWebApi.Models;

namespace TestTaskWebApi.Data
{
    public interface IProduct
    {
        IEnumerable<Product> GetAllProduct();
        Product GetProductById(int id);
    }
}
