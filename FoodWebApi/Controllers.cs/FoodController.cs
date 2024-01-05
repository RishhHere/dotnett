namespace WebApp.Controller;
using Microsoft.AspNetCore.Mvc;
using BOL;
using BLL;

[ApiController]
[Route("[controller]")]

public class FoodController:ControllerBase{
    private readonly ILogger<FoodController> _logger;
    public FoodController(ILogger<FoodController> logger)
    {
        _logger = logger;
    }
    [HttpGet]
    public IEnumerable<Food> Get(){
        List<Food> foodlist = FoodManager.GetAllItems();
        return foodlist.ToArray();
    }
}