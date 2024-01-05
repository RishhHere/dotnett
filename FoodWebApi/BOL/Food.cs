namespace BOL;

public class Food {
    public int item_id {get; set;}
    public string item_name{get; set;}
    public Food(){

    }
    public Food(int id, string name){
        item_id = id;
        item_name = name;
    }
}