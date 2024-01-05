namespace BLL;
using BOL;
using DAL;

public class FoodLogic{
    public static List<Food> GetAllItems(){
        List<Food> foodlist = new List<Food>();
        foodlist = FoodDBManager.GetAllItems();
        return foodlist;
    }
    // public static List<Food> GetFoodItem(int itemid){
    //     // List<Food> fooditem = GetAllItems();
    //     //LINQ
    //     // var food = from f in fooditem where f.itemid == itemid select f;
    //     // return food.ToArray;
    //     Food fooditem = GetAllItems.Find((fooditem)=>fooditem.itemid == itemid);
    //     return fooditem;
    // }
}