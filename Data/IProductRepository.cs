using Furlong_UnitTest.Models;

namespace Furlong_UnitTest.Data
{
    public interface IProductRepository
    {

        List<Product> GetProducts();

        void CreateProduct(Product product);



    }
}
