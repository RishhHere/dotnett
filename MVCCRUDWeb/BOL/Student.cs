namespace BOL;

public class Student{
    public int id {get; set;}
    public string name {get; set;}
    public string password {get; set;}
    public string city {get; set;}

    public Student(){

    }
    public Student(int id, string name, string password) {
        this.id = id;
        this.name = name;
        this.password = password;
    }
    public Student(int id, string name, string password, string city) {
        this.id = id;
        this.name = name;
        this.password = password;
        this.city = city;
    }
}