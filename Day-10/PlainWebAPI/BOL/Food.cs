namespace BOL;

public class Food{
    public int itemid {get; set;}
    public string itemname {get; set;}
    public Food(){

    }
    public Food(int id, string name){
        itemid = id;
        itemname = name;
    }
}