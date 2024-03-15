using BiteBeats.Core.Entities.ViewModel;
using BiteBeats.Core.Interfaces.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BiteBeats.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantController : ControllerBase
    {
        private readonly IRestaurantService _restaurantService;

        public RestaurantController(IRestaurantService restaurantService)
        {
            _restaurantService = restaurantService;
        }

        [HttpPost]
        [Route("AddRestaurant")]
        public async Task<ActionResult> AddRestaurant(UserRestaurantVM userRestaurant)
        {
            var responseModelDto = await _restaurantService.AddRestaurantAsync(userRestaurant);
            return Ok(responseModelDto);

        }
    }
}
