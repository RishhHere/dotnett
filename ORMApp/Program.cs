using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using BOL;
using DAL;
// using Org.BouncyCastle.Asn1.Misc;

IUserDBManager dbm = new UserDBManager();

bool status = true;
// Console based Menu driven User Interface
while (status) {
    Console.WriteLine("Choose Option :");
    Console.WriteLine("1. Display  records");
    Console.WriteLine("2. Insert  new record");
    Console.WriteLine("3. Update existing record");
    Console.WriteLine("4. Delete existing record");
    Console.WriteLine("5. Exit");

    switch (int.Parse(Console.ReadLine())){
        case 1:
        {
            List<User> users = dbm.GetAll();
                foreach (var u in users){
                Console.WriteLine(" id: {0}, name: {1}, email: {2}, country:{3}",
                    u.id, u.name, u.email, u.country);
                }
            }
            break;
        case 2:
            var newUser = new User();
            Console.WriteLine("Enter Id: ");
            newUser.id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name: ");
            newUser.name = Console.ReadLine();
            Console.WriteLine("Enter Email: ");
            newUser.email = Console.ReadLine();
            Console.WriteLine("Enter Country: ");
            newUser.country = Console.ReadLine();
            dbm.Insert(newUser);
            break;
        case 3:
            var updtUser = new User();
            Console.WriteLine("Enter Id: ");
            updtUser.id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name: ");
            updtUser.name = Console.ReadLine();
            Console.WriteLine("Enter Email: ");
            updtUser.email = Console.ReadLine();
            Console.WriteLine("Enter Country: ");
            updtUser.country = Console.ReadLine();
            dbm.Update(updtUser);
            break;

        case 4:
            Console.WriteLine("Enter Id:");
            int id = int.Parse(Console.ReadLine());
            dbm.Delete(id);
            break;

        case 5:
            status = false;
            break;
    }
}


