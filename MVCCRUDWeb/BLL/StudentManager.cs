namespace BLL;
using DAL;
using BOL;

public class StudentManager{
    public static List<Student> GetAllStudent(){
        return StudentDBManager.GetAllStudent();
        // List<Student> stlist = StudentDBManager.GetAllStudent();
        // return stlist;
    }
    public static void InsertStudent(int id, string name, string pass, string city){
        StudentDBManager.Insert(id,name,pass,city);
    }
    public static void DeleteStudent(int id){
        StudentDBManager.Delete(id);
    }
    public static void UpdateStudent(int id, string name, string pass, string city){
        StudentDBManager.Update(id,name,pass,city);
    }
}