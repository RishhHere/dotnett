using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HRPortal.Models;
using DAL;

// using Microsoft.Extensions.Logging;


namespace HRPortal.Controllers;

public class EmpController : Controller
{
    private readonly ILogger<EmpController> _logger;

    public EmpController(ILogger<EmpController> logger)
    {
        _logger = logger;
    }
    public IActionResult Edit(){
        return View();
    }
    public IActionResult Emp(){
        List<Employee> emp = EmpDB.GetAllEmp();
        this.ViewData["emp"] = emp;
        return View();
    }
    public IActionResult List(){
        List<Employee> emp = EmpDB.GetAllEmp();
        this.ViewData["emp"] = emp;
        return View();
    }
    public IActionResult Index()
    {
        return View();
    }
public IActionResult show(int empno)
    {
        List<Employee> emp = EmpDB.GetAllEmp();
        var e = emp.Find((emp)=>emp.eid == empno);        
        return View(e);
    }
    public IActionResult Privacy()
    {
        return View();
    }
    // public IActionResult Details(int id){
    //     // List<Employee> emp = EmpDB.GetAllEmp();
    //     // var e = emp.Find((emp)=>emp.eid == id);
    //     // return View(e);
    // }

    // public IActionResult GetDetails(int eid)
    // {
    //      List<Employee> emp = EmpDB.GetAllEmp();
    //     var e=emp.Find((emp10)=>emp10.empno==eid);
    //     return View(e);
    // }  
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
