using System;

class ASCIItable
{
    static void Main(string[] args)
    {
	byte min = 0;
	byte max = 255;
	for (int i = min; i < max; i++)
	    {	    
	    char c = (char)i;        
	    string result = string.Empty;
	    if (char.IsWhiteSpace(c))
	        {
            result = c.ToString();		
	        }
	    else if (char.IsControl(c))
	    {
		result = " ";
	    }
	    else
	    {
		result = c.ToString();
	    }
        Console.WriteLine("    ", result);
	    }
    }
}