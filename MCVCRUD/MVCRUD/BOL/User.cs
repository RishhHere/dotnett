namespace BOL;
public class User{

    public string username{get;set;}

    public string password{get;set;}

    public string email{get;set;}

    public User()
    {

    }

    public User(string username,string password,string email)
    {
        this.username=username;
        this.password=password;
        this.email=email;
    }

}