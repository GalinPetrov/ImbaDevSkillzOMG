using System;

class DateAndTime
{
    static void Main()
    {
       	DateTime time = DateTime.Now;             
	    string format = "dd MM yyyy HH:mm ";    
	    Console.WriteLine(time.ToString(format));     
    }
}