
using System;

class AgeAfter10YearsApp
{
    static void Main()
    {
        Console.WriteLine("Input your date of birth in a dd/mm/yyyy format");
        DateTime InputDate = DateTime.Parse(Console.ReadLine());
        var age = DateTime.Today.Subtract(InputDate).Ticks;
        Console.WriteLine("Your current age is {0} years", new DateTime(age).Year - 1);
        Console.WriteLine("In 10 years your age will be {0} years.", new DateTime(age).AddYears(10).Year - 1);
    }
}