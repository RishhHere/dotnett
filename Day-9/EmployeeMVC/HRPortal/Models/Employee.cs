namespace HRPortal.Models;

public class Employee{
    public int? eid {get; set;}
    public string? ename {get; set;}
    public string? job {get; set;}

    public Employee(){

    }
    public Employee(int eid, string ename, string job){
        this.eid = eid;
        this.ename = ename;
        this.job = job;
    }
}