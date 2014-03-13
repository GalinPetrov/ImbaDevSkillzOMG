using System;

class VariablesInHexFormat
{
    static void Main()
    {
        Console.WriteLine("Please input your lucky number!");
        int input = int.Parse(Console.ReadLine());
        Console.WriteLine("Your lucky number in hexadecimal format is {0}", input.ToString("X"));
    }
}