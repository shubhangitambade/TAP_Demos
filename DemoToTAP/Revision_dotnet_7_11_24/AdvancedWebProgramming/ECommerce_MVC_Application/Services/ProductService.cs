using ECommerce_MVC_Application.Models;

namespace ECommerce_MVC_Application.Services
{
    public class ProductService:IProductService
    {
        List<Product> products;  
        

        public ProductService() {

            //Property Intialization
             products = new List<Product>();
            products.Add(new Product { Id = 1, Name = "Laptop", Price = 35000 });
            products.Add(new Product { Id = 2, Name = "Printer", Price = 20000 });
            products.Add(new Product { Id = 3, Name = "HeadPhone", Price = 2000 });
            products.Add(new Product { Id = 4, Name = "Desktop", Price = 9000 });

        }

        public void Delete(int id)
        {
            Product product = products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                products.Remove(product);
            }
           
        }

        public List<Product> GeAll()
        {
            return products;
        }

        public Product GetById(int id)
        {
            Product product = products.FirstOrDefault(p => p.Id == id);
            if(product != null)
            {
                return product;
            }
            return null;
        }

        public void Insert(Product product)
        {
           products.Add(product);
        }

        public void Update(Product product)
        {
            //Product prd = products.FirstOrDefault(product => product.Id == id);

            var existingProduct = products.FirstOrDefault(p => p.Id == product.Id);
            if (existingProduct != null)
            {
                // prd = product;

                products[products.IndexOf(existingProduct)] = product;
            }
        }
    }
}
