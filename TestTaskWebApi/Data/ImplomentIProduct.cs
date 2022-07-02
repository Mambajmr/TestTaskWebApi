using System.Collections.Generic;
using TestTaskWebApi.Models;

namespace TestTaskWebApi.Data
{
    public class ImplomentIProduct : IProduct
    {
        public IEnumerable<Product> GetAllProduct()
        {
            List<Product> products = new List<Product>
            {
                new Product{ Id=1, Name = "Apple", Category = "Fruits", Description = "Green Apple" },
                new Product{ Id=2, Name = "Meat", Category = "Meat", Description = "Chicken meat" },
                new Product{ Id=3, Name = "OrangeJuice", Category = "Drinks", Description = "Fresh orange juice" }
            };
            return products;
        }

        public Product GetProductById(int id)
        {
            return new Product{ Id=0, Name = "Apple", Category = "Fruits", Description = "Green Apple" };
        }
    }
}
