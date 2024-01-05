namespace BLL;
using DAL;
using BOL;

public static class UserManager{
    public static List<User> GetAllUsers()
    {
        List<User> ulist = UserDBManager.GetAllUsers();
        return ulist;
    }

    public static bool Validate(string user,string pass)
    {
        return UserDBManager.Validate(user,pass);
    }

    public static void InsertData(string username,string  password,string email)
    {
        // List<User> ulist =
         UserDBManager.InsertData(username,password,email);
        // return ulist;
    }

     public static void DeleteData(string username)
    {
        // List<User> ulist =
         UserDBManager.DeleteData(username);
        // return ulist;
    }
}