using MySql.Data.MySqlClient;
Console.WriteLine("Welcome to database App");


// <-----------------------------------INSERTION------------------------------------------------------->
// public string connstring = "server=192.168.10.150;port=3306;user=dac2;password=welcome;database=dac2";
    MySqlConnection conn=new MySqlConnection();
    conn.ConnectionString="server=192.168.10.150;port=3306;user=dac2;password=welcome;database=dac2";
   
    //string query="insert into emp10 values (1,1,'Aleen','HR')";
    Console.WriteLine("Enter the id of employee to be deleted:");
    int empno = Convert.ToInt32(Console.ReadLine());
    // int empno = int.Parse(Console.ReadLine());
    
   
    string query="delete from emp10 where empno=@empno";
    
     MySqlCommand cmd = new MySqlCommand(query,conn);
     cmd.Parameters.AddWithValue("@empno",empno);
    // string query="update emp10 set empno='1313' where empno=1";
   
    
        //cmd.Connection = conn;
        
        try{
            conn.Open();
            cmd.ExecuteNonQuery();
        } catch(Exception e) {
            Console.WriteLine(e.Message);
        } finally {
            conn.Close();
    }
