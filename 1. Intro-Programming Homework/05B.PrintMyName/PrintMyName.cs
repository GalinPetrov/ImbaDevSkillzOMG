using System;

class PrintMyName
{
    static void Main()
    {
        Console.WriteLine("Input your first name");
        String InputFirstName = (Console.ReadLine());
        Console.WriteLine("Yay! Now input your surname!");
        String InputSecondName = (Console.ReadLine());
        Console.WriteLine("Congratulations, {0} {1}, you apparently know your name! You're like...awesome! I'm so proud of you!", InputFirstName, InputSecondName);
    }
}