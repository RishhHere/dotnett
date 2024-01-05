using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FirstWebApp.Models;
using Catalogue;

namespace FirstWebApp.Controllers;

public class ProductsController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public ProductsController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Products()
    {
        Product p = new Product();
        p.title = "Sunflower";
        p.price = 150;
        p.imgurl = "/images/download.jpeg";
        p.quantity=1313;

        ViewData["flower"]=p;
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
