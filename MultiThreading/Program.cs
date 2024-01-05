// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using Util;
using System;
using System.Threading;
using System.Threading.Tasks;

Thread theThread = Thread.CurrentThread;
Console.WriteLine("Main method thread= " + theThread.ManagedThreadId);

Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
Helper.GetRemoteData();
Helper.StoreData();


