// using System;

// namespace Inheritance;

//   // base class
//   class Animal { 
//     public virtual void eat() {

//       Console.WriteLine("I eat food");
//     }
//     public virtual void potty() {
//         Console.WriteLine("Animal is Pooping....");
//     }
//     public virtual void eat2() {
//       Console.WriteLine("Animals eat food.");
//     }
//   } 
  
//   // derived class of Animal 
//   class Dog : Animal {

//     // overriding method from Animal
//     public override void eat() {

//       Console.WriteLine("I eat Dog food");
//     }     
//     public override void potty(){
//         Console.WriteLine("Specific potty of Dog.... Until not made Virtual");
//     }
//   }
//   class Dog : Animal {

//     // overriding method from Animal
//     public override void eat() {
      
//       // call method from Animal class
//       base.eat();
      
//       Console.WriteLine("Dogs eat Dog food.");
//     }     
//   }

