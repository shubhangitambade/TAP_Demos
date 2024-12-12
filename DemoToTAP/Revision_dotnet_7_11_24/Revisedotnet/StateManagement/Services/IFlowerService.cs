using StateManagement.Models;

namespace StateManagement.Services
{
    public interface IFlowerService
    {
        public List<Flower> GetAll();

        public Flower GetById(int id);
        public List<Flower> GetAllSold();

    }
}
