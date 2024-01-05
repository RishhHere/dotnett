namespace BookSection;
using Book;
public static class Books{
    public event BorrowBook limit;
    public int qty{get;set;}
    public static void Borrow(int qty){
        this.qty = qty;
        if(this.qty>4)
            limit(5);
    }
    public static void Amt(int qty){
        Console.WriteLine("Limit Exceeds..");
    }
}