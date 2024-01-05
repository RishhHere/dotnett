namespace DAL;

public class DBManager{

    public static connstring = "server=192.168.10.150;port=3306;user=dac2;password=welcome;database=dac2";
    MySqlConnection conn=new MySqlConnection();
    conn.ConnectionString=connstring;
    public static void Insert(){
        public string query="insert into emp values (1,1,'Aleen','HR');
        MySqlCommand cmd = new MySqlCommand(query,conn);
        cmd.Connection = conn;
        conn.Open();
        try{
            cmd.ExecuteNonQuery();
        } catch(Exception e) {
            Console.WriteLine(e.Message);
        } finally {
            conn.Close();
        }
    }
}
// MySqlConnection conn = new MySqlConnection("User Id=root;Password=mypassword;Host=127.0.0.1;");
// MySqlCommand cmd = new MySqlCommand();
// cmd.CommandText = "INSERT INTO dept (deptno, dname, loc) VALUES (10,'Accounting','New York')";
// cmd.Connection = conn;
// conn.Open();
// try {
//   int aff = cmd.ExecuteNonQuery();
//   MessageBox.Show(aff + " rows were affected.");
// }
// catch {
//   MessageBox.Show("Error encountered during INSERT operation.");
// }
// finally {
//   conn.Close();

