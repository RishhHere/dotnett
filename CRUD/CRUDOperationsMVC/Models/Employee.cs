namespace CRUDOperationsMVC.Models;

public class Employee{
    public int eid {get; set;}
    public string ename {get; set;}
    public int deptno {get; set;}
    public string job {get; set;}

    public Employee(){

    }
    public Employee(int id, string name, int deptno, string job){
        eid = id;
        ename = name;
        this.deptno = deptno;
        this.job = job;
    }
}