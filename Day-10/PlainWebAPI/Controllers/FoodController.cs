using Microsoft.AspNetCore.Mvc;
using BOL;
using BLL;

namespace PlainWebApi.Controller;


[ApiController]
[Route("[controller]")]
public class FoodController : ControllerBase
{ 
    private readonly ILogger<FoodController> _logger;
    public FoodController(ILogger<FoodController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<Food> Get()
    {
        List<Food> food = FoodLogic.GetAllItems();
        return food.ToArray(); 
    }
    // [System.Web.Http.HttpPost]
    // public IHttpActionResult FoodInsert(){
    //     database.
    // }
}

    // [HttpGet("{itemid}")]
    // public Food GetFoodItem(int itmeid){

    // }

