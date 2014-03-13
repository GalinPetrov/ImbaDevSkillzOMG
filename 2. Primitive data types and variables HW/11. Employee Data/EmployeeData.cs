using System;

class EmployeeData
{
    static void Main()
    {
        Console.WriteLine("Employee's First Name:");
        string name = Console.ReadLine();
        Console.WriteLine("Employee's Last Name:");
        string surname = Console.ReadLine();

        Console.WriteLine("Employee's age");
        string age = Console.ReadLine();
        byte AGE;
        AGE = byte.Parse(age);

        Console.WriteLine("Employee's sex (m/f)");
        string sex = Console.ReadLine();

        Console.WriteLine("Employee's Personal ID Number");
        string id = Console.ReadLine();
        long ID;
        ID = long.Parse(id);

        Console.WriteLine("Unique employee number");
        string uen = Console.ReadLine();
        long UEN;
        UEN = long.Parse(uen);
        //For some reason the 27560000…27569999 values of int and uint type are not accepted here...

        Console.Clear();
        Console.WriteLine("Employee information: \n\n Name:{0} {1}\n Age:{2}\n Sex:{3}\n Personal ID number:{4}\n Unique employee number:{5}\n\n\n ", name, surname, AGE, sex, ID, UEN);
    }
}