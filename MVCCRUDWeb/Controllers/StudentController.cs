using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCCRUDWeb.Models;
using BLL;
using BOL;

namespace MVCCRUDWeb.Controllers;

public class StudentController : Controller
{
    private readonly ILogger<StudentController> _logger;

    public StudentController(ILogger<StudentController> logger)
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
    public IActionResult List()
    {
        List<Student> studentList = StudentManager.GetAllStudent();
        Console.WriteLine("In List");
        ViewData["slist"] = studentList;
        return View();
    }
    public IActionResult Insert()
    {
        // return this.RedirectToAction("Insert");
        return View();
    }

    [HttpPost]
    public IActionResult Insert(int id, string name, string password, string city){
        StudentManager.InsertStudent(id,name,password,city);
        return RedirectToAction("List");
        return View();
    }  

    public IActionResult Delete(){
        return View();
    }
    [HttpPost]
    public IActionResult Delete(int id){
        StudentManager.DeleteStudent(id);
        return RedirectToAction("List");
        return View();
    }
    public IActionResult UpdateID(){
        return View();
    }
    public IActionResult Update(){
        return View();
    }
    [HttpPost]
    public IActionResult Update(int id, string name, string pass, string city){
        StudentManager.UpdateStudent(id,name,pass, city);
        // Console.WriteLine("In Update");
        return RedirectToAction("List");
        return View();
    }
    public IActionResult ParticularView(int id){
        List<Student> stlist = StudentManager.GetAllStudent();
        var s = stlist.Find((e)=>e.id==id);
        return View(s);
    }
    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
