using System;

class ComparingFloats
{
    static void Main()
    {        
        string input1;
        float a;
        Console.WriteLine("Enter first float number: ");
        input1 = Console.ReadLine();
        a = float.Parse(input1);

        string input2;
        float b;
        Console.WriteLine("Enter second float number: ");
        input2 = Console.ReadLine();
        b = float.Parse(input2);        
        
        float esp = 0.0000001f;
        bool result = Math.Abs(a - b) < esp;
        Console.WriteLine(result);
    }
}