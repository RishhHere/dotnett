using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProductApp.Models;
using BOL;
using BLL;

namespace ProductApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Product()
    {
        ProductManager mgr = new ProductManager();
        List<Product> p = new List<Product>();
        p = mgr.GetAllProducts();
        this.ViewData["products"] = p;
        return View();
    }

      public IActionResult ProductById()
    {
        Console.WriteLine("Enter Id:");
        int id=int.Parse(Console.ReadLine());
        ProductManager mgr = new ProductManager();
        List<Product> p = new List<Product>();
        p = mgr.GetProductsById(id);
        this.ViewData["products"] = p;
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
