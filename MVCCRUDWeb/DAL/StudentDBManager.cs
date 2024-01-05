namespace DAL;
using BOL;
using MySql.Data.MySqlClient;

public class StudentDBManager{
    public static List<Student> GetAllStudent(){
        List<Student> slist = new List<Student>();

        MySqlConnection conn = new MySqlConnection();
        conn.ConnectionString = "server=127.0.0.1; port=3306; user=root; password=welcome; database=dac2";

        string query = "select * from students";
        MySqlCommand cmd = new MySqlCommand(query, conn);

        try{
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read()){
                int id = int.Parse(reader["id"].ToString());
                string name = reader["name"].ToString();
                string pass = reader["password"].ToString();
                string city = reader["city"].ToString();

                // Student s = new Student();
                // s.id = id;
                // s.name = name;
                // s.password = pass;
                // s.city = city;

                Student s = new Student(id, name, pass, city);
                slist.Add(s);
            }
        } catch(Exception e){
            Console.WriteLine(e.Message);
        } finally{
            conn.Close();
        } return slist;
    }
    public static void Insert(int id, string name, string pass, string city){
        MySqlConnection conn = new MySqlConnection();
        conn.ConnectionString = "server=127.0.0.1; port=3306; user=root; password=welcome; database=dac2";
        string query = "insert into students values(@id, @name, @password, @city)";

        MySqlCommand cmd = new MySqlCommand(query, conn);
        try{
            conn.Open();
            cmd.Parameters.AddWithValue("@id",id);
            cmd.Parameters.AddWithValue("@name",name);
            cmd.Parameters.AddWithValue("@password",pass);
            cmd.Parameters.AddWithValue("@city",city);
            cmd.ExecuteNonQuery();
        } catch (Exception e){
            Console.WriteLine(e.Message);
        } finally{
            conn.Close();
        } 
    }
    public static void Delete(int id){
        MySqlConnection conn = new MySqlConnection();
        conn.ConnectionString = "server=127.0.0.1; port=3306; user=root; password=welcome; database=dac2";

        string query = "delete from students where id=@id";
        MySqlCommand cmd = new MySqlCommand(query,conn);
        try{
            conn.Open();
            cmd.Parameters.AddWithValue("@id",id);
            cmd.ExecuteNonQuery();
        } catch(Exception e){
            Console.WriteLine(e.Message);
        }finally{
            conn.Close();
        }
    }
    public static void Update(int id, string name, string password, string city){
        MySqlConnection conn = new MySqlConnection();
        conn.ConnectionString= "server=127.0.0.1; port=3306; user=root; password=welcome; database=dac2";
        string query = "update students set name=@name,password=@password, city=@city where id=@id";

        MySqlCommand cmd = new MySqlCommand(query,conn);

        try{
            conn.Open();
            cmd.Parameters.AddWithValue("@id",id);
            cmd.Parameters.AddWithValue("@name",name);
            cmd.Parameters.AddWithValue("@password",password);
            cmd.Parameters.AddWithValue("@city",city);
            cmd.ExecuteNonQuery();
        } catch (Exception e){
            Console.WriteLine(e.Message);
        } finally {
            conn.Close();
        }
    }
}