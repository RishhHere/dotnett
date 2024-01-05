using Devices;
using Structure;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Printer p = new Printer();
p.Print();

Line l = new Line();
l.StartPoint = new Structure.Point(3,4);
l.EndPoint = new Structure.Point(4,5);
l.Color = "purple";
l.Width = 6;
Console.WriteLine(l);