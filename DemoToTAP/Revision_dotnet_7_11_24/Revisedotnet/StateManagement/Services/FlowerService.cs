using StateManagement.Models;

namespace StateManagement.Services
{
    public class FlowerService : IFlowerService
    {
       

        public List<Flower> GetAll()
        {
            //Property INtializer List
            List<Flower> flowers = new List<Flower>()
            {
                 new Flower()
                {
                    Id= 14,
                    Name = "Summer Breeze Flower Box",
                    SalePrice = 4.99M,
                    UnitPrice = 1.69M,
                    Quantity = 43
                },
                 new Flower()
                {
                    Id= 3,
                    Name = "Yellow Mellow Sunshine Bouquet",
                    SalePrice = 4.89M,
                    UnitPrice = 1.13M,
                    Quantity = 319
                },
                new Flower()
                {
                    Id= 18,
                    Name = "Sunshine Floral Ecstasy",
                    SalePrice = 5.69M,
                    UnitPrice = 0.47M,
                    Quantity = 319
                },
                new Flower()
                {
                    Id= 19,
                    Name = "Red Rose Beautiful Bunch",
                    SalePrice = 6.19M,
                    UnitPrice = 0.59M,
                    Quantity = 252
                },
                new Flower()
                {
                    Id= 1,
                    Name = "Dreamy Hues",
                    SalePrice = 5.59M,
                    UnitPrice = 1.12M,
                    Quantity = 217
                }
            };

            return flowers;
        }

        public List<Flower> GetAllSold()
        {
            List<Flower> items = new List<Flower>()
            {
                new Flower()
                {
                    Id= 14,
                    Name = "Summer Breeze Flower Box",
                    SalePrice = 4.99M,
                    UnitPrice = 1.69M,
                    Quantity = 43
                },
                new Flower()
                {
                    Id= 3,
                    Name = "Yellow Mellow Sunshine Bouquet",
                    SalePrice = 4.89M,
                    UnitPrice = 1.13M,
                    Quantity = 319
                },
                new Flower()
                {
                    Id= 18,
                    Name = "Sunshine Floral Ecstasy",
                    SalePrice = 5.69M,
                    UnitPrice = 0.47M,
                    Quantity = 319
                },
                new Flower()
                {
                    Id= 19,
                    Name = "Red Rose Beautiful Bunch",
                    SalePrice = 6.19M,
                    UnitPrice = 0.59M,
                    Quantity = 252
                },
                new Flower()
                {
                    Id= 1,
                    Name = "Dreamy Hues",
                    SalePrice = 5.59M,
                    UnitPrice = 1.12M,
                    Quantity = 217
                }
            };
            return items;

        }

        public Flower GetById(int id)
        {
            List<Flower> flowers = GetAll();
            Flower flower = flowers.FirstOrDefault(x => x.Id == id);

            return flower;
        }
    }
}
