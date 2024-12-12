using Product_MVC_HardcodeList.Models;

namespace Product_MVC_HardcodeList.Services
{
    public class ProductService : IProductService
    {
        private List<Product> products;
        public ProductService() {
        
            products = new List<Product>();
            products.Add(new Product { Id = 1, Name = "Laptop", UnitPrice = 40000, Quantity = 10 });
            products.Add(new Product { Id = 2, Name = "Desktop", UnitPrice = 10000, Quantity = 5 });
            products.Add(new Product { Id = 3, Name = "Printer", UnitPrice = 20000, Quantity = 9 });
            products.Add(new Product { Id = 4, Name = "Headphone", UnitPrice = 2000, Quantity = 15 });
            
        }
        public void Delete(int id)
        {
            Product product = products.FirstOrDefault(x => x.Id == id);
            if(product != null)
            {
                products.Remove(product);
            }
            
        }

        public List<Product> GetAll()
        {
            return products;
        }

        public Product GetById(int id)
        {
            Product product = products.FirstOrDefault(x => x.Id == id);
            return product;
        }

        public void Insert(Product product)
        {
            products.Add(product);
        }

        public void Update(Product product)
        {
            Product prd = products.FirstOrDefault(x => x.Id == product.Id);
            if (prd != null)
            {
                products[products.IndexOf(prd)] = product;
            }
        }
    }
}
