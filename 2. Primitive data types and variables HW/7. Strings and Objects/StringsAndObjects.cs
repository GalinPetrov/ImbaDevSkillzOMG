using System;

//Declare two string variables and assign them with “Hello” and “World”. 
//Declare an object variable and assign it with the concatenation of the first two 
// variables (mind adding an interval between). Declare a third string variable and 
//initialize it with the value of the object variable (you should perform type casting).

class StringsAndObjects
{
    static void Main()
    {
        string var1 = "Hello";
        string var2 = "World";
        object concat = var1 + " " + var2;
        string result = concat.ToString();
        Console.WriteLine(result);
    }
}