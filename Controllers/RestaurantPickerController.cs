using Microsoft.AspNetCore.Mvc;
using MiniChallengeEightToTen___Endpoints.Services.RestaurantPicker;

namespace MiniChallengeEightToTen___Endpoints.Controllers;
[Route("[controller]")]
public class RestaurantPickerController : ControllerBase
{
    private readonly IRestaurantPickerService _restaurantPickerService;

    public RestaurantPickerController(IRestaurantPickerService restaurantPickerService)
    {
        _restaurantPickerService = restaurantPickerService;
    }

    [HttpGet]
    [Route("restaurantpicker/{num}")]
    public string Category(string num) {
        return _restaurantPickerService.Category(num);
    }
}