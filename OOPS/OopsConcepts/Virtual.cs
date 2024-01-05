// namespace HR;
// public class Employee{
//     public virtual void CalculateSalary(){
//             Console.WriteLine("Employee : CalculateSalary");
//     }
//     public virtual void DoWork(){
//         Console.WriteLine("Inside base class DO WORK");
//     }
// }
// public class SalesEmployee:Employee{
//     //shadowing 
//     public new virtual void CalculateSalary()
//     {
//         Console.WriteLine("Sales Employee : CalculateSalary"); 
//         //base.CalculateSalary();
//     }
//     public override void DoWork()
//     {
//         Console.WriteLine("Inside SE class DO WORK");
//         base.DoWork();
//     }
// }
// public class SalesManager:SalesEmployee{
//     public override void CalculateSalary()
//     {
//         Console.WriteLine("Inside SM Cal Sal");
//         base.CalculateSalary();
//     }
// }