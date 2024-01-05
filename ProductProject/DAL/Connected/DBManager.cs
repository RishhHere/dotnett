namespace DBManager.Connected;
using MySql.Data.MySqlClient;
// using System.Data;
using BOL; 

// MySqlConnection      -->     Establishing Connection
// MySqlCommand         -->     To write MySql commands
// Represents an SQL statement to execute against a MySQL database. This class cannot be inherited.
// MySqlDataReader      -->     Firing a query on DB

public class DBManager{
    public static string connectionString = "server=192.168.10.150;port=3306;user=dac2; password=welcome;database=dac2";
    public static List<Product> GetAllProducts(){
        List<Product> list = new List<Product>();
        MySqlConnection conn = new MySqlConnection();
        conn.ConnectionString = connectionString;
        string query = "select * from product";
        try{
            MySqlCommand cmd = new MySqlCommand(query, conn);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read()) {
            Product product = new Product();
                
                // product.Id = intParse(reader["id"].ToString());
                int id = int.Parse(reader["id"].ToString());
                string title=reader["title"].ToString();
                int unitPrice = int.Parse(reader["unitPrice"].ToString());
                product.pid = id;
                product.title=title;
                product.unitPrice=unitPrice;
                list.Add(product);
            }
            return list;
            reader.Close();
        } catch(Exception e) {
            Console.WriteLine(e.Message);
            return null;

        } finally {
            conn.Close();
        }
    }

     public static List<Product> GetProductsById(int pid){
        int search_id=pid;
        List<Product> list = new List<Product>();
        MySqlConnection conn = new MySqlConnection();
        conn.ConnectionString = connectionString;
        string query = "select * from product where id= "+search_id;
        try{
            MySqlCommand cmd = new MySqlCommand(query,conn);
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read()) {
            Product product = new Product();
                
                // product.Id = intParse(reader["id"].ToString());
                int id = int.Parse(reader["id"].ToString());
                string title=reader["title"].ToString();
                int unitPrice = int.Parse(reader["unitPrice"].ToString());
                product.pid = id;
                product.title=title;
                product.unitPrice=unitPrice;
                list.Add(product);
            }
            return list;
            reader.Close();
        } catch(Exception e) {
            Console.WriteLine(e.Message);
            return null;

        } finally {
            conn.Close();
        }
    }

}
