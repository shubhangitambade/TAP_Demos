using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DotnetCoreWebAPI.Services;
using DotnetCoreWebAPI.Model;


//That’s it! You’ve created a complete .NET 8 Web API for CRUD operations with an In-memory database.
//You can now integrate this API into your front-end application.
namespace DotnetCoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OurHerosController : ControllerBase
    {
        private readonly IOurHeroService _heroService;
        public OurHerosController(IOurHeroService heroService)
        {
            _heroService = heroService;
        }

        [HttpGet]
        public IActionResult Get([FromQuery] bool? isActive = null)
        {
            return Ok(_heroService.GetAllHeros(isActive));
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {

            var hero = _heroService.GetHerosByID(id);
            if (hero == null)
            {
                return NotFound();
            }
            return Ok(hero);
        }

        [HttpPost]

        public IActionResult Post(AddUpdateOurHero heroObj)
        {
            var hero = _heroService.AddOurHero(heroObj);

            if (hero == null)
            {
                return BadRequest();
            }

            return Ok(new
            {
                message = "Super Hero Created Successfully!!",

                id = hero!.Id
            });
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Put([FromRoute] int id, [FromBody] AddUpdateOurHero heroObject) {

            var hero = _heroService.GetHerosByID(id);

            if(hero == null)
            {
                return NotFound();
            }
            return Ok(new
            {
                message="Super hero Updated Successfully!!",
                id = hero!.Id
            });
            
        }

        [HttpDelete]
        [Route("{id}")]

        public IActionResult Delete([FromRoute] int id)
        {
            if(! _heroService.DeleteHerosByID(id))
            {
                return NotFound();
            }

            return Ok(new
            {
                message = "Super hero Updated Successfully!!",
                id=id
            });

        }

    }
}


/*
    
1.HttpGet. it makes this method a GET method

2.IActionResult: It represents a return type to the action method.
3.[FromQuery]: indicate getting this value from API Query String
4._heroService.GetAllHeros(isActive): get all OurHero data from OurHeroService
5.Ok(object): sending data with 200 status codes.

 */