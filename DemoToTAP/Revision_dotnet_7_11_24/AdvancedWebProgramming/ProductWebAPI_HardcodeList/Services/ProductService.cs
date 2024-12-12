using ProductWebAPI_HardcodeList.Model;

namespace ProductWebAPI_HardcodeList.Services
{
    public class ProductService : IProductService
    {
        private List<Product> products;

        public ProductService() { 
        
            products = new List<Product>();

            products.Add(new Product { Id = 1, Name = "Laptop", UnitPrice = 40000, Quantity = 10 });
            products.Add(new Product {Id=2,Name="Dektop",UnitPrice=15000,Quantity=5 });
            products.Add(new Product { Id=3,Name="Printer",UnitPrice=25000,Quantity=5 });
            products.Add(new Product { Id = 4, Name = "HeadPhone", UnitPrice = 2000, Quantity = 15 });
        }

        public void Delete(int id)
        {
            Product product = products.FirstOrDefault(p => p.Id == id); 
            products.Remove(product);
        }

        public Product GetProduct(int id)
        {
            Product product = products.FirstOrDefault(x => x.Id == id );
            return product;
        }

        public List<Product> GetProductList()
        {
            return products;    
        }

        public void Insert(Product product)
        {
            products.Add(product);
        }

        public void Update(Product product)
        {
            Product exsistingProduct = products.FirstOrDefault(x => x.Id==product.Id);
            if(exsistingProduct != null)
            {
                products[products.IndexOf(exsistingProduct)] = product;
            }
        }
    }
}
