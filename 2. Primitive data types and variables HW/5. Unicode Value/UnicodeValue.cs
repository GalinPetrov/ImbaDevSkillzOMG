using System;

class UnicodeValue
{
    static void Main()
    {
        string dec = "\u0072";
        string hex = "\u0048";
        Console.WriteLine("The letter with unicode value of 72 in decimal is {0}", dec);
        Console.WriteLine("The letter with unicode value of 72 in hexadecimal is {0}", hex);
    }
}