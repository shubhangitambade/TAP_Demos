using Product_MVC_HardcodeList.Models;

namespace Product_MVC_HardcodeList.Services
{
    public interface IProductService
    {
        List<Product> GetAll();

        Product GetById(int id);

        void Insert (Product product);
        void Update (Product product);
        void Delete (int id);

    }
}
