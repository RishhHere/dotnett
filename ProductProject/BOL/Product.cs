namespace BOL;
public class Product{
    public int? pid {get; set;}
    public string? title{get; set;}
    // public string description {get; set;}
    // public int quantity {get; set; }
    public int? unitPrice {get; set;}
    
    public Product(){
        Console.WriteLine("Called Default Constructor");
    }
    
    // public Product(int id, string title){
    //     pid = id;
    //     this.title = title;
    // }
    
    // public Product(int id, string title, string description){
    //     pid = id;
    //     this.title = title;
    //     this.description = description;
    // }
     public Product(int id, string title, int unitPrice){
        pid = id;
        this.title = title;
        this.unitPrice = unitPrice;
    }

    // public Product(int id, string title, string description, int quantity, int unitPrice){
    //     pid = id;
    //     this.title = title;
    //     this.description = description;
    //     this.quantity = quantity;
    //     this.unitPrice = unitPrice;
    // }

   
}