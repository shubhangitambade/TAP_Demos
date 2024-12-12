using ProductWebAPI_HardcodeList.Model;

namespace ProductWebAPI_HardcodeList.Services
{
    public interface IProductService
    {
        List<Product> GetProductList();
        Product GetProduct(int id);
        void Insert(Product product);
        void Update(Product product);
        void Delete(int id);


    }
}
