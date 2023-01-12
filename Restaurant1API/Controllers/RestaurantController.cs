using Microsoft.AspNetCore.Mvc;
using Restaurant1API.Entities;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Restaurant1API.Controllers
{
    [Route("api/restaurant")]
    public class RestaurantController : ControllerBase
    {
        private readonly RestaurantDbContext _dbContext;
       public RestaurantController(RestaurantDbContext dbContext) 
        {
            _dbContext = dbContext;
        }
    public ActionResult<IEnumerable<Restaurant>> GetAll()
        {
            var restaurants = _dbContext
                            .Restaurants
                            .ToList();


            return Ok(restaurants);
        }
    }
}
