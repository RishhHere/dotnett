using Banking;
using Notify;
using Taxslab;

Account acc = new Account();
acc.balance = 1900000;
// Console.WriteLine("Your account balance is: "+ acc.balance);

// acc.WithDraw(1);
// Console.WriteLine("Your account balance is: "+ acc.balance);

// acc.Deposit(1999999999);
// Console.WriteLine("Your account balance is: "+ acc.balance);


// Notification.SendEmail("Alen", 545);
// Taxation.DedcutTax(10000);

//Assigning Functions to Delegate
// NotifyDelegate notifySMS =new NotifyDelegate(Notification.SendSMS);
// NotifyDelegate notifyEmail =new NotifyDelegate(Notification.SendEmail);
// NotifyDelegate notifyWhatsApp =new NotifyDelegate(Notification.SendWhatsApp);


// TaxDelegate taxifyDedcutTax =new TaxDelegate(Taxation.DedcutTax);
// //taxify(50000);

// NotifyDelegate notify = null;
// //Chaining
// notify += notifySMS;
// notify += notifyEmail;
// notify += notifyWhatsApp;


// TaxDelegate proxy=null;
// proxy += taxifyDedcutTax;


// notify("abc",2552);
// proxy(1000);

//When invoking an event that 
acc.overBalance += Taxation.DedcutTax;
acc.underBalance += Notify.Notification.SendEmail;

acc.Deposit(100000);
Console.WriteLine("Current Balance =" +acc.balance);


