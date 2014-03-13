using System;

//Declare two integer variables a and b and assign them with 5 and 10 and after
//that exchange their values. Print the variable values before and after the exchange.
class ExchangeVarValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        int c = a;
        a = b;
        b = c;
        Console.WriteLine("{0} & {1}", a, b);
    }
}