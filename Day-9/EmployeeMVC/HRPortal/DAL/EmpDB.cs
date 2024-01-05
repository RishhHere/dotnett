namespace DAL;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using HRPortal.Models;
public class EmpDB{
    public static string connect = "server=192.168.10.150; port=3306; user=dac2; password=welcome; database=dac2";
    public static List<Employee> GetAllEmp(){
        List<Employee> employee = new List<Employee>();
        MySqlConnection conn = new MySqlConnection();
        conn.ConnectionString = connect;
        string query = "select empno, ename, job from emp";
    //    Console.WriteLine("Enter the id of product to be updated:");
    //     int id=int.Parse(Console.ReadLine());
    //    string query="update emp empno='1313' where empno=@id";
        MySqlCommand cmd = new MySqlCommand(query,conn);
        try{
            conn.Open();
            MySqlDataReader red = cmd.ExecuteReader();
        
            while(red.Read()){
                int id = int.Parse(red["empno"].ToString());
                string name = red["ename"].ToString();
                string job = red["job"].ToString();

                Employee emp = new Employee();
                emp.eid = id;
                emp.ename = name;
                emp.job = job;

                employee.Add(emp);
            }
        } catch(Exception e){
            Console.WriteLine(e.Message);
        } finally{
            conn.Close();
        }
        return employee;
    }
}