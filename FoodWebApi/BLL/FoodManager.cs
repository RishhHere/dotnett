namespace BLL;
using BOL;
using DAL;

public class FoodManager {
    public static List<Food> GetAllItems(){
        return FoodDBManager.GetAllItems();
    }
}