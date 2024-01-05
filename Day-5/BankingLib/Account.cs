namespace Banking;
using Notify;
using Taxslab;

public class Account{
    public event NotifyDelegate underBalance;
    public event TaxDelegate overBalance;
    public float balance {get; set;}
    public void Deposit(float amount){
        this.balance += amount;
        if(this.balance>=1900001)
            overBalance(10000);
    }
    public void WithDraw(float amount){
        this.balance-= amount;
        if(this.balance<=10000)
            underBalance("blocked",1000);
    }
}