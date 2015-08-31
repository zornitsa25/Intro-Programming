using System;

class EscapeQuotes
{
    static void Main()
    {
        string str = @"The ""use"" of quotations causes difficulties.";
        string str2 = "The \"use\" of quotations causes difficulties.";
        Console.WriteLine(str);
        Console.WriteLine(str2);
    }
}
