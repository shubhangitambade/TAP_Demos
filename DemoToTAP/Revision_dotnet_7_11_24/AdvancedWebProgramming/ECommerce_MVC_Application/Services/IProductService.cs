using ECommerce_MVC_Application.Models;

namespace ECommerce_MVC_Application.Services
{
    public interface IProductService
    {
        List<Product> GeAll();
        Product GetById(int id);
        void Insert(Product product);

        void Update(Product product);   

        void Delete(int id);

    }
}
