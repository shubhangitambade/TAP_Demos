using Product_MVC_Project.Models;

namespace Product_MVC_Project.Services
{
    public interface IProductService
    {
        Task <List<Product>> GetAll();
        Task<Product> GetById(int id);
        Task<Product> GetByName(string name);

        Task Remove(int id);
        Task Insert(Product product);
        Task Update(Product product);   

    }
}
