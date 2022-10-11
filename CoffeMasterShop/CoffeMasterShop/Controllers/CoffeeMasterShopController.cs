using CoffeeMasterShop_DataAccess.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeMasterShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoffeeMasterShopController : ControllerBase
    {
        private static List<CoffeeModel> coffees = new List<CoffeeModel>()
        {
        new CoffeeModel()
                { Id =1,
                  Name = "Latte",
                  CoffeeBeans = "Arabica",
                  SizeCup = CoffeeMasterShop_DataAccess.Enums.SizeCup.Large,
                  ToGoOrNot = false,
                  WithDelivery = false,
                }
        };

        [HttpGet]
        public async Task<ActionResult<List<CoffeeModel>>> Get()
        {
            if (coffees != null)
            {
                return Ok(coffees);
            }

            return BadRequest();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<List<CoffeeModel>>> Get(int id)
        {
            var coffee = coffees.Find(x => x.Id == id);

            if (coffee != null)
                return BadRequest("Coffee not found");

            return Ok(coffee);
        }

        [HttpPost]
        public async Task<ActionResult<List<CoffeeModel>>> AddNewCoffee(CoffeeModel newCoffee)
        {
            coffees.Add(newCoffee);
            return Ok(coffees);
        }
        [HttpPut]
        public async Task<ActionResult<List<CoffeeModel>>> Update(CoffeeModel request)
        {
            var coffee = coffees.Find(x => x.Equals(request.Id));
            if (coffee != null)
                return BadRequest("Coffee not found");

            return Ok(coffees);
        }
    }
}

