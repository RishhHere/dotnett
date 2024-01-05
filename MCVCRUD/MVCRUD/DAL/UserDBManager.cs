namespace DAL;
using BOL;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

public class UserDBManager
{


    public static List<User> GetAllUsers()
    {
        List<User> userlist = new List<User>();
        MySqlConnection conn = new MySqlConnection();
        conn.ConnectionString = "server=192.168.10.150;port=3306;user=dac2;password=welcome;database=dac2";
        string query = "select * from login";

        MySqlCommand cmd = new MySqlCommand(query, conn);

        try
        {
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string user = reader["username"].ToString();
                string pass = reader["password"].ToString();
                string email = reader["email"].ToString();
                User u = new User();
                u.username = user;
                u.password = pass;
                u.email = email;

                userlist.Add(u);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            conn.Close();
        }
        return userlist;
    }

    public static bool Validate(String user, String pass)
    {
        // List<User> userlist = new List<User>();
        MySqlConnection conn = new MySqlConnection();
        conn.ConnectionString = "server=192.168.10.150;port=3306;user=dac2;password=welcome;database=dac2";
        string query = "select username,password from login where username=@user and password=@pass";

        MySqlCommand cmd = new MySqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@user", user);
        cmd.Parameters.AddWithValue("@pass", pass);

        try
        {
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                return true;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            conn.Close();
        }
        return false;
    }
    public static List<User> InsertData(String user, String pass, String email)
    {
        List<User> userlist = new List<User>();
        MySqlConnection conn = new MySqlConnection();
        conn.ConnectionString = "server=192.168.10.150;port=3306;user=dac2;password=welcome;database=dac2";
        string query = "insert into login values (@user,@pass,@email)";

        MySqlCommand cmd = new MySqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@user", user);
        cmd.Parameters.AddWithValue("@pass", pass);
        cmd.Parameters.AddWithValue("@email", email);

        try
        {
            conn.Open();
            cmd.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            conn.Close();
        }
        return userlist;
    }

    public static List<User> DeleteData(String user)
    {
        List<User> userlist = new List<User>();
        MySqlConnection conn = new MySqlConnection();
        conn.ConnectionString = "server=192.168.10.150;port=3306;user=dac2;password=welcome;database=dac2";
        string query = "delete from login where username=@user";

        MySqlCommand cmd = new MySqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@user", user);

        try
        {
            conn.Open();
            cmd.ExecuteNonQuery();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            conn.Close();
        }
        return userlist;
    }
}
