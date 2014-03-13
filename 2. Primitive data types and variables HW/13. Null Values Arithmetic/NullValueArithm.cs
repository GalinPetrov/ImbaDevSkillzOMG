using System;

//Create a program that assigns null values to an integer and to a double variable. Try to print these variables 
//at the console. Try to add some number or the null literal to these variables and print the result.
class NullValueArithm
{
    static void Main()
    {
        int? var1 = null;
        double? var2 = null;
        Console.WriteLine("Null Value Variables (Trust me, they are right here ->) {0} {1}", var1, var2);
        Console.WriteLine("Null Value Variables with added random numbers:", var1 + 171, var2 + 131.178);
    }
}