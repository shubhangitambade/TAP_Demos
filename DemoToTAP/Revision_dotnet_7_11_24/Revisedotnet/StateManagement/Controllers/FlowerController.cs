using Microsoft.AspNetCore.Mvc;
using StateManagement.Services;

namespace StateManagement.Controllers
{
    public class FlowerController : Controller
    {
        private readonly IFlowerService _flowerService;
        public FlowerController(IFlowerService flowerService)
        {
            _flowerService = flowerService;
        }
        public IActionResult Index()
        {
            var itemsSold = _flowerService.GetAll();
            return View(itemsSold);
        }
    }
}
