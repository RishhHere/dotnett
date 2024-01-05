namespace Notify;

public static class Notification{
    // public static void DeductNotify(string to, float amount){
    //     Console.WriteLine(" "+ amount + " deducted "+ to);
    // }
    // public static void CreditNotify(string to, float amount){
    //     Console.WriteLine(" "+ amount + " credited " + to);
    // }
    public static void SendSMS(string to, float amount){
        Console.WriteLine(" "+ amount + " deducted "+ to + " - SMS");
    }
    public static void SendEmail(string to, float amount){
        Console.WriteLine(" "+ amount + " deducted "+ to +" - Email");
    }
    public static void SendWhatsApp(string to, float amount){
        Console.WriteLine(" "+ amount + " deducted "+ to + " - WhatsApp");
    }
}