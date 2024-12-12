using Product_MVC_Project.Models;

namespace Product_MVC_Project.Services
{
    public class ProductService:IProductService
    {
        private List<Product> products;
        public ProductService() {
        
            products = new List<Product>();
            products.Add(new Product { Id = 1, Name = "Laptop", Price = 40000 });
            products.Add(new Product { Id = 2, Name = "Printer", Price = 24000 });
            products.Add(new Product { Id = 3, Name = "Desktop", Price = 29000 });
            products.Add(new Product { Id = 4, Name = "Mobile", Price = 90000 });
            products.Add(new Product { Id = 5, Name = "HeadPhone", Price = 2000 });
        }

        public async Task<List<Product>> GetAll()
        {
            return products;    
        }
        public async Task<Product> GetById(int id)
        {
            Product product = products.FirstOrDefault(x => x.Id == id);
            return product;
        }
        public async Task<Product> GetByName(string name)
        {
            Product product = products.FirstOrDefault(x => x.Name == name);
            return product;
        }

        public async Task Remove(int id)
        {
            Product product = products.FirstOrDefault(x => x.Id == id);
            if(product != null)
            {
                products.Remove(product);
            }
        }
        public async Task Insert(Product product)
        {
            products.Add(product);
        }
        public async Task Update(Product product)
        {
            Product existingProduct = products.FirstOrDefault(x=> x.Id == product.Id);
            if(existingProduct != null) {

                products[products.IndexOf(existingProduct)] = product;
            }
        }
    }
}
