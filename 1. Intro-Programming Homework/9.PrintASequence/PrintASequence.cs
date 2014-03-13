using System;

class PrintASequence
{
    static void Main()
    {
        int OutputNumber;
        for (int i = 2; i <= 11; ++i)
        {
            if (i % 2 == 0)
            {
                OutputNumber = i;
            }
            else
            {
                OutputNumber = i * (-1);
            }
            Console.WriteLine(OutputNumber);
        }
    }
}