namespace DAL;
using BOL;
using MySql.Data.MySqlClient;

public class FoodDBManager{
    public static List<Food> GetAllItems(){
        List<Food> listfood = new List<Food>();
        MySqlConnection conn = new MySqlConnection();
        // conn.ConnectionString = "server=192.168.10.150; port=3306; user=dac2; password=welcome; database=dac2";
        conn.ConnectionString = "server=127.0.0.1; port=3306; user=root; password=welcome; database=dac2";
        string query = "select item_id, item_name from food";
        MySqlCommand cmd = new MySqlCommand(query,conn);

        try{
            conn.Open();
            MySqlDataReader read = cmd.ExecuteReader();
                while(read.Read()){
                    int id = int.Parse(read["item_id"].ToString());
                    string item = read["item_name"].ToString();
                    Food f = new Food();
                    f.itemid = id;
                    f.itemname = item;

                    listfood.Add(f);
                } 
            } catch (Exception e){
                Console.WriteLine(e.Message);
            } finally {
                conn.Close();
            }
            Console.WriteLine(listfood);
            return listfood;
        }
}