using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HRPortal.Models;
using DAL;

namespace HRPortal.Controllers;

public class FormController : Controller
{
    private readonly ILogger<FormController> _logger;

    public FormController(ILogger<FormController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Login(){

        return View();
    }

    [HttpPost]
    public IActionResult Login(string username,string password)
    {
        Console.WriteLine(username + " "+ password);
         if(username == "chitra" && password== "chitra"){
            System.Console.WriteLine("In IF condition");
            return this.RedirectToAction("Emp"); 
            //return RedirectToAction("LogIn", "Account", new { area = "" });
         } else {
            // System.Console.WriteLine("In ELSE condition");
            return RedirectToAction("Register");
         }
        return View();
    }

    public IActionResult Emp(){
        List<Employee> emp = EmpDB.GetAllEmp();
        this.ViewData["emp"] = emp;
        return View();
    }


    public IActionResult Register()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
