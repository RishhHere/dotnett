namespace Emp;

public class Employee{
    // Default Constructor
    public Employee(){
        this.id = 1;
        this.name = " ";
    }

    // Parameterized Constructor
    public Employee(int id, string name) {
        this.id = id;
        this.name = name;
    }
    //Normal Declaration
//    private int id;
    
   public int id {
    get {return this.id;}
    set { this.id = value;}
   }

    //Auto - Property Value Declaration
    public string name { get; set; }

    public string ToString(){
        return id + " " + name;
    }

}