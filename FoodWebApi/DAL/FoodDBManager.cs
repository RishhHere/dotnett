using BOL;
using MySql.Data.MySqlClient;
namespace DAL;

public class FoodDBManager{
    public static List<Food> GetAllItems(){
        List<Food> foodlist = new List<Food>();
        MySqlConnection conn = new MySqlConnection();
        conn.ConnectionString = "server=127.0.0.1; port=3306; user=root; password=welcome; database=dac2";
        string query = "select item_id, item_name from food";
        MySqlCommand cmd = new MySqlCommand(query,conn);
        try{
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read()){
                int id = int.Parse(reader["item_id"].ToString());
                string name = reader["item_name"].ToString();

                Food food = new Food(id, name);
                foodlist.Add(food);
            }

        } catch(Exception e){
            Console.WriteLine(e.Message);
        } finally{
            conn.Close();
        } return foodlist;
    }
}