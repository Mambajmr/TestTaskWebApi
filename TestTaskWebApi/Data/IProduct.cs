using System.Collections.Generic;
using TestTaskWebApi.Models;

namespace TestTaskWebApi.Data
{
    public interface IProduct
    {
        //интерфейс для реализации и внедрения зависимостей
        bool SaveChanges();
        IEnumerable<Product> GetAllProduct();
        Product GetProductById(int id);
        void CreateProduct(Product cmd);
        void UpdateProduct(Product cmd);
        void DeleteProduct(Product cmd);
    }
}
