using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCRUD.Models;
using BLL;
using BOL;

namespace MVCRUD.Controllers;

public class UserController : Controller
{
    private readonly ILogger<UserController> _logger;

    public UserController(ILogger<UserController> logger)
    {
        _logger = logger;
    }
    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult List()
    {
        List<User> ulist= UserManager.GetAllUsers();
        this.ViewData["uli"]=ulist;
        return View();
    }
     public IActionResult Login()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Login(string user,string pass)
    {
        bool status = UserManager.Validate(user,pass);
        Console.WriteLine("in");
        if(status){
            return this.RedirectToAction("List");
        } 
         return View();
    }

    public IActionResult Insert()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Insert(string user, string pass, string email) {
        // List<User> insertlist = 
        UserManager.InsertData(user,pass,email);
        Console.WriteLine("INnn---11");
        // this.ViewData["ilist"]=insertlist;
        return this.RedirectToAction("List");
        return View();
    }

    public IActionResult Delete()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Delete(string user1)
    {
        UserManager.DeleteData(user1);
        Console.WriteLine("in del");
        return this.RedirectToAction("List");
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
